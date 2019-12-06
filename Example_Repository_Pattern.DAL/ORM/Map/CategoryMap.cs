using Example_Repository_Pattern.DAL.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Repository_Pattern.DAL.ORM.Map
{
    class CategoryMap:CoreMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categories");
            Property(x => x.Name).IsRequired();
            Property(x => x.Description).IsOptional();

            HasMany(x => x.Articles)
                .WithRequired(x => x.Category)
                .HasForeignKey(x => x.CategoryID)
                .WillCascadeOnDelete(false);
        }
    }
}
