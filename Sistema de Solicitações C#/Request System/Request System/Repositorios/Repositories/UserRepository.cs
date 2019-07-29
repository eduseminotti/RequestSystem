using Request_System.Repositorios.Contexts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Request_System.Repositorios.Repositories
{
    public class UserRepository
    {
        public DbSet<Entities.User> dbSet;

        public UserRepository(MainContext context)
        {
            this.dbSet = context.Set<Entities.User>();
        }

        public Entities.User GetByUsername(string username)
        {
            return dbSet.FirstOrDefault(x => x.UserName == username);
        }

        public Entities.User GetByUserId(int id)
        {
            return dbSet.FirstOrDefault(x => x.Id == id);
        }
        
        public IList<Entities.User> GetUsers()
        {
            return dbSet.ToList();
        }

        public IQueryable<Entities.User> GetAll()
        {
            return dbSet;
        }

        public void AddNewUser(Entities.User User)
        {
            dbSet.Add(User);
        }
    }
}
