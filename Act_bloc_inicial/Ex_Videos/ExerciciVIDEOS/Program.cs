using System;
using ExerciciVIDEOS;
using System.Runtime.CompilerServices;
using ExerciciVIDEOS.Model;
using System.Transactions;
using System.Collections.Generic;
using System.Linq;

namespace ExerciciVIDEOS
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadInitialData();
            ShowMainMenu();
        }
        #region Menus
        public static void ShowMainMenu()
        {
            while (true)
            {
            Console.WriteLine("--Videos IT Academy--");
            Console.WriteLine("Indica el teu nom d'usuari per accedir als teus vídeos");

            var currentUserName = Console.ReadLine();

            var validResult = Validation.UserNameExistsValidation(currentUserName);

                if (validResult.IsSuccess)
                    ShowUserMenu(validResult.ValidatedResult);
                else
                {
                    foreach (var error in validResult.Errors)
                    {
                        Console.WriteLine(error);
                    }
                }
            }
        }

        public static void ShowUserMenu(User CurrentUser)
        {
            var keepdoing = true;

            while (keepdoing)
            {
                Console.WriteLine("--Videos IT Academy--");
                Console.WriteLine("--Menú Usuari--");
                Console.WriteLine("Veure llistat de vídeos - apreta a");
                Console.WriteLine("Afegir un nou vídeo - apreta b");
                Console.WriteLine("Anar a la gestió de vídeos - apreta c");
                Console.WriteLine("Sortir de l'aplicació - apreta e");

                var currentOption = Console.ReadLine();

                switch (currentOption)
                {
                    case "a":
                        Video.GetVideosByUser(CurrentUser);
                        break;
                    case "b":
                        NewVideoValidationProcess(CurrentUser);
                        break;
                    case "c":
                        ShowVideoMenu(CurrentUser);
                        break;
                    case "e":
                        ShowMainMenu();
                        keepdoing = false;
                        break;
                    default:
                        Console.WriteLine("Opció incorrecta. Torna-ho a escriure");
                        break;
                }
            }
        }        
        
        public static void ShowVideoMenu(User CurrentUser)
        {
            while (true)
            {
                Console.WriteLine("--Videos IT Academy--");
                Console.WriteLine("--Gestió Vídeos--");                
                Console.WriteLine("Afegir un tag al vídeo - apreta a");
                Console.WriteLine("Veure tots els tags - apreta b");
                Console.WriteLine("Reproduir un vídeo - apreta c");
                Console.WriteLine("Per tornar al menú anterior - apreta e");
            
                var currentOption = Console.ReadLine();

                if (currentOption == "e")
                {
                    ShowUserMenu(CurrentUser);                    
                }

                if (currentOption == "a" || currentOption == "b" || currentOption == "c")
                {
                    while (true)
                    {
                        Console.WriteLine("Indica el vídeo que vol utilitzar");

                        var currentVideoTitle = Console.ReadLine();

                        var validResult = Validation.VideoTitleExistsValidation(currentVideoTitle);

                        if (!validResult.IsSuccess)
                        {
                            foreach (var error in validResult.Errors)
                            {
                                Console.WriteLine(error);
                            }
                        }
                        else
                        {
                            switch (currentOption)
                            {
                                case "a":
                                    NewTagValidationProcess(validResult.ValidatedResult);
                                    break;
                                case "b":
                                    Tag.GetTagsByVideo(validResult.ValidatedResult);
                                    break;
                                case "c":
                                    ShowPlayVideoMenu(validResult.ValidatedResult);
                                    break;                                
                            }
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Opció incorrecta. Torna-ho a escriure");
                }
            }
        }

        public static void ShowPlayVideoMenu(Video currentVideo)
        {
            Console.WriteLine($"El vídeo {currentVideo.Title} s'està reproduint."); 
            Console.WriteLine("Indica a continuació què vols fer:");
            Console.WriteLine($"{VideoActions.Pause} - apreta p");
            Console.WriteLine($"{VideoActions.Stop} - apreta s");
            Console.WriteLine($"{VideoActions.Exit} - apreta e");

            var keepdoing = true;
            
            while (keepdoing)
            {            
                var option = Console.ReadLine();

                switch (option)
                {
                    case "p":
                        ShowPauseVideoMenu(currentVideo);
                        keepdoing = false;
                        break;
                    case "s":
                        ShowStopVideoMenu(currentVideo);
                        keepdoing = false;
                        break;
                    case "e":
                        keepdoing = false;
                        break;
                    default:
                        Console.WriteLine("Opció incorrecte. Torna-ho a provar");
                        break;
                }
            }
        }

        public static void ShowPauseVideoMenu(Video currentVideo)
        {
            Console.WriteLine($"El vídeo {currentVideo.Title} està en pausa. ");
            Console.WriteLine("Indica a continuació què vols fer:");
            Console.WriteLine($"{VideoActions.Play} - apreta p");
            Console.WriteLine($"{VideoActions.Stop} - apreta s");
            Console.WriteLine($"{VideoActions.Exit} - apreta e");

            var keepdoing = true;

            while (keepdoing)
            {
                var option = Console.ReadLine();

                switch (option)
                {
                    case "p":
                        ShowPlayVideoMenu(currentVideo);
                        keepdoing = false;
                        break;
                    case "s":
                        ShowStopVideoMenu(currentVideo);
                        keepdoing = false;
                        break;
                    case "e":
                        keepdoing = false;
                        break;
                    default:
                        Console.WriteLine("Opció incorrecte. Torna-ho a provar");
                        break;
                }
            }
        }

        public static void ShowStopVideoMenu(Video currentVideo)
        {
            Console.WriteLine($"El vídeo {currentVideo.Title} està parat.");
            Console.WriteLine("Indica a continuació què vols fer:");
            Console.WriteLine($"{VideoActions.Play} - apreta p");
            Console.WriteLine($"{VideoActions.Pause} - apreta s");
            Console.WriteLine($"{VideoActions.Exit} - apreta e");

            var keepdoing = true;

            while (keepdoing)
            {
                var option = Console.ReadLine();

                switch (option)
                {
                    case "p":
                        ShowPlayVideoMenu(currentVideo);
                        keepdoing = false;
                        break;
                    case "s":
                        ShowPauseVideoMenu(currentVideo);
                        keepdoing = false;
                        break;
                    case "e":
                        keepdoing = false;
                        break;
                    default:
                        Console.WriteLine("Opció incorrecte. Torna-ho a provar");
                        break;
                }
            }
        }

        #endregion

        #region ValidationProcesses

        public static void NewVideoValidationProcess(User CurrentUser)
        {
            var keepdoing = true;
            
            while (keepdoing)
            {
                Console.WriteLine("Introdeix el títol del nou vídeo:");

                var newVideoTitle = Console.ReadLine();

                var validResult = Validation.VideoTitleValidation(newVideoTitle);

                if (!validResult.IsSuccess)
                {
                    foreach (var error in validResult.Errors)
                    {
                        Console.WriteLine(error);
                    }
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Introdueix l'adreça web:");

                        var newVideoUrl = Console.ReadLine();

                        var urlValidResult = Validation.VideoUrlValidation(newVideoUrl);

                        if (!urlValidResult.IsSuccess)
                        {
                            foreach (var error in urlValidResult.Errors)
                            {
                                Console.WriteLine(error);
                            }
                        }
                        else
                        {
                            var video = new Video()
                            {
                                Id = Guid.NewGuid(),
                                Title = newVideoTitle,
                                Url = newVideoUrl,
                                User = CurrentUser
                            };

                            Video.CreateNewVideo(video);

                            keepdoing = false;
                            break;
                        }
                    }                    
                }
            }
        }

        public static void NewTagValidationProcess(Video currentVideo)
        {
            while (true)
            {
                Console.WriteLine("Introdueix el nou tag:");

                var newTagName = Console.ReadLine();

                var tagValidResult = Validation.VideoUrlValidation(newTagName);

                if (!tagValidResult.IsSuccess)
                {
                    foreach (var error in tagValidResult.Errors)
                    {
                        Console.WriteLine(error);
                    }
                }
                else
                {                    
                    var tag = new Tag()
                    {                        
                        TagName = newTagName,
                        Video = currentVideo
                    };

                    Tag.AddNewTag(tag);

                    break;
                }
            }            
        }

        #endregion

        #region Enum
        enum VideoActions
        {
            Play,
            Pause,
            Stop,
            Exit
        }

        #endregion

        #region InitialData
        public static void LoadInitialData()
        {
            var gerard = new User
            {
                UserName = "ger123",
                FirstName = "Gerard",
                LastName = "Ferrer",
                Password = "1111",
                RegisterDate = new DateTime(2020, 06, 10, 11, 47, 45),
            };
            var felip = new User
            {
                UserName = "fel123",
                FirstName = "Felip",
                LastName = "Tort",
                Password = "2222",
                RegisterDate = new DateTime(2019, 06, 12, 11, 47, 45)
            };

            var joan = new User
            {
                UserName = "joan123",
                FirstName = "Joan",
                LastName = "Birbe",
                Password = "3333",
                RegisterDate = new DateTime(2016, 04, 12, 11, 47, 45)
            };

            VideoContext.Users.Add(joan.UserName, joan);
            VideoContext.Users.Add(gerard.UserName, gerard);
            VideoContext.Users.Add(felip.UserName, felip);

            var video1_gerard = new Video()
            {
                Id = Guid.NewGuid(),
                Title = "C# Tutorial",
                Url = "www.itacademy.com/csharptutorial",
                User = gerard
            };

            var video2_gerard = new Video()
            {
                Id = Guid.NewGuid(),
                Title = "ASP.NET Tutorial",
                Url = "www.itacademy.com/aspnettutorial",
                User = gerard
            };

            var video1_joan = new Video()
            {
                Id = Guid.NewGuid(),
                Title = "C# Tutorial",
                Url = "www.itacademy.com/csharptutorial",
                User = joan
            };

            var video3_joan = new Video()
            {
                Id = Guid.NewGuid(),
                Title = "WPF Tutorial",
                Url = "www.itacademy.com/wpftutorial",
                User = joan
            };

            var video3_felip = new Video()
            {
                Id = Guid.NewGuid(),
                Title = "WPF Tutorial",
                Url = "www.itacademy.com/wpftutorial",
                User = felip
            };

            VideoContext.Videos.Add(Guid.NewGuid(), video1_gerard);
            VideoContext.Videos.Add(Guid.NewGuid(), video2_gerard);
            VideoContext.Videos.Add(Guid.NewGuid(), video1_joan);
            VideoContext.Videos.Add(Guid.NewGuid(), video3_joan);
            VideoContext.Videos.Add(Guid.NewGuid(), video3_felip);

            var tag1_video1_g = new Tag()
            {
                TagName = "Beginners",
                Video = video1_gerard
            };
            var tag2_video1_g = new Tag()
            {
                TagName = "c#",
                Video = video1_gerard
            };
            var tag3_video2_g = new Tag()
            {
                TagName = "Advanced",
                Video = video2_gerard
            };
            var tag3_video3_j = new Tag()
            {
                TagName = "Advanced",
                Video = video3_joan
            };
            var tag4_video3_f = new Tag()
            {
                TagName = "WPF",
                Video = video3_felip
            };
            var tag5_video2_g = new Tag()
            {
                TagName = "Asp.net",
                Video = video2_gerard
            };

            VideoContext.Tags.Add(tag1_video1_g);
            VideoContext.Tags.Add(tag2_video1_g);
            VideoContext.Tags.Add(tag3_video2_g);
            VideoContext.Tags.Add(tag3_video3_j);
            VideoContext.Tags.Add(tag4_video3_f);
            VideoContext.Tags.Add(tag5_video2_g);
        }
        #endregion
    }
}
