using System;
using Bridge.Commons.System.Contracts;
using Bridge.Commons.System.Enums;

namespace Bridge.Commons.System.Models
{
    /// <summary>
    ///     Paginação
    /// </summary>
    public class Pagination : IPagination
    {
        /// <summary>
        ///     Página atual
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        ///     Campo usado para ordenação
        /// </summary>
        public string SortField { get; set; }

        /// <summary>
        ///     Tipo de ordenação (Ascending (asc) = 0, Descending (desc) = 1)
        /// </summary>
        public ESortType Order { get; set; }

        /// <summary>
        ///     Quantidade de elementos por página (10 itens por padrão)
        /// </summary>
        public int PageSize { get; set; } = 10;

        /// <summary>
        ///     Quantidade de itens que devem ser pulados
        /// </summary>
        public int Skip => (Page - 1) * PageSize;

        /// <summary>
        ///     Buscar contagem da página
        /// </summary>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public int GetPageCount(int totalCount)
        {
            return (int)Math.Ceiling((double)totalCount / PageSize);
        }
    }
}