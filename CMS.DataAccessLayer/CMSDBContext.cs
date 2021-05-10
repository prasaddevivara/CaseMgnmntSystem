using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DataAccessLayer
{
    public class CMSDBContext : DbContext
    {
        public CMSDBContext() : base("CMSDB") { }

        public DbSet<User> Categories { get; set; }
 
    }
}
