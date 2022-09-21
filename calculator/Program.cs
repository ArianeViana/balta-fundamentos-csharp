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
            Console.WriteLine("=====CALCULADORA=====");
            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("1-SOMA / 2-SUBTRAÇÃO / 3-MULTIPLICAÇÃO / 4-DIVISÃO / 5-SAIR");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void Soma()
        {
            //limpa o console
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            //Console.ReadLine trabalha com strings por isso é necessário fazer a conversão dos tipos
            float primeiroValor = float.Parse(Console.ReadLine());


            Console.WriteLine("Segundo valor:");
            float segundoValor = float.Parse(Console.ReadLine());

            float soma = primeiroValor + segundoValor;

            Console.WriteLine($"O resultado da soma é {soma}.");

            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float primeiroValor = float.Parse(Console.ReadLine());


            Console.WriteLine("Segundo valor:");
            float segundoValor = float.Parse(Console.ReadLine());

            float subtracao = primeiroValor - segundoValor;

            Console.WriteLine($"O resultado da subtração é {subtracao}.");

            //para a aplicação não encerrar sozinha
            Console.ReadKey();
            Menu();

        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float segundoValor = float.Parse(Console.ReadLine());

            float divisao = primeiroValor / segundoValor;

            Console.WriteLine($"O resultado da subtração é {divisao}.");

            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float segundoValor = float.Parse(Console.ReadLine());

            float multiplicacao = primeiroValor * segundoValor;

            Console.WriteLine($"O resultado da multiplicação é {multiplicacao}.");

            Console.ReadKey();
            Menu();
        }
    }
}
