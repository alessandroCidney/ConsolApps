using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = Start();

            Operations(option);
        }

        private static string Start()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Calculadora C#");
            Console.WriteLine("-------------------");
            Console.WriteLine("Opções");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Diferença");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("X - Sair");
            Console.WriteLine("");

            string option = Console.ReadLine();

            return option;
        }

        private static void Operations(string option)
        {
            while (option != "X")
            {
                switch (option)
                {
                    case "1":
                        Soma();
                        break;

                    case "2":
                        Diferenca();
                        break;

                    case "3":
                        Multiplicacao();
                        break;

                    case "4":
                        Divisao();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("");
                option = Start();
            }

            Console.WriteLine("");
            Console.WriteLine("Obrigado por utilizar esta aplicação!");
        }

        private static void Soma()
        {
            Console.Write("");
            Console.WriteLine("Digite o primeiro número:");

            if (decimal.TryParse(Console.ReadLine(), out decimal numberOne))
            {
                Console.WriteLine("");
                Console.WriteLine("Digite o segundo número:");

                if(decimal.TryParse(Console.ReadLine(), out decimal numberTwo))
                {
                    Console.WriteLine("");
                    Console.WriteLine($"O resultado da operação vale {numberOne+numberTwo}");
                }
            }
            else
            {
                throw new ArgumentException("O valor deve ser um número!");
            }
        }

        private static void Multiplicacao()
        {
            Console.Write("");
            Console.WriteLine("Digite o primeiro número:");

            if (decimal.TryParse(Console.ReadLine(), out decimal numberOne))
            {
                Console.WriteLine("");
                Console.WriteLine("Digite o segundo número:");

                if(decimal.TryParse(Console.ReadLine(), out decimal numberTwo))
                {
                    Console.WriteLine("");
                    Console.WriteLine($"O resultado da operação vale {numberOne*numberTwo}");
                }
            }
            else
            {
                throw new ArgumentException("O valor deve ser um número!");
            } 
        }

        private static void Diferenca()
        {
            Console.Write("");
            Console.WriteLine("Digite o primeiro número:");

            if (decimal.TryParse(Console.ReadLine(), out decimal numberOne))
            {
                Console.WriteLine("");
                Console.WriteLine("Digite o segundo número:");

                if(decimal.TryParse(Console.ReadLine(), out decimal numberTwo))
                {
                    Console.WriteLine("");
                    Console.WriteLine($"O resultado da operação vale {numberOne-numberTwo}");
                }
            }
            else
            {
                throw new ArgumentException("O valor deve ser um número!");
            } 
        }

        private static void Divisao()
        {
            Console.Write("");
            Console.WriteLine("Digite o primeiro número:");

            if (decimal.TryParse(Console.ReadLine(), out decimal numberOne))
            {
                Console.WriteLine("");
                Console.WriteLine("Digite o segundo número:");

                if(decimal.TryParse(Console.ReadLine(), out decimal numberTwo))
                {
                    Console.WriteLine("");
                    Console.WriteLine($"O resultado da operação vale {numberOne/numberTwo}");
                }
            }
            else
            {
                throw new ArgumentException("O valor deve ser um número!");
            } 
        }
    }
}
