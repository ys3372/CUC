namespace cuc.core
{
    using System.IO;
    public static class PathHelpers
    {
        #region public methods

        /// <summary>
        /// a helper class that contains functions for dealing with physical files on disk
        /// </summary>
        /// <param name="fullPath"></param>
        /// <returns></returns>
        public static string GetFileName(string fullPath)
        {
            if(string.IsNullOrEmpty(fullPath))
                return string.Empty;

            var lastIndex = fullPath.LastIndexOf('\\');

            if(lastIndex < 0)
                return fullPath;

            //return file name without extension
            return Path.GetFileNameWithoutExtension(fullPath.Substring(lastIndex + 1));

        }

        #endregion
    }
}
