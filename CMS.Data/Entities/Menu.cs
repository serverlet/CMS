using CMS.Data.Entities.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Menu : BaseModel
    {
        public Guid MenuId { get; set; }

        public Guid? ParentId { get; set; }

        public string MenuCode { get; set; }

        public string MenuName { get; set; }

        public string ActionUrl { get; set; }
    }
}
