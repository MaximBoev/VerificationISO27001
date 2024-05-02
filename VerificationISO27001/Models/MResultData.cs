using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VerificationISO27001.Models
{
    public class MResultData
    {
        public bool Success { get; set; }
        public float correctness {  get; set; }
        public int scoreOfHighRisk { get; set; }
        public int scoreOfMediumRisk { get; set; }
        public int scoreOfAcceptableRisk { get; set; }
    }
}