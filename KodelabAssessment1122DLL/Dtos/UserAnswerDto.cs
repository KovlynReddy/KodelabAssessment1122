using System;
using System.Collections.Generic;
using System.Text;

namespace KodelabAssessment1122DLL.Dtos
{
    public class UserAnswerDto
    {
        public int QuestionNumber { get; set; }
        public string UserId { get; set; }
        public string QuestionId { get; set; }
        public string SelectedAnswerId { get; set; }
        public string QuestionText { get; set; }
        public List<string> AnswerText { get; set; }
        public List<string> AnswerIds { get; set; }
        public string DateTimeString { get; set; }
        public DateTime DateTimeCreated { get; set; }
    }
}
