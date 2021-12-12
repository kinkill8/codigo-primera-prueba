using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo_primera_prueba
{
    class proceso
    {
        static void Main(string[] args)
        {
            clase_arquitecto caT = new clase_arquitecto();
            clase_constructor ccT = new clase_constructor();
            trabajador t1T = new trabajador();
            caT.nombre_arquitecto = "jose";
            caT.apellido_arquitecto = "sepulveda";
            caT.tiempo_de_trabajoA = 7;
            caT.hora_de_salidaA = 6;
            caT.rut2 = 78904326;
            caT.desempeño1 = "exelente";
            ccT.nombre_constructor = "juan";
            ccT.apellido_constructor = "mundaca";
            ccT.tiempo_de_trabajo = 7;
            ccT.hora_de_salida = 7;
            ccT.tipo_de_trabajoT = "pegado de ceramica";
            ccT.lugar_de_trabajoT = "aysen";
            ccT.rut1 = 123456783;

            
            t1T.iniciando();
            t1T.tipo();
            caT.especificacion();
            t1T.espacios();
            ccT.constructor();
            t1T.espacios();


        }

    }
}
