using MySql.Data.MySqlClient;
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
        Conexion miConexion = new Conexion(); //PARA QUE COJA LA CONEXION
        DataTable misPokemons = new DataTable(); //TABLA POR ID
        DataTable misPokemonsNombre = new DataTable(); //TABLA NUEVA POR NOMBRE

        int idactual = 0; //EL POKEMON QUE ESTAMOS VIENDO
        private MySqlTransaction conexion;

        public VentanaPrincipal()
        {
            InitializeComponent();
        }
        private Image convierteBlobAImagen (byte[] img)
        { //CONVIERTE LA IMAGEN
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
        private void datosPokemon()
        {
            //TE COLOCA TODOS LOS DATOS DE LOS POKEMONS CADA UNO EN SU LABEL
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

        private void izquierda_Click(object sender, EventArgs e)
        {
            //CAMBIA EL POKEMON HACIA LA IZQUIERDA Y SI PASA DE 0 NO TE DEJA MAS
            idactual--;
            if (idactual <= 0) { idactual = 1; }
            misPokemons = miConexion.getPokemonPorId(idactual);
            datosPokemon();
        }

        private void derecha_Click(object sender, EventArgs e)
        {
            //CAMBIA EL POKEMON HACIA LA DERECHA Y SI PASA DE 151 NO TE DEJA MAS
            idactual++;
            if (idactual >= 151) { idactual = 151; }
            misPokemons = miConexion.getPokemonPorId(idactual);
            datosPokemon();
        }


        private void entrenador_Click(object sender, EventArgs e)
        {
            //VENTANA QUE SE ABRE CUANDO PINCHO EL BOTON Y EN ESTE CASO ME PONE UNA IMAGEN
            Entrenador entrenador = new Entrenador();
            entrenador.Show();
        }

        private void botonbuscador_Click(object sender, EventArgs e)
            //ESTE BOTON TE BUSCA EL POKEMON SEGUN SU NOMBRE
        {
            String textoBuscador = buscador.Text; //PARA QUE ME LEA LO QUE ESCRIBO
            //LO QUE ME HACE BUSCAR POR NOMBRE ESTA DECLARADO EN CONEXION
            misPokemonsNombre = miConexion.getPokemonPorNombre(textoBuscador);
            if (misPokemonsNombre.Rows.Count == 0)
            {
                //ME DICE SI HAY DATOS DE LO BUSCADO
                buscador.Text = "NO EXISTE";
            }
            else
            {
                //PARA QUE ME BUSQUE POR NOMBRE USO LO QUE DECLARE ARRIBA COMO NUEVA TABLA
                nombrePokemon.Text = misPokemonsNombre.Rows[0]["nombre"].ToString();
                altura.Text = misPokemonsNombre.Rows[0]["altura"].ToString();
                peso.Text = misPokemonsNombre.Rows[0]["peso"].ToString();
                especie.Text = misPokemonsNombre.Rows[0]["especie"].ToString();
                habilidad.Text = misPokemonsNombre.Rows[0]["habilidad"].ToString();
                habitat.Text = misPokemonsNombre.Rows[0]["habitat"].ToString();
                pre.Text = misPokemonsNombre.Rows[0]["PreEvolucion"].ToString();
                pos.Text = misPokemonsNombre.Rows[0]["PosEvolucion"].ToString();
                tipo1.Text = misPokemonsNombre.Rows[0]["tipo1"].ToString();
                tipo2.Text = misPokemonsNombre.Rows[0]["tipo2"].ToString();
                mov1.Text = misPokemonsNombre.Rows[0]["movimiento1"].ToString();
                mov2.Text = misPokemonsNombre.Rows[0]["movimiento2"].ToString();
                mov3.Text = misPokemonsNombre.Rows[0]["movimiento3"].ToString();
                mov4.Text = misPokemonsNombre.Rows[0]["movimiento4"].ToString();
                descripcion.Text = misPokemonsNombre.Rows[0]["descripcion"].ToString();
                imagenpokemon.Image = convierteBlobAImagen((byte[])misPokemonsNombre.Rows[0]["imagen"]);
            }
            
        }

    }
}
