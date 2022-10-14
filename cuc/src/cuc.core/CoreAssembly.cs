using System.Reflection;

namespace cuc.core
{
    public static class CoreAssembly
    {
        #region public methods
        /// <summary>
        /// Get the core assembly location
        /// </summary>
        /// <returns></returns>
        public static string GetAssemblyLocation()
        {
            return Assembly.GetExecutingAssembly().Location;
        }
        #endregion
    }
}
