using Request_System.Repositorios.Configurations;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;

namespace Request_System.Repositorios.Contexts
{
    //https://www.entityframeworktutorial.net/code-first/move-configurations-to-seperate-class-in-code-first.aspx

    public class MainContext : DbContext
    {
        public List<User> Users { get; set; }

        public MainContext() : base(ConfigurationManager.ConnectionStrings["CS"].ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
        }
    }
}
