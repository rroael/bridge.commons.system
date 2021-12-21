using System.Collections.Generic;
using System.Linq;
using Bridge.Commons.System.Contracts.Mappers;

namespace Bridge.Commons.System.Models.Results
{
    /// <summary>
    ///     Listas paginadas
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PaginatedList<T> where T : class
    {
        #region Convertion

        /// <summary>
        ///     Converção de lista paginada
        /// </summary>
        /// <typeparam name="TU"></typeparam>
        /// <returns></returns>
        public PaginatedList<TU> ConvertTo<TU>() where TU : class, IFromObjectMapper<T, TU>, new()
        {
            return new PaginatedList<TU>(Data.Select(x => new TU().MapFrom(x)).ToList(), CurrentPage, PageSize,
                PageCount, TotalCount);
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Dados
        /// </summary>
        public IEnumerable<T> Data { get; set; }

        /// <summary>
        ///     Página atual
        /// </summary>
        /// <example>1</example>
        public int CurrentPage { get; set; }

        /// <summary>
        ///     Contagem de página
        /// </summary>
        /// <example>1</example>
        public int PageCount { get; set; }

        /// <summary>
        ///     Contagem total
        /// </summary>
        /// <example>3</example>
        public int TotalCount { get; set; }

        /// <summary>
        ///     Tamanho da página
        /// </summary>
        /// <example>10</example>
        public int PageSize { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        ///     Criação do objeto paginado baseado em uma lista com tipo
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="currentPage">Página atual solicitada</param>
        /// <param name="pageSize">Tamanho de registros que o consumidor deseja (ex: 10 registros por página)</param>
        /// <param name="pageCount">Total de páginas resultantes da paginação dos dados (total de páginas para percorrer)</param>
        /// <param name="totalCount">Total de registros existentes na fonte de dados (sem considerar paginação)</param>
        public PaginatedList(IEnumerable<T> collection, int currentPage = 1, int? pageSize = null,
            int? pageCount = null, int? totalCount = null)
        {
            var enumerable = collection as T[] ?? collection.ToArray();
            var total = enumerable.Count();

            CurrentPage = currentPage;
            PageSize = pageSize ?? total;
            PageCount = pageCount ?? 1;
            TotalCount = totalCount ?? total;
            Data = enumerable;
        }

        /// <summary>
        ///     Criação de uma lista paginada baseada em outra lista paginada
        /// </summary>
        /// <param name="collection"></param>
        public PaginatedList(PaginatedList<T> collection)
        {
            CurrentPage = collection.CurrentPage;
            PageSize = collection.PageSize;
            PageCount = collection.PageCount;
            TotalCount = collection.TotalCount;
            Data = collection.Data;
        }

        /// <summary>
        ///     Criação de lista vazia
        /// </summary>
        public PaginatedList()
        {
        }

        #endregion
    }
}