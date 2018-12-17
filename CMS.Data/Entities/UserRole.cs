﻿using CMS.Data.Entities.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.Entities
{
    public class UserRole : BaseModel
    {
        public Guid UserRoleId { get; set; }

        public Guid UserId { get; set; }

        public Guid RoleId { get; set; } 
    }
}
