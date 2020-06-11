using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ExerciciVIDEOS.Model
{
    public class Video : Entity
    {
        #region Properties
        public string Title { get; set; }
        public string Url { get; set; }        
        
        public User User { get; set; }        

        #endregion

        #region CRUD
        public static void CreateNewVideo(Video newVideo)
        {
            VideoContext.Videos.Add(newVideo.Id, newVideo);
        }        

        public static void GetVideosByUser(User CurrentUser)
        {
            var videosByUser = VideoContext.Videos.Values.Where(v => v.User == CurrentUser);

            foreach (var video in videosByUser)
            {
                Console.WriteLine($"{video.Title} - {video.Url}");
            }
        }        
        
        #endregion
        
    }
}
