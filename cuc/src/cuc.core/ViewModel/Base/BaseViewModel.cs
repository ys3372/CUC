namespace cuc.core
{
    using System.ComponentModel;
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region events
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
        #endregion

        #region public methods
        /// <summary>
        /// Call this method to raise case <see cref="PropertyChanged"> event
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
