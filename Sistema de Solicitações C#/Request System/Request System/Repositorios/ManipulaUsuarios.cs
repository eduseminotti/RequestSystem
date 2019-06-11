using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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

        public List<Return_Usuarios> GetUsuarios(String UserName, String Name, String Setor, UserIsactive Status)
        {
            List<Return_Usuarios> return_usuarios = new List<Return_Usuarios>();

            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

            try
            {
                string queryString = "SELECT cpf, NAME, email, UserName , Password , setor , " +
                    "isactive , type  FROM [dbo].[users] where id > 0 ";

                SqlCommand cmd = new SqlCommand(queryString, sqlConn);

                if (UserName != null)
                {
                    cmd.CommandText += " and UserName like @UserName";
                    cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = "%" + UserName + "%";
                }
                if (Name != null)
                {
                    cmd.CommandText += " and Name like @Name";
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = "%" + Name + "%";
                }
                if (Setor != null)
                {
                    cmd.CommandText += " and Setor like @Setor";
                    cmd.Parameters.Add("@Setor", SqlDbType.VarChar).Value = "%" + Setor + "%";
                }
                if (Status != UserIsactive._)
                {
                    cmd.CommandText += " and isactive = @Status";
                    cmd.Parameters.Add("@Status", SqlDbType.Int).Value = Status;
                }

                sqlConn.Open();
                SqlDataReader query = cmd.ExecuteReader();
                while (query.Read())
                {
                    Return_Usuarios usuarios = new Return_Usuarios();

                    usuarios.CPF = query["cpf"].ToString();
                    usuarios.Name = query["Name"].ToString();
                    usuarios.UserName = query["UserName"].ToString();
                    usuarios.Password = query["Password"].ToString();
                    usuarios.Email = query["email"].ToString();
                    usuarios.Setor = query["Setor"].ToString();
                    usuarios.IsActive = (UserIsactive)int.Parse(query["isActive"].ToString());
                    usuarios.Type = (UserType)int.Parse(query["Type"].ToString());
                    
                    return_usuarios.Add(usuarios);
                }
            }
            catch (SqlException ex)
            {
                log.logador("Erro ao carregar a lista de usuarios.");
                log.logador(ex);
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
            return return_usuarios;
        }
        public bool Novo_Usuario(String Name, String Setor, String eMail, String CPF, String UserName, String Password, UserType type, UserIsactive isActive)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
            bool sucess = false;

            string queryString = "insert dbo.Users(Name,Setor,eMail,CPF,UserName,Password,Type,isActive) " +
                "values (@name, @setor, @email, @cpf, @username, @Password, @type, @isactive)";

            SqlCommand cmd = new SqlCommand(queryString, sqlConn);       

            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@setor", Setor);
            cmd.Parameters.AddWithValue("@email", eMail);
            cmd.Parameters.AddWithValue("@cpf", CPF);
            cmd.Parameters.AddWithValue("@username", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@isactive", isActive);

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                sucess = true;
                log.logador("Usuario cadastrado com sucesso: " + UserName);
            }
            catch (SqlException ex)
            {
                log.logador("Erro ao cadastrar usuario: " + UserName);
                log.logador(ex);
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
            return sucess;
        }
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
    }
}
