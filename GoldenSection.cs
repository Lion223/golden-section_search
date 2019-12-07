using System;

namespace SearchMethods
{
    public static class GoldenSection
    {
        // target function
        private static double Func(double x) =>
            Math.Pow(x, 4) + 2 * Math.Pow(x, 2) + 4 * x + 1;

        // main method
        public static void FindMinX(double _a, double _b, double _e)
        {
            double a = _a, b = _b, e = _e, i = 0, l, k, x1, x2, x;
            l = b - a;
            k = (-1 + Math.Sqrt(5)) / 2;
            x1 = a + (1 - k) * l;
            x2 = a + k * l;

            while (Math.Abs(l) > e)
            {
                Console.WriteLine($"#{i}: f(x1) = {Func(x1)}; f(x2) = {Func(x2)}");
                Console.WriteLine($"a({i}) = {a}; b({i}) = {b}");

                i++;

                if (Func(x1) < Func(x2))
                {
                    b = x2;
                    x2 = x1;
                    l = b - a;
                    x1 = a + (1 - k) * l;
                }
                else if (Func(x1) > Func(x2))
                {
                    a = x1;
                    x1 = x2;
                    l = b - a;
                    x2 = a + k * l;
                }

                if (Math.Abs(l) < e)
                {
                    x = (a + b) / 2;
                    Console.WriteLine($"x(min) = {x}; f(x(min)) = {Func(x)}");
                }
            }
        }
    }
}
