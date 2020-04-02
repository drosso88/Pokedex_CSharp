using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex_c_sharp_definitivo
{
   
    public partial class Ventana03 : Form
    {
       
        Conexion miConexion = new Conexion();
        DataTable todosMisPokemons = new DataTable();
        public Ventana03()
        {
            InitializeComponent();
           
            dataGridView1.DataSource = miConexion.getAllPokemons();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

        }
        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text ="Nombre: " + dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            label2.Text ="id: " + dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            label3.Text = "Peso: " + dataGridView1.Rows[e.RowIndex].Cells["peso"].Value.ToString();
            label4.Text = "Altura: " + dataGridView1.Rows[e.RowIndex].Cells["altura"].Value.ToString();
            label5.Text = "Especie: " + dataGridView1.Rows[e.RowIndex].Cells["especie"].Value.ToString();
            label6.Text = "Habitat: " + dataGridView1.Rows[e.RowIndex].Cells["habitat"].Value.ToString();
            label7.Text = "Tipo 1: "+ dataGridView1.Rows[e.RowIndex].Cells["tipo1"].Value.ToString();
            label8.Text = "Tipo 2: " + dataGridView1.Rows[e.RowIndex].Cells["tipo2"].Value.ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])dataGridView1.Rows[e.RowIndex].Cells["imagen"].Value);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
                String nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                String id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();

               MessageBox.Show(miConexion.actualizaPokemons(id, nombre));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
