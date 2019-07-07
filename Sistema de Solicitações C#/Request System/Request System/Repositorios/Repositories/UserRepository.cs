using Request_System.Repositorios.Contexts;
using System.Data.Entity;
using System.Linq;

namespace Request_System.Repositorios.Repositories
{
    public class UserRepository
    {
        private DbSet<Entities.User> dbSet;

        public UserRepository(MainContext context)
        {
            this.dbSet = context.Set<Entities.User>();
        }

        public Entities.User GetByUsername(string username)
        {
            return dbSet.FirstOrDefault(x=> x.UserName == username);
        }

        public Entities.User GetByUserId(int id)
        {
            return dbSet.FirstOrDefault(x=> x.Id == id);
        }

        public void Add(Entities.User newUser)
        {
            dbSet.Add(newUser);
        }
    }
}
