namespace Bridge.Commons.System.Contracts.Mappers
{
    /// <summary>
    ///     Mapear do objeto
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TOutput"></typeparam>
    public interface IFromObjectMapper<in TInput, out TOutput>
        where TInput : class
        where TOutput : class
    {
        /// <summary>
        ///     Mapear de input
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        TOutput MapFrom(TInput input);
    }
}