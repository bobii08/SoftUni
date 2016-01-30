﻿using System;
using System.Collections.Generic;
using LoggerLibrary.Interfaces;

namespace LoggerLibrary.Models
{
    public class Logger : ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            this.Appenders = appenders;
        }

        public IAppender[] Appenders { get; private set; }

        public void Info(string message)
        {
            this.AppendMessage(message, ReportLevel.Info);
        }

        public void Warn(string message)
        {
            this.AppendMessage(message, ReportLevel.Warn);
        }

        public void Error(string message)
        {
            this.AppendMessage(message, ReportLevel.Error);
        }

        public void Critical(string message)
        {
            this.AppendMessage(message, ReportLevel.Critical);
        }

        public void Fatal(string message)
        {
            this.AppendMessage(message, ReportLevel.Fatal);
        }

        public void AppendMessage(string message, ReportLevel reportLevel)
        {
            var reportDateTime = DateTime.Now;

            foreach (var appender in this.Appenders)
            {
                appender.Append(reportDateTime, reportLevel, message);
            }
        }
    }
}
