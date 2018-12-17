using CMS.Data.Entities.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.Entities
{
    public class RoleMenu : BaseModel
    {

        public Guid RoleMenuId { get; set; }

        public Guid RoleId { get; set; }

        public Guid MenuId { get; set; }
    }
}
