using ExerciciVIDEOS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciVIDEOS
{
    public static class Validation
    {
        #region ExistenceValidations
        public static ValidationResult<User> UserNameExistsValidation(string currentUserName)
        {
            var validationResult = new ValidationResult<User>()
            {
                IsSuccess = true
            };
            
            var userExists = VideoContext.Users.Values.FirstOrDefault(u => u.UserName == currentUserName);

            if (userExists != default)
            {
                validationResult.ValidatedResult = userExists;
            }
            else
            {
                validationResult.IsSuccess = false;
                validationResult.Errors.Add("Aquest usuari no existeix");                
            }

            return validationResult;
        }

        public static ValidationResult<Video> VideoTitleExistsValidation(string currentVideoTitle)
        {
            var validationResult = new ValidationResult<Video>()
            {
                IsSuccess = true
            };

            var videoExists = VideoContext.Videos.Values.FirstOrDefault(u => u.Title == currentVideoTitle);

            if (videoExists != default)
            {
                validationResult.ValidatedResult = videoExists;
            }
            else
            {
                validationResult.IsSuccess = false;
                validationResult.Errors.Add("Aquest vídeo no existeix");
            }

            return validationResult;
        }

        #endregion

        #region NewInputValidations
        public static ValidationResult<string> VideoTitleValidation(string newVideoTitle)
        {
            var validationResult = new ValidationResult<string>
            {
                IsSuccess = true,
            };

            if (string.IsNullOrEmpty(newVideoTitle))
            {
                validationResult.IsSuccess = false;
                validationResult.Errors.Add("El camp no pot estar buit");
            }
            else
            {
                var videoTitleExists = VideoContext.Videos.Values.FirstOrDefault(u => u.Title == newVideoTitle);

                if (videoTitleExists != default)
                {
                    validationResult.IsSuccess = false;
                    validationResult.Errors.Add("Aquest títol ja existeix");
                }
                else
                {
                    validationResult.IsSuccess = true;
                }
            }

            return validationResult;
        }

        public static ValidationResult<string> VideoUrlValidation(string newVideoUrl)
        {
            var validationResult = new ValidationResult<string>
            {
                IsSuccess = true,
            };

            if (string.IsNullOrEmpty(newVideoUrl))
            {
                validationResult.IsSuccess = false;
                validationResult.Errors.Add("El camp no pot estar buit");
            }
            else
            {
                var videoUrlExists = VideoContext.Videos.Values.FirstOrDefault(u => u.Url == newVideoUrl);

                if (videoUrlExists != default)
                {
                    validationResult.IsSuccess = false;
                    validationResult.Errors.Add("Aquesta adreça ja existeix");
                }
                else
                {
                    validationResult.IsSuccess = true;
                }
            }

            return validationResult;
        }

        public static ValidationResult<string> TagNameValidation(string newTagName)
        {
            var validationResult = new ValidationResult<string>
            {
                IsSuccess = true,
            };

            if (string.IsNullOrEmpty(newTagName))
            {
                validationResult.IsSuccess = false;
                validationResult.Errors.Add("El camp no pot estar buit");
            }
            else
            {
                var tagNameExists = VideoContext.Tags.FirstOrDefault(u => u.TagName == newTagName);

                if (tagNameExists != default)
                {
                    validationResult.IsSuccess = false;
                    validationResult.Errors.Add("Aquest tag ja existeix");
                }
                else
                {
                    validationResult.IsSuccess = true;
                }
            }

            return validationResult;
        }
        #endregion
    }
}
