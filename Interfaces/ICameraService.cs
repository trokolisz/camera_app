using AForge.Video.DirectShow;

namespace camera_teszt.Interfaces
{
    public interface ICameraService
    {
        FilterInfoCollection GetAvailableCameras();
        VideoCapabilities[] GetCameraResolutions(string monikerString);
        void StartCamera(string monikerString, VideoCapabilities? resolution);
        void StopCamera();
        bool IsRunning { get; }
        event AForge.Video.NewFrameEventHandler NewFrame;
        void DisplayCameraProperties();
    }
}
