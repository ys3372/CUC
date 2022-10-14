namespace cuc
{
    using Autodesk.Revit.ApplicationServices;
    using Autodesk.Revit.UI;
    using cuc.ui;

    public class Main : IExternalApplication
    {
        #region external application public methods
        /// <summary>
        /// Revit启动时触发
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Result OnStartup(UIControlledApplication application)
        {
            #region 不用了的
            //string tabName = "数字化事业部";

            //string panelAnnotationName = "AnnotationCommands";

            //application.CreateRibbonTab(tabName);

            //var panelAnnotation = application.CreateRibbonPanel(tabName, panelAnnotationName);

            //var TagWallLayersBtnData = new PushButtonData("TagWallLayersBtnData", "Tag Wall\nLayers", Assembly.GetExecutingAssembly().Location, "cuc.TagWallLayersCommand")
            //{
            //    ToolTipImage = new BitmapImage(new System.Uri(@"D:\VisualStudio\BIMDevelopment\Ribbon\icon\14.ico")),
            //    ToolTip = "...",

            //};
            //var TagWallLayersBtn = panelAnnotation.AddItem(TagWallLayersBtnData) as PushButton;
            //TagWallLayersBtn.LargeImage = new BitmapImage(new System.Uri(@"D:\VisualStudio\BIMDevelopment\Ribbon\icon\14.ico"));
            #endregion

            //具体启动文件详见SetupInterface处
            var ui = new SetupInterface();
            ui.Initialize(application);

            application.ControlledApplication.ApplicationInitialized += DockablePaneRegisters;

            return Result.Succeeded;
        }

        #region private methods
        /// <summary>
        /// Register dockable panes in zero state document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DockablePaneRegisters(object sender, Autodesk.Revit.DB.Events.ApplicationInitializedEventArgs e) 
        {
            //register dockable pane
            var familyManagerRegisterCommand = new RegisterFamilyManagerCommand();
            familyManagerRegisterCommand.Execute(new UIApplication(sender as Application));
        }
        #endregion

        /// <summary>
        /// Revit关闭时触发
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
        #endregion

    }
}
