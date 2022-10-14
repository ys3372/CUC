namespace cuc.ui
{
    using System.Windows.Controls;
    using core;

    /// <summary>
    /// Interaction logic for FamilyListControl.xaml
    /// </summary>
    /// <seealso cref="UserControl">
    public partial class FamilyListControl : UserControl
    {
        #region constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public FamilyListControl()
        {
            InitializeComponent();

            //list model binded into data context
            DataContext = new FamilyListViewModel();
        }
        #endregion
    }
}
