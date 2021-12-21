namespace Bridge.Commons.System.Contracts.Filters
{
    /// <summary>
    ///     Filtro de paginação
    /// </summary>
    public interface IFilterPagination : IPagination
    {
        /// <summary>
        ///     Filtros
        /// </summary>
        IFilter Filters { get; set; }
    }

    /// <summary>
    ///     Filtro de paginação com parâmentro TFilter
    /// </summary>
    /// <typeparam name="TFilter"></typeparam>
    public interface IFilterPagination<TFilter> : IFilterPagination
        where TFilter : IFilter
    {
        /// <summary>
        ///     Objeto TFilter de Filters
        /// </summary>
        new TFilter Filters { get; set; }
    }
}