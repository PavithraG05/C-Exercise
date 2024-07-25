using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay6
{
    public class Logger
    {
        public delegate void LoggingOperation(string message);
        public void Info(string message)
        {
            Console.WriteLine("[INFO] " + message);
        }

        public void Warning(string message)
        {
            Console.WriteLine("[Warning] " + message);
        }

        public void ERROR(string message)
        {
            Console.WriteLine("[ERROR] " + message);
        }
    }
}
