using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JogoEspadaPocaoBits
{
    class Jogo
    {
        //Construtor
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


        //Metodos
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

        public void VerificarVencedor()
        {
            if (Jogador.EstaVivo())
            {
                Console.WriteLine("Jogador Venceu!");
            }
            else
            {
                Console.WriteLine("Inimigo Venceu!");
            }
        }

        public Ataque CriarAtaque(Ataque.TipoAtaque tipo)
        {
            int dMin;
            int dMax;
            int ch;

            if (tipo == Ataque.TipoAtaque.Leve)
            {
                dMin = 5;
                dMax = 10;
                ch = 90;
            }
            else if (tipo == Ataque.TipoAtaque.Medio)
            {
                dMin = 10;
                dMax = 20;
                ch = 75;
            }
            else
            {
                dMin = 20;
                dMax = 30;
                ch = 60;
            }

            Ataque novoAtaque = new Ataque(tipo, dMin, dMax, ch);
            return novoAtaque;
        }
        public void ExecutarTurno()
        {
            throw new NotImplementedException();
        }

    }
}
