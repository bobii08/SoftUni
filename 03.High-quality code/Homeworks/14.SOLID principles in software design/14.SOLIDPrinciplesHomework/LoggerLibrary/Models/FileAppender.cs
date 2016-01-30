using System;
using System.IO;
using LoggerLibrary.Interfaces;

namespace LoggerLibrary.Models
{
    public class FileAppender : IAppender
    {
        private string filePath;

        public FileAppender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = ReportLevel.Info;
        }

        public ILayout Layout { get; private set; }

        public string FilePath
        {
            get { return this.filePath; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("fileName", "File name cannot be null or whitespace");
                }

                this.filePath = value;
            }
        }

        public ReportLevel ReportLevel { get; set; }

        public void Append(DateTime dateTime, ReportLevel reportLevel, string message)
        {
            string formattedOutput = this.Layout.PrintingFormat(dateTime, reportLevel, message);

            File.AppendAllText(this.FilePath, formattedOutput);
        }
    }
}
