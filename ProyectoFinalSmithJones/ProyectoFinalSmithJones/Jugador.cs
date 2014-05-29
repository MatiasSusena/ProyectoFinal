using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalSmithJones
{
    public class Jugador
    {
        public int id_jugador { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string puesto { get; set; }
        public int id_capitan { get; set; }
        public string fecha_alta { get; set; }
        public int salario { get; set; }
        public int equipo { get; set; }
        public double altura { get; set; }



        // Contructor
        public Jugador()
        {
        }

        public Jugador(int pid_jugador, string pnombre, string papellido, string ppuesto, int pid_capitan, string pfecha_alta,
            int psalario, int pequipo, double paltura)
        {
            this.id_jugador = pid_jugador;
            this.nombre = pnombre;
            this.apellido = papellido;
            this.puesto = ppuesto;
            this.id_capitan = pid_capitan;
            this.fecha_alta = pfecha_alta;
            this.salario = psalario;
            this.equipo = pequipo;
            this.altura = paltura;
        }

    }

}


