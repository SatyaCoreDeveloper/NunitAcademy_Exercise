using System;
using System.Collections.Generic;
using System.Text;

namespace NunitAcademy.Core.FinalCode
{
    public class EventLogViewer
    {
        private readonly IEvents _events;
        private List<Eventlog> _eventlogs;

        public EventLogViewer(IEvents events)
        {
            _events = events;
            _eventlogs = new List<Eventlog>();
        }

        public IEnumerable<Eventlog> getEventsfromLast5Minutes()
        {            
            DateTime fromDate = DateTime.Now.Subtract(new TimeSpan(hours: 0, minutes: 5, seconds: 0));
            _eventlogs.Clear();
            var logs = _events.getEventLogs(fromDate);
            if (logs is null)
                return null;
            foreach(var log in logs)
            {
                _eventlogs.Add(new Eventlog()
                {
                    Message = log["Message"].ToString(),
                    ComputerName = log["ComputerName"].ToString(),
                    Type = log["Type"].ToString(),
                    User = log["User"].ToString(),
                    EventCode = log["EventCode"].ToString(),
                    Category = log["Category"].ToString(),
                    SourceName = log["SourceName"].ToString(),
                    RecordNumber = log["RecordNumber"].ToString(),
                    TimeWritten = Convert.ToDateTime(log["TimeWritten"].ToString())
                });
            }
            return _eventlogs;            
        }
    }
}
