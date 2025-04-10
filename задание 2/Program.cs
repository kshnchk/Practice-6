/*
Заполнить одномерный массив длины 8 вещественными числами,
вводимыми с клавиатуры. Найти среднее арифметическое положительных элементов.
*/

namespace задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len = 8;
            double[] arr = new double[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write($"Введите вещественное число для элемента {i + 1}: ");
                string input = Console.ReadLine();
                arr[i] = Convert.ToDouble(input);
            }
            double sum = 0;
            int count = 0;
            for (int i = 0; i < len; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                    count++;
                }
            }
            double average = sum / count;
            Console.WriteLine($"Среднее арифметическое положительных элементов: {average}");

        }
    }
}
