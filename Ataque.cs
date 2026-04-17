using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoEspadaPocaoBits
{
    class Ataque
    {
        public enum TipoAtaque
        {
            Leve,
            Medio,
            Forte
        }

        private Random random = new Random();

        public TipoAtaque Tipo { get; set; }
        public int DanoMin { get; set; }
        public int DanoMax { get; set; }
        public int ChanceAcerto { get; set; }

        public int CalcularDano()
        {
            int chance = random.Next(1, 1001);
            if(chance <= ChanceAcerto)
            {
                var dano = random.Next(DanoMin, DanoMax + 1);
                return dano;
            }
            return 0;
        }
    }
}
