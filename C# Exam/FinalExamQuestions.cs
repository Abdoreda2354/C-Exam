using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
     class FinalExamQuestions : Exam
    {
        public static int count { get; set; }
        public List<MCQQuestion> MCQ { get; set; }
        public List<TrueFalseQuestion> TrueFalse { get; set; }
        public FinalExamQuestions(DateTime timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {
            MCQ = new List<MCQQuestion>();
            TrueFalse = new List<TrueFalseQuestion>();
        }


        public void AddMcqQuestion(MCQQuestion question)
        {
            if (count < NumberOfQuestions)
            {
            MCQ.Add(question);
                count++;
            }

        }
        public void AddTrueFalseQuestion(TrueFalseQuestion question)
        {
            if (count < NumberOfQuestions)
            {
                TrueFalse.Add(question);
                count++;
            }

        }
        public override void ShowExam()
        {
            for (int i = 0; i < MCQ.Count; i++)
            {
                Console.WriteLine(MCQ[i]);
            }
            for (int i = 0; i < TrueFalse.Count; i++)
            {
                Console.WriteLine(TrueFalse[i]);
            }
        }
    }
}
