using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoFinalSmithJones
{
    public class BD_Conexion
    {
        public static MySqlConnection BD_Conectar()
        {
            // BD_Conectar = Método que nos conectara a la base de datos.

            MySqlConnection BD_Cnx = new MySqlConnection();
            /*
            Server = Dirección o Servidor de MySQL.
            database = Nombre de la base de datos a la cual nos conectamos.
            Uid = Nombre del usuario de Mysql (por defecto "root")
            pwd = Contraseña del usuario (dejar en blanco sino tiene) .
            */

            BD_Cnx.ConnectionString = "Server=localhost;Port=3306;Database=liga;Uid=root;Pwd=";
            BD_Cnx.Open();
            return BD_Cnx;
        }

    }
}