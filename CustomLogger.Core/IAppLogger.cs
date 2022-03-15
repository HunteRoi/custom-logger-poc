namespace CustomLogger.Core;

public interface IAppLogger<T>
{
    void CustomLogEvent(string message);
}