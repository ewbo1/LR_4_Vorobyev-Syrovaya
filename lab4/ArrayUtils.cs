using System;
using System.Collections.Generic;

namespace lab4
{
    public static class ArrayUtils
    {
        public static double FindMaxAbsolute(double[] a)
        {
            if (a == null) throw new ArgumentNullException(nameof(a));
            if (a.Length == 0) throw new ArgumentException("Массив не должен быть пустым.", nameof(a));

            double max = Math.Abs(a[0]);
            for (int i = 1; i < a.Length; i++)
            {
                double absVal = Math.Abs(a[i]);
                if (absVal > max) max = absVal;
            }
            return max;
        }
    }
}
