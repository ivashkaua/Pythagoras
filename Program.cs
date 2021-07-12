using System;

namespace _01_Pythagoras_upd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Рекомендуемый диапазон значений от 0 до 40\n");
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

            // определяем количество цифр в максимальном числе таблицы

            int numberofdigits = 0;
            int biggestnumber = HighHor * HighVer;

            while (biggestnumber > 0)
            {
                numberofdigits++;
                biggestnumber /= 10;
            }

            //Console.WriteLine(numberofdigits); // Количество цифр в максимальном числе в таблице 

            // Определяем максимальное число в вертикальном ряду

            int numberofvertdigits = 0;
            int HighVertDigits = HighVer;
            while (HighVertDigits > 0)
            {
                numberofvertdigits++;
                HighVertDigits /= 10;
            }

            //Console.WriteLine(numberofvertdigits); // Количество цифр в максимальном числе вертикального ряда

            Console.WriteLine();



            // Пробелы в первом ряду до разделителя |

            int numberofspaces = numberofvertdigits;
            
            while (0 <= numberofspaces + 1)
            {
                Console.Write(space);
                numberofspaces = numberofspaces - 1;
            }

            Console.Write("|");



            // Горизонтальный заглавный ряд

            for (int l = LowHor; l <= HighHor; l++)
            {
                int numberofHORdigits = 0;
                int HORspace = l;
                while (HORspace > 0)
                {
                    numberofHORdigits++;
                    HORspace /= 10;       
                }
                int HorDIFF = numberofdigits - numberofHORdigits + 1;
                while (0 <= HorDIFF)
                {
                    Console.Write(space);
                    HorDIFF--;
                }
                Console.Write(l);
            }
            Console.WriteLine();


            // Подчеркивание заглавного ряда

            int numberofminuses = numberofvertdigits;

            while (0 <= numberofminuses + 1)
            {
                Console.Write("-");
                numberofminuses = numberofminuses - 1;
            }

            Console.Write("+");


            int counter = HighHor - LowHor + 1;

            while (0 < counter)
            {
                int numberofhorizontalminusblock = numberofdigits;
                while (0 <= numberofhorizontalminusblock)

                {
                    Console.Write("-");
                    numberofhorizontalminusblock--;
                }
                Console.Write("-");
                counter--;

            }



            // Основная таблица        
            
            Console.WriteLine();
            for (int b = LowVer; b <= HighVer; b++)
            {

                int vertSpace = 0;
                int vertnumber = b;
                while (vertnumber > 0)
                {
                    vertSpace++;
                    vertnumber /= 10;
                }
                while (numberofvertdigits - vertSpace + 1 > 0)
                {
                    Console.Write(space);
                    vertSpace++;
                }

                Console.Write(b + " |");


                for (int a = LowHor; a <= HighHor; a++)
                {
                    int numberofMAINdigits = 0;
                    int MAINspace = a * b;
                    while (MAINspace > 0)
                    {
                        numberofMAINdigits++;
                        MAINspace /= 10;
                    }
                    int MainDIFF = numberofdigits - numberofMAINdigits + 1;
                    while (0 <= MainDIFF)
                    {
                        Console.Write(space);
                        MainDIFF--;
                    }

                    Console.Write(a*b);

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