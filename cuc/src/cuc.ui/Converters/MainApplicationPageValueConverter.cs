namespace cuc.ui
{
    using System;
    using System.Windows.Data;
    using System.Globalization;

    using core;

    public class MainApplicationPageValueConverter:IValueConverter
    {
        #region public methods
        /// <summary>
        /// converts a value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //switch current app page based on provided type of the page
            switch ((ApplicationPageType)value)
            {
                case ApplicationPageType.Family:
                    return new FamilyPage();
                case ApplicationPageType.Preferences:
                    return new PreferencesPage();
                default:
                    return new FamilyPage();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
