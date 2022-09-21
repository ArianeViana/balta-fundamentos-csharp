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
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {

                case 0:
                    System.Environment.Exit(0);
                    break;

                case 1:
                    Abrir();
                    break;

                case 2:
                    Criar();
                    break;

                default:
                    Menu();
                    break;

            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual é o caminho do arquivo?");
            string path = Console.ReadLine();

            using (var arquivo = new StreamReader(path))
            {
                string texto = arquivo.ReadToEnd();
                Console.WriteLine(texto);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Criar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("---------------------------------------");

            string texto = "";

            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(texto);
        }

        static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var arquivo = new StreamWriter(path))
            {
                arquivo.Write(texto);
            }

            Console.WriteLine($"Arquivo salvo com sucesso em {path}.");
            Console.ReadLine();
            Menu();
        }
    }
}