using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoFinalSmithJones
{
    public class JugadoresDAL
    {

        public static int Agregar(Jugador pJugador)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format(
                "Insert into Jugadores1 (nombre, apellido, puesto, id_capitan, fecha_alta, salario, equipo, altura) values ('{0}','{1}','{2}', '{3}', '{4}','{5}','{6}', '{7}')",
                pJugador.nombre, pJugador.apellido, pJugador.puesto, pJugador.id_capitan, pJugador.fecha_alta, pJugador.salario, pJugador.equipo, pJugador.altura), BD_Conexion.BD_Conectar());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        public static List<Jugador> Buscar(string pNombre, string pApellido)

        {

           List<Jugador> _lista = new List<Jugador>();

               MySqlCommand _comando = new MySqlCommand(String.Format(

              "SELECT id_jugador, nombre, apellido, puesto, salario, altura FROM Jugadores1 WHERE nombre ='{0}' or apellido='{1}'", pNombre, pApellido), BD_Conexion.BD_Conectar());
               MySqlDataReader _reader = _comando.ExecuteReader();
               while (_reader.Read())
               {
                   Jugador pJugador  = new Jugador();
                   pJugador.id_jugador = _reader.GetInt32(0);
                   pJugador.nombre = _reader.GetString(1);
                   pJugador.apellido = _reader.GetString(2);
                   pJugador.puesto = _reader.GetString(3);
                   pJugador.salario = _reader.GetInt32(4);
                   pJugador.altura = _reader.GetDouble(5);

                   _lista.Add(pJugador);
               }
           
           return _lista;
        }

        public static Jugador ObtenerJugadores(int pId)
        {
            Jugador pJugador  = new Jugador();
            // MySqlConnection conexion = BD_Conexion.BD_Conectar();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT id_jugador, nombre, apellido, puesto, salario, altura FROM Jugadores1 WHERE id_jugador={0}", pId), BD_Conexion.BD_Conectar());
            MySqlDataReader _reader = _comando.ExecuteReader();
           
            while (_reader.Read())
            {
                pJugador.id_jugador = _reader.GetInt32(0);
                pJugador.nombre = _reader.GetString(1);
                pJugador.apellido = _reader.GetString(2);
                pJugador.puesto = _reader.GetString(3);
                pJugador.salario = _reader.GetInt32(4);
                pJugador.altura = _reader.GetDouble(5);
            }
            // conexion.Close();
            BD_Conexion.BD_Conectar().Close();

            return pJugador  ;

        }



    }

}
