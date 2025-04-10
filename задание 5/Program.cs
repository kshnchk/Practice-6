/*
Задан одномерный массив целых чисел array размера n (n – вводится с
клавиатуры). Элементы массива вводить с помощью генератора рандомных
чисел. Для выполнения каждой задачи создать метод, который принимает
на вход массив и возвращает значение в соответствии с задачей.
1. Найти сумму элементов с четными индексами.
2. Найти минимальный элемент среди положительных элементов.
3. Найти сумму максимального и минимального элементов.
4. Найти количество положительных элементов.
5. Определить сумму четных положительных элементов массива с
индексами с a-го по b-й (a и b вводятся с клавиатуры).
6. Найти среднее значение чётных элементов.
7. Определить сумму чётных положительных элементов массива.
8. Просуммировать все неотрицательные элементы, стоящие на четных
местах.
9. Найти максимальный элемент среди элементов с a-го по b-й и его
индекс (a и b вводятся с клавиатуры).
10. Найти минимальный элемент среди элементов, стоящих на четных
позициях и его номер.
11. Найти минимальный элемент среди элементов массива с a-го по b-й
и его индекс (a и b вводятся с клавиатуры).
12. Найти среднее арифметическое элементов с нечетными индексами.
13. Найти среднее арифметическое элементов, не превышающих 50
14. Сформировать два массива, в первый - элементы исходного
массива с четными индексами, а во второй - с нечетными индексами.
15. Сформировать два массива, в первый - четные элементы исходного
массива с нечетными индексами, а во второй нечетные элементы с
четными индексами.
*/

namespace задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-100, 101);
            }
            Console.WriteLine("Элементы массива:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("задание 1");
            int sumEvenIdx = 0;
            for (int i = 0; i < n; i += 2)
            {
                sumEvenIdx += arr[i];
            }
            Console.WriteLine($"Сумма элементов с четными индексами: {sumEvenIdx}");

            Console.WriteLine("задание 2");
            int minPos = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0 && arr[i] < minPos)
                {
                    minPos = arr[i];
                }
            }
            Console.WriteLine($"Минимальный элемент среди положительных: {minPos}");


            Console.WriteLine("задание 3");
            int minElem = int.MaxValue, maxElem = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < minElem)
                {
                    minElem = arr[i];
                }
                else if (arr[i] > maxElem)
                {
                    maxElem = arr[i];
                }
            }
            Console.WriteLine($"Сумма максимального и минимального: {minElem + maxElem}");

            Console.WriteLine("задание 4");
            int countPos = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0) countPos++;
            }
            Console.WriteLine($"Количество положительных: {countPos}");

            Console.WriteLine("задание 5");
            Console.Write("Введите индекс a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите индекс b: ");
            int b = int.Parse(Console.ReadLine());
            int sumEvenPosInRange = 0;
            for (int i = a; i <= b && i < n; i++)
            {
                if (arr[i] > 0 && arr[i] % 2 == 0)
                {
                    sumEvenPosInRange += arr[i];
                }
            }
            Console.WriteLine($"Сумма четных положительных с индекса {a} по {b}: {sumEvenPosInRange}");

            Console.WriteLine("задание 6");
            double sumEven = 0;
            int countEven = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sumEven += arr[i];
                    countEven++;
                }
            }
            if (countEven > 0)
            {
                Console.WriteLine($"Среднее значение чётных элементов: {sumEven / countEven}");

                Console.WriteLine("задание 7");
                int sumEvenPos = 0;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] > 0 && arr[i] % 2 == 0)
                    {
                        sumEvenPos += arr[i];
                    }
                }
                Console.WriteLine($"Сумма четных положительных: {sumEvenPos}");

                Console.WriteLine("задание 8");
                int sumNonNegEvenIdx = 0;
                for (int i = 0; i < n; i += 2)
                {
                    if (arr[i] >= 0)
                    {
                        sumNonNegEvenIdx += arr[i];
                    }
                }
                Console.WriteLine($"Сумма неотрицательных на четных местах: {sumNonNegEvenIdx}");

                Console.WriteLine("задание 9");
                int maxInRange = int.MinValue;
                int maxIdx = -1;
                for (int i = a; i <= b && i < n; i++)
                {
                    if (arr[i] > maxInRange)
                    {
                        maxInRange = arr[i];
                        maxIdx = i;
                    }
                }
                Console.WriteLine($"Максимальный с индексов {a} по {b}: {maxInRange}, индекс: {maxIdx}");

                Console.WriteLine("задание 10");
                int minEvenPos = int.MaxValue;
                int minEvenIdx = -1;
                for (int i = 0; i < n; i += 2)
                {
                    if (arr[i] < minEvenPos)
                    {
                        minEvenPos = arr[i];
                        minEvenIdx = i;
                    }
                }
                Console.WriteLine($"Минимальный на четных позициях: {minEvenPos}, индекс: {minEvenIdx}");

                Console.WriteLine("задание 11");
                int minInRange = int.MaxValue;
                int minInRangeIdx = -1;
                for (int i = a; i <= b && i < n; i++)
                {
                    if (arr[i] < minInRange)
                    {
                        minInRange = arr[i];
                        minInRangeIdx = i;
                    }
                }
                Console.WriteLine($"Минимальный с индексов {a} по {b}: {minInRange}, индекс: {minInRangeIdx}");

                Console.WriteLine("задание 12");
                double sumOddIdx = 0;
                int countOddIdx = 0;
                for (int i = 1; i < n; i += 2)
                {
                    sumOddIdx += arr[i];
                    countOddIdx++;
                }
                Console.WriteLine($"Среднее на нечетных индексах: {(countOddIdx > 0 ? sumOddIdx / countOddIdx : 0)}");

                Console.WriteLine("задание 13");
                double sumLessThan50 = 0;
                int countLessThan50 = 0;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] <= 50)
                    {
                        sumLessThan50 += arr[i];
                        countLessThan50++;
                    }
                }
                Console.WriteLine($"Среднее элементов <= 50: {(countLessThan50 > 0 ? sumLessThan50 / countLessThan50 : 0)}");

                Console.WriteLine("задание 14");
                int[] evenIdxArr = new int[(n + 1) / 2];
                int[] oddIdxArr = new int[n / 2];
                int evenCount = 0, oddCount = 0;

                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenIdxArr[evenCount++] = arr[i];
                    }
                    else
                    {
                        oddIdxArr[oddCount++] = arr[i];
                    }
                }
                Console.WriteLine("Четные индексы:");
                for (int i = 0; i < evenCount; i++)
                {
                    Console.WriteLine(evenIdxArr[i]);
                }
                Console.WriteLine("Нечетные индексы:");
                for (int i = 0; i < oddCount; i++)
                {
                    Console.WriteLine(oddIdxArr[i]);
                }

                Console.WriteLine("задание 15");
                int[] evenOddArr = new int[n / 2];
                int[] oddEvenArr = new int[(n + 1) / 2];
                int evenOddCount = 0, oddEvenCount = 0;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] % 2 == 0 && i % 2 != 0)
                    {
                        evenOddArr[evenOddCount++] = arr[i];
                    }
                    else if (arr[i] % 2 != 0 && i % 2 == 0)
                    {
                        oddEvenArr[oddEvenCount++] = arr[i];
                    }
                }

                Console.WriteLine("Четные на нечетных индексах:");
                for (int i = 0; i < evenOddCount; i++)
                {
                    Console.WriteLine(evenOddArr[i]);
                }
                Console.WriteLine("Нечетные на четных индексах:");
                for (int i = 0; i < oddEvenCount; i++)
                {
                    Console.WriteLine(oddEvenArr[i]);
                }
            }
        }
    }
}
