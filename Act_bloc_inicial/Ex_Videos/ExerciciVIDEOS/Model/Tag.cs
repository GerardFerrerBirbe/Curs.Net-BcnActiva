using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciVIDEOS.Model
{
    public class Tag
    {
        #region Properties
        public string TagName { get; set; }

        public Video Video { get; set; }

        #endregion

        #region CRUD
        public static void AddNewTag(Tag newTag)
        {
            VideoContext.Tags.Add(newTag);
        }

        public static void GetTagsByVideo(Video currentVideo)
        {
            var tagsByVideo = VideoContext.Tags.Where(v => v.Video == currentVideo);

            Console.WriteLine($"Tags inclosos al vídeo {currentVideo.Title}:");

            foreach (var tag in tagsByVideo)
            {
                Console.WriteLine($"{tag.TagName}");
            }
        }

        #endregion
    }
}
