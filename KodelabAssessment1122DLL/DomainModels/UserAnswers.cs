using System;
using System.Collections.Generic;
using System.Text;

namespace KodelabAssessment1122DLL.DomainModels
{
    public class UserAnswers : BaseModel
    {
        public string UserGuid { get; set; }
        public string QuestionId { get; set; }
        public string AnswerId { get; set; }
        public string IsCorrect { get; set; }
    }
}
