using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
     class Subject
    {

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam exam { get; set; }
        public Subject(int subjectId, string subjectName, Exam exam)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
            this.exam = exam;
        }
    }
}
