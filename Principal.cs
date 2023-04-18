using Blockcraft;


//Arma pico = new Arma(10);
//Arma hacha = new Arma(20);

Enemigo enemigo = new Enemigo(100);

Jugador jugador = new Jugador(new Pico());
jugador.atacar(enemigo);

jugador.cambiarArma(new Hacha());
jugador.atacar(enemigo);



