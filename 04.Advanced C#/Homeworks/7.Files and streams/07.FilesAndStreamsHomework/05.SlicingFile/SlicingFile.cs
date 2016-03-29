namespace _05.SlicingFile
{
    using System.Collections.Generic;
    using System.IO;

    internal class SlicingFile
    {
        private static void Main()
        {
            Slice("../../cat_original.jpg", @"D:\myrepo\SoftUni\04.Advanced C#\Homeworks\07.Files and streams\07.FilesAndStreamsHomework\05.SlicingFile\Destination Folder", 10);
            var listOfFilePaths = new List<string>()
            {
@"D:\myrepo\SoftUni\04.Advanced C#\Homeworks\07.Files and streams\07.FilesAndStreamsHomework\05.SlicingFile\Destination Folder\Part-0.jpg",
@"D:\myrepo\SoftUni\04.Advanced C#\Homeworks\07.Files and streams\07.FilesAndStreamsHomework\05.SlicingFile\Destination Folder\Part-1.jpg",
@"D:\myrepo\SoftUni\04.Advanced C#\Homeworks\07.Files and streams\07.FilesAndStreamsHomework\05.SlicingFile\Destination Folder\Part-2.jpg",
@"D:\myrepo\SoftUni\04.Advanced C#\Homeworks\07.Files and streams\07.FilesAndStreamsHomework\05.SlicingFile\Destination Folder\Part-3.jpg",
@"D:\myrepo\SoftUni\04.Advanced C#\Homeworks\07.Files and streams\07.FilesAndStreamsHomework\05.SlicingFile\Destination Folder\Part-4.jpg",
@"D:\myrepo\SoftUni\04.Advanced C#\Homeworks\07.Files and streams\07.FilesAndStreamsHomework\05.SlicingFile\Destination Folder\Part-5.jpg",
@"D:\myrepo\SoftUni\04.Advanced C#\Homeworks\07.Files and streams\07.FilesAndStreamsHomework\05.SlicingFile\Destination Folder\Part-6.jpg",
@"D:\myrepo\SoftUni\04.Advanced C#\Homeworks\07.Files and streams\07.FilesAndStreamsHomework\05.SlicingFile\Destination Folder\Part-7.jpg",
@"D:\myrepo\SoftUni\04.Advanced C#\Homeworks\07.Files and streams\07.FilesAndStreamsHomework\05.SlicingFile\Destination Folder\Part-8.jpg",
@"D:\myrepo\SoftUni\04.Advanced C#\Homeworks\07.Files and streams\07.FilesAndStreamsHomework\05.SlicingFile\Destination Folder\Part-9.jpg"
            };

            Assemble(listOfFilePaths, @"D:\myrepo\SoftUni\04.Advanced C#\Homeworks\07.Files and streams\07.FilesAndStreamsHomework\05.SlicingFile\Destination Directory");
        }

        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (var source = new FileStream(sourceFile, FileMode.Open))
            {
                long fileLength = source.Length;
                long singlePartOfSourceLength = fileLength / parts;
                for (int i = 0; i < parts; i++)
                {
                    int totalReadBytes = 0;
                    using (var destination = new FileStream(destinationDirectory + "\\Part-" + i + ".jpg", FileMode.Create))
                    {
                        byte[] buffer = new byte[4096];

                        while (true)
                        {
                            int readBytes = source.Read(buffer, 0, buffer.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }

                            totalReadBytes += readBytes;
                            if (totalReadBytes >= singlePartOfSourceLength)
                            {
                                long bytesToRead = singlePartOfSourceLength - (totalReadBytes - readBytes);
                                destination.Write(buffer, 0, (int)bytesToRead);
                                break;
                            }

                            destination.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }

        static void Assemble(List<string> files, string destinationDirectory)
        {
            using (var destinationFile = new FileStream(destinationDirectory + "\\destinationFile.jpg", FileMode.Create))
            {
                for (int i = 0; i < files.Count; i++)
                {
                    using (var source = new FileStream(files[i], FileMode.Open))
                    {
                        byte[] buffer = new byte[4096];

                        while (true)
                        {
                            int readBytes = source.Read(buffer, 0, buffer.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }

                            destinationFile.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }
    }
}