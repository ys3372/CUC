namespace cuc.core
{
    using System.Linq;
    using System.IO;
    using System.Collections.Generic;


    /// <summary>
    /// get the items from the repository
    /// </summary>
    public static class FamilyList
    {
        #region public methods

        /// <summary>
        /// get the items from the repository
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<FamilyItem> GetItems(string path)
        {
            var items = new List<FamilyItem>();

            try
            {
                var fs = Directory.GetFiles(path);

                //check if the directory has file items
                //cast file items to more specific familyitems
                if (fs.Length > 0)
                    items.AddRange(fs.Select(file => new FamilyItem { FullPath = file }));
            }
            catch
            { }

            return items;
        }
        #endregion
    }
}