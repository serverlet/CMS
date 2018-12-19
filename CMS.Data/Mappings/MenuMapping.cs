using CMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.Mappings
{
    public class MenuMapping : EntityTypeConfiguration<Menu>
    {
        public MenuMapping()
        {
            this.ToTable($"Sys{nameof(Menu)}");
            this.HasKey(_ => _.MenuId);
            this.Property(_ => _.MenuName).HasMaxLength(15);
            this.Property(_ => _.MenuCode).HasMaxLength(10);
            this.Property(_ => _.ActionUrl).HasMaxLength(300);
        }
    }
}
