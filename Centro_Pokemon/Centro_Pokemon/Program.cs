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
                Console.WriteLine("\n digite a opção escolhida:  ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());



                switch (opcao)
                {
                    case 1:
                        cadastroPokemon(); //abre a função
                        break;
                        {

                        }
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
                        Thread.Sleep(2000); //espera por 2 segundos
                        break;
                }

            }
        }

        static void cadastroPokemon()
        {
            Console.Clear(); // limpa a tela
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@" 
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");

            Console.ForegroundColor = ConsoleColor.Green;
                
            Console.WriteLine("\n digite o nome do seu Pokemon:  ");
            string nomePokemon = Console.ReadLine();         // string = textos

            Console.WriteLine("\n digite o tipo do seu Pokemon:  ");
            string tipoPokemon = Console.ReadLine();        // string = textos

            Console.WriteLine("\n digite o tamanho do seu Pokemon:  ");
            double alturaPokemon = double.Parse(Console.ReadLine());   //double = casa decimal

            Console.WriteLine("\n digite o peso do seu Pokemon:  ");
            double pesoPokemon = double.Parse(Console.ReadLine());    //double  casa decimal

            //fraqueza

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("quantas fraquezas ele tem?  :");
            int qtdfraqueza = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdfraqueza; i++)
            {
                Console.WriteLine($"Fraqueza  {i}  ;  ");  //{i} --- colocar a variavel no texto
                string fraquezaPokemon = Console.ReadLine();

            }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("quantas evoluções ele tem?  :");
                int qtdevolucao = int.Parse(Console.ReadLine());
            

            for (int i = 1;  i <= qtdevolucao; i++)
            {
                Console.WriteLine($"nome da evolução  {i}  ;  ");  //{i} --- colocar a variavel no texto
                string evolucaoPokemon = Console.ReadLine();

                Console.ForegroundColor= ConsoleColor.Green ;
                Console.WriteLine("PARABÉNS... Pokemon cadastrado");
                Thread.Sleep(3000);
                Console.ResetColor();



            }


        }






    }
}
