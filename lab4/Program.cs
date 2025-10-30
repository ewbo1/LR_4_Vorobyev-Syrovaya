using System;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            var rnd = new Random();
            double[] arr = new double[n];
            Console.WriteLine("Сгенерирован массив из {0} элементов (диапазон [-100, 100]):", n);
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.NextDouble() * 200.0 - 100.0;
                Console.WriteLine($"a[{i}] = {arr[i]:F6}");
            }
            double maxAbs = ArrayUtils.FindMaxAbsolute(arr);
            Console.WriteLine();
            Console.WriteLine($"Максимум из модулей элементов: {maxAbs:F6}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
