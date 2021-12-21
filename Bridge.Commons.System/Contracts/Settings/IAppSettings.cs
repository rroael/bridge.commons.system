namespace Bridge.Commons.System.Contracts.Settings
{
    /// <summary>
    ///     Configurações do Aplicativo
    /// </summary>
    public interface IAppSettings
    {
        /// <summary>
        ///     Ambiente
        /// </summary>
        string Environment { get; set; }
    }
}