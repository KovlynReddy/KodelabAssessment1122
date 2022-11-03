using KodelabAssessment1122DLL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodelabAssessment1122API.Data.Interface
{
    public interface IAnswer
    {
        public Task<List<QuizAnswers>> GetAll();
        public Task<QuizAnswers> GetQuiz(int Id);
        public Task<QuizAnswers> DeleteQuiz(int Id);
        public Task<QuizAnswers> CreateQuiz(QuizAnswers newQuizAnswer);

    }
}
