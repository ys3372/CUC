namespace cuc.ui
{
    using System;
    using System.Windows.Controls;
    using Autodesk.Revit.UI;
    using core;
    using res;

    public static class RevitPushButton
    {
        #region public methods
        public static PushButton Create(RevitPushButtonDataModel data)
        {
            //button name based on unique identifier
            var btnDataName = Guid.NewGuid().ToString();

            //set button data
            var btnData = new PushButtonData(btnDataName, data.Label, CoreAssembly.GetAssemblyLocation(), data.CommandNamespacePath)
            {
                LargeImage = ResourceImage.GetIcon(data.IconImageName),
                ToolTipImage = ResourceImage.GetIcon(data.TooltipImageName)
            };

            //return created button 
            return data.Panel.AddItem(btnData) as PushButton;

        }
        #endregion
    }
}
