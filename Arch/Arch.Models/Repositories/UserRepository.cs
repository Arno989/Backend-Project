using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizProject.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        IEnumerable<User> IUserRepository.AllUsers
        {
            get
            {
                return _appDbContext.Users;
            }
        }

        User IUserRepository.GetUserById(int Id)
        {
            return _appDbContext.Users.FirstOrDefault(u => u.Id == Id);
        }
    }
}
