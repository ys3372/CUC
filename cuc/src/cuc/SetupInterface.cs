

namespace cuc
{
    using Autodesk.Revit.UI;
    using ui;
    using res;
    using core;

    public class SetupInterface
    {
        #region constructor
        public SetupInterface()
        {

        }
        #endregion

        #region public methods
        public void Initialize(UIControlledApplication app)
        {
            //创建工具栏
            string tabName = "数字化事业部";
            app.CreateRibbonTab(tabName);

            //创建工具面板
            var annotateCommandsPanel = app.CreateRibbonPanel(tabName, "Annotation Commands");
            var managerCommandsPanel = app.CreateRibbonPanel(tabName, "FamilyManager Commands");

            #region annotate
            var TagWallButtonData = new RevitPushButtonDataModel
            {
                Label = "Tag Wall\nLayers",
                Panel = annotateCommandsPanel,
                Tooltip = "对墙体结构进行标注分析",
                CommandNamespacePath = TagWallLayersCommand.GetPath(),
                IconImageName = "14_32x.png",
                TooltipImageName = "14_320x.png"
            };
            RevitPushButton.Create(TagWallButtonData);
            #endregion

            #region manager

            var FamilyManagerButtonData_Show = new RevitPushButtonDataModel
            {
                Label = "开启族管理器",
                Panel = annotateCommandsPanel,
                Tooltip = "点击打开族管理器",
                CommandNamespacePath = ShowFamilyManagerCommand.GetPath(),
                IconImageName = "15.ico",
                TooltipImageName = "8.jpg"
            };
            RevitPushButton.Create(FamilyManagerButtonData_Show);

            var FamilyManagerButtonData_Hide = new RevitPushButtonDataModel
            {
                Label = "关闭族管理器",
                Panel = annotateCommandsPanel,
                Tooltip = "点击关闭族管理器",
                CommandNamespacePath = HideFamilyManagerCommand.GetPath(),
                IconImageName = "4.ico",
                TooltipImageName = "4.jpg"
            };
            RevitPushButton.Create(FamilyManagerButtonData_Hide);

            #endregion

        }
        #endregion
    }
}
