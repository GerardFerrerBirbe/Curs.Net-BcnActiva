using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;

namespace ExerciciVIDEOS.Model
{
    public class User
    {
        #region Properties
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }
        
        #endregion      

    }
}
