using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex_c_sharp_definitivo
{
    //probando                                                            
    public partial class VentanaPrincipal : Form
    {

        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        Ventana02 ventanaBusqueda = new Ventana02();
        int idActual = 1;

        public VentanaPrincipal()
        {
            InitializeComponent();

        }

        public void pushButton()
        {
            try
            {
                SoundPlayer Player = new SoundPlayer(Properties.Resources.push14);
                Player.Play();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void clickIzquierdo(object sender, EventArgs e)
        {
            pushButton();
            idActual--;
            if (idActual <= 0)
            {
                idActual = 1;
            }


                misPokemons = miConexion.getPokemonPorId(idActual);
                nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
                pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                label1.Text = "peso: " + misPokemons.Rows[0]["peso"].ToString();
                label2.Text = "altura: " + misPokemons.Rows[0]["altura"].ToString();
                label3.Text = "especie:" + misPokemons.Rows[0]["especie"].ToString();
                label4.Text = "habitat: " + misPokemons.Rows[0]["habitat"].ToString();
                label5.Text = "tipo1: " + misPokemons.Rows[0]["tipo1"].ToString();
                label6.Text = "tipo2: " + misPokemons.Rows[0]["tipo2"].ToString();
                label7.Text = "descripcion: " + misPokemons.Rows[0]["descripcion"].ToString();
            

        }

        private void clickDerecho(object sender, EventArgs e)
        {
            pushButton();
            idActual++;
            if (idActual >= 151)
            {
                idActual = 151;
            }
                misPokemons = miConexion.getPokemonPorId(idActual);
                nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
                pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                label1.Text = "peso: " + misPokemons.Rows[0]["peso"].ToString();
                label2.Text = "altura: " + misPokemons.Rows[0]["altura"].ToString();
                label3.Text = "especie:" + misPokemons.Rows[0]["especie"].ToString();
                label4.Text = "habitat: " + misPokemons.Rows[0]["habitat"].ToString();
                label5.Text = "tipo1: " + misPokemons.Rows[0]["tipo1"].ToString();
                label6.Text = "tipo2: " + misPokemons.Rows[0]["tipo2"].ToString();
                label7.Text = "descripcion: " + misPokemons.Rows[0]["descripcion"].ToString();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

          
            ventanaBusqueda.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            idActual = ventanaBusqueda.buscadorPokemons();
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            label1.Text = "peso: " + misPokemons.Rows[0]["peso"].ToString();
            label2.Text = "altura: " + misPokemons.Rows[0]["altura"].ToString();
            label3.Text = "especie:" + misPokemons.Rows[0]["especie"].ToString();
            label4.Text = "habitat: " + misPokemons.Rows[0]["habitat"].ToString();
            label5.Text = "tipo1: " + misPokemons.Rows[0]["tipo1"].ToString();
            label6.Text = "tipo2: " + misPokemons.Rows[0]["tipo2"].ToString();
            label7.Text = "descripcion: " + misPokemons.Rows[0]["descripcion"].ToString();
        }

        internal class MediaPlayer
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ventana03 ventanGrid = new Ventana03();
            ventanGrid.Show();
        }
    }
}
