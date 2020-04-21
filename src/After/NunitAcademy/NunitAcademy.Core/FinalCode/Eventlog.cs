using System;

namespace NunitAcademy.Core.FinalCode
{
    public class Eventlog
    {
        public string Message { get; set; }
        public string ComputerName { get; set; }
        public string Type { get; set; }
        public string User { get; set; }
        public string EventCode { get; set; }
        public string Category { get; set; }
        public string SourceName { get; set; }
        public string RecordNumber { get; set; }
        public DateTime TimeWritten { get; set; }
    }
}