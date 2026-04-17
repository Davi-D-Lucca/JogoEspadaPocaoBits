using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoEspadaPocaoBits
{
    class Inimigo : Personagem
    {
        public int EscolherAcao(Random random)
        {
            int acao = random.Next(1, 4);
            return acao;
        }
    }
}
