using System;
using System.Collections.Generic;
using Bridge.Commons.System.Models.Validations;

namespace Bridge.Commons.System.Exceptions
{
    /// <summary>
    ///     Repository exception
    /// </summary>
    public class RepositoryException : BaseException
    {
        /// <summary>
        ///     Construtor
        /// </summary>
        public RepositoryException()
        {
        }

        /// <summary>
        ///     Construtor recebendo a exceção
        /// </summary>
        /// <param name="innerException"></param>
        public RepositoryException(Exception innerException) : base(innerException)
        {
        }

        /// <summary>
        ///     Construtor recebendo código, mensagem, campo e a exceção
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="field"></param>
        /// <param name="innerException"></param>
        public RepositoryException(int code, string message, string field = null, Exception innerException = null)
            : base(code, message, field, innerException)
        {
        }

        /// <summary>
        ///     Construtor recebendo mensagem e a exceção
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public RepositoryException(string message, Exception innerException = null)
            : base(message, innerException)
        {
        }

        /// <summary>
        ///     Construtor recebendo uma lista de erros e a exceção
        /// </summary>
        /// <param name="errorList"></param>
        /// <param name="innerException"></param>
        public RepositoryException(IList<ErrorInstance> errorList, Exception innerException = null)
            : base(errorList, innerException)
        {
        }
    }
}