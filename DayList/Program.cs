using System;

namespace DayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListItems[] listItems = new ListItems[10];
        }

        private static string ShowOptions()
        {

            // É importante mostrar as opções para que o usuário possa escolher o que fazer
            // O valor retornado é uma string contendo 1, 2, X ou um valor que não está nas opções

            Console.WriteLine("Day List");
            Console.WriteLine("Uma checklist muito útil");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Digite 1 para anotar novas tarefas");
            Console.WriteLine("Digite 2 para remover tarefas");
            Console.WriteLine("Digite X para sair");
            Console.WriteLine();

            string option = Console.ReadLine();

            Console.WriteLine();

            return option;
        }

        private static void Actions(string option)
        {
            switch (option)
            {
                case "1":
                    
            }
        }

        private static Add()
        {

        }
    }
}
