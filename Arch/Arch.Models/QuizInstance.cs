using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizProject.Models
{
    public class QuizInstance
    {
        public Guid Id { get; set; }
        public Quiz Quiz { get; set; }
        public DateTime Date { get; set; }
        public List<Participant> Participants { get; set; }
    }

    public class Participant
    {
        public User User { get; set; }
        public int Score { get; set; }
    }
}
