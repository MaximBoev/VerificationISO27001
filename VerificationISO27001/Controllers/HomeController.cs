using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VerificationISO27001.Models;

namespace VerificationISO27001.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
            
        }

        public ActionResult FAQ()
        {
            var tmp = new MListOfQuestionsData()
            {
                Questions = new List<MQuestionData>(),
            };
            for(int i=1; i<4; i++)
            {
                var tmp1 = new MQuestionData()
                {
                    Number = i,
                    Id = i,
                    Question = "What is the purpose of life, and how can we find it?",
                };
                tmp.Questions.Add(tmp1);
            }

            return View(tmp);

        }

        [HttpPost]
        public ActionResult StartFAQ(List<MQuestionData> list)
        {
            var tmp = list;
            return RedirectToAction("Index", "Home");

        }

        [HttpGet]
        public ActionResult Results()
        {
            return View();
        }
    }
}