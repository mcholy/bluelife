using Contracts;
using Serilog;

namespace LoggerService
{
    public class LoggerManager : ILoggerManager
    {
        private static readonly ILogger _logger = Log.ForContext<LoggerManager>();
        public LoggerManager() { }
        public void LogDebug(string message) => _logger?.Debug(message);

        public void LogError(string message) => _logger?.Error(message);

        public void LogInfo(string message) => _logger?.Information(message);

        public void LogWarn(string message) => _logger?.Warning(message);
    }
}
