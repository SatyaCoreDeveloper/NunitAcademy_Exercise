using System;
using System.Collections.Generic;
using System.Text;

namespace NunitAcademy.Core.Advanced
{
    public class ErrorLogger
    {
        public string LastError { get; set; }

        public event EventHandler<string> ErrorLogged;

        public void Log(string error)
        {
            if (String.IsNullOrWhiteSpace(error))
                throw new ArgumentNullException();

            LastError = error;

            // Write the log to a storage
            // ...

            ErrorLogged?.Invoke(this, error);
        }
    }
}
