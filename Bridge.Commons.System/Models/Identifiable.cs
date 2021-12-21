using System;
using Bridge.Commons.System.Contracts;

namespace Bridge.Commons.System.Models
{
    /// <summary>
    /// </summary>
    /// <typeparam name="TId"></typeparam>
    public class Identifiable<TId> : IIdentifiable<TId> where TId : IConvertible
    {
        /// <summary>
        ///     Construtor
        /// </summary>
        public Identifiable()
        {
        }

        /// <summary>
        ///     Construtor recebendo identificador
        /// </summary>
        /// <param name="id"></param>
        public Identifiable(TId id)
        {
            Id = id;
        }

        /// <summary>
        ///     Propriedade identificador
        /// </summary>
        public TId Id { get; set; }
    }


    /// <summary>
    ///     Identifiable (int)
    /// </summary>
    public class IdentifiableInt : IIdentifiable<int>
    {
        /// <summary>
        ///     Construtor
        /// </summary>
        public IdentifiableInt()
        {
        }

        /// <summary>
        ///     Construtor recebendo identificador
        /// </summary>
        /// <param name="id"></param>
        public IdentifiableInt(int id)
        {
            Id = id;
        }

        /// <summary>
        ///     Propriedade identificador
        /// </summary>
        public int Id { get; set; }
    }

    /// <summary>
    ///     Identifiable long
    /// </summary>
    public class IdentifiableLong : IIdentifiable<long>
    {
        /// <summary>
        ///     Construtor
        /// </summary>
        public IdentifiableLong()
        {
        }

        /// <summary>
        ///     Construtor recebendo identificador
        /// </summary>
        /// <param name="id"></param>
        public IdentifiableLong(long id)
        {
            Id = id;
        }

        /// <summary>
        ///     Propriedade identificador
        /// </summary>
        public long Id { get; set; }
    }

    /// <summary>
    ///     Identifiable short
    /// </summary>
    public class IdentifiableShort : IIdentifiable<short>
    {
        /// <summary>
        ///     Construtor
        /// </summary>
        public IdentifiableShort()
        {
        }

        /// <summary>
        ///     Construtor recebendo identificador
        /// </summary>
        /// <param name="id"></param>
        public IdentifiableShort(short id)
        {
            Id = id;
        }

        /// <summary>
        ///     Propriedade identificador
        /// </summary>
        public short Id { get; set; }
    }

    /// <summary>
    ///     Identifiable string
    /// </summary>
    public class IdentifiableString : IIdentifiable<string>
    {
        /// <summary>
        ///     Construtor
        /// </summary>
        public IdentifiableString()
        {
        }

        /// <summary>
        ///     Construtor recebendo identificador
        /// </summary>
        /// <param name="id"></param>
        public IdentifiableString(string id)
        {
            Id = id;
        }

        /// <summary>
        ///     Propriedade string
        /// </summary>
        public string Id { get; set; }
    }
}