using KodelabAssessment1122DLL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodelabAssessment1122API.Data.Interface
{
    public interface IQuizDB
    {
        public Task<List<Quiz>> GetAll();
        public Task<Quiz> GetQuiz(int Id);
        public Task<Quiz> DeleteQuiz(int Id);
        public Task<Quiz> CreateQuiz(Quiz newQuiz);


    }
}
