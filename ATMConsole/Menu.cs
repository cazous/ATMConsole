using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsole
{
    internal class Menu
    {
        Lista lista = new Lista();
        public void menu()
        {
            int opcao;

            Console.WriteLine("Selecione operação desejada: ");

            Console.WriteLine("1. Criar Conta");
            Console.WriteLine("2. Listar todas as contas");
            Console.WriteLine("3. Procurar conta por id");
            Console.WriteLine("4. Procurar conta por nome");
            Console.WriteLine("5. Remover Conta");
            Console.WriteLine("6. Adicionar saldo");
            Console.WriteLine("7. Remover saldo");
            Console.WriteLine("8. Listar contas especiais");
            Console.WriteLine("9. Adicionar crédito especial");
            Console.WriteLine("10. Remover crédito especial");


            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Informe tipo da conta:");
                    Console.WriteLine("1 - Conta Comum");
                    Console.WriteLine("2 - Conta Especial");
                    int tipoConta = int.Parse(Console.ReadLine());

                    if (tipoConta == 1)
                    {
                        Console.WriteLine("Informe nome da conta");
                        string nome = Console.ReadLine();
                        lista.criarConta(nome);
                        Console.Clear();
                    }
                    else if (tipoConta == 2)
                    {
                        Console.WriteLine("Informe nome da conta");
                        string nome = Console.ReadLine();
                        lista.CriarContaEspecial(nome);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Opção inválida.");
                    }
                    Console.WriteLine();
                    //Background verde
                    menu();
                    break;

                case 2:
                    Console.Clear();
                    lista.exibirContas();
                    Console.WriteLine();
                    menu();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Informe o id da conta");
                    int id = int.Parse(Console.ReadLine());
                    if (lista.validarIdConta(id))
                    {
                        Console.WriteLine(lista.procurarPorId(id));
                        Console.WriteLine();
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Conta inválida");
                        Console.WriteLine();
                        menu();
                    }
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Informe o nome da conta");
                    string nome2 = Console.ReadLine();
                    if (lista.validarNomeConta(nome2))
                    {
                        Console.WriteLine(lista.procurarPorNome(nome2));
                        Console.WriteLine();
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Conta inválida");
                        Console.WriteLine();
                        menu();
                    }
                    break;

                case 5:
                    Console.Clear();
                    lista.exibirContas();
                    Console.WriteLine("Informe o id da conta");
                    int id2 = int.Parse(Console.ReadLine());
                    if (lista.validarIdConta(id2))
                    {
                        lista.deletarConta(id2);
                        Console.WriteLine();
                        menu();

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Conta inválida");
                        Console.WriteLine();
                        menu();
                    }

                    break;

                case 6:
                    Console.Clear();
                    lista.exibirContas();
                    Console.WriteLine("Informe o id da conta");
                    int id3 = int.Parse(Console.ReadLine());
                    if (lista.validarIdConta(id3))
                    {
                        Console.WriteLine("Informe saldo adicionado");
                        double saldoAdd = Double.Parse(Console.ReadLine());
                        lista.procurarPorId(id3).addSaldo(saldoAdd);
                        //Conta conta1 = lista.procurarPorId(id3);
                        //conta1.addSaldo(saldoAdd);
                        Console.WriteLine();
                        menu();

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Conta inválida");
                        Console.WriteLine();
                        menu();
                    }

                    break;

                case 7:
                    Console.Clear();
                    lista.exibirContas();
                    Console.WriteLine("Informe o id da conta");
                    int id4 = int.Parse(Console.ReadLine());
                    if (lista.validarIdConta(id4))
                    {
                        Console.WriteLine("Informe saldo removido");
                        double saldoRemovido = Double.Parse(Console.ReadLine());
                        lista.procurarPorId(id4).removerSaldo(saldoRemovido);
                        Console.WriteLine();
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Conta inválida");
                        Console.WriteLine();
                        menu();
                    }
                    break;

                case 8:
                    Console.Clear();
                    lista.exibirContasEspeciais();
                    Console.WriteLine();
                    menu();
                    break;

                case 9:
                    Console.Clear();
                    lista.exibirContasEspeciais();
                    Console.WriteLine("Informe o id da conta");
                    int id5 = int.Parse(Console.ReadLine());
                    if (lista.validarIdConta(id5))
                    {
                        Console.WriteLine("Informe crédito especial adicionado");
                        double creditoAdicionado = Double.Parse(Console.ReadLine());
                        lista.procurarPorIdEspecial(id5).addCreditoEspecial(creditoAdicionado);
                        Console.WriteLine();
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Conta inválida");
                        Console.WriteLine();
                        menu();
                    }
                    break;

                case 10:
                    Console.Clear();
                    lista.exibirContasEspeciais();
                    Console.WriteLine("Informe o id da conta");
                    int id6 = int.Parse(Console.ReadLine());
                    if (lista.validarIdConta(id6))
                    {
                        Console.WriteLine("Informe crédito especial removido");
                        double creditoRemovido = Double.Parse(Console.ReadLine());
                        lista.procurarPorIdEspecial(id6).removerCreditoEspecial(creditoRemovido);
                        Console.WriteLine();
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Conta inválida");
                        Console.WriteLine();
                        menu();
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opcão inválida, selecione novamente");
                    menu();
                    break;
            }
        }

    }
}
