using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.Mappings
{
    public class UserRoleMapping : EntityTypeConfiguration<Entities.UserRole>
    {
        public UserRoleMapping()
        {
            this.HasKey(_ => _.UserRoleId);
        }
    }
}
