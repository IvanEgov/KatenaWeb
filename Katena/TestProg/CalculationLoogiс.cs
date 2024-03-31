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


            //корекция сложеных данных мотивации
            if (distr_mentor > distr_looking && distr_mentor > distr_hunter) 
            {
                distr_mentor = distr_mentor + 1 + answers.typeWeight2*2 +answers.typeWeight3; // + AL253*2  +  V253;   
            }
            else
            {
                distr_mentor = distr_mentor + answers.typeWeight2 * 2 + answers.typeWeight3;
            }

            if (distr_looking > distr_mentor && distr_looking > distr_hunter)
            {
                distr_looking = distr_looking + 1 + (answers.typeWeight1+answers.typeWeight2)*2 + answers.typeWeight3 + answers.typeWeight4 ; // (F253+V253)+ AL253*2  +  BB253;    
            }
            else
            {
                distr_looking = distr_looking + (answers.typeWeight1 + answers.typeWeight2) * 2 + answers.typeWeight3 + answers.typeWeight4;
            }

            if (distr_hunter > distr_mentor && distr_hunter > distr_looking)
            {
                distr_hunter = distr_hunter + 1 + answers.typeWeight4*2 + answers.typeWeight1; // + BB253*2  +  F253; 
            }
            else
            {
                distr_hunter = distr_hunter + answers.typeWeight4 * 2 + answers.typeWeight1;
            }

            double? distr_mentorP; 
            double? distr_lookingP;
            double? distr_hunterP; 

            if(distr_mentor>=distr_looking && distr_mentor>=distr_hunter)
            {
                distr_mentorP = 1;
            }
            else
            {
                distr_mentorP= 0;
            }
            if (distr_looking >=distr_mentor && distr_looking >= distr_hunter)
            {
                distr_lookingP = 1;
            }
            else
            {
                distr_lookingP = 0;
            }
            if (distr_hunter >= distr_looking && distr_hunter >= distr_mentor)
            {
                distr_hunterP = 1;
            }
            else
            {
                distr_hunterP = 0;
            }
            //корекция сложеных данных дистриктув
            switch (style_P)
            {
                case 1:
                    style_P = 0;
                    break;
                case 2:
                    style_P = 2;
                    break;
                case 3:
                    style_P = 4;
                    break;
                case 4:
                    style_P = 6;
                    break;
                default:
                    style_P = 5;
                    break;
            }
           var style_All = (reason.typeWeight1 + reason.typeWeight2 + reason.typeWeight3) * 2 + reason.typeWeight1 + reason.typeWeight2 + reason.typeWeight3;
            style_P += style_All;

            switch(style_A)
            {
                case 1:
                    style_A = 0;
                    break;
                case 2:
                    style_A = 2;
                    break;
                case 3:
                    style_A = 4;
                    break;
                case 4:
                    style_A = 6;
                    break;
                default:
                    style_A = 5;
                    break;
            }
            style_A += style_All;

            switch (style_E)
            {
                case 1:
                    style_E = 0;
                    break;
                case 2:
                    style_E = 2;
                    break;
                case 3:
                    style_E = 4;
                    break;
                case 4:
                    style_E = 6;
                    break;
                default:
                    style_E = 5;
                    break;
            }
            style_E += style_All;

            switch (style_I)
            {
                case 1:
                    style_I = 0;
                    break;
                case 2:
                    style_I = 2;
                    break;
                case 3:
                    style_I = 4;
                    break;
                case 4:
                    style_I = 6;
                    break;
                default:
                    style_I = 5;
                    break;
            }
            style_I += style_All;

            double? style_PP;
            double? style_AA;
            double? style_EE;
            double? style_II;

            if (style_P >= style_A && style_P >= style_E && style_P>=style_I )
            {
                style_PP = 1;
            }
            else
            {
                style_PP = 0;
            }
            if (style_A >= style_P && style_A >= style_E && style_A >= style_I)
            {
                style_AA = 1;
            }
            else
            {
                style_AA = 0;
            }
            if (style_E >= style_A && style_E >= style_P && style_E >= style_I)
            {
                style_EE = 1;
            }
            else
            {
                style_EE = 0;
            }
            if (style_I >= style_A && style_I >= style_E && style_I >= style_P)
            {
                style_II = 1;
            }
            else
            {
                style_II = 0;
            }

            //вызов функции  где уже складывается и выбирается стили  заменить на ViewBag_________________________________
           // LoogicAll(distr_mentorP,distr_lookingP,distr_hunterP, style_PP,style_AA, style_EE, style_II);
        }
    }
}
