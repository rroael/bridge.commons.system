using System;

namespace Bridge.Commons.System.Contracts
{
    /// <summary>
    ///     Base Audit
    /// </summary>
    public interface IBaseAudit : IBaseModel
    {
        /// <summary>
        ///     Data de criação
        /// </summary>
        DateTime? CreateDate { get; set; }

        /// <summary>
        ///     Data de atualização
        /// </summary>
        DateTime? UpdateDate { get; set; }
    }
}