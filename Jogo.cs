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
            this.random = random;
            this.jogador = jogador;
            this.inimigo = inimigo;
        }

        public Jogador jogador { get; set; }
        public Inimigo inimigo { get; set; }
        public int Rodada { get; set; }
        public Random random { get; set; }

        public void Iniciar()
        {
            jogador.Nome = "Heroi";
            jogador.Vida = 100;
            jogador.Pocoes = 3;

            inimigo.Nome = "Monstro";
            inimigo.Vida = 100;

            Rodada = 1;

            while(jogador.EstaVivo() && inimigo.EstaVivo())
            {
                Console.WriteLine($"Rodada: {Rodada}");
                ExecutarTurno();
                Rodada = Rodada + 1;
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
