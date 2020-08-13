using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizProject.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> AllUsers { get; }
        User GetUserById(int Id);
    }
}
