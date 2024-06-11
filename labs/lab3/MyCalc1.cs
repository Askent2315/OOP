using System;
using System.Collections.Generic;
using System.Text;

namespace labs
{
    public class MyCalc1
    {
        //
        //Для 3 лабораторной
        //
        public static string task5(double a, double b)
        {
            string Result = "";
            if ((a == 0) || (b == 0))
            {
                Result = "Деление на 0!";
            }
            else
            {
                Result = Convert.ToString((a + b) / b + (a - b) / a);
            }
            return Result;
        }
    }
    public class MyCalc2 : MyCalc1
    {
        public static string task6(double a, double b, double d)
        {
            string Result = "";
            if (d == 0)
            {
                Result = "Деление на 0!";
            }
            else
            {
                if (d < a)
                {
                    if (a == 0)
                    {
                        Result = "Деление на 0!";
                    }
                    else
                    {
                        Result = Convert.ToString((a + b) / d + (a - b) / a);
                    }
                }
                else
                {
                    Result = Convert.ToString((a - b) / d);
                }
            }
            return Result;
        }
        public static int task7()
        {
            return 0;
        }
    }
}
