using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KodelabAssessment1122DLL.Helpers
{
    public class QuizStructure
    {
        [JsonProperty("movieQuiz")]
        public IEnumerable<Quiz> Quizes { get; set; }

    }

    public class Quiz {

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }


        [JsonProperty("questions")]
        public IEnumerable<Questions> questions { get; set; }


    }

    public class Questions {
        [JsonProperty("question")]
        public string question { get; set; }

        [JsonProperty("answers")]
        public IEnumerable<Answer> answers { get; set; }

    }

    public class Answer {
        [JsonProperty("answer")]
        public string answer { get; set; }

        [JsonProperty("isCorrect")]
        public string isCorrect { get; set; }
    }
}
