using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bridge.Commons.System.Utils
{
    /// <summary>
    ///     Utilidades no tratamento de imagens
    /// </summary>
    public class ImageUtil
    {
        private static readonly Regex DataMimeTypePattern =
            new Regex(@"data\:(?<type>image\/(png|tiff|tif|jpg|jpeg|gif))",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private static readonly Regex DataFilePattern =
            new Regex(@"^data\:image\/(png|tiff|tif|jpg|jpeg|gif);base64,(?<data>.*)$",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private static readonly Regex DataExtensionPattern = new Regex(@"[^\.]+(?<type>\.(png|tiff|tif|jpg|jpeg|gif))",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);


        /// <summary>
        ///     Busca o tipo do MIME
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string GetMimeType(string data)
        {
            var match = DataMimeTypePattern.Match(data);

            return !match.Success ? null : match.Groups["type"].Value;
        }

        /// <summary>
        ///     Busca dados do arquivo por Base64
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string GetBase64DataFile(string data)
        {
            var match = DataFilePattern.Match(data);

            return !match.Success ? data : match.Groups["data"].Value;
        }

        /// <summary>
        ///     Busca a extensão do arquivo
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static string GetFileExtension(string filename)
        {
            var match = DataExtensionPattern.Match(filename);

            return !match.Success ? null : match.Groups["type"].Value;
        }

        /// <summary>
        ///     Busca o tipo de MIME por extensão
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static string GetMimeTypeByExtension(string extension)
        {
            var ext = extension.Replace(".", "");

            switch (ext)
            {
                case "jpg":
                case "jpeg":
                    return "image/jpeg";
                case "png":
                    return "image/png";
                case "gif":
                    return "image/gif";
                case "tif":
                case "tiff":
                    return "image/tiff";
                case "webp":
                    return "image/webp";
                default:
                    return null;
            }
        }

        /// <summary>
        ///     Busca a extensão pelo tipo de MIME
        /// </summary>
        /// <param name="mimeType"></param>
        /// <returns></returns>
        public static string GetExtensionByMimeType(string mimeType)
        {
            switch (mimeType)
            {
                case "image/jpg":
                case "image/jpeg":
                    return ".jpg";
                case "image/png":
                    return ".png";
                case "image/gif":
                    return ".gif";
                case "image/tiff":
                case "image/tif":
                    return ".tif";
                case "image/webp":
                    return ".webp";
                default:
                    return null;
            }
        }

        /// <summary>
        ///     Busca a extensão da Base64
        /// </summary>
        /// <param name="imageBase64"></param>
        /// <returns></returns>
        public static string GetExtensionFromBase64DataImage(string imageBase64)
        {
            var mimeType = GetMimeType(imageBase64);
            return GetExtensionByMimeType(mimeType);
        }

        /// <summary>
        ///     Busca MemoryStream da Base64
        /// </summary>
        /// <param name="base64Image"></param>
        /// <returns></returns>
        public static MemoryStream GetMemoryStreamFromBase64String(string base64Image)
        {
            return new MemoryStream(Convert.FromBase64String(GetBase64DataFile(base64Image)));
        }

        /// <summary>
        ///     Retorna imagem buscando de MemoryStream convertendo para Base64
        /// </summary>
        /// <param name="ms"></param>
        /// <returns></returns>
        public static string MemoryStreamImageToBase64String(MemoryStream ms)
        {
            var imageBytes = ms.ToArray();
            return Convert.ToBase64String(imageBytes);
        }

        /// <summary>
        ///     Gera nome do arquivo de Base64
        /// </summary>
        /// <param name="imageBase64"></param>
        /// <returns></returns>
        public static string GenerateFileNameFromBase64DataImage(string imageBase64)
        {
            var extension = GetExtensionFromBase64DataImage(imageBase64);

            return string.IsNullOrWhiteSpace(extension) == false
                ? $"{Guid.NewGuid().ToString()}{extension}"
                : $"{Guid.NewGuid().ToString()}.jpg";
        }

        /// <summary>
        ///     Busca nome do arquivo da Url da imagem
        /// </summary>
        /// <param name="urlImage"></param>
        /// <returns></returns>
        public static string GetFileNameFromUrlOfImage(string urlImage)
        {
            return string.IsNullOrWhiteSpace(urlImage) ? null : urlImage.Split('/').Last();
        }

        /// <summary>
        ///     Baixa da imagem
        /// </summary>
        /// <param name="url"></param>
        /// <param name="configureAwait"></param>
        /// <returns></returns>
        public static async Task<byte[]> DownloadImage(string url, bool configureAwait = false)
        {
            using (var client = new WebClient())
            {
                return await client.DownloadDataTaskAsync(url)
                    .ConfigureAwait(configureAwait);
            }
        }

        /// <summary>
        ///     Baixa a imagem como Base64
        /// </summary>
        /// <param name="url"></param>
        /// <param name="configureAwait"></param>
        /// <returns></returns>
        public static async Task<string> DownloadImageAsBase64(string url, bool configureAwait = false)
        {
            var bytes = await DownloadImage(url).ConfigureAwait(configureAwait);
            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        ///     Busca a MemoryStream de uma Url
        /// </summary>
        /// <param name="url"></param>
        /// <param name="configureAwait"></param>
        /// <returns></returns>
        public static async Task<MemoryStream> GetMemoryStreamFromUrl(string url, bool configureAwait = false)
        {
            using (var client = new WebClient())
            {
                var stream = await client.OpenReadTaskAsync(new Uri(url)).ConfigureAwait(configureAwait);
                var memoryStream = new MemoryStream();
                await stream.CopyToAsync(memoryStream).ConfigureAwait(configureAwait);
                return memoryStream;
            }
        }
    }
}