namespace camera_teszt.Models
{
    public class CameraInfo
    {
        public string Name { get; set; } = string.Empty;
        public string MonikerString { get; set; } = string.Empty;
        public ResolutionInfo[] Resolutions { get; set; } = Array.Empty<ResolutionInfo>();
    }

    public class ResolutionInfo
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public float Fps { get; set; }

        public override string ToString()
        {
            return $"{Width}x{Height} @ {Fps}fps";
        }
    }
}
