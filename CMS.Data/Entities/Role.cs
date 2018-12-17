﻿using CMS.Data.Entities.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.Entities
{
    public class Role : BaseModel
    {
        public Guid RoleId { get; set; }

        public string RoleCode { get; set; }

        public string RoleName { get; set; }

        public string Remark { get; set; }
    }
}
