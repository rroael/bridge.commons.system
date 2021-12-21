using System;
using System.Collections.Generic;
using Bridge.Commons.System.Models.Validations;

namespace Bridge.Commons.System.Exceptions
{
    /// <summary>
    ///     Conflict Exception (HTTP 409)
    /// </summary>
    public class ConflictException : BaseException
    {
        /// <summary>
        ///     Construtor
        /// </summary>
        public ConflictException()
        {
        }

        /// <summary>
        ///     Construtor recebendo uma exceção
        /// </summary>
        /// <param name="innerException"></param>
        public ConflictException(Exception innerException) : base(innerException)
        {
        }

        /// <summary>
        ///     Construtor recebendo código da exceção, mensagem, campo e uma exceção
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="field"></param>
        /// <param name="innerException"></param>
        public ConflictException(int code, string message, string field = null, Exception innerException = null)
            : base(code, message, field, innerException)
        {
        }

        /// <summary>
        ///     Construtor recebendo mensagem e uma exceção
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ConflictException(string message, Exception innerException = null)
            : base(message, innerException)
        {
        }

        /// <summary>
        ///     Construtor recebendo uma lista de erros e uma exceção
        /// </summary>
        /// <param name="errorList"></param>
        /// <param name="innerException"></param>
        public ConflictException(IList<ErrorInstance> errorList, Exception innerException = null)
            : base(errorList, innerException)
        {
        }
    }
}