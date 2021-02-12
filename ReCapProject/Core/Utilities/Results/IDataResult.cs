namespace Core.Utilities.Results
{
    internal interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}