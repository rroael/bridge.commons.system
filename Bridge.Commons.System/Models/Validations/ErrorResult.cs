using System.Collections.Generic;
using Bridge.Commons.System.Contracts.Validators;

namespace Bridge.Commons.System.Models.Validations
{
    /// <summary>
    ///     Resultados de erros
    /// </summary>
    public class ErrorResult : IError
    {
        /// <summary>
        ///     Erros resultantes em uma lista
        /// </summary>
        public ErrorResult()
        {
            ErrorList = new List<ErrorInstance>();
        }

        /// <summary>
        ///     Resultado se há erro ou não
        /// </summary>
        /// <param name="hasError"></param>
        public ErrorResult(bool hasError) : this()
        {
            HasError = hasError;
        }

        /// <summary>
        ///     Adiciona a mensagem e o códio do erro à lista
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        /// <param name="field"></param>
        public ErrorResult(int errorCode, string message, string field) : this(true)
        {
            ErrorList.Add(new ErrorInstance(errorCode, message));
        }

        /// <summary>
        ///     Se tiver erro retornará true, senão false
        /// </summary>
        public bool HasError { get; set; }

        /// <summary>
        ///     Lista de erros
        /// </summary>
        public IList<ErrorInstance> ErrorList { get; set; }

        /// <summary>
        ///     Adiciona a mensagem, código e campo do erro à lista
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorCode"></param>
        /// <param name="field"></param>
        public void AddError(string message, int errorCode = 0, string field = null)
        {
            HasError = true;
            ErrorList.Add(new ErrorInstance(errorCode, message, field));
        }

        /// <summary>
        ///     Envia os parâmetros a função AddError
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        /// <param name="field"></param>
        public void AddError(int errorCode, string message = null, string field = null)
        {
            AddError(message, errorCode, field);
        }

        /// <summary>
        ///     Adiciona a instância do erro à ErrorList e HasError true
        /// </summary>
        /// <param name="error"></param>
        public void AddError(ErrorInstance error)
        {
            HasError = true;
            ErrorList.Add(error);
        }

        /// <summary>
        ///     Cria um resultado com o erro
        /// </summary>
        /// <param name="result"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T CreateResultWithError<T>(ErrorResult result) where T : ErrorResult, new()
        {
            return new T
            {
                HasError = result.HasError,
                ErrorList = result.ErrorList
            };
        }
    }
}