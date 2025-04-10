/*
Задан одномерный массив чисел длины n (n – вводится с клавиатуры).
Заполнить его числами Фибоначчи.
Последовательность чисел Фибоначчи: n0 = 0, n1=1, …, ni = ni-1 + ni-2, где i –
номер элемента последовательности; пример: n0=0, n1=1, n2=1+0=1,
n3=1+1=2 и т.д. Если N=45, то последовательность будет: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55
*/

namespace задание_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            long[] fibonacci = new long[n];
            if (n >= 1)
            {
                fibonacci[0] = 0;
            }
            if (n >= 2)
            {
                fibonacci[1] = 1;
            }
            for (int i = 2; i < n; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2]; 
            }
            Console.WriteLine("Последовательность Фибоначчи:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(fibonacci[i]);
            }
        }
    }
}
