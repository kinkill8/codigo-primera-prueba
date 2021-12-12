using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo_primera_prueba
{
    class clase_arquitecto : trabajador
    {
        public string nombre_arquitecto;
        public string apellido_arquitecto;
        public int tiempo_de_trabajoA;
        public int hora_de_salidaA;
        private string desempeño;
        private int rutA;

        public string desempeño1 { get => desempeño; set => desempeño = value; }
        public int rut2 { get => rutA; set => rutA = value; }
        public void especificacion()
        {
            Console.WriteLine("rut " + this.rut2 + " , el arquitecto asignado fue " 
                + this.nombre_arquitecto + " de apellido " + this.apellido_arquitecto
                + " trabajo durante " + this.tiempo_de_trabajoA + " y salio a las " +
                this.hora_de_salidaA + " y su desempeño fue " + this.desempeño1);
        }

    }
}
