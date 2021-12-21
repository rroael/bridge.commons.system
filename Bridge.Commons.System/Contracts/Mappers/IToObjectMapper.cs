namespace Bridge.Commons.System.Contracts.Mappers
{
    /// <summary>
    ///     Mapear para o objeto
    /// </summary>
    /// <typeparam name="TOutput"></typeparam>
    public interface IToObjectMapper<out TOutput>
        where TOutput : class
    {
        /// <summary>
        ///     Mapeia para
        /// </summary>
        /// <returns></returns>
        TOutput MapTo();
    }
}