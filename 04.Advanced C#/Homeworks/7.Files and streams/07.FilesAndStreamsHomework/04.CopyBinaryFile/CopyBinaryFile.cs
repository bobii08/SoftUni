namespace _04.CopyBinaryFile
{
    using System.IO;

    internal class CopyBinaryFile
    {
        private static void Main()
        {
            using (var source = new FileStream("../../cat_original.jpg", FileMode.Open))
            {
                using (var destination = new FileStream("../../result_cat.jpg", FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}