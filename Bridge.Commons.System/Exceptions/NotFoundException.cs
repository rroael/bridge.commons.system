using System;
using System.Collections.Generic;
using Bridge.Commons.System.Models.Validations;

namespace Bridge.Commons.System.Exceptions
{
    /// <summary>
    ///     Not found exception
    /// </summary>
    public class NotFoundException : BaseException
    {
        /// <summary>
        ///     Construtor
        /// </summary>
        public NotFoundException()
        {
        }

        /// <summary>
        ///     Construtor recebendo uma exceção
        /// </summary>
        /// <param name="innerException"></param>
        public NotFoundException(Exception innerException) : base(innerException)
        {
        }

        /// <summary>
        ///     Construtor recebendo código, messagem, campo e a exceção
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="field"></param>
        /// <param name="innerException"></param>
        public NotFoundException(int code, string message, string field = null, Exception innerException = null)
            : base(code, message, field, innerException)
        {
        }

        /// <summary>
        ///     Construtor recebendo menssagem e a exceção
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public NotFoundException(string message, Exception innerException = null)
            : base(message, innerException)
        {
        }

        /// <summary>
        ///     Construtor uma lista de erros e a exceção
        /// </summary>
        /// <param name="errorList"></param>
        /// <param name="innerException"></param>
        public NotFoundException(IList<ErrorInstance> errorList, Exception innerException = null)
            : base(errorList, innerException)
        {
        }
    }
}