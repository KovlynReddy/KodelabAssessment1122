using System;
using System.Collections.Generic;
using System.Text;

namespace KodelabAssessment1122DLL.Dtos
{
    public class SingleQuestionAnswerDto
    {
        public string UserId { get; set; }
        public string QuestionId { get; set; }
        public string AnswerId { get; set; }
        public int IsCorrect { get; set; }
        public string DateTimeCreated { get; set; }
        public int QuestionNumber { get; set; }
    }
}
