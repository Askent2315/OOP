using System;
namespace labs
{
    //Консольная программа
    class labs
    {
        static void Main(string[] args)
        {
            
            string W = "0";
            string str_Input = "";
            while (W != "exit")
            {
                Console.WriteLine("Введите номер лабораторной");
                Console.WriteLine("Для выхода напишите exit");
                str_Input = Console.ReadLine();
                W = str_Input;
                str_Input = "";
                Console.WriteLine($"{W} лабораторная");
                switch (W)
                {
                    case "1":
                        {
                            Console.WriteLine("----------------------------------------------------------------------------------------------");
                            Console.WriteLine($" задание");
                            Console.WriteLine("            -a * (q - b)");
                            Console.WriteLine("R =  exp --------------------  + 1");
                            Console.WriteLine("                q - 6");
                            double R, a, q, b;
                            R = a = q = b = 0;
                            Console.WriteLine("Введите a:");
                            a = LibClass.ReadToConvertDouble(a);
                            Console.WriteLine("Введите q:");
                            q = LibClass.ReadToConvertDouble(q);
                            Console.WriteLine("Введите b:");
                            b = LibClass.ReadToConvertDouble(b);

                            R = LibClass.task1(a, b, q);

                            //R = Math.Exp(((-1) * a * (q - b) / (q - 6)) + 1);
                            Console.WriteLine($"            -{a} * ({q} - {b})");
                            Console.WriteLine($"R =  exp -------------------- + 1 = {R}");
                            Console.WriteLine($"              {q} - 6");
                            Console.WriteLine("----------------------------------------------------------------------------------------------");
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("----------------------------------------------------------------------------------------------");
                            double x, y, z;
                            x = y = z = 0;
                            Console.WriteLine("     max(x^2+y+z, xyz)");
                            Console.WriteLine("q = -------------------");
                            Console.WriteLine("     min(x^2+y+z, xyz)");
                            Console.WriteLine("Введите x:");
                            x = LibClass.ReadToConvertDouble(x);
                            Console.WriteLine("Введите y:");
                            y = LibClass.ReadToConvertDouble(y);
                            Console.WriteLine("Введите z:");
                            z = LibClass.ReadToConvertDouble(z);
                            //Console.WriteLine(x*x+y+z);
                            //Console.WriteLine(x*y*z);
                            Console.WriteLine($"     max({x}^2+{y}+{z}, {x}*{y}*{z})");
                            Console.WriteLine($"q = --------------------------------  = {LibClass.task2(x, y, z)}");
                            Console.WriteLine($"     min({x}^2+{y}+{z}, {x}*{y}*{z})");
                            Console.WriteLine("----------------------------------------------------------------------------------------------");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("----------------------------------------------------------------------------------------------");
                            double Xn, Xk;
                            Xn = Xk = 0;
                            double[,] Result = new double[11, 2];
                            Console.WriteLine("2^x              \t x E [Xn, Xk]\n");
                            Console.WriteLine("_N_");
                            Console.WriteLine(@"\   ln(2)^n * x^n");
                            Console.WriteLine("/__       n!     \t N = 10");
                            Console.WriteLine("n=0");
                            Console.WriteLine("Введите Xn:");
                            Xn = LibClass.ReadToConvertDouble(Xn);
                            Console.WriteLine("Введите Xk:");
                            Xk = LibClass.ReadToConvertDouble(Xk);
                            double h = (Xk - Xn) / 10;
                            Console.WriteLine("----------------------------------------------------------------------------------------------");
                            Console.WriteLine("| #N |           Y(x)            || #N |           S(x)            |            x            |");
                            Console.WriteLine("----------------------------------------------------------------------------------------------");
                            Result = LibClass.task3(Xn, Xk);
                            for (int i = 0; i < 10; i++) 
                            {

                                //Вывод
                                Console.Write("|{0, -4}| 2^x = {1, -20}|", i, Result[i, 0]);
                                Console.WriteLine("|{0, -4}| SUM = {1,-20}| X = {2,-20}|", i, Result[i, 1], Xn);
                                //Обнуление результатов и увеличение счетчика цикла
                                //Result1 = 0;
                                //Result2 = 0;
                                Xn = Math.Round(Xn + h, 2);
                            }
                            Console.WriteLine("----------------------------------------------------------------------------------------------");
                            break;
                        }
                    case "4":
                        {
                            Random rnd = new Random();
                            Console.WriteLine("----------------------------------------------------------------------------------------------");
                            int N = 10;
                            int imax = 0;
                            Console.WriteLine("Введите длину массива");
                            N = Convert.ToInt32(Console.ReadLine());
                            int[] A = new int[N];
                            Console.Write($"A[{N}] =");
                            for (int i = 0; i < N; i++)
                            {
                                A[i] = rnd.Next(100);
                                Console.Write($" {A[i]}");
                            }
                            imax = LibClass.task4(A);
                            Console.WriteLine($"\nAmax = {A[imax]}");
                            Console.WriteLine($"imax = {imax}");
                            Console.Write($"A[{N}] =");
                            for (int i = 0; i < N; i++)
                            {
                                if (i != imax)
                                {
                                    Console.Write($" {A[i]}");
                                }
                                else
                                {
                                    Console.Write($"->{A[i]}<-");
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("----------------------------------------------------------------------------------------------");
                            break;
                        }
                    default:
                        {
                            if (W == "exit")
                            {
                                break;
                            }
                            Console.WriteLine("Введен не корректный номер лабораторной");
                            break;
                        }
                }
            }
        }
    }
}

