using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizProject.Models
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly AppDbContext _appDbContext;

        public QuestionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        IEnumerable<Question> IQuestionRepository.RandomQuestion => throw new NotImplementedException();

        IEnumerable<Question> IQuestionRepository.AllQuestions => throw new NotImplementedException();
    }
}
