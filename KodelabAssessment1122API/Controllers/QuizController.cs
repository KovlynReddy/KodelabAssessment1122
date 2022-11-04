using KodelabAssessment1122API.Data.Context;
using KodelabAssessment1122API.Data.Interface;
using KodelabAssessment1122DLL.DomainModels;
using KodelabAssessment1122DLL.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodelabAssessment1122API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuizController : Controller
    {
        public KodelabAssessmentContext db { get; set; }
        public IAnswer _AnswerDb { get; set; }
        public IQuestion _QuestionDb { get; set; }
        public IQuizDB _QuizDb { get; set; }
        public QuizController(IAnswer answerDb, IQuestion questionDb, IQuizDB quizDb, KodelabAssessmentContext context)
        {
            _AnswerDb = answerDb;
            _QuestionDb =questionDb ;
            _QuizDb = quizDb;
            db = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        { 
            var results = await _QuizDb.GetAll();

            return Ok(results);
        }

        [HttpPost]
        [Route("~/api/Quiz/AnswerQuestion")]
        public async Task<IActionResult> AnswerQuestion([FromBody]CreateUserAnswerDto newAnswer) {

            UserAnswers answer = new UserAnswers
            {
                UserGuid = newAnswer.UserGuid,
                AnswerId = newAnswer.AnswerId,
                CreatedDateTime = newAnswer.CreatedDateTime,
                CreatorId = newAnswer.CreatorId,
                IsCorrect = newAnswer.IsCorrect.ToString(),
                IsDeleted = newAnswer.IsDeleted,
                ModelId = newAnswer.ModelId,
                QuestionId = newAnswer.QuestionId,
            };

            db.Add(answer);

            db.SaveChanges();


            return Ok();
        }


        public async Task<IActionResult> UpdateDB() {

            var results = KodelabAssessment1122DLL.Services.QuizUpdater.UpdateFromFile();

            db.AddRange(results.quizes);
            db.AddRange(results.questions);
            db.AddRange(results.answers);

            db.SaveChanges();

            return View();
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

        [HttpGet]
        public ActionResult GetAllUserAnswers()
        {
            var allUserAnswers = db.UserAnswers.ToList();
            var allUserAnswerDtos = new List<CreateUserAnswerDto>();

            foreach (var answer in allUserAnswers)
            {
                var AnswerDto = new CreateUserAnswerDto {
                    UserGuid = answer.UserGuid,
                    AnswerId = answer.AnswerId,
                    CreatedDateTime = answer.CreatedDateTime,
                    CreatorId = answer.CreatorId,
                    IsCorrect = Convert.ToInt32(answer.IsCorrect),
                    IsDeleted = answer.IsDeleted,
                    ModelId = answer.ModelId,
                    QuestionId = answer.QuestionId,
                };

                allUserAnswerDtos.Add(AnswerDto);
            }

            return Ok(allUserAnswerDtos);
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

        // GET: QuizController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
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
        public ActionResult Delete(int id)
        {
            return View();
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
