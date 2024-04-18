using Katena.Domain.Entities;

namespace Katena.TestProg
{
    public class CalculationLoogiсAnswer
    {
        readonly AnswersBase answers; // ответ с весами
       

        private double?[] AnswerCheckP = { 0, 0, 0, 0};// Масив весов ответа Производитель
        private double?[] AnswerCheckA = { 0, 0, 0, 0 };// Масив весов ответа Админестратор
        private double?[] AnswerCheckE = { 0, 0, 0, 0 };// Масив весов ответа Предприниматель
        private double?[] AnswerCheckI = { 0, 0, 0, 0 };// Масив весов ответа Интегратор

        public CalculationLoogiсAnswer(AnswersBase answers)
        {
            
            this.answers= answers;
           
        }

        public void MassCheckAnswer()
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

            CheckAnswer();
        }

         public double? style_P = 0;//стиль управления процесами Производитель
         public double?  style_A = 0;//стиль управления процесами Администратор
         public double? style_E = 0;//стиль управления процесами Предпренематель
         public double? style_I = 0;//стиль управления процесами Интегратор
        public int style_PP = 0;
        public int style_AA = 0;
        public int style_EE = 0;
        public int style_II = 0;
        private void CheckAnswer()
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
            
            /// в каждом ответе есть главынй ответ Производитель админестратор и тд
            /// тоже самое и мотивом только их 3  
            /// и они вкладываются в расчет пометил ячейкой 


            
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
           // var style_All = 0; // (reason.typeWeight1 + reason.typeWeight2 + reason.typeWeight3) * 2 + reason.typeWeight1 + reason.typeWeight2 + reason.typeWeight3;
            style_P += answers.typeWeight1;

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
            style_A += answers.typeWeight2;

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
            style_E += answers.typeWeight3;

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
            style_I += answers.typeWeight4;

            

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
