using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoEspadaPocaoBits
{
    class Jogador : Personagem
    {
        
        public int Pocoes { get; set; }

        //Metodos
        public void UsarPocao()
        {
            if(Pocoes > 0)
            {
                Curar(20);
                //Pocoes = Pocoes - 1;
                Pocoes--;
                Console.WriteLine("Poção utilizada com sucesso");
            }
            else
            {
                Console.WriteLine("Sem poções");
            }
        }

        public int EscolherAcao()
        {
            Console.WriteLine("1 - Ataque Leve");
            Console.WriteLine("2 - Ataque Médio");
            Console.WriteLine("3 - Ataque Forte");
            Console.WriteLine("4 - Defender");
            Console.WriteLine("5 - Usar Poção");

            int opcao;
            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 5)
            {
                Console.WriteLine("Opção inválida, tente novamente:");
            }

            return opcao;
        }
    }
}
