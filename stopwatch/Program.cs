using System;
using System.Threading;

namespace Stopwatch
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
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 2m = 2 minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();

            if (data.Length > 1)
            {
                char type = char.Parse(data.Substring(data.Length - 1, 1));
                int time = int.Parse(data.Substring(0, data.Length - 1));

                if (type == 'm')
                {
                    PreStart(time * 60);
                    Menu();
                }
                else if (type == 's')
                {
                    PreStart(time);
                    Menu();
                }
                else
                {
                    Console.WriteLine("Opção Inválida!");
                    Thread.Sleep(1000);
                    Menu();
                }

            }

            if (data.Length == 1)
            {
                string option = data;

                if (option == "0")
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Opção Inválida!");
                    Thread.Sleep(1000);
                    Menu();
                }
            }

        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }
    }
}