using System;

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
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {

                case 0: System.Environment.Exit(0); break;
                case 1: abrir(); break;
                case 2: editar(); break;
                default: Menu(); break;
            }
        }

        static void abrir()
        {

        }

        static void editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo");
            Console.WriteLine("---------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Write(text);
        }
    }
}
