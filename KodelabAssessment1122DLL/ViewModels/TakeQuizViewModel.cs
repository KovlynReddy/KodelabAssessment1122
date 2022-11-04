using KodelabAssessment1122DLL.DomainModels;
using KodelabAssessment1122DLL.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace KodelabAssessment1122DLL.ViewModels
{
    public class TakeQuizViewModel
    {
        public List<DomainModels.Quiz> quizes { get; set; } = new List<DomainModels.Quiz>();
        public List<QuizQuestions> questions { get; set; } = new List<DomainModels.QuizQuestions>();
        public List<QuizAnswers> answers { get; set; } = new List<DomainModels.QuizAnswers>();


        // only needed List ===>
        public List<UserAnswerDto> userAnswers { get; set; } = new List<UserAnswerDto>();

    }
}
