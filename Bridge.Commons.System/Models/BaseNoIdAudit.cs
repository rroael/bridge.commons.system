using System;
using Bridge.Commons.System.Contracts;

namespace Bridge.Commons.System.Models
{
    /// <summary>
    ///     Base Audit para tabelas sem Id
    /// </summary>
    public class BaseNoIdAudit : IBaseAudit
    {
        /// <summary>
        ///     Data de criação
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        ///     Data de atualização
        /// </summary>
        public DateTime? UpdateDate { get; set; }
    }
}