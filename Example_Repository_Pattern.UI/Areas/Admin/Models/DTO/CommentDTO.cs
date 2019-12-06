using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example_Repository_Pattern.UI.Areas.Admin.Models.DTO
{
    public class CommentDTO:BaseDTO
    {
        public string Content { get; set; }
        public Guid ArticleID { get; set; }
        public Guid AppUserID { get; set; }

    }
}