using System;
using System.IO;

namespace TextEditor
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
            Console.WriteLine("TextEditor");
            Console.WriteLine("-------------------");
            Console.WriteLine("1 - Create new file");
            Console.WriteLine("2 - Open file");
            Console.WriteLine("0 - Exit");

            short options = short.Parse(Console.ReadLine());
            switch (options)
            {
                case 1: Criar(); break;
                case 2: Abrir(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Criar()
        {
            Console.Clear();
            Console.WriteLine("Type your text here (ESC to exit):");
            Console.WriteLine("----------------------");

            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }

        static void Salvar(string text)
        {
            Console.Clear();
            // Need to discover why code is deleting first letter on the next line!
            Console.WriteLine("aWhat path to save the file?");
            // suggested file to be saved: C:\coding\Github-Course\Courses-C-Sharp-dotNET\01-Course-Balta-io-Fundamentos-do-C-sharp\TextEditor\test.txt
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"File {path} successfully saved");
            Console.ReadLine();
            Menu();
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("What is the file path?");
            // suggested file to be opened: C:\coding\Github-Course\Courses-C-Sharp-dotNET\01-Course-Balta-io-Fundamentos-do-C-sharp\TextEditor\test.txt
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
    }
}
