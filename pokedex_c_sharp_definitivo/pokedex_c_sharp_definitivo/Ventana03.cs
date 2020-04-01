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
        Conexion miConexion2 = new Conexion();
        DataTable todosMisPokemons = new DataTable();
        public Ventana03()
        {
            InitializeComponent();
           
            dataGridView1.DataSource = miConexion2.getAllPokemons();
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
            label1.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            label2.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])dataGridView1.Rows[e.RowIndex].Cells["imagen"].Value);
        }
    }
}
