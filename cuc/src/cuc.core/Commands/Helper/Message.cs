using Autodesk.Revit.UI;

namespace cuc.core
{

    public static class Message
    {
    #region public methods
        /// <summary>
        /// Display the specified message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"><see cref="WindowType"></param>
        public static void Display(string message, WindowType type)
        {
            string title = "";
            var Icon = TaskDialogIcon.TaskDialogIconNone;

            //customize window based on type of message
            switch (type)
            {
                case WindowType.Information:
                    title = "~INFORMATION~";
                    Icon = TaskDialogIcon.TaskDialogIconInformation;
                    break;
                case WindowType.Warning:
                    title = "~WARNING~";
                    Icon= TaskDialogIcon.TaskDialogIconWarning;
                    break;
                case WindowType.Error:
                    title = "~ERROR~";
                    Icon=(TaskDialogIcon)TaskDialogIcon.TaskDialogIconError;
                    break;
                default:
                    break;
            }

            //Build a window to diplay specified message
            var window = new TaskDialog(title)
            {
                MainContent = message,
                MainIcon = Icon,
                CommonButtons = TaskDialogCommonButtons.Ok
            };
            window.Show();
        }
    #endregion
    }

}
