using System;
using System.Collections.Generic;
using Bridge.Commons.System.Models.Validations;

namespace Bridge.Commons.System.Exceptions
{
    /// <summary>
    ///     Business Exception
    /// </summary>
    public class BusinessException : BaseException
    {
        /// <summary>
        ///     Construtor
        /// </summary>
        public BusinessException()
        {
        }

        /// <summary>
        ///     Construtor recebendo uma exceção
        /// </summary>
        /// <param name="innerException"></param>
        public BusinessException(Exception innerException) : base(innerException)
        {
        }

        /// <summary>
        ///     Construtor recebendo código da exceção, mensagem, campo e uma exceção
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="field"></param>
        /// <param name="innerException"></param>
        public BusinessException(int code, string message, string field = null, Exception innerException = null)
            : base(code, message, field, innerException)
        {
        }

        /// <summary>
        ///     Construtor recebendo mensagem e uma exceção
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public BusinessException(string message, Exception innerException = null)
            : base(message, innerException)
        {
        }

        /// <summary>
        ///     Construtor recebendo uma lista de erros e uma exceção
        /// </summary>
        /// <param name="errorList"></param>
        /// <param name="innerException"></param>
        public BusinessException(IList<ErrorInstance> errorList, Exception innerException = null)
            : base(errorList, innerException)
        {
        }
    }
}