using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    public partial class TodosLosPokemons : Form
    {
        Conexion miConexion = new Conexion(); //PARA QUE COJA LA CONEXION
        VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
        public TodosLosPokemons()
        {
            InitializeComponent();
            todos.DataSource = miConexion.todos();
            todos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            todos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ventanaPrincipal.nombrePokemon.Text = todos.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            ventanaPrincipal.altura.Text = todos.Rows[e.RowIndex].Cells["altura"].Value.ToString();
            ventanaPrincipal.peso.Text = todos.Rows[e.RowIndex].Cells["peso"].Value.ToString();
            ventanaPrincipal.especie.Text = todos.Rows[e.RowIndex].Cells["especie"].Value.ToString();
            ventanaPrincipal.habilidad.Text = todos.Rows[e.RowIndex].Cells["habilidad"].Value.ToString();
            ventanaPrincipal.habitat.Text = todos.Rows[e.RowIndex].Cells["habitat"].Value.ToString();
            ventanaPrincipal.pre.Text = todos.Rows[e.RowIndex].Cells["PreEvolucion"].Value.ToString();
            ventanaPrincipal.pos.Text = todos.Rows[e.RowIndex].Cells["PosEvolucion"].Value.ToString();
            ventanaPrincipal.tipo1.Text = todos.Rows[e.RowIndex].Cells["tipo1"].Value.ToString();
            ventanaPrincipal.tipo2.Text = todos.Rows[e.RowIndex].Cells["tipo2"].Value.ToString();
            ventanaPrincipal.mov1.Text = todos.Rows[e.RowIndex].Cells["movimiento1"].Value.ToString();
            ventanaPrincipal.mov2.Text = todos.Rows[e.RowIndex].Cells["movimiento2"].Value.ToString();
            ventanaPrincipal.mov3.Text = todos.Rows[e.RowIndex].Cells["movimiento3"].Value.ToString();
            ventanaPrincipal.mov4.Text = todos.Rows[e.RowIndex].Cells["movimiento4"].Value.ToString();
            ventanaPrincipal.descripcion.Text = todos.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
            ventanaPrincipal.imagenpokemon.Image = ventanaPrincipal.convierteBlobAImagen((byte[])todos.Rows[e.RowIndex].Cells["imagen"].Value);
        }
        public void todos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ventanaPrincipal.nombrePokemon.Text = todos.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            ventanaPrincipal.altura.Text = todos.Rows[e.RowIndex].Cells["altura"].Value.ToString();
            ventanaPrincipal.peso.Text = todos.Rows[e.RowIndex].Cells["peso"].Value.ToString();
            ventanaPrincipal.especie.Text = todos.Rows[e.RowIndex].Cells["especie"].Value.ToString();
            ventanaPrincipal.habilidad.Text = todos.Rows[e.RowIndex].Cells["habilidad"].Value.ToString();
            ventanaPrincipal.habitat.Text = todos.Rows[e.RowIndex].Cells["habitat"].Value.ToString();
            ventanaPrincipal.pre.Text = todos.Rows[e.RowIndex].Cells["PreEvolucion"].Value.ToString();
            ventanaPrincipal.pos.Text = todos.Rows[e.RowIndex].Cells["PosEvolucion"].Value.ToString();
            ventanaPrincipal.tipo1.Text = todos.Rows[e.RowIndex].Cells["tipo1"].Value.ToString();
            ventanaPrincipal.tipo2.Text = todos.Rows[e.RowIndex].Cells["tipo2"].Value.ToString();
            ventanaPrincipal.mov1.Text = todos.Rows[e.RowIndex].Cells["movimiento1"].Value.ToString();
            ventanaPrincipal.mov2.Text = todos.Rows[e.RowIndex].Cells["movimiento2"].Value.ToString();
            ventanaPrincipal.mov3.Text = todos.Rows[e.RowIndex].Cells["movimiento3"].Value.ToString();
            ventanaPrincipal.mov4.Text = todos.Rows[e.RowIndex].Cells["movimiento4"].Value.ToString();
            ventanaPrincipal.descripcion.Text = todos.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
            ventanaPrincipal.imagenpokemon.Image = ventanaPrincipal.convierteBlobAImagen((byte[])todos.Rows[e.RowIndex].Cells["imagen"].Value);
        }
    }
}
