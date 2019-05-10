using System;
using System.Diagnostics;

namespace Request_System
{
    public class LOG
    {
        const string LOG_NAME = "Log";
        const string SOURCE = "RequestSystem";

        public LOG()
        {
            if (EventLog.SourceExists(SOURCE) == false)
                EventLog.CreateEventSource(SOURCE, LOG_NAME);
        }

        public void WriteEntry(string input, EventLogEntryType entryType)
        {
            //grava o texto na fonte de logs com o nome que      definimos para a constante SOURCE. 
            EventLog.WriteEntry(SOURCE, input, entryType);
        }
        public void _WriteEntry(string input)
        {
            //loga um simples evento com a categoria de informação. 
            WriteEntry(input, EventLogEntryType.Information);
        }
        public void _WriteEntry(Exception ex)
        {
            //loga a ocorrência de uma excessão com a categoria de erro. 
            WriteEntry(ex.ToString(), EventLogEntryType.Error);
        }

    }
}
