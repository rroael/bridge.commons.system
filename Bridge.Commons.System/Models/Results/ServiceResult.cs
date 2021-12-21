using System;
using System.Net;
using Bridge.Commons.System.Exceptions;

namespace Bridge.Commons.System.Models.Results
{
    /// <summary>
    ///     Resultado do serviço
    /// </summary>
    public class ServiceResult
    {
        /// <summary>
        ///     Resultado do serviço
        /// </summary>
        public ServiceResult()
        {
            var a = new BusinessException(new Exception("abc"));
        }

        /// <summary>
        ///     Código do status do http response
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; set; }

        /// <summary>
        ///     Mensagem
        /// </summary>
        public string Message { get; set; }
    }
}