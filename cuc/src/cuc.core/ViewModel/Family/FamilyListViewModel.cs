namespace cuc.core
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>
    /// a view model for the list of family items
    /// </summary>
    /// <seealso cref="cuc.core.BaseViewModel"/>

    public class FamilyListViewModel : BaseViewModel
    {
        #region private members

        /// <summary>
        /// The path list to directories with items
        /// to do implements in preferences system for choosing directori locations
        /// below are some folders with Revit Family and project items
        /// </summary>
        private List<string> mPaths = new List<string>
        {
            @"C:\ProgramData\Autodesk\RVT 2021\Libraries\Chinese\结构预制\安装件"
        };
        #endregion

        #region public properties
        public ObservableCollection<FamilyItem> Items { get; set; }
        #endregion

        #region constructor

        /// <summary>
        /// default constructor
        /// Initials a new instance of the <see cref="FamilyListViewModel"/> class
        /// </summary>
        public FamilyListViewModel()
        {
            //Populate item list for list control
            Items = Populate(mPaths);
        }

        #endregion

        #region private methods

        private ObservableCollection<FamilyItem> Populate (List<string> paths)
        {
            var items = new ObservableCollection<FamilyItem> ();
            foreach (var path in paths)
            {
                //get family item from repository
                var children = FamilyList.GetItems(path);
                
                //add them to collection
                foreach (var child in children)
                    items.Add (child);
            }
            return items;

        }

        #endregion

    }
}
