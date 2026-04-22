using System;

namespace JogoEspadaPocaoBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Espadas, Poções e Bits";

            bool sair = false;

            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("=== ESPADAS, POÇÕES E BITS ===");
                Console.WriteLine("1 - Jogar");
                Console.WriteLine("2 - Sair");
                Console.Write("Escolha: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        IniciarJogo();
                        break;

                    case "2":
                        sair = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void IniciarJogo()
        {
            Console.Clear();

            Jogo jogo = new Jogo();
            jogo.Iniciar();

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}