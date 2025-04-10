/*
Создать одномерный массив длины 10 и записать в каждый элемент
массива число M (M вводится с клавиатуры).
*/

namespace задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len = 10;
            int[] arr = new int[len];
            Console.Write("Введите число: ");
            int m = Convert.ToInt32(Console.ReadLine()); 
            for (int i = 0; i < len; i++)
            {
                arr[i] = m;
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
