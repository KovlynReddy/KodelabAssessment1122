using System;
using System.Collections.Generic;
using System.Text;

namespace KodelabAssessment1122DLL.DomainModels
{
    public class QuizQuestions : BaseModel
    {
        public string quizId { get; set; }
        public string question { get; set; }
    }
}
