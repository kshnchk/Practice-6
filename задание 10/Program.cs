/*
Заполните массив длины n с клавиатуры. Вывести на экран True, если
есть хотя бы 1 отрицательный элемент.
*/

namespace задание_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива n: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            bool Negative = false;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    Negative = true; 
                    break; 
                }
            }
            if (Negative)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
    }
}
