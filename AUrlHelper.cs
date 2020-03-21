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
        public static string GetFileName(string path)
        {
            if (!Path.HasExtension(path))
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
        public static string GetFolderName(string path)
        {
            if (Path.HasExtension(path))
            {
                var fileName = GetFileName(path);
                path = path.Replace($"{Delimeter}{fileName}", string.Empty);
            }

            var folderName = path.Trim(Delimeter).Split(Delimeter).LastOrDefault();

            return folderName;
        }
    }
}
