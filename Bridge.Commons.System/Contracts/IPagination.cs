using Bridge.Commons.System.Enums;

namespace Bridge.Commons.System.Contracts
{
    /// <summary>
    ///     Paginação
    /// </summary>
    public interface IPagination
    {
        /// <summary>
        ///     Página
        /// </summary>
        int Page { get; set; }

        /// <summary>
        ///     Sort field (se será ascendente ou descendente)
        /// </summary>
        string SortField { get; set; }

        /// <summary>
        ///     Ordem
        /// </summary>
        ESortType Order { get; set; }

        /// <summary>
        ///     Tamanho da página
        /// </summary>
        int PageSize { get; set; }

        /// <summary>
        ///     Pular
        /// </summary>
        int Skip { get; }

        /// <summary>
        ///     Buscar contagem da página
        /// </summary>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        int GetPageCount(int totalCount);
    }
}