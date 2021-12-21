using System;
using Bridge.Commons.System.Contracts;
using Bridge.Commons.System.Contracts.Filters;
using Bridge.Commons.System.Contracts.Mappers;
using Bridge.Commons.System.Enums;

namespace Bridge.Commons.System.Models.Requests
{
    /// <summary>
    ///     Requisição de filtro da paginação
    /// </summary>
    /// <typeparam name="TFilter"></typeparam>
    public class FilterPaginationRequest<TFilter> : IPagination, IToObjectMapper<FilterPagination<TFilter>>
        where TFilter : IFilter
    {
        #region Properties

        /// <summary>
        ///     Número da página
        /// </summary>
        /// <example>1</example>
        public int Page { get; set; }

        /// <summary>
        ///     Campo de ordenação
        /// </summary>
        /// <example>Ordenação</example>
        public string SortField { get; set; }

        /// <summary>
        ///     Direção da ordenação (Ascendente = 0, Descendente = 1)
        /// </summary>
        /// <example>0</example>
        public ESortType Order { get; set; }

        /// <summary>
        ///     Número de itens por página (Padrão de 10 itens por página)
        /// </summary>
        /// <example>10</example>
        public int PageSize { get; set; } = 10;

        /// <summary>
        ///     Cálcula o número de itens que serão pulados
        /// </summary>
        /// <example>0</example>
        public int Skip => (Page - 1) * PageSize;

        /// <summary>
        ///     Objeto de filtro da paginação
        /// </summary>
        public TFilter Filters { get; set; }

        #endregion


        #region Implements

        /// <summary>
        ///     Buscar contagem da página
        /// </summary>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public int GetPageCount(int totalCount)
        {
            return (int)Math.Ceiling((double)totalCount / PageSize);
        }

        /// <summary>
        ///     Mapeia filtros
        /// </summary>
        /// <returns></returns>
        public FilterPagination<TFilter> MapTo()
        {
            return new FilterPagination<TFilter>
            {
                Page = Page,
                SortField = SortField,
                Order = Order,
                PageSize = PageSize,
                Filters = Filters
            };
        }

        #endregion
    }
}