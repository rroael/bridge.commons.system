namespace Bridge.Commons.System.Models.Validations
{
    /// <summary>
    ///     Instância de erro
    /// </summary>
    public class ErrorInstance
    {
        /// <summary>
        ///     Construtor
        /// </summary>
        public ErrorInstance()
        {
        }

        /// <summary>
        ///     Construtor
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="field"></param>
        public ErrorInstance(int code, string message, string field = null)
        {
            ErrorCode = code;
            Message = message;
            Field = field;
        }

        /// <summary>
        ///     Código do erro
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        ///     Mensagem
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     Campo
        /// </summary>
        public string Field { get; set; }
    }
}