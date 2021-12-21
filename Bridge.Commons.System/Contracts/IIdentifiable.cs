using System;

namespace Bridge.Commons.System.Contracts
{
    /// <summary>
    ///     Identificavel
    /// </summary>
    /// <typeparam name="TId"></typeparam>
    public interface IIdentifiable<TId> where TId : IConvertible
    {
        /// <summary>
        ///     Propriedade identificador
        /// </summary>
        TId Id { get; set; }
    }
}