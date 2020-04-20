using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NunitAcademy.Core.Dependencies
{
    public class FileReader : IFileReader
    {
        public Video Read(string path)
        {
            var str = File.ReadAllText(@".\Dependencies\video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            return video;
        }
    }

    public class StreamReader : IFileReader
    {
        public Video Read(string path)
        {
            var str = File.ReadAllText(@".\Dependencies\video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            return video;
        }
    }
}
