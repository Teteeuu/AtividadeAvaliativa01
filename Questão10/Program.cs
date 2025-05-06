using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tarefas = new List<string>();
        List<bool> concluidas = new List<bool>();

        while (true)
        {
            Console.Clear(); 

            Console.WriteLine("=== LISTA DE TAREFAS ===");
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Ver todas as tarefas");
            Console.WriteLine("3. Marcar tarefa como concluída");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção (1-4): ");
            
            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                
                Console.Write("Digite a nova tarefa: ");
                string novaTarefa = Console.ReadLine();
                tarefas.Add(novaTarefa);
                concluidas.Add(false);
                Console.WriteLine("Tarefa adicionada!");
            }
            else if (opcao == "2")
            {
                
                Console.WriteLine("\n=== SUAS TAREFAS ===");

                if (tarefas.Count == 0)
                {
                    Console.WriteLine("Nenhuma tarefa cadastrada ainda.");
                }
                else
                {
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        string status = concluidas[i] ? "[X]" : "[ ]";
                        Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");
                    }
                }
            }
            else if (opcao == "3")
            {
                
                if (tarefas.Count == 0)
                {
                    Console.WriteLine("Não há tarefas para marcar.");
                }
                else
                {
                    Console.WriteLine("\n=== MARCAR COMO CONCLUÍDA ===");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        string status = concluidas[i] ? "[X]" : "[ ]";
                        Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");
                    }

                    Console.Write("Digite o número da tarefa: ");
                    if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 1 && numero <= tarefas.Count)
                    {
                        if (concluidas[numero - 1])
                        {
                            Console.WriteLine("Essa tarefa já foi concluída.");
                        }
                        else
                        {
                            concluidas[numero - 1] = true;
                            Console.WriteLine($"Tarefa '{tarefas[numero - 1]}' marcada como concluída!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Número inválido!");
                    }
                }
            }
            else if (opcao == "4")
            {
                
                Console.WriteLine("Obrigado por usar a Lista de Tarefas!");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }

            Console.WriteLine("\nPressione Enter para continuar...");
            Console.ReadLine(); 
        }
    }
}
