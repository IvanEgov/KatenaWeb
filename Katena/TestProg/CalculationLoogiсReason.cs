using Katena.Domain.Entities;

namespace Katena.TestProg
{
    public class CalculationLoogiсReason
    {
        readonly ReasonBase reason; // мотив с весами 

        private int?[] ReasonCheckZ = { 0, 0, 0, 0, 0 };// Масив весов мотивов З
        private int?[] ReasonCheckP = { 0, 0, 0, 0, 0 };// Масив весов мотивов P
        private int?[] ReasonCheckX = { 0, 0, 0, 0, 0 };// Масив весов мотивов Х

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

        
        public int? distr_mentor = 0; //гендерному дистрибутиву наставник
        public int? distr_looking = 0;//гендерному дистрибутиву Ищущий
        public int? distr_hunter = 0; //гендерному дистрибутиву охотник
        public int distr_mentorP = 0;
        public int distr_lookingP = 0;
        public int distr_hunterP = 0;
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
            //убераем погрешность
           // distr_mentor = distr_mentor + reason.typeWeight4 + reason.typeWeight5 + reason.typeWeight7;  

            if (distr_looking > distr_mentor && distr_looking > distr_hunter)
            {
                distr_looking = distr_looking + 1;// + (answers.typeWeight1 + answers.typeWeight2) * 2 + answers.typeWeight3 + answers.typeWeight4; // (F253+V253)+ AL253*2  +  BB253;    
            }
            else
            {
                distr_looking = distr_looking;// + (answers.typeWeight1 + answers.typeWeight2) * 2 + answers.typeWeight3 + answers.typeWeight4;
            }
           // distr_looking = distr_looking + reason.typeWeight5 + reason.typeWeight6 + reason.typeWeight7;

            if (distr_hunter > distr_mentor && distr_hunter > distr_looking)
            {
                distr_hunter = distr_hunter + 1;// + answers.typeWeight4 * 2 + answers.typeWeight1; // + BB253*2  +  F253; 
            }
            else
            {
                distr_hunter = distr_hunter;// + answers.typeWeight4 * 2 + answers.typeWeight1;
            }
          //  distr_hunter = distr_hunter + reason.typeWeight4 + reason.typeWeight6 + reason.typeWeight7;


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
