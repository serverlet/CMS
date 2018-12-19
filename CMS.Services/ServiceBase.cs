using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Data;

namespace CMS.Services
{
    public class ServiceBase
    {
        protected CmsDbContext CmsDbContext => new CmsDbContext();
    }
}
