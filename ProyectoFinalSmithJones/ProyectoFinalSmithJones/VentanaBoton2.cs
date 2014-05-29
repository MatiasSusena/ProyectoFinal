using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalSmithJones
{
    public partial class VentanaBoton2 : Form
    {
        public VentanaBoton2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cierra el formulario
            Close();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //boton Guardar crea un nuevo jugador y almacena los datos
        private void button3_Click(object sender, EventArgs e)
        {
            
            Jugador pJugador = new Jugador();

            pJugador.nombre = textBox1.Text.Trim();
            pJugador.apellido = textBox2.Text.Trim();
            pJugador.puesto = textBox3.Text.Trim();
            pJugador.id_capitan = Convert.ToInt32(textBox4.Text.Trim());
            pJugador.fecha_alta = dateTimePicker1.Value.ToString("yyyy-MM-dd"); //dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day;
            pJugador.salario = Convert.ToInt32(textBox6.Text.Trim());
            pJugador.equipo = Convert.ToInt32(textBox7.Text.Trim());
            pJugador.altura = Convert.ToDouble(textBox8.Text);


            int resultado = JugadoresDAL.Agregar(pJugador);

            if (resultado > 0)
            {
                MessageBox.Show("Guardado !!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
