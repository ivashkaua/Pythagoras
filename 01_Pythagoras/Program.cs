using System;

namespace _01_Pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рекомендуемый диапазон значений от 0 до 40\n");
            Console.Write("Введите минимальное число для горизонтали:\t");
            int LowHor = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите максимальное число для горизонтали:\t");
            int HighHor = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите минимальное число для вертикали:\t");
            int LowVer = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите максимальное число для вертикали:\t");
            int HighVer = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Горизонтальный диапазон:\t от {LowHor} до {HighHor}\n");
            Console.WriteLine($"Вертикальный диапазон:  \t от {LowVer} до {HighVer}\n");
            Console.WriteLine("Таким образом, таблица Пифагора для выбранного диапазонов выглядит следующим образом:");
            Console.WriteLine();

            string space = " ";

            Console.Write("    |");

            for (int l = LowHor; l <= HighHor; l++)
            {
                int HH = 0;

                if (l < 10)
                {
                    HH = 4;
                }
                else if (l >= 10 && l < 100)
                {
                    HH = 3;
                }
                else if (l >= 100 && l < 1000)
                {
                    HH = 2;
                }
                else
                {
                    HH = 1;
                }

                int K = HH;
                while (0 < K)
                {
                    Console.Write(space);
                    K = K - 1;
                }
                Console.Write(l);
            }
            Console.WriteLine();
            Console.Write("----+");

            for (int l = LowHor; l <= HighHor; l++)
            {
                //int Y = HH;
                //while (0 < Y)
                //{
                Console.Write("-----");
                //    Y = Y - 1;
                //}
            }
            Console.WriteLine();

            for (int b = LowVer; b <= HighVer; b++)
            {
                int JJ = 0;

                if (b < 10)
                {
                    JJ = 2;
                }
                else
                {
                    JJ = 1;
                }

                int M = JJ;
                while (0 < M)
                {
                    Console.Write(space);
                    M = M - 1;
                }
                Console.Write(b + " |");

                for (int a = LowHor; a <= HighHor; a++)
                {
                    int HH = 0;

                    if (a * b < 10)
                    {
                        HH = 4;
                    }
                    else if (a * b >= 10 && a * b < 100)
                    {
                        HH = 3;
                    }
                    else if (a * b >= 100 && a * b < 1000)
                    {
                        HH = 2;
                    }
                    else
                    {
                        HH = 1;
                    }

                    int P = HH;
                    while (0 < P)
                    {
                        Console.Write(space);
                        P = P - 1;
                    }
                    Console.Write(a * b);

                }
                Console.WriteLine();
            }


            Console.WriteLine();

            Console.WriteLine("\nВНИМАНИЕ!!!");
            Console.WriteLine();
            Console.WriteLine("\nСпасибо за внимание!");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}