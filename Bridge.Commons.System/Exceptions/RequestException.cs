using System;
using System.Collections.Generic;
using Bridge.Commons.System.Models.Validations;

namespace Bridge.Commons.System.Exceptions
{
    /// <summary>
    ///     Request Exception
    /// </summary>
    public class RequestException : BaseException
    {
        /// <summary>
        ///     Construtor
        /// </summary>
        public RequestException()
        {
        }

        /// <summary>
        ///     Construtor recebendo a exceção
        /// </summary>
        /// <param name="innerException"></param>
        public RequestException(Exception innerException) : base(innerException)
        {
        }

        /// <summary>
        ///     Construtor recebendo codigo, mensagem, campo e a exceção
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="field"></param>
        /// <param name="innerException"></param>
        public RequestException(int code, string message, string field = null, Exception innerException = null)
            : base(code, message, field, innerException)
        {
        }

        /// <summary>
        ///     Construtor recebendo mensagem e a exceção
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public RequestException(string message, Exception innerException = null)
            : base(message, innerException)
        {
        }

        /// <summary>
        ///     Construtor recebendo uma lista de erros e a exceção
        /// </summary>
        /// <param name="errorList"></param>
        /// <param name="innerException"></param>
        public RequestException(IList<ErrorInstance> errorList, Exception innerException = null)
            : base(errorList, innerException)
        {
        }
    }
}