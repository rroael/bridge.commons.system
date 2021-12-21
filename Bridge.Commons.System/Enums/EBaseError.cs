namespace Bridge.Commons.System.Enums
{
    /// <summary>
    ///     Enumeradores de erro
    /// </summary>
    public enum EBaseError
    {
        //Entity
        /// <summary>
        ///     Entidade não encontrada
        /// </summary>
        ENTITY_NOT_FOUND = 1,

        //Field +25
        /// <summary>
        ///     Campo deve ser preenchido
        /// </summary>
        FIELD_MUST_BE_FILLED = 26,

        /// <summary>
        ///     Tamanho máximo do campo
        /// </summary>
        FIELD_MAXIMUM_LENGTH = 27,

        /// <summary>
        ///     Campo tipo incorreto
        /// </summary>
        FIELD_WRONG_TYPE = 28,

        /// <summary>
        ///     Comprimento incorreto do campo
        /// </summary>
        FIELD_WRONG_LENGTH = 29,

        /// <summary>
        ///     Campo fora de alcance
        /// </summary>
        FIELD_OUT_OF_RANGE = 30,

        //Generic +50
        /// <summary>
        ///     Parâmetro requerido incorreto
        /// </summary>
        INVALID_REQUEST_PARAMETER = 76,

        /// <summary>
        ///     Parâmetros requeridos incorretos
        /// </summary>
        INVALID_REQUEST_PARAMETERS = 77,

        //Connection +50
        /// <summary>
        /// </summary>
        INVALID_OPERATION_ON_READONLY_CONNECTION = 126,

        /// <summary>
        ///     Não autorizado
        /// </summary>
        UNAUTHORIZED = 401,

        /// <summary>
        ///     Acesso proibido (geralmente por falta de permissão)
        /// </summary>
        FORBIDDEN = 403
    }
}