using MyApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosConceituais.Conceitos
{
    internal class SortMethods
    {
        private Random rnd = new Random();
        private List<int> intList = new List<int>();

        public SortMethods() { }

        public void SortMenu()
        {
            var program = new Program();

            Console.WriteLine("Ok, Vamos testar ordenação em uma lista de inteiros. O que deseja fazer agora?");
            Console.WriteLine("1 - Adicionar 10 números");
            Console.WriteLine("2 - Verificar numeros da lista");
            Console.WriteLine("3 - Ordenar com BubbleSort");
            Console.WriteLine("4 - Ordenar com Sort do .NET(QuickSort incluso)");
            Console.WriteLine("5 - Limpar lista");
            Console.WriteLine("6 - Voltar ao menu principal");
            Console.WriteLine("7 - Encerrar");

            try
            {
                var operacaoComSort = Console.ReadLine();
                if (operacaoComSort is null)
                {
                    Console.WriteLine("Nenhum dado inserido!");
                    SortMenu();
                }
                switch (operacaoComSort)
                {
                    case "1":
                        AddNumbers();
                        SortMenu();
                        break;
                    case "2":
                        VerificarTodosInteiros();
                        SortMenu();
                        break;
                    case "3":
                        OrdenarPorBubble();
                        SortMenu();
                        break;
                    case "4":
                        OrdenarPorQuick();
                        SortMenu();
                        break;
                    case "5":
                        LimparLista();
                        SortMenu();
                        break;
                    case "6":
                        program.MenuInicial();
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Nenhuma função encontrada com esse número!");
                        SortMenu();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
                SortMenu();
            }
        }

        private void AddNumbers()
        {      
                try
                {
                    for(int i = 0; i < 10; i++)
                    {
                        intList.Add(rnd.Next());
                    }
                    Console.WriteLine("Numeros adicionados");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    AddNumbers();
                }
        }

        private void VerificarTodosInteiros()
        {
            Console.WriteLine("Todos on inteiros na lista:");
            foreach (var result in intList)
            {
                Console.WriteLine(result);
            }
        }

        private void OrdenarPorBubble()
        {
            for(var i = 0; i < intList.Count - 1; i++)
            {
                for (var j = 0; j < intList.Count - 1; j++)
                {
                    if (intList[j] > intList[j + 1])
                    {
                        int temp = intList[j];
                        intList[j] = intList[j + 1];
                        intList[j + 1] = temp;

                    }
                }
            }

            Console.WriteLine("Nova ordem da lista apos BubbleSort:");
            foreach (var result in intList)
            {
                Console.WriteLine(result);
            }
        }

        private void OrdenarPorQuick()
        {
            intList.Sort();

            Console.WriteLine("Nova ordem da lista apos QuickSort:");
            foreach (var result in intList)
            {
                Console.WriteLine(result);
            }
        }

        private void LimparLista()
        {
            intList.Clear();
            Console.WriteLine("Lista esvaziada!");
        }

        }
}
