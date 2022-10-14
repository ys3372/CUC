﻿namespace cuc.ui
{
    using Autodesk.Revit.UI;

    public class RevitPushButtonDataModel
    {
        #region public methods
        /// <summary>
        /// Get与Set
        /// </summary>
        public string Label { get; set; }
        public RibbonPanel Panel { get; set; }
        public string CommandNamespacePath { get; set; }
        public string Tooltip { get; set; }
        public string IconImageName { get; set; }
        public string TooltipImageName { get; set; }
        #endregion

        #region constructor

        public RevitPushButtonDataModel()
        {

        }

        #endregion
    }
}
