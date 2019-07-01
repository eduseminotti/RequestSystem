using System;

namespace Request_System.Entities
{
    public class User
    {
        public long Id { get; set; }
        public String CPF { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Setor { get; set; }
        public UserIsactive IsActive { get; set; }
        public UserType Type { get; set; }
        public DateTime InsertDate { get; set; }

        public bool IsValid(String password)
        {
            return this.IsActive == UserIsactive.Ativo && this.Password == password;
        }
    }
}
