using MyApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosConceituais.Conceitos
{
    internal class StackMethods
    {
        private Stack<string> stack = new Stack<string>();

        public StackMethods() { }

        public void StackMenu()
        {
            var program = new Program();

            Console.WriteLine("Ok, Vamos operar uma pilha(stack) de strings. O que deseja fazer agora?");
            Console.WriteLine("1 - Adicionar um nome");
            Console.WriteLine("2 - Verificar todos os nomes");
            Console.WriteLine("3 - Verificar topo");
            Console.WriteLine("4 - Remover o primeiro nome");
            Console.WriteLine("5 - Voltar ao menu principal");
            Console.WriteLine("6 - Encerrar");

            try
            {
                var operacaoComStack = Console.ReadLine();
                if (operacaoComStack is null)
                {
                    Console.WriteLine("Nenhum dado inserido!");
                    StackMenu();
                }
                switch (operacaoComStack)
                {
                    case "1":
                        AddString();
                        StackMenu();
                        break;
                    case "2":
                        VerificarTodasStrings();
                        StackMenu();
                        break;
                    case "3":
                        VerificarTopoPilha();
                        StackMenu();
                        break;
                    case "4":
                        RemoverString();
                        StackMenu();
                        break;
                    case "5":
                        program.MenuInicial();
                        break;
                    case "6":
                        break;
                    default:
                        Console.WriteLine("Nenhuma função encontrada com esse número!");
                        StackMenu();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
                StackMenu();
            }
        }

        private void AddString()
        {
            Console.WriteLine("Digite a string a ser adicionada: ");
            string? nomeParaAdicionar = Console.ReadLine();

            if (nomeParaAdicionar is null)
            {
                Console.WriteLine("Nenhuma string recebida!");
                AddString();
            }
            else
            {
                try
                {
                    stack.Push(nomeParaAdicionar);
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    AddString();
                }

            }
        }

        private void VerificarTodasStrings()
        {
            Console.WriteLine("Todos as strings na pilha:");
            foreach (var result in stack)
            {
                Console.WriteLine(result);
            }
        }

        private void VerificarTopoPilha()
        {
            Console.WriteLine("Primeira string na pilha:");
            Console.WriteLine(stack.Peek());
        }
        
        private void RemoverString()
        {
            Console.WriteLine($"String removida: {stack.Peek()}");
            stack.Pop();
            Console.WriteLine($"String atualmente no topo da  pilha: {stack.Peek()}");           
        }

       

        
    }
}
