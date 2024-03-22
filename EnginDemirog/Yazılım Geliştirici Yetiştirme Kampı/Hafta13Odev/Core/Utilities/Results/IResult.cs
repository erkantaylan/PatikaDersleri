namespace Core.Utilities.Results
{
    public interface IResult
    {
        //Temel Voidler için başlangıç
        bool Success { get; }
        string Message { get; }
    }
}