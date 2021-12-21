using Microsoft.Extensions.Configuration;

namespace Bridge.Commons.System.Contracts.Settings
{
    /// <summary>
    ///     Configurações
    /// </summary>
    public interface ISettings
    {
        /// <summary>
        ///     Buscar configurações do aplicativo
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetAppSettings<T>() where T : IAppSettings, new();

        /// <summary>
        ///     Buscar configuração do root
        /// </summary>
        /// <returns></returns>
        IConfigurationRoot GetConfigurationRoot();
    }
}