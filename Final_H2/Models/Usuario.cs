using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_H2.Models
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string primerNombre { get; set; }
        public string? segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string? segundoApellido { get; set; }
        public string correo { get; set; }
        public string nombreUsuario { get; set; }
        public string contrasenaHash { get; set; }
        public string rol { get; set; }
        public string preguntaSeguridad { get; set; }
        public string respuestaSeguridadHash { get; set; }


        public string NombreCompleto
        {
            get
            {
                return $"{primerNombre} {segundoNombre} {primerApellido} {segundoApellido}".Replace("  ", " ");
            }
        }

        public override string ToString()
        {
            return NombreCompleto;
        }

        // Constructor vacío obligatorio
        public Usuario() { }

        // Constructor 
        public Usuario(string nombUsuario, string contraHash)
        {
            nombreUsuario = nombUsuario;
            contrasenaHash = contraHash;
        }

    }


}
