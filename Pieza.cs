using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JuegoDeLudo
{
    public class Pieza
    {
        public Jugador propietario { get; set; }
        public int posicion { get; set; }
        public bool enCasa { get; set; }
        public bool terminado { get; set; }

        public Pieza(Jugador propietario)
        {
            this.propietario = propietario;
            this.posicion = 0;
            this.enCasa = true;
            this.terminado = false;
        }

        public void Mover(int pasos, List<Pieza> todasLasPiezas)
        {
            // Implementar lógica del movimiento
            if (enCasa && pasos == 6) 
            {
                enCasa = false;
                posicion = 0;
            }
            else if (!enCasa && !terminado)
            {
                int nuevaPosicion = posicion + pasos;

                // Controlar capturas
                foreach (Pieza otraPieza in todasLasPiezas)
                {
                    if (otraPieza != this && otraPieza.propietario != propietario && otraPieza.posicion == nuevaPosicion)
                    {
                        otraPieza.enCasa = true;
                        otraPieza.posicion = 0;
                        break;
                    }
                }

                posicion = nuevaPosicion;
                // Revisa si la pieza llegó a la posición final
                if (posicion >= 52)
                {
                    posicion = 52;
                    terminado = true;
                }
            }
        }
    }
}
