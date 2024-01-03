namespace MapleStory.NET.Objects;
public class CallResult(Error? error)
{
    public Error? Error { get; set; } = error;
    public bool Success => Error is null;

    public static implicit operator bool(CallResult obj) => obj?.Success == true;

    public override string ToString() => Success ? "Success" : $"Error: {Error}";
}

public class CallResult<T> : CallResult
{
    public T? Data { get; internal set; }
    protected CallResult(T? data, Error? error) : base(error) => Data = data;
    public CallResult(T? data) : this(data, null) { }
    public CallResult(Error error) : this(default, error) { }
    public static implicit operator bool(CallResult<T> obj) => obj?.Success == true;
}

