using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VerificationISO27001.Models;
using VerificationISO27001.SessionData;
using VerificationISO27001.ServiceData;

namespace VerificationISO27001.Controllers
{
    public class HomeController : Controller
    {
        internal Session currentSessionData = new Session();
        internal Service currentServiceData = new Service();

        // GET: Home
        public ActionResult Index()
        {
            return View();
            
        }

        public ActionResult FAQ()
        {
            var ListOfQuestions = new MListOfQuestionsData()
            {
                Questions = new List<MQuestionData>(),
            };

            var tmp = new MQuestionData()
            {
                Id = 1,
                Number = 1,
                Question = "nvjndfvfd",
                Risk = Enums.Risk.High,
                Scored = 5
            };
            ListOfQuestions.Questions.Add(tmp);
            
            //currentServiceData.FillQuestions(ListOfQuestions);

            return View(ListOfQuestions);

        }

        [HttpPost]
        public ActionResult CheckFAQ(List<MQuestionData> QuestionList)
        {
            var tmp = QuestionList;
            return RedirectToAction("Results", "Home");
        }

        [HttpPost]
        public ActionResult StartFAQ(MCompanyNameData nameData)
        {
            //currentSessionData.CompanyName = nameData.CompanyName;
            return RedirectToAction("FAQ", "Home");
        }

        [HttpGet]
        public ActionResult Results()
        {
            return View();
        }
    }
}