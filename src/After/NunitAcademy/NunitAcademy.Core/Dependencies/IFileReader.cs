using System;
using System.Collections.Generic;
using System.Text;

namespace NunitAcademy.Core.Dependencies
{
    public interface IFileReader
    {
        Video Read(string path);
    }
}
