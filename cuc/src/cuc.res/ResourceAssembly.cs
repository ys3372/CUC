namespace cuc.res
{
    using System.Reflection;

    public static class ResourceAssembly
    {
        #region public methods
        /// <summary>
        /// 获取当前资源目录
        /// </summary>
        /// <returns></returns>
        public static Assembly GetAssembly()
        {
            return Assembly.GetExecutingAssembly();
        }

        /// <summary>
        /// 获取命名空间
        /// </summary>
        /// <returns></returns>
        public static string GetNamespace()
        {
            return typeof(ResourceAssembly).Namespace + ".";
        }
        #endregion
    }
}
