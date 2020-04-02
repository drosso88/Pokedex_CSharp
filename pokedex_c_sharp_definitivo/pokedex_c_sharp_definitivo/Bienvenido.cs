using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex_c_sharp_definitivo

{//Diseño y codigo por Rocio
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {        
            VentanaPrincipal vp = new VentanaPrincipal();
            vp.Show();
        }
    }
}
