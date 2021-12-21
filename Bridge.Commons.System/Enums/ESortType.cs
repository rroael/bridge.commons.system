using System.ComponentModel;

namespace Bridge.Commons.System.Enums
{
    /// <summary>
    ///     Enumeradores Sort type
    /// </summary>
    public enum ESortType
    {
        /// <summary>
        ///     Ascendente
        /// </summary>
        [Description("asc")] ASCENDING = 0,

        /// <summary>
        ///     Descendente
        /// </summary>
        [Description("desc")] DESCENDING = 1
    }
}