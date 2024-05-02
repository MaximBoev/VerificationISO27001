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
        internal Service service = new Service();
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
            service.FillQuestions(ListOfQuestions);
            service.RandomQuestion(ListOfQuestions);

            var tmp = (Session)System.Web.HttpContext.Current.Session["SessionData"];
            tmp.MListOfQuestions = ListOfQuestions;
            System.Web.HttpContext.Current.Session["SessionData"] = tmp;

            return View(ListOfQuestions);
        }

        [HttpPost]
        public ActionResult CheckFAQ(List<MQuestionData> list)
        {
            service.Evaluate(list, (Session)System.Web.HttpContext.Current.Session["SessionData"]);
            return RedirectToAction("Results", "Home");
        }

        [HttpPost]
        public ActionResult StartFAQ(MCompanyNameData nameData)
        {
            var currentSession = new Session()
            {
                CompanyName = nameData
            };
            System.Web.HttpContext.Current.Session["SessionData"] = currentSession;
            return RedirectToAction("FAQ", "Home");
        }

        [HttpGet]
        public ActionResult Results()
        {   
            var tmp = (Session)System.Web.HttpContext.Current.Session["SessionData"];
            return View(tmp);
        }

    }
}