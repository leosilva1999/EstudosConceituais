using EstudosConceituais.Conceitos;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var program = new Program();
            program.MenuInicial();
        }


        public void MenuInicial()
        {
            ListMethods _listMethods = new ListMethods();
            StackMethods _stackMethods = new StackMethods();
            QueueMethods _queueMethods = new QueueMethods();

            Console.WriteLine("Olá, seja bem vindo ao projeto de estudos conceituais. Por onde deseja começar? Digite o número correspondente à sua escolha:");
            Console.WriteLine("1 - Collections");
            Console.WriteLine("2 - Stack(Pilha)");
            Console.WriteLine("3 - Queue(Fila)");
            Console.WriteLine("5 - Encerrar");
            
            try
            {
                var ondeComecar = Console.ReadLine();
                if (ondeComecar is null)
                {
                    MenuInicial();
                    throw new ArgumentNullException("Nenhum valor inserido!");
                }
                switch (ondeComecar)
                {
                    case "1":
                        _listMethods.ListMenu();
                        break;
                    case "2":
                        _stackMethods.StackMenu();
                        break;
                    case "3":
                        _queueMethods.QueueMenu();
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        MenuInicial();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }
        }
    }

}


