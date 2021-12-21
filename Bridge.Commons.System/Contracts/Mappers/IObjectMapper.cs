namespace Bridge.Commons.System.Contracts.Mappers
{
    /// <summary>
    ///     Mapeador de objeto
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TOutput"></typeparam>
    public interface IObjectMapper<TInput, out TOutput> : IFromObjectMapper<TInput, TOutput>, IToObjectMapper<TInput>
        where TInput : class
        where TOutput : class
    {
    }
}