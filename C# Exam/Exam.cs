using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    abstract class Exam
    {
        public DateTime TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        protected Exam(DateTime timeOfExam, int numberOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
        }
        public abstract void ShowExam();
    }
}
