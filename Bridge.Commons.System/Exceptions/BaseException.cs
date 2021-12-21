using System;
using System.Collections.Generic;
using Bridge.Commons.System.Models.Validations;

namespace Bridge.Commons.System.Exceptions
{
    /// <summary>
    ///     Base exception
    /// </summary>
    public class BaseException : Exception
    {
        /// <summary>
        ///     Cria uma lista de erros
        /// </summary>
        public BaseException()
        {
            ErrorList = new List<ErrorInstance>();
        }

        /// <summary>
        ///     Adiciona um erro a lista caso a innerexception esteja nula
        /// </summary>
        /// <param name="innerException"></param>
        public BaseException(Exception innerException) : base(innerException?.Message, innerException)
        {
            ErrorList = new List<ErrorInstance>();

            if (innerException != null)
                ErrorList.Add(new ErrorInstance(-1, innerException?.Message, innerException?.Source));
        }

        /// <summary>
        ///     Cria uma instância de erro recebendo código, mensagem e campo da exceção
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="field"></param>
        /// <param name="innerException"></param>
        public BaseException(int code, string message, string field = null, Exception innerException = null)
            : base(message, innerException)
        {
            ErrorList = new List<ErrorInstance>
            {
                new ErrorInstance(code, message, field)
            };
        }

        /// <summary>
        ///     Cria uma instância de erro recebendo a mensagem e a exceção
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public BaseException(string message, Exception innerException = null)
            : base(message, innerException)
        {
            ErrorList = new List<ErrorInstance>
            {
                new ErrorInstance(-1, message)
            };
        }

        /// <summary>
        ///     Cria uma lista de erro recebendo uma errorlist e uma exceção
        /// </summary>
        /// <param name="errorList"></param>
        /// <param name="innerException"></param>
        public BaseException(IEnumerable<ErrorInstance> errorList, Exception innerException = null)
            : base(innerException?.Message, innerException)
        {
            ErrorList = new List<ErrorInstance>(errorList);
        }

        /// <summary>
        ///     Lista de erros
        /// </summary>
        public IList<ErrorInstance> ErrorList { get; set; }

        /// <summary>
        ///     Inicializa nova instância de erro
        /// </summary>
        /// <param name="errorList"></param>
        /// <param name="innerException"></param>
        public void Initialize(IEnumerable<ErrorInstance> errorList, Exception innerException = null)
        {
            ErrorList = new List<ErrorInstance>(errorList);
        }
    }
}