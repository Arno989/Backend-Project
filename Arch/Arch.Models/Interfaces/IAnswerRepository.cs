﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizProject.Models
{
    public interface IAnswerRepository
    {
        public Answer GetAnswerById { get; }
    }
}
