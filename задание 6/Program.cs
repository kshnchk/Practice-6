/*
В массиве хранятся цены на 15 видов товаров. С помощью датчика
случайных чисел заполнить массив целыми значениями, лежащими в
диапазоне от 20 до 300 включительно. Определить цену самого дешевого
товара и его порядковый номер.
*/

namespace задание_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[15];
            Random rand = new Random();
            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] = rand.Next(20, 301); 
            }
            Console.WriteLine("Цены на товары:");
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine($"Товар {i + 1}: {prices[i]}");
            }
            int minPrice = prices[0];
            int minIndex = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                    minIndex = i;
                }
            }
            Console.WriteLine($"Самая дешевая цена: {minPrice} на товар {minIndex + 1}");
        }
    }
}
