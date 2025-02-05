namespace camera_teszt.Utils
{
    public static class ImageUtils
    {
        public static string GenerateTimestampedFilename(string prefix = "Capture", string extension = "jpg")
        {
            return $"{prefix}_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.{extension}";
        }

        public static void SaveImageToFile(Image image, string filePath)
        {
            using var bitmap = new Bitmap(image);
            bitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
