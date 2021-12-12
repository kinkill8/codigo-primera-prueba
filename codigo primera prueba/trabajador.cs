using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo_primera_prueba
{
    class trabajador
    {
        private int rut;
        public string nombre_arquitecto;
        public string apellido_arquitecto;
        public string nombre_constructor;
        public string apellido_constructor;
        public int tiempo_de_trabajo;
        public int hora_de_salidaA;

        public int Rut { get => rut; set => rut = value; }


        public void iniciando()
        {
            Console.WriteLine("iniciando programa");
        }
        public void espacios()
        {
            Console.WriteLine("******************************");
        }
        public void tipo()
        {
            Console.WriteLine("planilla de informacion");
        }
    }


    
}
