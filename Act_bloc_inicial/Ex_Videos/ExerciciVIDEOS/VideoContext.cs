using ExerciciVIDEOS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciVIDEOS
{
    public class VideoContext
    {
        public static Dictionary<string, User> Users { get; set; } = new Dictionary<string, User>();
        public static Dictionary<Guid, Video> Videos { get; set; } = new Dictionary<Guid, Video>();
        public static List<Tag> Tags { get; set; } = new List<Tag>();

    }
}
