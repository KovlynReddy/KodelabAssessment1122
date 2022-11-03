using KodelabAssessment1122DLL.DomainModels;
using KodelabAssessment1122DLL.Dtos;
using KodelabAssessment1122DLL.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KodelabAssessment1122DLL.Services
{
    public class QuizUpdater
    {
        public static QuizFileDto UpdateFromFile() {

            // string path = @"C:\Users\User\OneDrive\Documents\Kodelab Assessment\KodelabAssessment1122\KodelabAssessment1122\wwwroot\quiz-data.json";
            var rootPath = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(rootPath);
            rootPath = di.Parent.FullName ;

            string path = Path.Combine(rootPath, "KodelabAssessment1122", @"Data\", "quiz-data.json");
            path = path.Replace("Data", "wwwroot");
            var jsonstring = File.ReadAllText(path);
            dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonstring);
            QuizStructure deserializedProduct = JsonConvert.DeserializeObject<QuizStructure>(jsonstring);
            List<DomainModels.Quiz> quizes = new List<DomainModels.Quiz>();
            List<QuizQuestions> questions = new List<DomainModels.QuizQuestions>();
            List<QuizAnswers> answers = new List<DomainModels.QuizAnswers>();



            foreach (var Quizes in deserializedProduct.Quizes)
            {
                DomainModels.Quiz quiz = new DomainModels.Quiz { 
                //id = Convert.ToInt32(Quizes.id),
                ModelId = Quizes.id,
                QuizName = Quizes.name ,
                CreatedDateTime = DateTime.Now.ToString()

                };

                quizes.Add(quiz);

                foreach (var Questions in Quizes.questions)
                {
                    QuizQuestions question = new QuizQuestions {
                    quizId = quiz.ModelId,
                    CreatedDateTime = DateTime.Now.ToString(),
                    //id = Convert.ToInt32(quiz.id),
                    ModelId = Guid.NewGuid().ToString(),
                    question = Questions.question
                    };

                    questions.Add(question);

                    foreach (var Answers in Questions.answers)
                    {

                        QuizAnswers answer = new QuizAnswers { 
                        CreatedDateTime = DateTime.Now.ToString(),
                        answer = Answers.answer,
                       // id = Convert.ToInt32(question.id),
                        isCorrect =Convert.ToBoolean(Answers.isCorrect) ? 1 : 0 ,
                        ModelId = Guid.NewGuid().ToString() ,
                        QuestionId =  question.ModelId
                        };

                        answers.Add(answer);
                    }

                }
    
            }

            QuizFileDto Dto = new QuizFileDto();
            Dto.answers     = answers;
            Dto.questions   = questions;
            Dto.quizes      = quizes;

            return Dto;

            //FileStream fileStream = new FileStream(@"C:\Users\User\OneDrive\Documents\Kodelab Assessment\KodelabAssessment1122\KodelabAssessment1122\wwwroot\quiz-data.json", FileMode.Open);

            //using (StreamReader file = new StreamReader(fileStream))
            //{
            //    int counter = 0;
            //    string ln;

            //    while ((ln = file.ReadLine()) != null)
            //    {
            //        Console.WriteLine(ln);
            //        counter++;
            //    }
            //    file.Close();
            //}

        }
    }
}
