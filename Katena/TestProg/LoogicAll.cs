namespace Katena.TestProg
{
    public class LoogicAll
    {
        public double? styl_All;
        double? distrikt_All;
        public LoogicAll(double? styl_All, double? distrikt_All)
        {
            this.styl_All = styl_All;
            this.distrikt_All = distrikt_All;
            StartA();
        }

        // Создаем функция общую 
        void StartA()
        {
            var aaa = styl_All;
            aaa += aaa;
        }
    }
}
