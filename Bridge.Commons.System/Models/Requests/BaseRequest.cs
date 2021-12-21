using System;

namespace Bridge.Commons.System.Models.Requests
{
    /// <summary>
    ///     Base das requisitções
    /// </summary>
    /// <typeparam name="TId"></typeparam>
    public class BaseRequest<TId> : BaseModel<TId> where TId : IConvertible
    {
        /// <summary>
        ///     Construtor
        /// </summary>
        public BaseRequest()
        {
        }

        /// <summary>
        ///     Construtor recebendo identificador
        /// </summary>
        /// <param name="id"></param>
        public BaseRequest(TId id) : base(id)
        {
        }

        /// <summary>
        ///     Construtor recebendo identificador e token da aplicação
        /// </summary>
        /// <param name="id"></param>
        /// <param name="applicationToken"></param>
        public BaseRequest(TId id, string applicationToken) : base(id, applicationToken)
        {
        }
    }
}