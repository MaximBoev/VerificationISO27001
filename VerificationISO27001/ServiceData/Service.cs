using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Web;
using VerificationISO27001.Models;
using VerificationISO27001.SessionData;

namespace VerificationISO27001.ServiceData
{
    public class Service
    {
        public void Evaluate(List<MQuestionData> answers, Session currentSession)
        {
            currentSession.ResultData = new MResultData();
            float numberOfPoints = 0;
            float totalPoints = 0;
            for (int i = 0; i < currentSession.MListOfQuestions.Questions.Count(); i++)
            {
                currentSession.MListOfQuestions.Questions[i].Answer = answers[i].Answer;
                totalPoints = totalPoints + currentSession.MListOfQuestions.Questions[i].Scored;

                if (currentSession.MListOfQuestions.Questions[i].CorrectAnswer ==
                    currentSession.MListOfQuestions.Questions[i].Answer)
                    numberOfPoints = numberOfPoints + currentSession.MListOfQuestions.Questions[i].Scored;
            }
            currentSession.ResultData.correctness = 100 * (numberOfPoints / totalPoints);
            if (currentSession.ResultData.correctness > 65)
            {
                currentSession.ResultData.Success = true;
            }
            else
            {
                currentSession.ResultData.Success = false;
            }
        }
        public void FillQuestions(MListOfQuestionsData mListOfQuestionsData) 
        {
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 1,
                Number = 1,
                Question = "Имеет ли организация утвержденную политику информационной безопасности?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.High,
                Scored = 10
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 2,
                Number = 2,
                Question = "Осуществляется ли регулярный аудит информационной безопасности?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.High,
                Scored = 8
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 3,
                Number = 3,
                Question = "Реализованы ли меры защиты от внутренних угроз (например, утечка данных сотрудником)?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.High,
                Scored = 12
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 4,
                Number = 4,
                Question = "Существует ли процедура реагирования на инциденты информационной безопасности?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.High,
                Scored = 15
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 5,
                Number = 5,
                Question = "Применяются ли шифрование и другие меры защиты для защиты конфиденциальной информации?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.High,
                Scored = 10
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 6,
                Number = 6,
                Question = "Проходят ли сотрудники обучение по вопросам информационной безопасности?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Medium,
                Scored = 6
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 7,
                Number = 7,
                Question = "Установлены ли ограничения на доступ к конфиденциальной информации в зависимости от роли сотрудника?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Medium,
                Scored = 5
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 8,
                Number = 8,
                Question = "Происходит ли резервное копирование данных с регулярной периодичностью?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Medium,
                Scored = 7
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 9,
                Number = 9,
                Question = "Существует ли процедура аутентификации и авторизации пользователей?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Medium,
                Scored = 8
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 10,
                Number = 10,
                Question = "Тесты на проникновение проводятся редко?",
                CorrectAnswer = "No",
                Risk = Enums.Risk.Medium,
                Scored = 9
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 11,
                Number = 11,
                Question = "Используется ли антивирусное программное обеспечение на всех компьютерах организации?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Acceptable,
                Scored = 3
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 12,
                Number = 12,
                Question = "Существует ли политика разделения обязанностей для минимизации рисков?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Acceptable,
                Scored = 4
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 13,
                Number = 13,
                Question = "Осуществляется ли мониторинг сетевой активности?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Acceptable,
                Scored = 5
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 14,
                Number = 14,
                Question = "Проводится ли регулярное обновление программного обеспечения и патчей безопасности?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Acceptable,
                Scored = 3
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 15,
                Number = 15,
                Question = "Существует ли процедура удаления доступа сотрудников после увольнения или перевода на другую должность?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Acceptable,
                Scored = 4
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 16,
                Number = 16,
                Question = "Осуществляется ли мониторинг и регистрация всех попыток доступа к конфиденциальной информации?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.High,
                Scored = 13
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 17,
                Number = 17,
                Question = "Существует ли процедура регулярного обновления политики информационной безопасности?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.High,
                Scored = 11
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 18,
                Number = 18,
                Question = "Проводятся ли тщательные проверки на безопасность при разработке новых информационных систем или приложений?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.High,
                Scored = 14
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 19,
                Number = 19,
                Question = "Используется ли многофакторная аутентификация для доступа к критическим системам?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.High,
                Scored = 16
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 20,
                Number = 20,
                Question = "Существует ли система мониторинга аномальной активности, которая может указывать на возможные инциденты безопасности?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.High,
                Scored = 18
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 21,
                Number = 21,
                Question = "Проводится ли регулярная оценка уязвимостей с использованием специализированных инструментов?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.High,
                Scored = 17
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 22,
                Number = 22,
                Question = "Существует ли процедура аварийного восстановления для быстрого восстановления после серьезных инцидентов безопасности?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.High,
                Scored = 20
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 23,
                Number = 23,
                Question = "Применяются ли штрафные санкции за нарушение политики информационной безопасности?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Medium,
                Scored = 7
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 24,
                Number = 24,
                Question = "Существует ли процедура рассмотрения и управления уязвимостями после их обнаружения?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Medium,
                Scored = 6
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 25,
                Number = 25,
                Question = "Применяется ли методика классификации данных для определения уровня конфиденциальности и ценности информации?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Medium,
                Scored = 8
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 26,
                Number = 26,
                Question = "Осуществляется ли шифрование данных в покое и в передаче?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Medium,
                Scored = 7
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 27,
                Number = 27,
                Question = "Сотрудники в области информационной безопасности проходят экзаминацию на подтверждение квалификации редко и за свой счет?",
                CorrectAnswer = "No",
                Risk = Enums.Risk.Medium,
                Scored = 6
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 28,
                Number = 28,
                Question = "Проводится ли анализ событий информационной безопасности для выявления потенциальных угроз?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Medium,
                Scored = 9
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 29,
                Number = 29,
                Question = "Существует ли процедура рассмотрения и управления инцидентами информационной безопасности?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Medium,
                Scored = 8
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 30,
                Number = 30,
                Question = "Проводится ли регулярное обучение сотрудников по процедурам обработки информации?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Acceptable,
                Scored = 4
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 31,
                Number = 31,
                Question = "Существует ли резервный центр обработки данных для обеспечения непрерывности бизнес-процессов?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Acceptable,
                Scored = 5
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 32,
                Number = 32,
                Question = "Проводятся ли проверки на соответствие стандартам безопасности у поставщиков услуг и продуктов?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Acceptable,
                Scored = 4
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 33,
                Number = 33,
                Question = "Используются ли шаблоны и стандарты для разработки безопасного программного обеспечения?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Acceptable,
                Scored = 3
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 34,
                Number = 34,
                Question = "Проводятся ли тесты на проникновение с внешней точки зрения для выявления слабых мест?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Acceptable,
                Scored = 3
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 35,
                Number = 35,
                Question = "Существует ли процедура резервного копирования для восстановления данных после потери или повреждения?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Acceptable,
                Scored = 4
            });
            mListOfQuestionsData.Questions.Add(new MQuestionData()
            {
                Id = 36,
                Number = 36,
                Question = "Применяется ли система управления доступом для контроля прав доступа пользователей?",
                CorrectAnswer = "Yes",
                Risk = Enums.Risk.Acceptable,
                Scored = 5
            });
        }

    }
}