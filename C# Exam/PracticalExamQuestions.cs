using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
     class PracticalExamQuestions :Exam
    {
        public List<MCQQuestion> MCQ { get; set; }
        public PracticalExamQuestions(DateTime timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {
           MCQ = new List<MCQQuestion>(numberOfQuestions);

        }

        public void AddMcqQuestion(MCQQuestion question)
        {
            if (MCQ.Count == NumberOfQuestions)
                MCQ.Add(question);

        }
        public override void ShowExam()
        {
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine(MCQ[i]);
            }
        }
    }
}
