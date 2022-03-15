using Microsoft.Extensions.Logging;

namespace CustomLogger.Core;

public partial class AppLogger<T> : IAppLogger<T>
{
    private readonly ILogger<T> _logger;

    public AppLogger(ILogger<T> logger)
    {
        _logger = logger;
    }

    [LoggerMessage(EventId = 0, Level = LogLevel.Critical, Message = "Custom log message `{message}`")]
    public partial void CustomLogEvent(string message);
}