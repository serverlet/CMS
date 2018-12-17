using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.Mappings
{
    public class RoleMapping : EntityTypeConfiguration<Entities.Role>
    {
        public RoleMapping()
        {
            this.ToTable($"Sys{nameof(Entities.Role)}");
            this.HasKey(_ => _.RoleId);
            this.Property(_ => _.RoleName).HasMaxLength(25);
            this.Property(_ => _.RoleCode).HasMaxLength(10);
            this.Property(_ => _.Remark).HasMaxLength(50);
        }
    }
}
