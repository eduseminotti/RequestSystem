using System;
using System.Configuration;

namespace Request_System
{
    public class LOG
    {
        String arquivoLog = ConfigurationManager.AppSettings.Get("LocalLog");

        private void logador( String entryType, String log)
        {

            System.IO.TextWriter arquivo = System.IO.File.AppendText(arquivoLog);

            arquivo.WriteLine(DateTime.Now + " -  [" + entryType + "] - Mensagem: " + log);
            arquivo.Close();
        }

        public void _logador(String log)
        {
            logador("INFO" ,log );
        }
        public void _logador(Exception ex)
        {
            logador("ERRO" , ex.ToString());
        }


    }
}
