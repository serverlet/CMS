using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data
{
    public class CmsDbContext : System.Data.Entity.DbContext
    {
        public DbSet<Entities.User> Users { get; set; }
    }
}
