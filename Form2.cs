using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUDO
{
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        public Form2()
        {

            InitializeComponent();
        }

        private void btnTirarDado_Click_1(object sender, EventArgs e)
        {
            int ValorDado = rnd.Next(1, 7);
            label1.Text = ValorDado.ToString();
            if (ValorDado == 6)
            {
                //jugador.SacarPieza();
            }
        }
    }
}
