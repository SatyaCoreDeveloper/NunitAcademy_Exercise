using System;
using System.Collections.Generic;
using System.Text;

namespace NunitAcademy.Core.Advanced
{
    public class HtmlFormatter
    {
        public string FormatAsBold(string content)
        {
            return $"<strong>{content}</strong>";
        }
    }
}
