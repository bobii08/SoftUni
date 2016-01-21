namespace CohesionAndCoupling
{
    public static class FilesUtils
    {
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);

            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileNameWithExtension)
        {
            int indexOfLastDot = fileNameWithExtension.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileNameWithExtension;
            }

            string fileNameWithoutExtension = fileNameWithExtension.Substring(0, indexOfLastDot);

            return fileNameWithoutExtension;
        }
    }
}
