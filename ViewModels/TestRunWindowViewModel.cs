using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GPSTests2._0.Models;

namespace GPSTests2._0.ViewModels
{
    public class TestRunWindowViewModel
    {
        public List<QuestionModel> Questions = new List<QuestionModel>();
        public int QuestionCounter;

        public ICommand BtnNextQuestion { get; set; }

        public TestRunWindowViewModel()
        {
            QuestListUpdate();
        }

        private void QuestListUpdate()
        {
            
        }
    }
}
