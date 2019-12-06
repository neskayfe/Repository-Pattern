using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example_Repository_Pattern.UI.Areas.Admin.Models.DTO
{
    public class CatergoryDTO:BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}