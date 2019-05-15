using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Request_System
{
    public class CriptografaSenhas
    {
        /// <summary>
        /// Recebe Solicitação de Criptografar senhas.
        /// </summary>
        /// <param name="pass">senha Nao criptografada</param>
        /// <returns>Senha Criptografada</returns>
        public String CriptografaSenha(String pass)
        {
            pass = hash(pass) + "E";            
            return pass;
        }

        private string hash(string _senha)
        {
            StringBuilder senha = new StringBuilder();

            MD5 md5 = MD5.Create();
            byte[] entrada = Encoding.ASCII.GetBytes(_senha);
            byte[] hash = md5.ComputeHash(entrada);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                senha.Append(hash[i].ToString("X2"));
            }
            return senha.ToString();
        }
    }   
}
