/*
Найти сумму массива длины n (значение n вводится с клавиатуры) с элементами:
1. 1, — 1/2, 1/3, -1/4, ..., ((-1)**n)/n
2. x, (x**3)/3, ..., (x**n)/n
3. 1, 1/(2!), 1/(3!), ..., 1/(k!), ..., 1/(n!), где 1 <= k <= n, k! = 1 · 2 · 3 · ... · k.
*/

namespace задание_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("задание 1");
            double sum1 = 0;
            for (int i = 1; i <= n; i++)
            {
                sum1 += Math.Pow(-1, i) / i;
            }
            Console.WriteLine($"Сумма для массива 1, -1/2, 1/3, -1/4, ..., ((-1)**n)/n: {sum1}");

            Console.WriteLine("задание 2");
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            double sum2 = 0;
            for (int i = 1; i <= n; i++)
            {
                sum2 += Math.Pow(x, i) / i;
            }
            Console.WriteLine($"Сумма для массива x, (x**3)/3, ..., (x**n)/n: {sum2}");

            Console.WriteLine("задание 3");
            double sum3 = 0;
            double factorial = 1; 
            for (int k = 1; k <= n; k++)
            {
                if (k > 1)
                {
                    factorial *= k; 
                }
                sum3 += 1 / factorial; 
            }
            Console.WriteLine($"Сумма для массива 1, 1/(2!), 1/(3!), ..., 1/(n!): {sum3}");
        }
    }
}
