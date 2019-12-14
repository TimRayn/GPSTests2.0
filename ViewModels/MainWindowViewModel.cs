using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace GPSTests2._0.ViewModels
{
    public class MainWindowViewModel
    {

        public ICommand BtnTestRunCommand { get; }
        public ICommand BtnTheoryCommand { get; }
        public ICommand BtnCreditsCommand { get; }
        public ICommand BtnExitCommand { get; }

        public MainWindowViewModel()
        {
            BtnTheoryCommand = new CommandHandler(OpenTestRunWindow, true);
            BtnExitCommand = new CommandHandler(Exit, true);
        }

        private void OpenTestRunWindow()
        {

        }

        private void Exit()
        {
            Application.Current.Shutdown();
        }
    }
}
