using System;

namespace ATLauncherAPI
{
    public class Logger
    {

        private string loggername;

        private Logger(string loggername)
        {
            this.loggername = loggername;
        }

        public static Logger getLogger(string name)
        {
            return new Logger(name);
        }

        public void error(string message)
        {
            Console.Error.WriteLine(loggername + ": " + message);
        }

    }
}