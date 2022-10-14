namespace cuc.ui
{
    using System;
    using System.Windows;
    using System.Windows.Controls;

    using Autodesk.Revit.UI;

    using core;
    /// <summary>
    /// Interaction logic for FamilyManagerMainPage.xaml
    /// </summary>
    public partial class FamilyManagerMainPage : Page, IDisposable, IDockablePaneProvider
    {
        #region constructor

        public FamilyManagerMainPage()
        {
            InitializeComponent();

            //Set data context for main application page
            DataContext = new FamilyManagerMainViewModel();
        }
        #endregion

        #region public methods
        public void Dispose()
        {
            this.Dispose();
        }

        public void SetupDockablePane(DockablePaneProviderData data)
        {
            data.FrameworkElement = this as FrameworkElement;
            data.InitialState = new DockablePaneState
            {
                DockPosition = DockPosition.Right,
            };
        }

        #endregion
    }
}