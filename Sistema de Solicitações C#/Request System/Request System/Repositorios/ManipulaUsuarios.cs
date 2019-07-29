using Request_System.Repositorios.Contexts;
using Request_System.Repositorios.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Request_System
{
    public class Return_Usuarios
    {
        public String CPF { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Setor { get; set; }
        public UserIsactive IsActive { get; set; }
        public UserType Type { get; set; }

    }

    public class ManipulaUsuarios
    {
        LOG log = new LOG();

        public Entities.User GetByUsername(String userName)
        {
            var context = new MainContext();

            using (context)
            {
                var userRepository = new UserRepository(context);

                var user = userRepository.GetByUsername(userName);

                return user;
            }
        }

        public void AddNewUser(Entities.User user)
        {
            var context = new MainContext();

            using (context)
            {
                var userRepository = new UserRepository(context);

                userRepository.AddNewUser(user);

                context.SaveChanges();
            }
        }

        public void EditUser(Entities.User user)
        {
            var context = new MainContext();

            using (context)
            {
                var userRepository = new UserRepository(context);

                context.SaveChanges();
            }
        }


        public IList<Entities.User> GetUsers(Entities.User users)
        {
            var context = new MainContext();

            var getUsers = new List<Entities.User>();

            using (context)
            {
                var userRepository = new UserRepository(context);

                var queryUsers = userRepository.GetAll().Where(x => x.Id > 0);

                if (users != null)
                {
                    if (users.UserName != null)
                        queryUsers = queryUsers.Where(x => x.UserName.Contains(users.UserName));

                    if (users.Name != null)
                        queryUsers = queryUsers.Where(x => x.Name.Contains(users.Name));

                    if (users.Setor != null)
                        queryUsers = queryUsers.Where(x => x.Setor.Contains(users.Setor));

                    if (users.IsActive != UserIsactive._)
                        queryUsers = queryUsers.Where(x => x.IsActive == users.IsActive);

                }

                getUsers = queryUsers.ToList();
            }

            return getUsers;
        }

        #region metodos antigos
     
        /*
        public bool Edit_User(String Name, String Setor, String eMail, String CPF, String UserName, String Password, UserType type, UserIsactive isActive)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
            bool sucess = false;
            string queryString = null;
            try
            {
                queryString = "UPDATE [dbo].[users] SET NAME = @name, setor = @setor, email = @email," +
               " cpf = @cpf, username = @username, type = @type, isactive = @isactive  ";

                SqlCommand cmd = new SqlCommand(queryString, sqlConn);

                if (Password != null)
                {
                    cmd.CommandText += "  , password = @Password  ";
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;
                }

                cmd.CommandText += "   WHERE UserName = @username  ";

                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@setor", Setor);
                cmd.Parameters.AddWithValue("@email", eMail);
                cmd.Parameters.AddWithValue("@cpf", CPF);
                cmd.Parameters.AddWithValue("@username", UserName);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@isactive", isActive);


                sqlConn.Open();
                cmd.ExecuteNonQuery();
                sucess = true;
                log.logador("Usuario editado com sucesso: " + UserName);
            }
            catch (SqlException ex)
            {
                log.logador("Erro ao editar usuario: " + UserName + " - " + queryString);
                log.logador(ex);
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
            return sucess;
        }
        */
        #endregion
    }
}
