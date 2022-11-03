using System;
using System.Collections.Generic;
using System.Text;

namespace KodelabAssessment1122DLL.DomainModels
{
    public class QuizAnswers : BaseModel
    {
        public string QuestionId { get; set; }
        public string answer { get; set; }
        public int isCorrect { get; set; }
    }
}
