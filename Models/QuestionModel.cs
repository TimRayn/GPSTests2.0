using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSTests2._0.Models
{
    public class QuestionModel
    {
        public string Question { get; set; }
        public string[] VarsAnswers { get; set; }
        public int CorrectIndex { get; set; }

        public QuestionModel(string question, string[] varsAnswers, int correctIndex)
        {
            Question = question;
            VarsAnswers = varsAnswers;
            CorrectIndex = correctIndex;
        }
    }
}
