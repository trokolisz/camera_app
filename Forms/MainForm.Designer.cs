namespace camera_teszt.Forms
{
    partial class MainForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            comboBoxCameras = new ComboBox();
            btnStartCamera = new Button();
            pictureBoxCamera = new PictureBox();
            btnCapture = new Button();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            cameraToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            resolutionToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            comboResolutions = new ComboBox();
            btnSettings = new Button();
            saveFileDialog = new SaveFileDialog();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).BeginInit();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxCameras
            // 
            comboBoxCameras.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCameras.FormattingEnabled = true;
            comboBoxCameras.Location = new Point(12, 27);
            comboBoxCameras.Name = "comboBoxCameras";
            comboBoxCameras.Size = new Size(200, 23);
            comboBoxCameras.TabIndex = 0;
            // 
            // btnStartCamera
            // 
            btnStartCamera.Location = new Point(218, 27);
            btnStartCamera.Name = "btnStartCamera";
            btnStartCamera.Size = new Size(100, 23);
            btnStartCamera.TabIndex = 1;
            btnStartCamera.Text = "Start Camera";
            toolTip.SetToolTip(btnStartCamera, "Start/Stop camera capture (F5)");
            btnStartCamera.UseVisualStyleBackColor = true;
            btnStartCamera.Click += btnStartCamera_Click;
            // 
            // pictureBoxCamera
            // 
            pictureBoxCamera.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxCamera.BackColor = Color.Black;
            pictureBoxCamera.Location = new Point(12, 64);
            pictureBoxCamera.Name = "pictureBoxCamera";
            pictureBoxCamera.Size = new Size(1139, 447);
            pictureBoxCamera.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCamera.TabIndex = 2;
            pictureBoxCamera.TabStop = false;
            // 
            // btnCapture
            // 
            btnCapture.Location = new Point(324, 27);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(100, 23);
            btnCapture.TabIndex = 3;
            btnCapture.Text = "Capture";
            toolTip.SetToolTip(btnCapture, "Capture image (Space)");
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += btnCapture_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, cameraToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(794, 24);
            menuStrip.TabIndex = 3;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(12, 20);
            // 
            // cameraToolStripMenuItem
            // 
            cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            cameraToolStripMenuItem.Size = new Size(12, 20);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(32, 19);
            // 
            // resolutionToolStripMenuItem
            // 
            resolutionToolStripMenuItem.Name = "resolutionToolStripMenuItem";
            resolutionToolStripMenuItem.Size = new Size(32, 19);
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(0, 514);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(794, 22);
            statusStrip.TabIndex = 2;
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(39, 17);
            statusLabel.Text = "Ready";
            // 
            // comboResolutions
            // 
            comboResolutions.DropDownStyle = ComboBoxStyle.DropDownList;
            comboResolutions.Location = new Point(430, 28);
            comboResolutions.Name = "comboResolutions";
            comboResolutions.Size = new Size(150, 23);
            comboResolutions.TabIndex = 1;
            toolTip.SetToolTip(comboResolutions, "Select camera resolution");
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(586, 28);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(75, 23);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Settings";
            btnSettings.Click += btnSettings_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "jpg";
            saveFileDialog.Filter = "JPEG Images|*.jpg|All Files|*.*";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 536);
            Controls.Add(btnSettings);
            Controls.Add(comboResolutions);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Controls.Add(btnCapture);
            Controls.Add(pictureBoxCamera);
            Controls.Add(btnStartCamera);
            Controls.Add(comboBoxCameras);
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(800, 572);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Camera Application";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCameras;
        private Button btnStartCamera;
        private PictureBox pictureBoxCamera;
        private Button btnCapture;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem cameraToolStripMenuItem;
        private ToolStripMenuItem resolutionToolStripMenuItem;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
        private ComboBox comboResolutions;
        private Button btnSettings;
        private SaveFileDialog saveFileDialog;
        private ToolTip toolTip;
    }
}
