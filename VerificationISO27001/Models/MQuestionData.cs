using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VerificationISO27001.Enums;

namespace VerificationISO27001.Models
{
    public class MQuestionData
    {
        public int Id { get; set; }
        public int Number {  get; set; } 
        public string Question {  get; set; }
        public string Answer { get; set; }
        public Risk Risk { get; set; }
        public int Scored {  get; set; }
    }
}