using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.Mappings
{
    public class RoleMenuMapping : EntityTypeConfiguration<Entities.RoleMenu>
    {
        public RoleMenuMapping()
        {
            this.HasKey(_ => _.RoleMenuId);
        }
    }
}
