namespace MapleStory.NET.Objects;
/// <summary>
/// 호출 결과
/// </summary>
/// <typeparam name="T">반환할 데이터의 타입</typeparam>
public class CallResult<T>
{
    /// <summary>
    /// 발생한 에러. 성공 시 null이 들어간다.
    /// </summary>
    public Error? Error { get; }
    /// <summary>
    /// 성공 시 반환할 데이터
    /// </summary>
    public T? Data { get; set; }

    /// <summary>
    /// 생성자
    /// </summary>
    /// <param name="data">데이터</param>
    /// <param name="error">에러</param>
    protected CallResult(T? data, Error? error)
    {
        Data = data;
        Error = error;
    }
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
    /// 문자열 반환을 위한 ToString 구현
    /// </summary>
    /// <returns>성공 시 Success, 실패 시 Error: {Error} 반환</returns>
    public override string ToString() => Data is not null ? "Success" : $"Error: {Error}";
}