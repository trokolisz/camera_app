using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using camera_teszt.Interfaces;
using camera_teszt.Models;
using camera_teszt.Services;

namespace camera_teszt.Forms
{
    public partial class MainForm : Form
    {
        private readonly ICameraService _cameraService;
        private bool _isCapturing;
        private FilterInfoCollection? _cameras;
        private readonly Dictionary<string, VideoCapabilities> _resolutionDictionary = new();

        public MainForm()
        {
            InitializeComponent();
            _cameraService = new CameraService();

            SetupEventHandlers();
            LoadCameras();
        }

        private void SetupEventHandlers()
        {
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            FormClosing += MainForm_FormClosing;
            comboBoxCameras.SelectedIndexChanged += ComboBoxCameras_SelectedIndexChanged;
            _cameraService.NewFrame += CameraService_NewFrame;
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            LoadResolutions();
        }

        private void CameraService_NewFrame(object sender, NewFrameEventArgs e)
        {
            if (pictureBoxCamera.Image != null)
            {
                pictureBoxCamera.Image.Dispose();
            }
            pictureBoxCamera.Image = (Bitmap)e.Frame.Clone();
        }

        private void LoadCameras()
        {
            _cameras = _cameraService.GetAvailableCameras();
            comboBoxCameras.Items.Clear();
            
            if (_cameras.Count == 0)
            {
                MessageBox.Show("No cameras found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (FilterInfo camera in _cameras)
            {
                comboBoxCameras.Items.Add(camera.Name);
            }
            
            comboBoxCameras.SelectedIndex = 0;
        }

        private void LoadResolutions()
        {
            if (_cameras == null || comboBoxCameras.SelectedIndex < 0) return;

            comboResolutions.Items.Clear();
            _resolutionDictionary.Clear();

            var capabilities = _cameraService.GetCameraResolutions(_cameras[comboBoxCameras.SelectedIndex].MonikerString);
            foreach (VideoCapabilities capability in capabilities)
            {
                string resolution = $"{capability.FrameSize.Width}x{capability.FrameSize.Height}";
                comboResolutions.Items.Add(resolution);
                _resolutionDictionary[resolution] = capability;
            }

            if (comboResolutions.Items.Count > 0)
                comboResolutions.SelectedIndex = 0;
        }

        private void MainForm_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    btnStartCamera.PerformClick();
                    break;
                case Keys.Space:
                    btnCapture.PerformClick();
                    break;
            }
        }

        private void btnStartCamera_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_isCapturing)
                {
                    if (comboBoxCameras.SelectedIndex < 0 || _cameras == null) return;

                    var selectedCamera = _cameras[comboBoxCameras.SelectedIndex];
                    var resolution = _resolutionDictionary[comboResolutions.Text];
                    
                    _cameraService.StartCamera(selectedCamera.MonikerString, resolution);
                    _isCapturing = true;
                    btnStartCamera.Text = "Stop Camera";
                    statusLabel.Text = "Camera running";
                }
                else
                {
                    _cameraService.StopCamera();
                    _isCapturing = false;
                    btnStartCamera.Text = "Start Camera";
                    statusLabel.Text = "Camera stopped";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Camera error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _isCapturing = false;
                btnStartCamera.Text = "Start Camera";
                statusLabel.Text = "Camera error";
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (!_isCapturing || pictureBoxCamera.Image == null) return;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCamera.Image.Save(saveFileDialog.FileName);
                statusLabel.Text = "Image saved successfully";
            }
        }

        private void ComboBoxCameras_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadResolutions();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            _cameraService.DisplayCameraProperties();
        }

        private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            _cameraService.StopCamera();
        }
    }
}
