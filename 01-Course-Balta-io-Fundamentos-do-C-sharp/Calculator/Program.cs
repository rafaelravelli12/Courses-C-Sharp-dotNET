using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Calculator");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Substraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("----------------------");
            Console.WriteLine("Choose one of the options: ");

            short res = short.Parse(Console.ReadLine());
            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
            }
        }

        static void Soma()
        {
            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());
            float result = v1 + v2;

            Console.WriteLine($"The sum result is: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());
            float result = v1 - v2;

            Console.WriteLine($"The substraction result is: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());
            float result = v1 * v2;

            Console.WriteLine($"The multiplication result is: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());
            float result = v1 / v2;

            Console.WriteLine($"The division result is: {result}");
            Console.ReadKey();
            Menu();
        }
    }
}
