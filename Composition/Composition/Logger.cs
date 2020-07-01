using System;

namespace Composition
{
    public class Logger
    {
        public void Log(string message)
        {
            if (message != null) Console.WriteLine(message);
        }
    }
}