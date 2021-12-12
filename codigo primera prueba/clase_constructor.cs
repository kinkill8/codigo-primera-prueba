using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo_primera_prueba
{
    class clase_constructor : trabajador
    {
        public string nombre_constructor;
        public string apellido_constructor;
        public int tiempo_de_trabajo;
        public int hora_de_salida;
        private string tipo_de_trabajo;
        private string lugar_de_trabajo;
        private int rutT;



        public string tipo_de_trabajoT { get => tipo_de_trabajo; set => tipo_de_trabajo = value; }
        public string lugar_de_trabajoT { get => lugar_de_trabajo; set => lugar_de_trabajo = value; }
        public int rut1 { get => rutT; set => rutT = value; }
        public void constructor()
        {
            Console.WriteLine("rut " + this.rut1 + ", el constructor asignado fue " + this.nombre_constructor + "de apellido " + this.apellido_constructor + 
                ", trabajo durante "+ this.tiempo_de_trabajo + "y salio de trabajar a las " 
                + this.hora_de_salida + ", el tipo de trabajo que realizo fue " 
                + this.tipo_de_trabajoT + " y el lugar donde lo realizo fue " + this.lugar_de_trabajoT);
        }

    }

}
