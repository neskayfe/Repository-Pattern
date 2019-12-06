using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example_Repository_Pattern.UI.Areas.Admin.Models.DTO
{
    public class ArticleDTO
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public Guid CategoryID { get; set; }
        public Guid AppUserID { get; set; }
        
    }
}