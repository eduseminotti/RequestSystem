﻿using System;
using System.Configuration;

namespace Request_System
{

    public class LOG
    {
        private void _logador( String entryType, String log)
        {
            String arquivoLog = ConfigurationManager.AppSettings.Get("LocalLog");

            System.IO.TextWriter arquivo = System.IO.File.AppendText(arquivoLog);

            arquivo.WriteLine(DateTime.Now + " -  [" + entryType + "] - Mensagem: " + log);
            arquivo.Close();
        }

        public void logador(String log)
        {
            _logador("INFO" ,log );
        }

        public void logador(Exception ex)
        {
            _logador("ERRO" , ex.ToString());
        }
    }
}
