using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_H2.Utils
{
    public static class RegistroValidator
    {
        private static bool EsCorreoValido(string correo)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }

        private static bool EsContrasenaSegura(string contrasena, out string error)
        {
            error = null;

            
            if (contrasena.Length < 8)
            {
                error = "La contraseña debe tener al menos 8 caracteres.";
                return false;
            }

            if (!Regex.IsMatch(contrasena, @"[A-Z]"))
            {
                error = "La contraseña debe contener al menos una letra mayúscula.";
                return false;
            }

            
            if (!Regex.IsMatch(contrasena, @"[a-z]"))
            {
                error = "La contraseña debe contener al menos una letra minúscula.";
                return false;
            }

            
            if (!Regex.IsMatch(contrasena, @"[0-9]"))
            {
                error = "La contraseña debe contener al menos un número.";
                return false;
            }

          
            if (!Regex.IsMatch(contrasena, @"[\W_]"))
            {
                error = "La contraseña debe contener al menos un carácter especial.";
                return false;
            }

            return true;
        }


        public static bool Validar(
            TextBox txtPrimerNombre,
            TextBox txtPrimerApellido,
            TextBox txtCorreo,
            TextBox txtUsuarioRegistro,
            TextBox txtContrasenaRegistro,
            TextBox txtPregunta,
            TextBox txtRespuestaSeguridad,
            ComboBox combBRol,
            out string error)
        {
            if (string.IsNullOrWhiteSpace(txtPrimerNombre.Text))
            { 
                error = "El primer nombre es obligatorio."; 
                return false; 
            }

            if (string.IsNullOrWhiteSpace(txtPrimerApellido.Text))
            { 
                error = "El primer apellido es obligatorio."; 
                return false; 
            }

            if (!EsCorreoValido(txtCorreo.Text))
            {
                error = "El correo electrónico no tiene un formato válido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsuarioRegistro.Text))
            { 
                error = "Debes escribir un nombre de usuario."; 
                return false; 
            }

            
            if (!EsContrasenaSegura(txtContrasenaRegistro.Text, out error))
            {
                return false;
            }


            if (combBRol.SelectedIndex == -1)
            {
                error = "Debes seleccionar un rol.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPregunta.Text))
            { 
                error = "Debes ingresar una pregunta de seguridad.";
                return false; 
            }

            if (string.IsNullOrWhiteSpace(txtRespuestaSeguridad.Text))
            { 
                error = "Debes ingresar una respuesta de seguridad."; 
                return false; 
            }

            error = null;
            return true;
        }

    }
}
