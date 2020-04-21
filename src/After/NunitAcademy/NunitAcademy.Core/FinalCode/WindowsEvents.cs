using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

namespace NunitAcademy.Core.FinalCode
{
    public class WindowsEvents : IEvents
    {
        private string _systemName;
        private ConnectionOptions _options;
        private ManagementScope _managementScope;

        public WindowsEvents(String systemName, ConnectionOptions options)
        {
            _systemName = systemName;
            _options = options;
            _managementScope = new ManagementScope(systemName, options);
        }       

        public ManagementObjectCollection getEventLogs(DateTime fromTime)
        {
            string dmtFromTime = Utilities.getDmtfFromDateTime(fromTime);
            try
            {
                _managementScope.Connect();
                if (_managementScope.IsConnected)
                {
                    SelectQuery query = new SelectQuery("Select * from Win32_NTLogEvent Where Logfile = 'Application' and TimeGenerated >='" + dmtFromTime + "'");
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher(_managementScope, query);
                    ManagementObjectCollection logs = searcher.Get();
                    return logs;
                }
                return null;
            }
            catch(ManagementException magementException)
            {
                //log exception
            }
            return null;
        }
    }
}
