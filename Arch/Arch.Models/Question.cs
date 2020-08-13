using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizProject.Models
{
    public class Question
    {
        public Guid Id { get; set; }
        public string Query { get; set; }
        public Uri? ContextImage { get; set; }
        public List<Answer> Answers { get; set; }
        public Answer CorrectAnswer { get; set; }
        public int Difficulty { get; set; } // difficulty 1 - 2 - 3
        public int PointValue { get; set; }

    }
}
