using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace NunitAcademy.Core.Dependencies
{
    public class VideoService
    {
        public string ReadVideoTitle(IFileReader fileReader, String path)
        {           
            var video = fileReader.Read(path);
            if (video == null)
                return "Error parsing the video.";
            return video.Title;
        }
    }

    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }
    
}
