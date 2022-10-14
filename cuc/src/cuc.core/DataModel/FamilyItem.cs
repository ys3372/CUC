namespace cuc.core
{

    /// <summary>
    /// represents a data model for one single family item in list of the items
    /// </summary>
    public class FamilyItem
    {
        #region public properties
        public string FullPath { get; set; }

        /// <summary>
        /// Get the name of the family item based on full path
        /// </summary>
        public string Name => PathHelpers.GetFileName(FullPath);
        public bool IsFamily { get; set; }
        #endregion

        #region constructor
        /// <summary>
        /// Default constructor
        /// Initialize a new instance of the <see cref="FamilyItem"/> class
        /// </summary>
        public FamilyItem()
        {

        }
        #endregion
    }
}
