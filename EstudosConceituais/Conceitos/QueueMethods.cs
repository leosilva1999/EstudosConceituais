using MyApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosConceituais.Conceitos
{
    internal class QueueMethods
    {
        private Queue<string> queue = new Queue<string>();

        public QueueMethods() { }

        public void QueueMenu()
        {
            var program = new Program();

            Console.WriteLine("Ok, Vamos operar uma fila(Queue) de strings. O que deseja fazer agora?");
            Console.WriteLine("1 - Adicionar um nome");
            Console.WriteLine("2 - Verificar todos os nomes");
            Console.WriteLine("3 - Verificar primeiro da fila");
            Console.WriteLine("4 - Remover o primeiro nome");
            Console.WriteLine("5 - Voltar ao menu principal");
            Console.WriteLine("6 - Encerrar");

            try
            {
                var operacaoComStack = Console.ReadLine();
                if (operacaoComStack is null)
                {
                    Console.WriteLine("Nenhum dado inserido!");
                    QueueMenu();
                }
                switch (operacaoComStack)
                {
                    case "1":
                        AddString();
                        QueueMenu();
                        break;
                    case "2":
                        VerificarTodasStrings();
                        QueueMenu();
                        break;
                    case "3":
                        VerificarTopoPilha();
                        QueueMenu();
                        break;
                    case "4":
                        RemoverString();
                        QueueMenu();
                        break;
                    case "5":
                        program.MenuInicial();
                        break;
                    case "6":
                        break;
                    default:
                        Console.WriteLine("Nenhuma função encontrada com esse número!");
                        QueueMenu();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
                QueueMenu();
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
                    queue.Enqueue(nomeParaAdicionar);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    AddString();
                }

            }
        }

        private void VerificarTodasStrings()
        {
            Console.WriteLine("Todos as strings na fila:");
            foreach (var result in queue)
            {
                Console.WriteLine(result);
            }
        }

        private void VerificarTopoPilha()
        {
            Console.WriteLine("Primeira string na pilha:");
            Console.WriteLine(queue.Peek());
        }

        private void RemoverString()
        {
            Console.WriteLine($"String removida: {queue.Peek()}");
            queue.Dequeue();
            Console.WriteLine($"String atualmente no topo da  pilha: {queue.Peek()}");
        }
    }
}
