using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    public class Pico : Arma
    {
	public void atacar(Enemigo enemigo)
        {
            enemigo.ActualizarVida(10);
        }
    }
}
