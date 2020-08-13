using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizProject.Models
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly AppDbContext _appDbContext;

        public AnswerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        Answer IAnswerRepository.GetAnswerById => throw new NotImplementedException();
    }
}
