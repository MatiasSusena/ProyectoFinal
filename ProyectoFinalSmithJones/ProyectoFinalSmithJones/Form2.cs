using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoFinalSmithJones
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //muestra el formulario
            new VentanaBoton2().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection cnx = new MySqlConnection();
            cnx.ConnectionString = "Server=localhost;Port=3306;Database=;Uid=root;Pwd=";

            //Definir linea Consulta SQL
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();

            ////define the connection used by the command object
            //msqlCommand.Connection = this.msqlConnection;

            //define the command text
            msqlCommand.CommandText = "SELECT * FROM liga.equipos;";
            try
            {
                cnx.Open();
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message);
                throw;
            }
            if (cnx.State == ConnectionState.Open)
            {
                MessageBox.Show("conectado");
                //open the connection
                cnx.Open();
                //use a DataReader to process each record
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    //Que tiene que hacer con cada fila que devuelve 
                }
            }


            else
                MessageBox.Show("no conectado");
        }
    }
}
