using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using GPSTests2._0.Windows;

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
            BtnTestRunCommand = new CommandHandler(OpenTestRunWindow, true);
            BtnExitCommand = new CommandHandler(Exit, true);
            BtnCreditsCommand = new CommandHandler(OpenCreditsWindow, true);
            BtnTheoryCommand = new CommandHandler(OpenTheoryWindow, true);
        }

        private void OpenTheoryWindow()
        {
            var theoryWindow = new Theory();
            theoryWindow.Show();
        }

        private void OpenCreditsWindow()
        {
            var creditsWindow = new Credits();
            creditsWindow.Show();
        }

        private void OpenTestRunWindow()
        {
            var testWindow = new TestRunWindow();
            testWindow.Show();
        }

        private void Exit()
        {
            Application.Current.Shutdown();
        }
    }
}
