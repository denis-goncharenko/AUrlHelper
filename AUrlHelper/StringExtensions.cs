namespace AUrlHelper
{
    public static class StringExtensions
    {
        /// <summary>
        /// Get file name from a path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">Throw if path doesn't contain a file</exception>
        public static string GetFileName(this string path)
        {
            return AUrlHelper.GetFileName(path);
        }

        /// <summary>
        /// Get file name without extension from a path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">Throw if path doesn't contain a file</exception>
        public static string GetFileNameWithoutExtension(this string path)
        {
            return AUrlHelper.GetFileNameWithoutExtension(path);
        }

        /// <summary>
        /// Get Folder name from a path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetFolderName(this string path)
        {
            return AUrlHelper.GetFolderName(path);
        }
    }
}
