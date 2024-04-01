using Katena.Domain.Entities;

namespace Katena.TestProg
{
    public class CalculationLoogiсReason
    {
        readonly ReasonBase reason; // мотив с весами 

        private double?[] ReasonCheckZ = { 0, 1, 2, 3, 4 };// Масив весов мотивов З
        private double?[] ReasonCheckP = { 0, 1, 2, 3, 4 };// Масив весов мотивов P
        private double?[] ReasonCheckX = { 0, 1, 2, 3, 4 };// Масив весов мотивов Х

        public CalculationLoogiсReason(ReasonBase reason)
        {

            this.reason = reason;
        }

        public void MassCheckReason()
        {
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
            CheckReason();
        }

        
        public double? distr_mentor; //гендерному дистрибутиву наставник
        public double? distr_looking;//гендерному дистрибутиву Ищущий
        public double? distr_hunter; //гендерному дистрибутиву охотник
        public double? distr_mentorP;
        public double? distr_lookingP;
        public double? distr_hunterP;
        private void CheckReason()
        {
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
            //корекция сложеных данных мотивации
            if (distr_mentor > distr_looking && distr_mentor > distr_hunter)
            {
                distr_mentor = distr_mentor + 1;// + answers.typeWeight2 * 2 + answers.typeWeight3; // + AL253*2  +  V253;   
            }
            else
            {
                distr_mentor = distr_mentor;// + answers.typeWeight2 * 2 + answers.typeWeight3;
            }

            if (distr_looking > distr_mentor && distr_looking > distr_hunter)
            {
                distr_looking = distr_looking + 1;// + (answers.typeWeight1 + answers.typeWeight2) * 2 + answers.typeWeight3 + answers.typeWeight4; // (F253+V253)+ AL253*2  +  BB253;    
            }
            else
            {
                distr_looking = distr_looking;// + (answers.typeWeight1 + answers.typeWeight2) * 2 + answers.typeWeight3 + answers.typeWeight4;
            }

            if (distr_hunter > distr_mentor && distr_hunter > distr_looking)
            {
                distr_hunter = distr_hunter + 1;// + answers.typeWeight4 * 2 + answers.typeWeight1; // + BB253*2  +  F253; 
            }
            else
            {
                distr_hunter = distr_hunter;// + answers.typeWeight4 * 2 + answers.typeWeight1;
            }

            

            if (distr_mentor >= distr_looking && distr_mentor >= distr_hunter)
            {
                distr_mentorP = 1;
            }
            else
            {
                distr_mentorP = 0;
            }
            if (distr_looking >= distr_mentor && distr_looking >= distr_hunter)
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
        }

     
    }
}
