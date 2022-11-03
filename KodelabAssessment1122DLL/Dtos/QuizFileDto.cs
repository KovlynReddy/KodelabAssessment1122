using KodelabAssessment1122DLL.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace KodelabAssessment1122DLL.Dtos
{
    public class QuizFileDto
    {
        public List<DomainModels.Quiz> quizes   { get; set; } = new List<DomainModels.Quiz>();
        public List<QuizQuestions> questions    { get; set; } = new List<DomainModels.QuizQuestions>();
        public List<QuizAnswers> answers        { get; set; } = new List<DomainModels.QuizAnswers>();
    }
}
