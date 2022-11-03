using KodelabAssessment1122API.Data.Context;
using KodelabAssessment1122API.Data.Interface;
using KodelabAssessment1122DLL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodelabAssessment1122API.Data.Repository
{
    public class AnswerDB : IAnswer
    {
        public KodelabAssessmentContext Db { get; set; }

        public AnswerDB(KodelabAssessmentContext _Db)
        {
            Db = _Db;
        }


        public async Task<QuizAnswers> CreateQuiz(QuizAnswers newQuizAnswer)
        {
            Db.Add(newQuizAnswer);

            return newQuizAnswer;
        }

        public Task<QuizAnswers> DeleteQuiz(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<QuizAnswers>> GetAll()
        {
            return Db.Answers.ToList();
        }

        public Task<QuizAnswers> GetQuiz(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
