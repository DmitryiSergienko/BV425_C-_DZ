namespace BV425_C__DZ;

public class FileLogger(string filePath)
{
    private readonly StreamWriter _writer;
    private void Log(string message)
    {
        using var streamWriter = new StreamWriter(filePath, true);
        string logMessage = $"{DateTime.Now}: {message}";
        streamWriter.WriteLine(logMessage);
    }

    public void LogError(string message)
    {
        Log($"ERROR: {message}");
    }

    public void LogWarning(string message)
    {
        Log($"WARNING: {message}");
    }

    public void LogInfo(string message)
    {
        Log($"INFO: {message}");
    }
}