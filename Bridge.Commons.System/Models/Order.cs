using Bridge.Commons.System.Enums;

namespace Bridge.Commons.System.Models
{
    /// <summary>
    ///     Ordem
    /// </summary>
    public class Order
    {
        /// <summary>
        ///     Campo de ordenação
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        ///     Tipo de ordenação (Ascending (asc) = 0, Descending (desc) = 1)
        /// </summary>
        public ESortType SortType { get; set; }
    }
}