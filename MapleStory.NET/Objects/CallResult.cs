namespace MapleStory.NET.Objects;
/// <summary>
/// 호출 결과
/// </summary>
/// <param name="error">발생한 에러</param>
public class CallResult(Error? error)
{
    /// <summary>
    /// 발생한 에러
    /// </summary>
    public Error? Error { get; set; } = error;
    /// <summary>
    /// 성공 여부
    /// </summary>
    public bool Success => Error is null;
    /// <summary>
    /// 성공 여부
    /// </summary>
    /// <param name="obj"></param>

    public static implicit operator bool(CallResult obj) => obj?.Success == true;
    /// <summary>
    /// 문자열 반환을 위한 ToString 구현
    /// </summary>
    /// <returns>성공 시 Success, 실패 시 Error: {Error} 반환</returns>
    public override string ToString() => Success ? "Success" : $"Error: {Error}";
}

/// <summary>
/// 호출 결과
/// </summary>
/// <typeparam name="T">반환할 데이터의 타입</typeparam>
public class CallResult<T> : CallResult
{
    /// <summary>
    /// 성공 시 반환할 데이터
    /// </summary>
    public T? Data { get; internal set; }
    /// <summary>
    /// 생성자
    /// </summary>
    /// <param name="data">데이터</param>
    /// <param name="error">에러</param>
    protected CallResult(T? data, Error? error) : base(error) => Data = data;
    /// <summary>
    /// 생성자
    /// </summary>
    /// <param name="data">데이터</param>
    public CallResult(T? data) : this(data, null) { }
    /// <summary>
    /// 생성자
    /// </summary>
    /// <param name="error">에러</param>
    public CallResult(Error error) : this(default, error) { }
    /// <summary>
    /// 성공 여부
    /// </summary>
    /// <param name="obj"></param>
    public static implicit operator bool(CallResult<T> obj) => obj?.Success == true;
}

