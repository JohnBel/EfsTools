using System;

namespace EfsTools
{
    internal class Logger
    {
        public void LogInfo(string format, params object[] args)
        {
            //var oldColor = Console.ForegroundColor;
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(format, args);
            //Console.ForegroundColor = oldColor;
        }

        public void LogWarning(string format, params object[] args)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(format, args);
            Console.ForegroundColor = oldColor;
        }

        public void LogError(string format, params object[] args)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(format, args);
            Console.ForegroundColor = oldColor;
        }
    }
}