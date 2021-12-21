using System;
using Bridge.Commons.System.Contracts.DependencyInjection;
using Bridge.Commons.System.Contracts.Settings;

namespace Bridge.Commons.System.Wrappers
{
    /// <summary>
    ///     Configurações do Wrapper
    /// </summary>
    public static class SettingsWrapper
    {
        private static ISettings _settings;

        private static ISettings GetSettings(IContainer container)
        {
            if (_settings != null)
                return _settings;

            _settings = container.GetInstance<ISettings>();

            return _settings;
        }

        /// <summary>
        ///     Busca as configurações
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="container"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static TResult GetSettings<T, TResult>(Func<T, TResult> expression, IContainer container)
            where T : IAppSettings, new()
        {
            var settings = GetSettings(container).GetAppSettings<T>();
            var result = expression.Invoke(settings);
            return result;
        }
    }
}