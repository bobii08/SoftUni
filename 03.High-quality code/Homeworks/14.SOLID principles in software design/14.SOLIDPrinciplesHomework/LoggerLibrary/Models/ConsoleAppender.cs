using System;
using LoggerLibrary.Interfaces;

namespace LoggerLibrary.Models
{
    public class ConsoleAppender : IAppender
    {
        private ILayout layout;

        public ConsoleAppender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = ReportLevel.Info;
        }

        public ILayout Layout
        {
            get { return this.layout; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("layout", "The layout you've passed cannot be null");
                }

                this.layout = value;
            }
        }

        public ReportLevel ReportLevel { get; set; }

        public void Append(DateTime dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                string formattedOutput = this.Layout.PrintingFormat(dateTime, reportLevel, message);

                Console.WriteLine(formattedOutput);
            }
        }
    }
}
