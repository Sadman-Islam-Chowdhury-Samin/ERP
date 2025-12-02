//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace HR.ViewModels
//{
//    public class RegisterViewModel
//    {
//    }
//}

using System.ComponentModel.DataAnnotations;

namespace HR.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
