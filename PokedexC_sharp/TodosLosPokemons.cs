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
        public TodosLosPokemons()
        {
            InitializeComponent();
            dataGridView1.DataSource = miConexion.todos();
        }
    }
}
