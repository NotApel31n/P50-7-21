using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main()
    {
        {
            Console.WriteLine("Введите число от 1 до 9 смотря какое действие вы хотите выполнить");
            Console.WriteLine("1. Сложить два числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти корень квадратный из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");
            string a;
            int a1;
            do
            {
                a = Console.ReadLine();
                a1 = Convert.ToInt32(a);

                if (a1 == 1)
                {
                    Console.WriteLine("Введите первое число: ");
                    string b = Console.ReadLine();
                    int b1 = Convert.ToInt32(b);
                    Console.WriteLine("Введите второе число: ");
                    string b6 = Console.ReadLine();
                    int b2 = Convert.ToInt32(b6);
                    int num = (b1 + b2);
                    Console.WriteLine("Сумма двух этих чисел: " + num);
                    Console.WriteLine("Введите число от 1 до 9 смотря какое действие вы хотите выполнить");
                }
                
               else if (a1 == 2) 
                {
                    Console.WriteLine("Введите первое число: ");
                    string b = Console.ReadLine();
                    int b1 = Convert.ToInt32(b);
                    Console.WriteLine("Введите второе число: ");
                    string b6 = Console.ReadLine();
                    int b2 = Convert.ToInt32(b6);
                    int num = (b1 - b2);
                    Console.WriteLine("Разность двух этих чисел: " + num);
                    Console.WriteLine("Введите число от 1 до 9 смотря какое действие вы хотите выполнить");
                }
                  
                else if (a1 == 3) 
                {
                    Console.WriteLine("Введите первое число: ");
                    string b = Console.ReadLine();
                    int b1 = Convert.ToInt32(b);
                    Console.WriteLine("Введите второе число: ");
                    string b6 = Console.ReadLine();
                    int b2 = Convert.ToInt32(b6);
                    int sum = (b1 * b2);
                    Console.WriteLine("Произведение двух этих чисел: " + sum);
                    Console.WriteLine("Введите число от 1 до 9 смотря какое действие вы хотите выполнить");
                }
                
                else if (a1 == 4) 
                {
                    Console.WriteLine("Введите первое число: ");
                    string b = Console.ReadLine();
                    int b1 = Convert.ToInt32(b);
                    Console.WriteLine("Введите второе число: ");
                    string b6 = Console.ReadLine();
                    int b2 = Convert.ToInt32(b6);
                    int sum = (b1/b2);
                    Console.WriteLine("Результат деления двух этих чисел: " + sum);
                    Console.WriteLine("Введите число от 1 до 9 смотря какое действие вы хотите выполнить");
                }
                
                else if (a1 == 5) 
                {
                    Console.WriteLine("Введите число: ");
                    string b = Console.ReadLine();
                    int b1 = Convert.ToInt32(b);
                    Console.WriteLine("Введите его степень  : ");
                    b = Console.ReadLine();
                    int N = Convert.ToInt32(b);
                    int b2 = 1;
                    for (int i = 0; i < N; i++)
                    {
                        b2 = b1 * b2;
                    }
                    Console.WriteLine("Результат возведения числа в степень "+N+" : " + b2);
                    Console.WriteLine("Введите число от 1 до 9 смотря какое действие вы хотите выполнить");
                }

                else if (a1 == 6) 
                {
                    Console.WriteLine("Введите число: ");
                    string b = Console.ReadLine();
                    double b1 = Convert.ToInt32(b);
                    b1 = Math.Sqrt(b1);
                 
                    Console.WriteLine("корень этого числа: " + b1);
                    Console.WriteLine("Введите число от 1 до 9 смотря какое действие вы хотите выполнить");
                }
                else if (a1 == 7) 
                {
                    Console.WriteLine("Введите число: ");
                    string b = Console.ReadLine();
                    float b1 = Convert.ToInt32(b);
                    b1 = (b1 / 100);
                    Console.WriteLine("Один процент от числа равен: " + b1);
                    Console.WriteLine("Введите число от 1 до 9 смотря какое действие вы хотите выполнить");
                }
                 else if (a1 == 8)
                {
                    Console.WriteLine("Введите число: ");
                    string b = Console.ReadLine();
                    int b1 = Convert.ToInt32(b);
                    int f = 1;
                    for (int i = 2; i <= b1; i++)
                    {
                        f = f * i;

                    }
                    Console.WriteLine("Факториал числа равен: " + f);
                    Console.WriteLine("Введите число от 1 до 9 смотря какое действие вы хотите выполнить");
                }
                else if(a1>9)
                {
                    Console.WriteLine("Введите число от 1 до 9 смотря какое действие вы хотите выполнить");
                }
                else if (a1 < 9)
                {
                    Console.WriteLine("Введите число от 1 до 9 смотря какое действие вы хотите выполнить");
                }



            }
            while (a1 != 9);
            Console.WriteLine("Конец программы");

        }
    }     
}
