using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    public class Jugador
    {
        private Arma arma;

        public Jugador(Arma arma)
        {
            this.arma = arma;  
        }

        public void cambiarArma(Arma arma)
        {
            this.arma = arma;
        }

        public void atacar(Enemigo enemigo)
        {
            this.arma.atacar(enemigo);
        }
    
    }
}
