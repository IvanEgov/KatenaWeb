using Katena.Domain.Entities;

namespace Katena.TestProg
{
    public class CalculationLoogiс
    {
        readonly QuestionPackBase nowPack;//Класс, хранящий пак вопросов для теста с id, названием, описанием и т.д., а также результаты теста.
        int index;// индекс -1 (это стартовая строница) остальные номера вопроса
        readonly QuestionBase question;
        readonly AnswersBase answers; // ответ с весами
        readonly ReasonBase reason; // мотив с весами 

        private double?[] AnswerCheckP = { 0, 0, 0, 0};// Масив весов ответа Производитель
        private double?[] AnswerCheckA = { 0, 0, 0, 0 };// Масив весов ответа Админестратор
        private double?[] AnswerCheckE = { 0, 0, 0, 0 };// Масив весов ответа Предприниматель
        private double?[] AnswerCheckI = { 0, 0, 0, 0 };// Масив весов ответа Интегратор

        private double?[] ReasonCheckZ = { 0, 1, 2, 3, 4};// Масив весов мотивов З
        private double?[] ReasonCheckP = { 0, 1, 2, 3, 4 };// Масив весов мотивов P
        private double?[] ReasonCheckX = { 0, 1, 2, 3, 4 };// Масив весов мотивов Х

        public CalculationLoogiс(QuestionPackBase nowPack, int index, QuestionBase question, AnswersBase answers, ReasonBase reason)
        {
            this.nowPack= nowPack;
            this.index= index;
            this.question= question;
            this.answers= answers;
            this.reason= reason;
        }

        
        public void MassCheck()
        {
            //наполнение масива весами
           
            AnswerCheckP[0] = answers.Weight; // принять решение / производитель
            AnswerCheckP[1] = answers.Weight1;// фокус внимания / производитель
            AnswerCheckP[2] = answers.Weight2;// процес решение / производитель
            AnswerCheckP[3] = answers.Weight3;// орентирован на / производитель

            AnswerCheckA[0] = answers.Weight4;// принять решение / админстратор
            AnswerCheckA[1] = answers.Weight5;
            AnswerCheckA[2] = answers.Weight6;
            AnswerCheckA[3] = answers.Weight7;

            AnswerCheckE[0] = answers.Weight8;// принять решение / предприниматель
            AnswerCheckE[1] = answers.Weight9;
            AnswerCheckE[2] = answers.Weight10;
            AnswerCheckE[3] = answers.Weight11;

            AnswerCheckI[0] = answers.Weight12;// принять решение / Интегратор
            AnswerCheckI[1] = answers.Weight13;
            AnswerCheckI[2] = answers.Weight14;
            AnswerCheckI[3] = answers.Weight15;

            //наполнение масива весами
            ReasonCheckZ[0] = reason.Weight;//поиск виновного / з
            ReasonCheckZ[1] = reason.Weight1;//поиск ценостей / з 
            ReasonCheckZ[2] = reason.Weight2;//Вектор внимания / з
            ReasonCheckZ[3] = reason.Weight3;//проявление заботы / з
            ReasonCheckZ[4] = reason.Weight4;//оринтация во времения / з

            ReasonCheckP[0] = reason.Weight5;//поиск виновного / П
            ReasonCheckP[1] = reason.Weight6;
            ReasonCheckP[2] = reason.Weight7;
            ReasonCheckP[3] = reason.Weight8;
            ReasonCheckP[4] = reason.Weight9;

            ReasonCheckX[0] = reason.Weight10;//поиск виновного / Х
            ReasonCheckX[1] = reason.Weight11;
            ReasonCheckX[2] = reason.Weight12;  
            ReasonCheckX[3] = reason.Weight13;
            ReasonCheckX[4] = reason.Weight14;
        }

        double? distr_mentor; //гендерному дистрибутиву наставник
        double? distr_looking;//гендерному дистрибутиву Ищущий
        double? distr_hunter; //гендерному дистрибутиву охотник
        double? style_P;//стиль управления процесами Производитель
        double?  style_A;//стиль управления процесами Администратор
        double? style_E;//стиль управления процесами Предпренематель
        double? style_I;//стиль управления процесами Интегратор

        public void Check()
        {
            for (int i = 0; i < AnswerCheckP.Length; i++)
            {
                style_P += AnswerCheckP[i];
            }
            for (int i = 0; i < AnswerCheckA.Length; i++)
            {
                style_A += AnswerCheckA[i];
            }
            for (int i = 0; i < AnswerCheckE.Length; i++)
            {
                style_E += AnswerCheckE[i];
            }
            for (int i = 0; i < AnswerCheckI.Length; i++)
            {
                style_I += AnswerCheckI[i];
            }
            for (int i = 0; i < ReasonCheckZ.Length; i++)
            {
                distr_mentor += ReasonCheckZ[i];
            }
            for (int i = 0; i < ReasonCheckP.Length; i++)
            {
                distr_looking += ReasonCheckP[i];
            }
            for (int i = 0; i < ReasonCheckX.Length; i++)
            {
                distr_hunter += ReasonCheckX[i];
            }
            /// в каждом ответе есть главынй ответ Производитель админестратор и тд
            /// тоже самое и мотивом только их 3  
            /// и они вкладываются в расчет пометил ячейкой 


            //корекция сложеных данных
            if (distr_mentor > distr_looking && distr_mentor > distr_hunter) 
            {
                distr_mentor = distr_mentor + 1; // + AL253*2  +  V253;  добавить надо а это вариант ответа только когда выбран  
            }
            else
            {
                //distr_mentor +=  AL253*2  +  V253;  добавить надо а это вариант ответа только когда выбран  
            }

            if (distr_looking > distr_mentor && distr_looking > distr_hunter)
            {
                distr_looking ++; // (F253+V253)+ AL253*2  +  BB253;  добавить надо а это вариант ответа только когда выбран  
            }
            else
            {
                //distr_mentor +=  AL253*2  +  V253;  добавить надо а это вариант ответа только когда выбран  
            }

            if (distr_hunter > distr_mentor && distr_hunter > distr_looking)
            {
                distr_hunter++; // + BB253*2  +  F253;  добавить надо а это вариант ответа только когда выбран  
            }
            else
            {
                //distr_mentor +=  AL253*2  +  V253;  добавить надо а это вариант ответа только когда выбран  
            }

        }
    }
}
