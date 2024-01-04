namespace MapleStory.NET;

/// <summary>
/// Provides extension methods for MapleStory.NET.
/// </summary>
public static class ExtensionMethods
{
    /// <summary>
    /// Formats an exception into a log string, including type, message, and stack trace.
    /// Nested inner exceptions are included recursively, with indentation.
    /// </summary>
    /// <param name="exception">The exception to format. Returns empty string if null.</param>
    /// <returns>Formatted log string of the exception. Empty if exception is null.</returns>
    public static string ToLogString(this Exception? exception)
    {
        var message = new StringBuilder();
        var indent = 0;

        while (exception is not null)
        {
            for (var i = 0; i < indent; i++)
                message.Append(' ');
            message.Append(exception.GetType().Name);
            message.Append(" - ");
            message.AppendLine(exception.Message);
            for (var i = 0; i < indent; i++)
                message.Append(' ');
            message.AppendLine(exception.StackTrace);

            indent += 2;
            exception = exception.InnerException;
        }

        return message.ToString();
    }
    /// <summary>
    /// Serializes the given object to a JSON string using standard serialization options.
    /// </summary>
    /// <typeparam name="T">Type of the object to serialize.</typeparam>
    /// <param name="obj">Object to serialize. Returns a JSON representation of null if the object is null.</param>
    /// <returns>JSON string of the object, formatted according to Helper.JsonSerializerOptions.</returns>
    public static string ToJsonString<T>(this T obj) where T : class => JsonSerializer.Serialize(obj, Helper.JsonSerializerOptions);
}