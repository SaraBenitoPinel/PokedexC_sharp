﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PokedexC_sharp
{
    class Conexion
    {
        public MySqlConnection conexion;
        public Conexion() //Para conectarse a la bbdd que tenengo en la maquina virtual
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = listapokemons; " +
                "Uid = root; Pwd = ; Port = 3306");
        }
        public DataTable getPokemonPorId(int id)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon where id = '" 
                    + id + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public DataTable getPokemonPorNombre (String nombre)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon " +
                    "where nombre = '" + nombre + "'",conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}

