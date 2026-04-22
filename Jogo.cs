using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoEspadaPocaoBits
{
    class Jogo
    {
        public Jogo(int rodada, Random random, Jogador jogador, Inimigo inimigo)
        {
            Rodada = rodada;
            this.Random = random;
            this.Jogador = jogador;
            this.Inimigo = inimigo;
        }

        public Jogador Jogador { get; set; }
        public Inimigo Inimigo { get; set; }
        public int Rodada { get; set; }
        public Random Random { get; set; }

        public void Iniciar()
        {
            Jogador.Nome = "Heroi";
            Jogador.Vida = 100;
            Jogador.Pocoes = 3;

            Inimigo.Nome = "Monstro";
            Inimigo.Vida = 100;

            Rodada = 1;

            while(Jogador.EstaVivo() && Inimigo.EstaVivo())
            {
                Console.WriteLine($"Rodada: {Rodada}");
                ExecutarTurno();
                Rodada++;
                //Rodada = Rodada + 1;
            }
            VerificarVencedor();
        }

        private void VerificarVencedor()
        {
            throw new NotImplementedException();
        }

        private void ExecutarTurno()
        {
            throw new NotImplementedException();
        }
    }
}
