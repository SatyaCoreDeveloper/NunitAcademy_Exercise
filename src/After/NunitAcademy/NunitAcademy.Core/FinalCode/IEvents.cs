using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

namespace NunitAcademy.Core.FinalCode
{
    public interface IEvents
    {
        ManagementObjectCollection getEventLogs(DateTime fromTime);
    }
}
