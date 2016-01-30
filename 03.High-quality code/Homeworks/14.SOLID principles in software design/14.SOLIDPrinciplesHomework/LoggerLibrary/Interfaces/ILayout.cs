using System;

namespace LoggerLibrary.Interfaces
{
    public interface ILayout
    {
        string PrintingFormat(DateTime dateTime, ReportLevel reportLevel, string message);
    }
}
