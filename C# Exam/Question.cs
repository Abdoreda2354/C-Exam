using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer RightAnswer { get; set; }
        public List<Answer> Answers { get; set; }

        public Question(string header, string body, int mark, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            RightAnswer = rightAnswer;
            Answers = new List<Answer>();
        }
        public void Add_answers(Answer answer)
        {
            Answers.Add(answer);
        }


    }
}
