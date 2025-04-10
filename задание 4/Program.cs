/*
Задан одномерный массив целых чисел длины 17 Определить среднее
значение нечетных положительных элементов массива.
*/

namespace задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[17];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 101);
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            double sum = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0 && arr[i] % 2 != 0)
                {
                    sum += arr[i];
                    count++;
                }
            }
            double average = sum / count;
            Console.WriteLine($"Среднее значение положительных нечетных элементов: {average}");
        }
    }
}