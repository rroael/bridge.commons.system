using System;
using System.Collections.Generic;
using Bridge.Commons.System.Models.Validations;

namespace Bridge.Commons.System.Exceptions
{
    /// <summary>
    ///     Exceção de autenticação
    /// </summary>
    public class AuthenticationException : BaseException
    {
        /// <summary>
        ///     Construtor
        /// </summary>
        public AuthenticationException()
        {
        }

        /// <summary>
        ///     Construtor recebendo uma exceção
        /// </summary>
        /// <param name="innerException"></param>
        public AuthenticationException(Exception innerException) : base(innerException)
        {
        }

        /// <summary>
        ///     Construtor recebendo um código da exceção, mensagem, campo e uma exceção
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="field"></param>
        /// <param name="innerException"></param>
        public AuthenticationException(int code, string message, string field = null, Exception innerException = null)
            : base(code, message, field, innerException)
        {
        }

        /// <summary>
        ///     Contrutor recebendo uma mensagem e uma exceção
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public AuthenticationException(string message, Exception innerException = null)
            : base(message, innerException)
        {
        }

        /// <summary>
        ///     Contrutor recebendo uma lista de erros e uma exceção
        /// </summary>
        /// <param name="errorList"></param>
        /// <param name="innerException"></param>
        public AuthenticationException(IList<ErrorInstance> errorList, Exception innerException = null)
            : base(errorList, innerException)
        {
        }
    }
}