using MyApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosConceituais.Conceitos
{
    internal class ListMethods
    {
        private List<string> list = new List<string>();
        public ListMethods()
        {
        }

        public void ListMenu()
        {
            var program = new Program();

                Console.WriteLine("Ok, Vamos operar uma lista de strings. O que deseja fazer agora?");
                Console.WriteLine("1 - Adicionar um nome");
                Console.WriteLine("2 - Buscar");
                Console.WriteLine("3 - Verificar todos os nomes");
                Console.WriteLine("4 - Excluir um nome");
                Console.WriteLine("5 - Voltar ao menu principal");
                Console.WriteLine("6 - Encerrar");

            try
            {
                var operacaoComList = Console.ReadLine();
                if (operacaoComList is null)
                {
                    Console.WriteLine("Nenhum dado inserido!");
                    ListMenu();
                }
                switch (operacaoComList)
                {
                    case "1":
                        AddString();
                        ListMenu();
                        break;
                    case "2":
                        BuscarString();
                        ListMenu();
                        break;
                    case "3":
                        VerificarTodasStrings();
                        ListMenu();
                        break;
                    case "4":
                        ExcluirString();
                        ListMenu();
                        break;
                    case "5":
                        program.MenuInicial();
                        break;
                    case "6":
                        break;
                    default: 
                        Console.WriteLine("Nenhuma função encontrada com esse número!");
                        ListMenu();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
                ListMenu();
            }
        }

        private void AddString()
        {
            Console.WriteLine("Digite a string a ser adicionada: ");
            string? nomeParaAdicionar = Console.ReadLine();

            if(nomeParaAdicionar is null)
            {
                Console.WriteLine("Nenhuma string recebida!");
                AddString();
            }
            else
            {
                list.Add(nomeParaAdicionar);
            }
        }

        private void BuscarString()
        {
            Console.WriteLine("Digite a string a ser buscada(ou parte dela): ");
            string? nomeParaBuscar = Console.ReadLine();

            if (nomeParaBuscar is null)
            {
                Console.WriteLine("Nenhuma string recebida!");
                BuscarString();
            }
            else
            {
                var listOfResults = list
                    .Where(n => n.Contains(nomeParaBuscar))
                    .ToList();

                Console.WriteLine("Resultados encontrados:");
                foreach(var result in listOfResults)
                {
                    Console.WriteLine(result.ToString());
                }
            }
        }
        
        private void VerificarTodasStrings()
        {
            
                var listOfResults = list
                    .ToList();

                Console.WriteLine("Todos as strings cadastradas:");
                foreach(var result in listOfResults)
                {
                    Console.WriteLine(result);
                }           
        }

        private void ExcluirString()
        {

            Console.WriteLine("Excluir por busca ou por posição na lista?");
            Console.WriteLine("1 - Busca");
            Console.WriteLine("2 - Posição");
            string? buscaOuPosicao = Console.ReadLine();

            if(buscaOuPosicao is null)
            {
                Console.WriteLine("Não consegui entender sua escolha!");
                ExcluirString();
            }

            if(buscaOuPosicao == "1")
            {
                Console.WriteLine("Digite a string a ser buscada(ou parte dela): ");
                string? nomeParaBuscar = Console.ReadLine();

                if (nomeParaBuscar is null)
                {
                    Console.WriteLine("Nenhuma string recebida!");
                    ExcluirString();
                }
                else
                {
                    var listOfResults = list
                        .Where(n => n.Contains(nomeParaBuscar))
                        .ToList();

                    if(listOfResults.Count == 0)
                    {
                        Console.WriteLine("Nenhum resultado.");
                        ExcluirString();
                    }

                    Console.WriteLine("Eis os resultados. Qual delas deseja excluir?:");
                    for(int i = 0; i < listOfResults.Count; i++)
                    {
                        Console.WriteLine($"{i}: {listOfResults[i]}");
                    }
                    int paraExcluir = int.Parse(Console.ReadLine());

                    if(paraExcluir < 0 || paraExcluir > listOfResults.Count())
                    {
                        Console.WriteLine("O número escolhido não está na lista.");
                        ExcluirString();
                    }

                    list.Remove(listOfResults[paraExcluir]);
                    Console.WriteLine($"String '{listOfResults[paraExcluir]}' excluída com sucesso!");

                }
            }else if(buscaOuPosicao == "2")
            {
                var listOfResults = list
                        .ToList();

                if (listOfResults.Count == 0)
                {
                    Console.WriteLine("Nenhum resultado.");
                    ListMenu();
                }

                Console.WriteLine("Eis os resultados. Qual delas deseja excluir?:");
                for (int i = 0; i < listOfResults.Count; i++)
                {
                    Console.WriteLine($"{i}: {listOfResults[i]}");
                }
                int paraExcluir = int.Parse(Console.ReadLine());

                if (paraExcluir < 0 || paraExcluir > listOfResults.Count())
                {
                    Console.WriteLine("O número escolhido não está na lista.");
                    ExcluirString();
                }

                list.Remove(listOfResults[paraExcluir]);
                Console.WriteLine($"String '{listOfResults[paraExcluir]}' excluída com sucesso!");
            }
            
            
        }
    }
}
