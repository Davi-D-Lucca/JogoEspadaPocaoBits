using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoEspadaPocaoBits
{
    class Personagem
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public bool Defendendo { get; set; }

        //Metodos
        public void ReceberDano(int dano)
        {
            if(Defendendo == true)
            {
                dano /= 2;
            }

            Vida -= dano;

            if(Vida < 0)
            {
                Vida = 0;
            }
        }

        public void Curar(int valorCura)
        {
            Vida += valorCura;
            if(Vida > 100)
            {
                Vida = 100;
            }
        }

        public bool EstaVivo()
        {
            return Vida > 0;
        }
    }
}
