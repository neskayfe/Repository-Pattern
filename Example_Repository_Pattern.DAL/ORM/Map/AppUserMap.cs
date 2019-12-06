using Example_Repository_Pattern.DAL.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Repository_Pattern.DAL.ORM.Map
{
   public  class AppUserMap:CoreMap<AppUser>
    {
        public AppUserMap()
        {
            ToTable("dbo.AppUsers");
            Property(x => x.UserName).IsRequired();
            Property(x => x.Password).IsRequired();
            Property(x => x.Email).IsRequired();
            Property(x => x.Role).IsRequired();
            Property(x => x.FirstName).IsRequired();
            Property(x => x.LastName).IsOptional();

            HasMany(x => x.Articles)
                .WithRequired(x => x.AppUser)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);

            HasMany(x => x.Comments)
               .WithRequired(x => x.AppUser)
               .HasForeignKey(x => x.AppUserID)
               .WillCascadeOnDelete(false);

            HasMany(x => x.Likes)
                .WithRequired(x => x.AppUser)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);
        }

    }
}
