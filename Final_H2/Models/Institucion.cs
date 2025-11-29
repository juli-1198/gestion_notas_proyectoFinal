using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_H2.Models;

namespace Final_H2.Models
{
    public class Institucion
    {
        public int idInstitucion { get; set; }

        
        public string nombre { get; set; }
        public int tipoInstitucion { get; set; }

        public string codigoInstitucion { get; set; }

        public string idDocente { get; set; }

        // Constructor vacío
        public Institucion() { }

        // Constructor opcional
        public Institucion(string nombre, int tipo, string codigo, string docente)
        {
            this.nombre = nombre;
            this.tipoInstitucion = tipo;
            this.codigoInstitucion = codigo;
            this.idDocente = docente;
        }

    }
}
