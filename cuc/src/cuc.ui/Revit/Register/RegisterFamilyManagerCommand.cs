using System;
using System.Windows;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;
using cuc.core;

namespace cuc.ui
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class RegisterFamilyManagerCommand : IExternalCommand
    {
        #region public methods
        public Result Execute(ExternalCommandData cD, ref string ms, ElementSet set)
        {
            return Execute(cD.Application);
        }

        public Result Execute(UIApplication uiApp)
        {
            var data = new DockablePaneProviderData();
            var managerPage = new FamilyManagerMainPage();

            data.FrameworkElement = managerPage as FrameworkElement;

            //Set up initial state
            var state = new DockablePaneState
            {
                DockPosition = DockPosition.Right,
            };

            //Use unique GUID for this dockable pane
            var dpid = new DockablePaneId(PaneIdentifiers.GetManagePaneIdentifier());

            //Register pane
            uiApp.RegisterDockablePane(dpid, "Family Manager", managerPage as IDockablePaneProvider);
            return Result.Succeeded;
        }

        #endregion
    }
}
