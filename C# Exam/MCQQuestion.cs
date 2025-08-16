using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark, Answer rightAnswer) : base(header, body, mark, rightAnswer)
        {
        }

        public override string ToString()
        {
            string answersText = "";
            for (int i = 0; i < Answers.Count; i++)
            {
                answersText += $"{i + 1}. {Answers[i]}\n";
            }
            return $"[MCQ Question]\n" +
              $"Header: {Header}\n" +
              $"Body: {Body}\n" +
              $"Mark: {Mark}\n" +
              $"Choices:\n{answersText}" +
              $"Right Answer: {RightAnswer}";
        }
    }
}
