using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Entities.Framework
{
    public class BaseModel
    {
        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public Guid CreateUser { get; set; }

        public Guid UpdateUser { get; set; }
    }
}
