namespace Bridge.Commons.System.Contracts.DependencyInjection
{
    /// <summary>
    ///     Container
    /// </summary>
    public interface IContainer
    {
        /// <summary>
        ///     Buscar instancia
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetInstance<T>() where T : class;
    }
}