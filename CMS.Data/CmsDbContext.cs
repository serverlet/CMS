using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data
{
    public class CmsDbContext : System.Data.Entity.DbContext
    {
        public CmsDbContext() : base("constr")
        {

        }

        public DbSet<Entities.User> Users { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
