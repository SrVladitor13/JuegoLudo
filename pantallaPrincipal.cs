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
    public partial class pantallaPrincipal : UserControl
    {
        public pantallaPrincipal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.Parse(label4.Text) + int.Parse(label5.Text) >= 4)
            {
                label6.Text = "Error. La cantidad máxima de jugadores y CPUs no puede ser mayor a 4";
                label6.Visible = true;
                return;
            }

            label4.Text = (int.Parse(label4.Text) + 1).ToString();
            label6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(label4.Text) <= 1)
            {
                label6.Text = "Error. El mínimo de jugadores humanos es 1";
                label6.Visible = true;
                return;
            }

            label4.Text = (int.Parse(label4.Text) - 1).ToString();
            label6.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(label4.Text) + int.Parse(label5.Text) >= 4)
            {
                label7.Text = "Error. La cantidad máxima de jugadores y CPUs no puede ser mayor a 4";
                label7.Visible = true;
                return;
            }

            label5.Text = (int.Parse(label5.Text) + 1).ToString();
            label7.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (int.Parse(label5.Text) > 0)
            {
                label5.Text = (int.Parse(label5.Text) - 1).ToString();
                label7.Visible = false;
            }

        }

        private void pantallaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
