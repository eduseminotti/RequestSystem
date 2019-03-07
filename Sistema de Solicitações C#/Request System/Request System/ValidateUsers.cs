using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Request_System
{

    public class User
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public int Type { get; set; }
        public bool IsActive { get; set; }
        public int Idioma { get; set; }

        public bool IsValid(String password)
        {
            return this.Password == password;
        }
    }
    public class ValidateUsers
    {

        public User GetUser(String userName, String pass)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["Casa"].ConnectionString);

            String loginUserName = userName;
            String loginPass = pass;

            User user = null;

            try
            {
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand("select  UserName , password, type , isActive, idioma from Seminotti_Teste.dbo.Users where UserName  = @UserName and password = @password", sqlConn);

                // Define as informações do parâmetro criado
                SqlParameter paramUser = new SqlParameter();
                paramUser.ParameterName = "@UserName";
                paramUser.Value = loginUserName;

                SqlParameter paramPass = new SqlParameter();
                paramPass.ParameterName = "@password";
                paramPass.Value = loginPass;

                // Inserindo o parâmetro no comando
                cmd.Parameters.Add(paramUser);
                cmd.Parameters.Add(paramPass);

                SqlDataReader query = cmd.ExecuteReader();

                while (query.Read())
                {
                    user = new User();

                    user.IsActive = bool.Parse(query["isActive"].ToString());
                    if (!user.IsActive)
                        return null;

                    user.Username = query["UserName"].ToString();
                    user.Password = query["password"].ToString();
                    user.Type = int.Parse(query["Type"].ToString());
                    user.Idioma = int.Parse(query["idioma"].ToString());        
                }

               
            }
            catch (SqlException)
            {

                throw;
            }

            finally
            {
                sqlConn.Close();

            }
            return user;
        }
    }
}
