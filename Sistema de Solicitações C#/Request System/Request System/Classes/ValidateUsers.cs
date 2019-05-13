using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Request_System
{
    public class User
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public UserType Type { get; set; }
        public UserIsactive IsActive { get; set; }
        public UserIdioma Idioma { get; set; }
        public int UserID { get; set; }
        public String Name { get; set; }

        public bool IsValid(String password)
        {
            return this.Password == password;
        }
    }

    public class ValidateUsers
    {
        LOG log = new LOG();

        public User ValidaUsuario(String userName, String pass)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            User user = null;
            try
            {
                string queryString = "select  ID, Name, UserName , password, type , isActive, idioma from Seminotti_Teste.dbo.Users where UserName  = @UserName and password = @password";
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(queryString, sqlConn);

                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = pass;

                SqlDataReader query = cmd.ExecuteReader();

                while (query.Read())
                {
                    user = new User();

                    user.IsActive = (UserIsactive)int.Parse(query["isActive"].ToString());

                    if (user.IsActive == UserIsactive.Inativo)
                        return null;

                    user.Username = query["UserName"].ToString();
                    user.Name = query["Name"].ToString();
                    user.Password = query["password"].ToString();
                    user.Type = (UserType)int.Parse(query["Type"].ToString());
                    user.Idioma = (UserIdioma)int.Parse(query["idioma"].ToString());
                    user.UserID = int.Parse(query["id"].ToString());
                }
                return user;
            }
            catch (SqlException ex)
            {
                log.logador("Erro ao validar usuario!");
                log.logador(ex);
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
        }
        public String GetUserName(int UserId)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            String userName = null;
            try
            {
                string queryString = "select   UserName from dbo.Users where id  = @id ";
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(queryString, sqlConn);

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = UserId;

                SqlDataReader query = cmd.ExecuteReader();

                while (query.Read())
                {
                    userName = query["UserName"].ToString();
                }
                return userName;
            }
            catch (SqlException ex)
            {
                log.logador("Erro ao capturar usuario do banco!");
                log.logador(ex);
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }
}
