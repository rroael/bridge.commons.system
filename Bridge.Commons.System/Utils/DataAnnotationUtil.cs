using System.ComponentModel;

namespace Bridge.Commons.System.Utils
{
    /// <summary>
    ///     Data annotation
    /// </summary>
    public class DataAnnotationUtil
    {
        /// <summary>
        ///     Busca a categoria do objeto
        /// </summary>
        /// <param name="value"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string GetObjectCategory<T>(T value)
        {
            return ((CategoryAttribute)value.GetType().GetMember(value.ToString())[0]
                .GetCustomAttributes(typeof(CategoryAttribute), false)[0]).Category;
        }

        /// <summary>
        ///     Busca a descrição do objeto
        /// </summary>
        /// <param name="value"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string GetObjectDescription<T>(T value)
        {
            return ((DescriptionAttribute)value.GetType().GetMember(value.ToString())[0]
                .GetCustomAttributes(typeof(DescriptionAttribute), false)[0]).Description;
        }
    }
}