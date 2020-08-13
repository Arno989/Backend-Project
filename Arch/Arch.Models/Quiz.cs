using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizProject.Models
{
    public class Quiz
    {
        public Guid Id { get; set; }
        public List<Question> Questions { get; set; }
    }
}
