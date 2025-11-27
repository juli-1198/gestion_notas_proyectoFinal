using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_H2.Models
{
    public class Estudiante : Usuario
    {
        public Estudiante()
        {
            Rol = "ESTUDIANTE";
        }

        //averiguar bien el funcionamiento de esto en la base de datos y la aplicacion
        public string CodigoEstudiante { get; set; }

    }
}
