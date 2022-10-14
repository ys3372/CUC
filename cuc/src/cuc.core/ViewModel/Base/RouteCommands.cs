namespace cuc.core
{
    using System;
    using System.Windows.Input;

    public class RouteCommands:ICommand
    {
        #region private members

        /// <summary>
        /// the action to execute
        /// </summary>
        private Action mAction = null;
        #endregion

        #region events
        /// <summary>
        /// occurs when changes occur that affect whether or not the command should execute
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };
        #endregion

        #region constructor
        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="action"></param>
        public RouteCommands(Action action)
        {
            mAction = action;
        }
        #endregion

        #region public methods

        /// <summary>
        /// defines the method that determines whether the command can execute in its current state
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// defines the method to be called when the command is invoked
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            mAction();
        }
        #endregion
    }
}
