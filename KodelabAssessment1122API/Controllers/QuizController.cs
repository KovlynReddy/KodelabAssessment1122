using KodelabAssessment1122API.Data.Context;
using KodelabAssessment1122API.Data.Interface;
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
