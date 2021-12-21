using System.Collections.Generic;
using Bridge.Commons.System.Models.Validations;

namespace Bridge.Commons.System.Contracts.Validators
{
    /// <summary>
    ///     Erros
    /// </summary>
    public interface IError
    {
        /// <summary>
        ///     Retorna true ou false caso haja algum erro no processo
        /// </summary>
        bool HasError { get; set; }

        /// <summary>
        ///     Lista de erros
        /// </summary>
        IList<ErrorInstance> ErrorList { get; set; }
    }
}