using LUDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeLudo
{
    internal class Juego
    {
        public int cantidadJugadores { get; set; }
        public (int, Celda) posicionCeldas { get; set; }
        public Jugador[] listaGanadores { get; set; }

        public Juego(int cantidadJugadores)
        {
            this.cantidadJugadores = cantidadJugadores;
        }
    }
}
