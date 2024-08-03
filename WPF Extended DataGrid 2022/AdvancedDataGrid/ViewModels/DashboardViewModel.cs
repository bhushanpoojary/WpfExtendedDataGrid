using GalaSoft.MvvmLight.Command;
using System;
using System.Diagnostics;

//using AttachedCommands.ACB;

namespace MultiEventCommand.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    {
        #region Members

        private RelayCommand _gitHubCommand;

        #endregion

        #region Commands

        public RelayCommand GitHubCommandCommand
        {
            get { return _gitHubCommand ?? (_gitHubCommand = new RelayCommand(GitHubCommandHandler)); }
            set { _gitHubCommand = value; }
        }

        #endregion

        #region Handlers

        private void GitHubCommandHandler()
        {
            Process.Start("https://github.com/bhushanpoojary/WpfExtendedDataGrid");
        }

        #endregion
    }
}
