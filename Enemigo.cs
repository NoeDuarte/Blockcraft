using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    public class Enemigo
    {
      
        private int vida;

        public Enemigo(int vida)
        {

             this.vida = vida;

        }

        public void ActualizarVida(int danio)
        {
            this.vida -=danio;
        }
    }
}
