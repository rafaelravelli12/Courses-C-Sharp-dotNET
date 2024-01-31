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

            Console.WriteLine("o que deseja fazer:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair do programa");
            Console.WriteLine("----------------------");
            Console.WriteLine("Selecione uma das opções:");
            short res = short.Parse(Console.ReadLine());

            // if (res == 1)
            // {
            //     Soma();
            // }
            // if (res == 2)
            // {
            //     Subtracao();
            // }
            // if (res == 3)
            // {
            //     Multiplicacao();
            // }
            // if (res == 4)
            // {
            //     Divisao();
            // }

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
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float result = v1 + v2;

            Console.WriteLine("");
            // Console.WriteLine("O resultado da soma é: " + result);
            // Console.WriteLine("O resultado da soma é: " + (v1 + v2)); // entre parênteses para que seja entendida a operação aritmética
            // Console.WriteLine($"O resultado da soma é: {v1 + v2}");
            Console.WriteLine($"O resultado da soma é: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float result = v1 - v2;

            Console.WriteLine($"O resultado da subtração é: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float result = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float result = v1 / v2;

            Console.WriteLine($"O resultado da divisão é: {result}");
            Console.ReadKey();
            Menu();
        }
    }
}
