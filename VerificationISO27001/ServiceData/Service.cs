using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Web;
using VerificationISO27001.Models;

namespace VerificationISO27001.ServiceData
{
    public class Service
    {
        public void FillQuestions(MListOfQuestionsData mListOfQuestionsData) 
        {
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 1,
                Number = 1,
                Question = "bimbim1",
                Answer = " ",
                Risk = Enums.Risk.Lower,
                Scored = 5
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 2,
                Number = 2,
                Question = "bimbim2",
                Answer = " ",
                Risk = Enums.Risk.Lower,
                Scored = 5
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 3,
                Number = 3,
                Question = "bimbim3",
                Answer = " ",
                Risk = Enums.Risk.Lower,
                Scored = 5
            });
            //mListOfQuestionsData.Questions.Add(new MQuestionData()
            //{
            //    Id = 4,
            //    Number = 4,
            //    Question = "bimbim4",
            //    Answer = " ",
            //    Risk = Enums.Risk.Lower,
            //    Scored = 5
            //});
            //mListOfQuestionsData.Questions.Add(new MQuestionData()
            //{
            //    Id = 5,
            //    Number = 5,
            //    Question = " ",
            //    Answer = " ",
            //    Risk = Enums.Risk.Lower,
            //    Scored = 5
            //});
            //mListOfQuestionsData.Questions.Add(new MQuestionData()
            //{
            //    Id = 6,
            //    Number = 6,
            //    Question = " ",
            //    Answer = " ",
            //    Risk = Enums.Risk.Lower,
            //    Scored = 5
            //});
            //mListOfQuestionsData.Questions.Add(new MQuestionData()
            //{
            //    Id = 7,
            //    Number = 7,
            //    Question = " ",
            //    Answer = " ",
            //    Risk = Enums.Risk.Lower,
            //    Scored = 5
            //});
            //mListOfQuestionsData.Questions.Add(new MQuestionData()
            //{
            //    Id = 8,
            //    Number = 8,
            //    Question = " ",
            //    Answer = " ",
            //    Risk = Enums.Risk.Lower,
            //    Scored = 5
            //});
            //mListOfQuestionsData.Questions.Add(new MQuestionData()
            //{
            //    Id = 9,
            //    Number = 9,
            //    Question = " ",
            //    Answer = " ",
            //    Risk = Enums.Risk.Lower,
            //    Scored = 5
            //});
            //mListOfQuestionsData.Questions.Add(new MQuestionData()
            //{
            //    Id = 10,
            //    Number = 10,
            //    Question = " ",
            //    Answer = " ",
            //    Risk = Enums.Risk.Lower,
            //    Scored = 5
            //});
        }
    }
}