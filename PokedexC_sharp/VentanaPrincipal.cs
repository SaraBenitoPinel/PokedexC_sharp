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

namespace PokedexC_sharp
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idactual = 0; //el pokemon que estamos viendo
        public VentanaPrincipal()
        {
            InitializeComponent();
        }
        private Image convierteBlobAImagen (byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void izquierda_Click(object sender, EventArgs e)
        {
            idactual--;
            if (idactual <= 0) { idactual = 0; }
            misPokemons = miConexion.getPokemonPorId(idactual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            altura.Text = misPokemons.Rows[0]["altura"].ToString();
            peso.Text = misPokemons.Rows[0]["peso"].ToString();
            especie.Text = misPokemons.Rows[0]["especie"].ToString();
            habilidad.Text = misPokemons.Rows[0]["habilidad"].ToString();
            habitat.Text = misPokemons.Rows[0]["habitat"].ToString();
            pre.Text = misPokemons.Rows[0]["PreEvolucion"].ToString();
            pos.Text = misPokemons.Rows[0]["PosEvolucion"].ToString();
            tipo1.Text = misPokemons.Rows[0]["tipo1"].ToString();
            tipo2.Text = misPokemons.Rows[0]["tipo2"].ToString();
            mov1.Text = misPokemons.Rows[0]["movimiento1"].ToString();
            mov2.Text = misPokemons.Rows[0]["movimiento2"].ToString();
            mov3.Text = misPokemons.Rows[0]["movimiento3"].ToString();
            mov4.Text = misPokemons.Rows[0]["movimiento4"].ToString();
            descripcion.Text = misPokemons.Rows[0]["descripcion"].ToString();
            imagenpokemon.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void derecha_Click(object sender, EventArgs e)
        {
            idactual++;
            if (idactual >= 151) { idactual = 151; }
            misPokemons = miConexion.getPokemonPorId(idactual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            altura.Text = misPokemons.Rows[0]["altura"].ToString();
            peso.Text = misPokemons.Rows[0]["peso"].ToString();
            especie.Text = misPokemons.Rows[0]["especie"].ToString();
            habilidad.Text = misPokemons.Rows[0]["habilidad"].ToString();
            habitat.Text = misPokemons.Rows[0]["habitat"].ToString();
            pre.Text = misPokemons.Rows[0]["PreEvolucion"].ToString();
            pos.Text = misPokemons.Rows[0]["PosEvolucion"].ToString();
            tipo1.Text = misPokemons.Rows[0]["tipo1"].ToString();
            tipo2.Text = misPokemons.Rows[0]["tipo2"].ToString();
            mov1.Text = misPokemons.Rows[0]["movimiento1"].ToString();
            mov2.Text = misPokemons.Rows[0]["movimiento2"].ToString();
            mov3.Text = misPokemons.Rows[0]["movimiento3"].ToString();
            mov4.Text = misPokemons.Rows[0]["movimiento4"].ToString();
            descripcion.Text = misPokemons.Rows[0]["descripcion"].ToString();
            imagenpokemon.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
