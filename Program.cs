using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите операцию, которую Вы хотите выполнить: ");
            Console.WriteLine("1. Сложить числа");
            Console.WriteLine("2. Вычесть первое число из второго");
            Console.WriteLine("3. Перемножить числа");
            Console.WriteLine("4. Разделить первое число на второе");
            Console.WriteLine("5. Возвести первое число в степень N");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал числа");
            Console.WriteLine("9. Выход из программы");

            while (true)


            {

                int c = Convert.ToInt32(Console.ReadLine());

                if (c == 8)
                {

                    int x = 1;
                    Console.WriteLine("Введите число: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= a; i++)
                    {
                        x = x * i;


                    }
                    Console.WriteLine(x);

                }
                if (c == 5)
                {
                    Console.WriteLine("Введите число: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите степень числа: ");
                    double n = Convert.ToDouble(Console.ReadLine());
                    x = Math.Pow(x, n);
                    Console.WriteLine(x);

                }
                if (c == 1)
                {
                    Console.WriteLine("Введите первое число: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(a + x);
                }
                if (c == 2)
                {
                    Console.WriteLine("Введите первое число: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(x - a);
                }
                if (c == 3)
                {
                    Console.WriteLine("Введите первое число: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(a * x);
                }
                if (c == 4)
                {
                    Console.WriteLine("Введите первое число: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    if (a == 0)
                        Console.WriteLine("Ошибка");
                    else
                        Console.WriteLine(x / a);
                }
                if (c == 9)
                {
                    Environment.Exit(0);
                }
                if (c == 6)
                {
                    Console.WriteLine("Введите число: ");
                    double x = Convert.ToDouble(Console.ReadLine());

                    if (x < 0)
                    {
                        Console.WriteLine("Ошибка");
                    }
                    else
                    {
                        x = Math.Sqrt(x);
                        Console.WriteLine(x);
                    }
                }
                if (c == 7)
                {

                    Console.WriteLine("Введите число: ");
                    double x = Convert.ToDouble(Console.ReadLine());

                    x = x * 1;
                    x = x / 100;
                    Console.WriteLine(x);

                }
                if (c < 1 || c > 9)
                {
                    Console.WriteLine("Извините, но операции под таким номером нет");
                }
                Console.WriteLine("Повторно выберите операцию: ");
            }







        }
    }
}





