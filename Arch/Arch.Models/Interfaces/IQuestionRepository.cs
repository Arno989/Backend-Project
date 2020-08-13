using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizProject.Models
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> RandomQuestion { get; }
        IEnumerable<Question> AllQuestions { get; }
    }
}
