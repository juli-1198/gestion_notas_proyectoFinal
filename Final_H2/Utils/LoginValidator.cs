using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_H2.Utils
{
    public static class LoginValidator
    {
        public static bool Validar(string usuario, string contrasena, out string error)
        {
            if (string.IsNullOrWhiteSpace(usuario))
            { error = "Escribe tu nombre de usuario."; return false; }

            if (string.IsNullOrWhiteSpace(contrasena))
            { error = "Escribe tu contraseña."; return false; }

            error = null;
            return true;
        }
    }
}
