using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoEspadaPocaoBits
{
    class Inimigo : Personagem
    {
        private Random random = new Random();
        public int EscolherAcao()
        {
            int acao = random.Next(1, 4);
            return acao;
        }
    }
}
