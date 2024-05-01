using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VerificationISO27001.Models;

namespace VerificationISO27001.SessionData
{
    public class Session
    {
        public string CompanyName {  get; set; }
        public MListOfQuestionsData MListOfQuestions {  get; set; }

    }
}