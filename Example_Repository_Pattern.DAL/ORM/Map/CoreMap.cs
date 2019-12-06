using Example_Repository_Pattern.DAL.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Repository_Pattern.DAL.ORM.Map
{
   public  class CoreMap<T> : EntityTypeConfiguration <T> where T:BaseEntity
    {
        public CoreMap()
        {
            Property(x => x.ID).HasColumnName("ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Status).HasColumnName("Status").IsOptional();
            Property(x => x.AddDate).HasColumnName("AddDate").IsOptional();
            Property(x => x.UpdateDate).HasColumnName("UpdateDate").IsOptional();
            Property(x => x.DeleteDate).HasColumnName("DeleteDate").IsOptional();

        }
    }
}
