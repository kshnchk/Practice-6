/*
Задан одномерный массив целых чисел длины 20 Просуммировать все
отрицательные элементы, стоящие на нечетных местах.
*/

namespace задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
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
            int sum = 0;
            for (int i = 1; i < arr.Length; i += 2)
            {
                if (arr[i] < 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine($"Сумма отрицательных элементов на нечетных местах: {sum}");
        }
    }
}
