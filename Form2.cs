using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDeLudo
{
    public partial class Form2 : Form
    {
        Juego juego = new Juego(2);
        public Form2()
        {

            InitializeComponent();
        }

        private void pantallaPrincipal1_Load(object sender, EventArgs e)
        {
            pantallaPrincipal1.Visible = true;
            pantallaJuego1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantallaPrincipal1.Visible = false;
            pantallaJuego1.Visible = true;
            button1.Visible = false;


        }
    }
}
