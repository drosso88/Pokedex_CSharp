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
{
    public partial class Ventana02 : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        String palabraIntroducida = "";
        Boolean busco = false;
        int numero = 0;
        public String nombrePokemon;
        public Ventana02()
        {
            InitializeComponent();

        }
        public void cambiaNombre(String nombrePokemon)
        {
            // label1.Text =nombrePokemon ;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            palabraIntroducida =escriboBienPalabraIntroducida(textBox1.Text);
            //MessageBox.Show("hola " + palabraIntroducida);
            
            busco = true;

            if (busco)
            {
                buscadorPokemons();
            }
            this.Hide();


        }
        public int buscadorPokemons()
        {


            numero = 1;
            misPokemons = miConexion.getPokemonPorId(numero);
            while (palabraIntroducida != misPokemons.Rows[0]["nombre"].ToString() && numero < 151 && palabraIntroducida != "")
            {
                misPokemons = miConexion.getPokemonPorId(numero);
                numero++;
            }
            label1.Text = (numero - 1).ToString();
            return numero - 1;

        }
        public String escriboBienPalabraIntroducida(String P)
        {
            String palabraBienEscrita = "";
            if(P.Length>0)
            {
                palabraBienEscrita = P.Substring(0, 1).ToUpper() + P.Substring(1).ToLower();  
            }
            return palabraBienEscrita;
        }


    }
}

