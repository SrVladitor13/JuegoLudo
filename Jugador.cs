using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LUDO
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public List<Pieza> Piezas { get; set; }

        public Jugador(string nombre) 
        {
            Nombre = nombre;
            Piezas = new List<Pieza>();
            InitializePiezas();
        }

        private void InitializePiezas()
        {
            for (int i = 0; i < 4; i++) 
            {
                Piezas.Add(new Pieza(this));
            }
        }

        public void SacarPieza()
        {
            
        }
    }
}
