/*
Дан массив длины n. Написать программу, которая генерирует новый
массив, в котором нет нечётных элементов.
*/

namespace задание_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива n: ");
            int n = int.Parse(Console.ReadLine());
            int[] originalArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                originalArray[i] = int.Parse(Console.ReadLine());
            }
            int evenCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (originalArray[i] % 2 == 0)
                {
                    evenCount++; 
                }
            }
            int[] evenArray = new int[evenCount];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                if (originalArray[i] % 2 == 0)
                {
                    evenArray[index] = originalArray[i];
                    index++;
                }
            }
            Console.WriteLine("Массив четных элементов:");
            for (int i = 0; i < evenCount; i++)
            {
                Console.WriteLine(evenArray[i]);
            }
        }
    }
}
