using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.Mappings
{
    public class MenuMapping : EntityTypeConfiguration<Entities.Menu>
    {
        public MenuMapping()
        {
            this.HasKey(_ => _.MenuId);
            this.Property(_ => _.MenuName).HasMaxLength(15);
            this.Property(_ => _.MenuCode).HasMaxLength(10);
            this.Property(_ => _.ActionUrl).HasMaxLength(300);
        }
    }
}
