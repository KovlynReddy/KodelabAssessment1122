using KodelabAssessment1122.Models;
using KodelabAssessment1122.Services;
using KodelabAssessment1122DLL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KodelabAssessment1122.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            //KodelabAssessment1122DLL.Services.QuizUpdater.UpdateFromFile();

            //var Answers = await QuizService.GetAllAnswers();
            //var Questions = await QuizService.GetAllQuestions();
            //var Quizs = await QuizService.GetAllQuizes();

            //TakeQuizViewModel model = new TakeQuizViewModel
            //{
            //    answers = Answers,
            //    questions = Questions,
            //    quizes = Quizs
            //};

            return View();
        }


        public IActionResult UpdateDB() {

            return View();
        
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
