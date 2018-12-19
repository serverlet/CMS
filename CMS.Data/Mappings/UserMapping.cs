using CMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.Mappings
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            this.ToTable($"Sys{nameof(User)}");
            this.HasKey(_ => _.UserId);
            this.Property(_ => _.UserName).HasMaxLength(25);
            this.Property(_ => _.LoginNo).HasMaxLength(25);
            this.Property(_ => _.Password).HasMaxLength(128);
        }
    }
}
