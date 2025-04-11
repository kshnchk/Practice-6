/*
Заполните массив длины n с клавиатуры. Вывести на экран True, если все
элементы массива являются чётными числами, иначе вывести False.
*/

namespace задание_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива n: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine($"Введите {n} элементов массива:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            bool allEven = true;
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 != 0) 
                {
                    allEven = false;
                    break;
                }
            }
            if (allEven)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
