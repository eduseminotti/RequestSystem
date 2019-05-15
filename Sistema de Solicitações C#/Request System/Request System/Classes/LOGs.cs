using System;
using System.Configuration;

namespace Request_System
{
    /// <summary>
    /// Classe responsavel por criar os LOGs da aplicação
    /// </summary>
    public class LOG
    {
        /// <summary>
        /// Captura o Local do LOG do APPConfig
        /// </summary>
        String arquivoLog = ConfigurationManager.AppSettings.Get("LocalLog");

        /// <summary>
        /// Metodo  de grava os logs no arquivo
        /// </summary>
        /// <param name="entryType"></param>
        /// <param name="log"></param>
        private void _logador( String entryType, String log)
        {
            System.IO.TextWriter arquivo = System.IO.File.AppendText(arquivoLog);

            arquivo.WriteLine(DateTime.Now + " -  [" + entryType + "] - Mensagem: " + log);
            arquivo.Close();
        }
        /// <summary>
        /// Recebe log do tipo Info
        /// </summary>
        /// <param name="log">Recebe parametros String com a mensagem a ser logada</param>
        public void logador(String log)
        {
            _logador("INFO" ,log );
        }
        /// <summary>
        /// Recebe log do tipo ERRO "Exceptiom"
        /// </summary>
        /// <param name="ex">Recebe variavel do tipo "Exception"</param>
        public void logador(Exception ex)
        {
            _logador("ERRO" , ex.ToString());
        }
    }
}
