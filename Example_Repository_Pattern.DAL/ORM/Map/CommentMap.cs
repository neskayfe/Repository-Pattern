using Example_Repository_Pattern.DAL.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Repository_Pattern.DAL.ORM.Map
{
    public class CommentMap:CoreMap<Comment>
    {
        public CommentMap()
        {
            ToTable("dbo.Comments");
            Property(x => x.Content).IsRequired();

            HasKey(x => new
            {
                x.AppUserID,
                x.ArticleID
            });
        }
    }
}
