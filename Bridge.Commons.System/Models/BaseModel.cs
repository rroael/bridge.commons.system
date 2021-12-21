using System;
using System.Text.Json.Serialization;

namespace Bridge.Commons.System.Models
{
    /// <summary>
    ///     Base dos modelos
    /// </summary>
    /// <typeparam name="TId"></typeparam>
    public class BaseModel<TId> : Identifiable<TId> where TId : IConvertible
    {
        /// <summary>
        ///     Construtor
        /// </summary>
        public BaseModel()
        {
        }

        /// <summary>
        ///     Construtor recebendo identificador
        /// </summary>
        /// <param name="id"></param>
        public BaseModel(TId id) : base(id)
        {
        }

        /// <summary>
        ///     Construtor recebendo identificador e token da aplicação
        /// </summary>
        /// <param name="id"></param>
        /// <param name="applicationToken"></param>
        public BaseModel(TId id, string applicationToken) : this(id)
        {
            ApplicationToken = applicationToken;
        }

        /// <summary>
        ///     Token da aplicação
        /// </summary>
        [JsonIgnore]
        public string ApplicationToken { get; set; }
    }
}