using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Centro_Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcao = 0;

          while (opcao != 4)   //diferente
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue; //cor do texto

                Console.WriteLine(@"
██████╗░░█████╗░██╗░░██╗███████╗███╗░░░███╗░█████╗░███╗░░██╗
██╔══██╗██╔══██╗██║░██╔╝██╔════╝████╗░████║██╔══██╗████╗░██║
██████╔╝██║░░██║█████═╝░█████╗░░██╔████╔██║██║░░██║██╔██╗██║
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██║╚██╔╝██║██║░░██║██║╚████║
██║░░░░░╚█████╔╝██║░╚██╗███████╗██║░╚═╝░██║╚█████╔╝██║░╚███║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝");  //escreve
                Console.ResetColor();  //tira cor do texto
                Console.WriteLine("\n Seja Bem Vindo ao Centro Pokemon");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n 1 - Cadastrar Pokemon");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n 2 - Consultar Pokemon");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n 3 - Apagar Pokemon");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n 4 - Sair");
                Console.ForegroundColor = ConsoleColor.Gray;
                opcao = int.Parse(Console.ReadLine());



                switch (opcao)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Tchau Tchau !!!");
                        System.Threading.Thread.Sleep(2000);
                        Console.ResetColor();
                        break;


                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opcao Inválida!!!");
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(2000);
                        Thread.Sleep(2000);
                        break;
                }

            }






            }
        }
    }
