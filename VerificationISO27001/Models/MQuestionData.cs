using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VerificationISO27001.Models
{
    public class MQuestionData
    {
        public int Id { get; set; }
        public int Number {  get; set; } 
        public string Question {  get; set; }
        public bool Answer { get; set; }
    }
}