using AForge.Video;
using AForge.Video.DirectShow;
using camera_teszt.Interfaces;

namespace camera_teszt.Services
{
    public class CameraService : ICameraService
    {
        private VideoCaptureDevice? videoSource;

        public bool IsRunning => videoSource?.IsRunning ?? false;

        public event NewFrameEventHandler? NewFrame;

        public FilterInfoCollection GetAvailableCameras()
        {
            return new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        public VideoCapabilities[] GetCameraResolutions(string monikerString)
        {
            var device = new VideoCaptureDevice(monikerString);
            return device.VideoCapabilities;
        }

        public void StartCamera(string monikerString, VideoCapabilities? resolution)
        {
            StopCamera();
            
            videoSource = new VideoCaptureDevice(monikerString);
            if (resolution != null)
            {
                videoSource.VideoResolution = resolution;
            }
            
            videoSource.NewFrame += OnNewFrame;
            videoSource.Start();
        }

        public void StopCamera()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource.NewFrame -= OnNewFrame;
            }
        }

        public void DisplayCameraProperties()
        {
            videoSource?.DisplayPropertyPage(IntPtr.Zero);
        }

        private void OnNewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            NewFrame?.Invoke(sender, eventArgs);
        }
    }
}
