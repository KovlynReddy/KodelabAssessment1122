using KodelabAssessment1122DLL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodelabAssessment1122API.Data.Interface
{
    public interface IQuestion
    {
        public Task<List<QuizQuestions>> GetAll();
        public Task<QuizQuestions> GetQuiz(int Id);
        public Task<QuizQuestions> DeleteQuiz(int Id);
        public Task<QuizQuestions> CreateQuiz(QuizQuestions newQuizQustion);

    }
}
