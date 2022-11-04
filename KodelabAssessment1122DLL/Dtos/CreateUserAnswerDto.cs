using System;
using System.Collections.Generic;
using System.Text;

namespace KodelabAssessment1122DLL.Dtos
{
    public class CreateUserAnswerDto
    {
        public string UserGuid { get; set; }
        public string QuestionId { get; set; }
        public string AnswerId { get; set; }
        public int IsCorrect { get; set; }
        public string ModelId { get; set; }
        public int IsDeleted { get; set; }
        public string CreatorId { get; set; }
        public string CreatedDateTime { get; set; }
    }
}
