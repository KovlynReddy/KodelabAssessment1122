using KodelabAssessment1122API.Data.Context;
using KodelabAssessment1122API.Data.Interface;
using KodelabAssessment1122DLL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodelabAssessment1122API.Data.Repository
{
    public class QuestionDB : IQuestion
    {
        public KodelabAssessmentContext Db { get; set; }

        public QuestionDB(KodelabAssessmentContext _db)
        {
            Db = _db;
        }

        public async Task<QuizQuestions> CreateQuiz(QuizQuestions newQuizQustion)
        {
            Db.Add(newQuizQustion);

            return newQuizQustion;
        }

        public Task<QuizQuestions> DeleteQuiz(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<QuizQuestions>> GetAll()
        {
            return Db.Questions.ToList();
        }

        public Task<QuizQuestions> GetQuiz(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
