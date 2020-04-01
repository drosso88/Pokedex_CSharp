using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace pokedex_c_sharp_definitivo
{
    class Conexion
    { 
        public MySqlConnection conexion;
        
        public Conexion()
        {
            conexion = new MySqlConnection("Server=192.168.182.145; DataBase=listapokemons; Uid =root; Pwd= ; Port=3306"); 
        }
        public DataTable getPokemonPorId(int id)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon WHERE id='"+id +"'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;
            }
            catch(MySqlException e)
            {
                
                throw e;
            }
        }
        public DataTable getAllPokemons()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT id,nombre,altura,especie,habitat,habilidad,preEvolucion FROM pokemon ", conexion);
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
