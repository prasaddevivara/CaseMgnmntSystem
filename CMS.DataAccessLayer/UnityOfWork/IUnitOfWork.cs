using CMS.DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DataAccessLayer.UnityOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
    }

    public interface IDALContext : IUnitOfWork
    {
        IUserRepository User { get; }
       
    }

    public class DALContext : IDALContext
    {
        private CMSDBContext dbContext;
        private IUserRepository user;
       

        public DALContext()
        {
            dbContext = new CMSDBContext();
        }

        public IUserRepository User
        {
            get
            {
                if (user == null)
                    user = new UserRepository(dbContext);
                return user;
            }
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (user != null)
                user.Dispose();
            if (dbContext != null)
                dbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
