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
        public int idSeleccionado;
        DataTable misPokemons = new DataTable(); //TABLA POR ID
        public TodosLosPokemons()
        {
            InitializeComponent();
            todos.DataSource = miConexion.todos();
            todos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            todos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        public void todos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSeleccionado = Convert.ToInt32(todos.Rows[e.RowIndex].Cells["id"].Value.ToString());
            this.Close();
        }
    }
}
