namespace Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Logger
    {
        private static readonly Logger _instance = new Logger();
        private readonly StringBuilder _logs;

        static Logger()
        {
        }

        private Logger()
        {
            _logs = new StringBuilder();
        }

        public static Logger Instance => _instance;
        public string AllLogs => _logs.ToString();

        public void LogInfo(string message)
        {
            Log(ErrorType.LogTypes.Info, message);
        }

        public void LogError(string message)
        {
            Log(ErrorType.LogTypes.Error, message);
        }

        public void LogWarning(string message)
        {
            Log(ErrorType.LogTypes.Warning, message);
        }

        public void Log(ErrorType.LogTypes type, string message)
        {
            var log = $"{DateTime.UtcNow}: {type.ToString()}: {message}";
            _logs.AppendLine(log);
            Console.WriteLine(log);
        }
    }
}
