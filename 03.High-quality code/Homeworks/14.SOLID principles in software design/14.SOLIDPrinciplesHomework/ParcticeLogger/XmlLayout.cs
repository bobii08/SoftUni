using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerLibrary.Interfaces;

namespace ParcticeLogger
{
    public class XmlLayout : ILayout
    {
        public string PrintingFormat(DateTime dateTime, LoggerLibrary.ReportLevel reportLevel, string message)
        {
            var result = new StringBuilder();
            result.AppendLine("<log>");
            result.Append("\t");
            result.AppendLine(string.Format("<date>{0}</date>", dateTime));
            result.Append("\t");
            result.AppendLine(string.Format("<level>{0}</level>", reportLevel));
            result.Append("\t");
            result.AppendLine(string.Format("<message>{0}</message>", message));
            result.Append("</log>");
            return result.ToString();
        }
    }
}
