//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace HR.ViewModels
//{
//    public class LoginViewModel
//    {
//    }
//}

using System.ComponentModel.DataAnnotations;

namespace HR.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
