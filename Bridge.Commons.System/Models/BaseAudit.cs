using System;
using Bridge.Commons.System.Contracts;

namespace Bridge.Commons.System.Models
{
    /// <summary>
    ///     Base Audit
    /// </summary>
    /// <typeparam name="TId"></typeparam>
    public class BaseAudit<TId> : BaseNoIdAudit, IIdentifiable<TId>
        where TId : IConvertible
    {
        #region Properties

        /// <summary>
        ///     Identificador
        /// </summary>
        public TId Id { get; set; }

        #endregion
    }

    /// <summary>
    ///     Base Audit (int)
    /// </summary>
    public class BaseAuditInt : BaseAudit<int>
    {
    }

    /// <summary>
    ///     Base Audit (long)
    /// </summary>
    public class BaseAuditLong : BaseAudit<long>
    {
    }

    /// <summary>
    ///     Base Audit (short)
    /// </summary>
    public class BaseAuditShort : BaseAudit<short>
    {
    }

    /// <summary>
    ///     Base Audit (string)
    /// </summary>
    public class BaseAuditString : BaseAudit<string>
    {
    }
}