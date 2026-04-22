using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoEspadaPocaoBits
{
    class Ataque
    { 
        //Construtor
        public Ataque(TipoAtaque tipo, int danoMin, int danoMax, int chanceAcerto)
        {
            Tipo = tipo;
            DanoMin = danoMin;
            DanoMax = danoMax;
            ChanceAcerto = chanceAcerto;
        }

        public enum TipoAtaque
        {
            Leve,
            Medio,
            Forte
        }

        public TipoAtaque Tipo { get; set; }
        public int DanoMin { get; set; }
        public int DanoMax { get; set; }
        public int ChanceAcerto { get; set; }

        //Metodos
        public int CalcularDano(Random random)
        {
            int chance = random.Next(1, 101);
            if(chance <= ChanceAcerto)
            {
                var dano = random.Next(DanoMin, DanoMax + 1);
                return dano;
            }
            return 0;
        }
    }
}
