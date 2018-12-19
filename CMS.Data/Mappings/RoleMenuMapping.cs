using CMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.Mappings
{
    public class RoleMenuMapping : EntityTypeConfiguration<RoleMenu>
    {
        public RoleMenuMapping()
        {
            this.ToTable($"Sys{nameof(RoleMenu)}");
            this.HasKey(_ => _.RoleMenuId);
        }
    }
}
