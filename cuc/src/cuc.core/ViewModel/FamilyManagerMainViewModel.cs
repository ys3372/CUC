namespace cuc.core
{
    using System.Windows.Input;
    using Autodesk.Revit.UI;
    /// <summary>
    /// a view model for the main app page
    /// </summary>
    /// <seealso cref="cuc.core.BaseViewModel"/>
    public class FamilyManagerMainViewModel:BaseViewModel
    {
        #region public properties

        public ApplicationPageType CurrentPage { get; set; } = ApplicationPageType.Family;


        #endregion

        #region commands
        /// <summary>
        /// get the family page as current
        /// </summary>
        public ICommand FamilyBtnCommand { get; set; }

        /// <summary>
        /// get or set the preference page as current
        /// </summary>
        public ICommand PreferencesBtnCommand { get; set; }
        #endregion

        #region constructor
        /// <summary>
        /// Default constructor
        /// Initials a new instance of the <see cref="FamilyManagerMainViewModel"/> class
        /// </summary>
        public FamilyManagerMainViewModel()
        {
            FamilyBtnCommand = new RouteCommands(() => CurrentPage = ApplicationPageType.Family);
            PreferencesBtnCommand = new RouteCommands(() => CurrentPage = ApplicationPageType.Preferences);
        }

        #endregion

        #region private methods

        private void FamilyBtnExec()
        {
            //test to see the the button command works
            Message.Display("works great", WindowType.Information);
        }

        private void PreferencesBtnExec()
        {
            Message.Display("works well", WindowType.Information);
        }

        #endregion

    }
}
