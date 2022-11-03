using KodelabAssessment1122API.Data.Context;
using KodelabAssessment1122API.Data.Interface;
using KodelabAssessment1122DLL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodelabAssessment1122API.Data.Repository
{
    public class QuizDB : IQuizDB
    {
        public KodelabAssessmentContext Db { get; set; }

        public async Task<Quiz> CreateQuiz(Quiz newQuiz)
        {
            Db.Add(newQuiz);

            return newQuiz;
        }

        public Task<Quiz> DeleteQuiz(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Quiz>> GetAll()
        {
            return Db.Quiz.ToList();
        }

        public Task<Quiz> GetQuiz(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
