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
    public class AnswerController : Controller
    {
        public KodelabAssessmentContext db { get; set; }
        public IAnswer _AnswerDb { get; set; }
        public IQuestion _QuestionDb { get; set; }
        public IQuizDB _QuizDb { get; set; }
        public AnswerController(IAnswer answerDb, IQuestion questionDb, IQuizDB quizDb)
        {
            _AnswerDb = answerDb;
            _QuestionDb = questionDb;
            _QuizDb = quizDb;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var results = await _AnswerDb.GetAll();


            return Ok(results);
        }

        // GET: AnswerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AnswerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnswerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnswerController/Create
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

        // GET: AnswerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnswerController/Edit/5
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

        // GET: AnswerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnswerController/Delete/5
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
