using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_H2.Models
{
    public class Curso
    {
        public int idCurso { get; set; }
        public string nombreCurso { get; set; }
        public string codigoCurso { get; set; }
        public int numeroGrupo { get; set; }
        public string salon { get; set; }
        public string idDocente { get; set; }
        public int idInstitucion { get; set; }

        // Constructor vacío
        public Curso() { }

        // Constructor 
        public Curso(string nombre, string codigo, int grupo, string salon, string docente, int idInst)
        {
            this.nombreCurso = nombre;
            this.codigoCurso = codigo;
            this.numeroGrupo = grupo;
            this.salon = salon;
            this.idDocente = docente;
            this.idInstitucion = idInst;
        }

    }
}
