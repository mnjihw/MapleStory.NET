namespace MapleStory.NET;

public static class ExtensionMethods
{
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
    public static string ToJsonString<T>(this T obj) => JsonSerializer.Serialize(obj, Helper.JsonSerializerOptions);
}