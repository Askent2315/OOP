using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace labs
{
    public static class LibClass //Класс для счёта и вывода результатов
    {
        public static double ReadToConvertDouble(double N)
        {
            String str_Input;
            N = 0;
            str_Input = Console.ReadLine();
            N = Convert.ToDouble(str_Input);
            return N;
        }
        public static double Factorial(int x)
        {
            double Result = 1;
            for (int n = 1; n <= x; n++)
            {
                Result = Result * n;
            }
            if (x == 0) Result = 1;
            return Result;
        }
        public static double Max(double x, double y)
        {
            if (x >= y)
            {
                return x;
            }
            else
                return y;
        }
        public static double Min(double x, double y)
        {
            if (x <= y)
            {
                return x;
            }
            else
                return y;
        }

        public static double task1(double a, double b, double q)
        {
            double R = Math.Exp(((-1) * a * (q - b) / (q - 6))) + 1.0;
            return R;
        }
        public static double task2(double x, double y, double z)
        {
            double q = 0;
            q = Max(x * x + y + z, x * y * z) / Min(x * x + y + z, x * y * z);
            return q;
        }
        public static double[,] task3(double Xn, double Xk)
        {
            double[,] Result = new double[11, 2];
            double h = (Xk - Xn) / 10;
            int N = 10;
            int i = 0; //счётчик цикла
            double X = Xn;
            while (X <= Xk)
            {
                //Счёт Y(x)
                Result[i, 0] = Math.Pow(2, X);
                //Счёт S(x)
                for (int n = 0; n < N; n++)
                {
                    Result[i, 1] += (Math.Pow(Math.Log(2), n) / Factorial(n)) * Math.Pow(X, n);
                }
                X = Math.Round(X + h, 2);
                i++;
                if (X == Xk) break;
            }
      
            return Result;
        }
        public static int task4(int[] A)
        {
            int max = A[1]; int imax = 1;
            for (int i = 3; i < A.Length; i = i + 2)
            {
                if (A[i] > max)
                {
                    max = A[i]; imax = i;
                }
            }
            return imax;
        }
    }
}
