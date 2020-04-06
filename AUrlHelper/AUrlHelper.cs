using System;
using System.IO;
using System.Linq;

namespace AUrlHelper
{
    public static class AUrlHelper
    {
        private const char Delimeter = '/';

        /// <summary>
        /// Get file name from a path
        /// </summary>
        /// <param name="path"></param>
        /// <returns>File name</returns>
        /// <exception cref="ArgumentException">Throw if path doesn't contain a file</exception>
        /// <exception cref="UriFormatException">Throw if path is not a url</exception>
        public static string GetFileName(string path)
        {
            var uri = new Uri(path);
            if (!Path.HasExtension(uri.LocalPath))
            {
                throw new ArgumentException($"{nameof(path)} doesn't contain a file");
            }
            var fileName = path.Split(Delimeter).LastOrDefault();
            return fileName;
        }

        /// <summary>
        /// Get file name without extension from a path
        /// </summary>
        /// <param name="path"></param>
        /// <returns>File name</returns>
        /// <exception cref="ArgumentException">Throw if path doesn't contain a file</exception>
        /// <exception cref="UriFormatException">Throw if path is not a url</exception>
        public static string GetFileNameWithoutExtension(string path)
        {
            var fileName = GetFileName(path);

            return Path.GetFileNameWithoutExtension(fileName);
        }

        /// <summary>
        /// Get folder name from a path
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Folder name</returns>
        /// <exception cref="UriFormatException">Throw if path is not a url</exception>
        public static string GetFolderName(string path)
        {
            var uri = new Uri(path);
            if (Path.HasExtension(uri.LocalPath))
            {
                var fileName = GetFileName(path);
                path = path.Replace($"{Delimeter}{fileName}", string.Empty);
            }

            var folderName = path.Trim(Delimeter).Split(Delimeter).LastOrDefault();

            return folderName;
        }
    }
}
