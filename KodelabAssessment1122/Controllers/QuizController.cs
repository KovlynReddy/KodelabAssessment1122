using KodelabAssessment1122.Services;
using KodelabAssessment1122DLL.Dtos;
using KodelabAssessment1122DLL.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodelabAssessment1122.Controllers
{
    public class QuizController : Controller
    {

        [HttpGet]
        public async Task<IActionResult> TakeQuiz() {

            var Answers = await QuizService.GetAllAnswers();
            var Questions = await QuizService.GetAllQuestions();
            var Quizs = await QuizService.GetAllQuizes();

            TakeQuizViewModel model = new TakeQuizViewModel
            {
                answers = Answers,
                questions = Questions,
                quizes = Quizs
            };

            var userGuid = Guid.NewGuid().ToString();

            foreach (var question in Questions)
            {
                var answer = new UserAnswerDto {
                    QuestionNumber = question.id,
                    //AnswerId = question.ModelId,
                    UserId = userGuid,
                    QuestionId = question.ModelId,
                    DateTimeCreated = DateTime.Now
                };

                model.userAnswers.Add(answer);
            }

                return View(model);
        }

        [HttpPost]
        public IActionResult SubmitQuiz(TakeQuizViewModel model) {

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SimpleQuiz() {

            var Answers = await QuizService.GetAllAnswers();
            var Questions = await QuizService.GetAllQuestions();
            var Quizs = await QuizService.GetAllQuizes();

            TakeQuizViewModel model = new TakeQuizViewModel
            {
                answers = Answers,
                questions = Questions,
                quizes = Quizs
            };

            var userGuid = Guid.NewGuid().ToString();

            foreach (var question in Questions)
            {
                var useranswer = new UserAnswerDto
                {
                    QuestionNumber = question.id,
                    //AnswerId = question.ModelId,
                    QuestionText = question.question,
                    UserId = userGuid,
                    QuestionId = question.ModelId,
                    DateTimeCreated = DateTime.Now
                };

                var answers = Answers.Where(m => m.QuestionId == question.ModelId).OrderBy(m => m.id);

                useranswer.AnswerIds = answers.Select(k => k.ModelId).ToList();
                useranswer.AnswerText = answers.Select(k => k.answer).ToList();

                model.userAnswers.Add(useranswer);
            }

            return View(model.userAnswers.FirstOrDefault());
        }



        [HttpGet]
        public async Task<IActionResult> TryQuiz()
        {

            var Answers = await QuizService.GetAllAnswers();
            var Questions = await QuizService.GetAllQuestions();
            var Quizs = await QuizService.GetAllQuizes();

            TakeQuizViewModel model = new TakeQuizViewModel
            {
                answers = Answers,
                questions = Questions,
                quizes = Quizs
            };

            var userGuid = Guid.NewGuid().ToString();

            foreach (var question in Questions)
            {
                var useranswer = new UserAnswerDto
                {
                    QuestionNumber = question.id,
                    //AnswerId = question.ModelId,
                    QuestionText = question.question,
                    UserId = userGuid,
                    QuestionId = question.ModelId,
                    DateTimeCreated = DateTime.Now
                };

                var answers = Answers.Where(m=>m.QuestionId == question.ModelId).OrderBy(m=>m.id);

                useranswer.AnswerIds = answers.Select(k=>k.ModelId).ToList();
                useranswer.AnswerText = answers.Select(k => k.answer).ToList();

                model.userAnswers.Add(useranswer);
            }

            return View(model);
        }

        [HttpPost]
        public async Task< IActionResult> AnswerQuestion(UserAnswerDto model) {

            var Answers = await QuizService.GetAllAnswers();
            var Questions = await QuizService.GetAllQuestions();
            var Quizs = await QuizService.GetAllQuizes();

            TakeQuizViewModel viewmodel = new TakeQuizViewModel
            {
                answers = Answers,
                questions = Questions,
                quizes = Quizs
            };

            var userGuid = Guid.NewGuid().ToString();

            foreach (var question in Questions)
            {
                var useranswer = new UserAnswerDto
                {
                    QuestionNumber = question.id,
                    //AnswerId = question.ModelId,
                    QuestionText = question.question,
                    UserId = userGuid,
                    QuestionId = question.ModelId,
                    DateTimeCreated = DateTime.Now
                };

                var answers = Answers.Where(m => m.QuestionId == question.ModelId).OrderBy(m => m.id);

                useranswer.AnswerIds = answers.Select(k => k.ModelId).ToList();
                useranswer.AnswerText = answers.Select(k => k.answer).ToList();

                viewmodel.userAnswers.Add(useranswer);
            }

            int Index = model.QuestionNumber++;

            var ViewModel = viewmodel.userAnswers[model.QuestionNumber];

            return View("SimpleQuiz",ViewModel);
        }

        // GET: QuizController
        public ActionResult Index()
        {
            return View();
        }

        // GET: QuizController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuizController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuizController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AnswerQuestionTest([FromBody]CompoundAnswer ans)
        {
            string UserGuid = Guid.NewGuid().ToString();

            var Answers = await QuizService.GetAllAnswers();
            var Questions = await QuizService.GetAllQuestions();
            var Quizs = await QuizService.GetAllQuizes();

            var QuestionAnswerPairs = ans.ans.Split("_");
            List<SingleQuestionAnswerDto> UserAnswers = new List<SingleQuestionAnswerDto>();
            List<CreateUserAnswerDto> UserAnswersDtos = new List<CreateUserAnswerDto>();

            foreach (var pair in QuestionAnswerPairs)
            {
                var QuestionAnswers = pair.Split(".");
                SingleQuestionAnswerDto userAnswer = new SingleQuestionAnswerDto();
                userAnswer.AnswerId = QuestionAnswers.FirstOrDefault();
                userAnswer.QuestionId = QuestionAnswers.LastOrDefault();

                UserAnswers.Add(userAnswer);
            }

            foreach (var pair in UserAnswers)
            {
                if (string.IsNullOrEmpty(pair.QuestionId))
                {
                    continue;
                }
                var matchingAnswer = Answers.FirstOrDefault(m => m.ModelId == pair.QuestionId);
                pair.IsCorrect = matchingAnswer.isCorrect;

                var answerdto =  new CreateUserAnswerDto();
                answerdto.IsCorrect = matchingAnswer.isCorrect;
                answerdto.AnswerId = pair.AnswerId;
                answerdto.QuestionId = pair.QuestionId;
                answerdto.UserGuid = UserGuid;
                answerdto.CreatedDateTime = DateTime.Now.ToString();
                answerdto.ModelId = Guid.NewGuid().ToString();

                UserAnswersDtos.Add(answerdto);
            }


            foreach (var answer in UserAnswersDtos)
            {
                await QuizService.CreateUserAnswer(answer);
            }

            UserResultsViewModel model = new UserResultsViewModel
            {
                Results = UserAnswersDtos.Where(m => m.IsCorrect == 1).ToList().Count,
                Time = UserAnswersDtos.FirstOrDefault().CreatedDateTime,
                Total = UserAnswersDtos.Count,
                UserId = UserGuid
            };

            return View("ViewResults",model );
        }

        // POST: QuizController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuizController/Delete/5
        [HttpGet]
        public async Task<IActionResult> GetAllUserResults()
        {
            ViewAllResultsViewModel model = new ViewAllResultsViewModel();
            model.AllAnswers = await QuizService.GetAllUserAnswers();

            var uniqueUsers = model.AllAnswers.Select(m => m.UserGuid).Distinct();

            foreach (var user in uniqueUsers)
            {

                    UserResultsViewModel userResults = new UserResultsViewModel {
                    Results = model.AllAnswers.Where(m => m.UserGuid == user && m.IsCorrect==1).ToList().Count,
                    Time = model.AllAnswers.FirstOrDefault(m => m.UserGuid == user).CreatedDateTime,
                    Total = model.AllAnswers.Where(m=>m.UserGuid==user).ToList().Count,
                    UserId = user
            };
                model.AllResults.Add(userResults);
            }
            

            return View(model);
        }

        // POST: QuizController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
