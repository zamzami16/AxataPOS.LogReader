using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AxataPOS.LogReader
{
    public class LogFilter
    {
        public DateTime DateStart { get; set; } = DateTime.Now.Date;
        public DateTime DateEnd { get; set; } = DateTime.Now.Date;
        public LogLevel LogLevel { get; set; } = LogLevel.Semua;
        public string Filters { get; set; } = string.Empty;
        public int CurrentPage { get; set; } = 1;
        public int PageCount { get; set; } = 500;
    }

    public enum LogLevel
    {
        Semua,
        Error,
        Warn,
        Info,
        Debug,
        Trace,
    }

    public class LogEntry
    {
        public DateTime Time { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Exception { get; set; } = string.Empty;
    }

    public class LogReader
    {
        private List<LogEntry> entries;

        public IEnumerable<LogEntry> ReadLogFile(string filePath)
        {
            entries = new List<LogEntry>();
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var logEntry = JsonConvert.DeserializeObject<LogEntry>(line);
                    entries.Add(logEntry);
                }
            }
            return entries;
        }

        public IEnumerable<LogEntry> Filter(IEnumerable<LogEntry> logEntries, LogFilter logFilter)
        {
            if (logEntries == null)
            {
                logEntries = entries;
            }

            return logEntries.Filters(logFilter);
        }
    }

    public static class LogEntriesFilter
    {
        public static IEnumerable<LogEntry> Filters(this IEnumerable<LogEntry> logEntries, LogFilter logFilter)
        {
            string filters = logFilter.Filters.ToLower();
            var start = logFilter.DateStart.Date;
            var end = logFilter.DateEnd.Date.AddDays(1).AddSeconds(-1);

            var filtered = logEntries
                .Where(l =>
                    (l.Message.ContainsIgnoreCase(filters)
                        || l.Exception.ContainsIgnoreCase(filters)
                        || l.Logger.ContainsIgnoreCase(filters)
                    ) && l.Time >= start && l.Time <= end);

            if (logFilter.LogLevel != LogLevel.Semua)
            {
                return filtered.Where(l => l.Level.EqualsIgnoreCase(logFilter.LogLevel.ToString()));
            }

            return filtered;
        }

        public static bool ContainsIgnoreCase(this string source, string value)
        {
            return source.IndexOf(value, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public static bool EqualsIgnoreCase(this string source, string value)
        {
            return source.Equals(value, StringComparison.OrdinalIgnoreCase);
        }

    }
}
