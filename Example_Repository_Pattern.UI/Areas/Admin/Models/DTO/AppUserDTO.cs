using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example_Repository_Pattern.UI.Areas.Admin.Models.DTO
{
    public enum Role
    {
        None=0,
        Admin=1,
        Author=2,
        Member=3
    }
    public class AppUserDTO:BaseDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
    }
}