using System.IO;

namespace Katena.TestProg
{
    public class Test_1
    {
        ///Создание теста на базе файла в БД

        int quection_count; // кол-во вопросов
        int distr_hunter; //гендерному дистрибутиву охотник
        int distr_mentor; //гендерному дистрибутиву наставник
        int distr_looking;//гендерному дистрибутиву Ищущий
        int psih_style;// психотип стиль
        int psih_distr; // психотип дистрибутив

        int style_P;//стиль управления процесами Производитель
        int style_A;//стиль управления процесами Администратор
        int style_E;//стиль управления процесами Предпренематель
        int style_I;//стиль управления процесами Интегратор

        string[] array; //масив  даных 

        StreamReader Read; //Считываем инфу из файла

        private void start()
        {
            var encoding =System.Text.Encoding.GetEncoding("UTF-8");  //Кодировка  файла (1251) можно  заменить для кирилицы
            
            try
            {
                Read  = new StreamReader(
                    Directory.GetCurrentDirectory() + "@\t.txt", encoding); // Проверка на ошибки чтения из файла

                // Text = Read.ReadLine(); // Добавляем в поле сайта когда будет 
                array = new string[15]; // иницилизайия масива на 15 вопроов !!!!! Важно сделать редактируемым в админке
            }
            catch(Exception)
            {
                /// вывод ошибки 
                
            }
            question();
        }

        private void question()// вопрос
        {

            // Считываем информацию с файла 
            // считали и вывели вопрос
            ///считали и вывели варианты ответа
            ///считали результат и записали в нужную форму стиля и тд
            ///и перешли в следуший вопрос мативации

            motivation();
        }

        private void motivation() // мотивация
        {
            //Считываем информацию с файла
            // считали и вывели вопрос
            ///считали и вывели варианты ответа
            ///считали результат и записали в нужную форму стиля и тд
            ///и перешли в следуший вопрос 
            ///увеличить счетчик вопроов на 1
            quection_count ++;
            //Проверка файла на конец
            if(Read.EndOfStream == true)
            {
                //вывод результата
            }
            question();
        }
    }
}
