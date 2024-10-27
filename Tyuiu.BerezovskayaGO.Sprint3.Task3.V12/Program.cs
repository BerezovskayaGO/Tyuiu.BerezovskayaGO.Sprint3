using Tyuiu.BerezovskayaGO.Sprint3.Task3.V12.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint3.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Березовская Г. О. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                                             *");
            Console.WriteLine("* Задание #3                                                                               *");
            Console.WriteLine("* Вариант #15                                                                              *");
            Console.WriteLine("* Выполнила: Березовская Галина Олеговна | АСОиУБ - 24-1                                   *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв k,                        *");
            Console.WriteLine("* находящихся на соседних позициях в строке: bkkrk ckkkcs ksr                              *");
            Console.WriteLine("*                                                                                          *");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            string value = "bkkrk ckkkcs ksr";
            char item = 'k';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый символ = " + item);

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Максимальное количество букв k = " + ds.GetMaxCharCount(value, item));

            Console.ReadKey();
        }
    }
}
