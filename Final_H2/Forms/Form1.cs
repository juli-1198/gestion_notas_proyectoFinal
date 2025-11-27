using Final_H2.Database;
using Final_H2.Models;
using Final_H2.Services;
using Final_H2.Utils;
using Final_H2.Forms;


namespace Final_H2
{
    public partial class FormRegistroLogin : Form
    {
        public FormRegistroLogin()
        {
            InitializeComponent();
        }


        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }




        private void FormRegistroLogin_Load(object sender, EventArgs e)
        {
            lblDisponible.Visible = false;

            panelInicioSesion.Visible = false;
            //panelInicioSesion.BringToFront();

            panelRegistrarUsuario.Visible = true;
            panelRecuperarContrasena.Visible = false;

            combBRol.Items.Add("DOCENTE");
            combBRol.Items.Add("ESTUDIANTE");
            combBRol.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!RegistroValidator.Validar(
                txtPrimerNombre,
                txtPrimerApellido,
                txtCorreo,
                txtUsuarioRegistro,
                txtContrasenaRegistro,
                txtConfirmarContrasenaRegistro,
                txtPregunta,
                txtRespuestaSeguridad,
                combBRol,
                out string error))
            {
                MessageBox.Show(error);
                return;
            }

            var service = new UsuarioService();

            if (!service.NombreUsuarioDisponible(txtUsuarioRegistro.Text))
            {
                MessageBox.Show("Ese nombre de usuario no está disponible.");
                return;
            }

            Usuario u = new Usuario
            {
                PrimerNombre = txtPrimerNombre.Text,
                SegundoNombre = txtSegundoNombre.Text,
                PrimerApellido = txtPrimerApellido.Text,
                SegundoApellido = txtSegundoApellido.Text,
                Correo = txtCorreo.Text,
                NombreUsuario = txtUsuarioRegistro.Text,
                ContrasenaHash = PasswordHelper.Hash(txtContrasenaRegistro.Text),
                PreguntaSeguridad = txtPregunta.Text,
                RespuestaSeguridadHash = PasswordHelper.Hash(txtRespuestaSeguridad.Text),
                Rol = combBRol.SelectedItem.ToString()
            };

            try
            {
                int id = service.RegistrarUsuario(u);

                if (id > 0)
                    MessageBox.Show("Usuario registrado correctamente.");
                else
                    MessageBox.Show("Error registrando usuario.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



            panelRegistrarUsuario.Visible = false; 

        }

        private void InicializarPanelRecuperar()
        {

            panelRecuperarContrasena.Visible = false;


            txtRecuperarUsuario.Text = "Usuario";
            txtRecuperarUsuario.ForeColor = Color.Gray;

            txtRecuperarRespuesta.Text = "Respuesta de seguridad";
            txtRecuperarRespuesta.ForeColor = Color.Gray;

            txtRecuperarNuevaContrasena.Text = "Nueva contraseña";
            txtRecuperarNuevaContrasena.ForeColor = Color.Gray;
            txtRecuperarNuevaContrasena.PasswordChar = '\0';

            txtRecuperarConfirmarContrasena.Text = "Confirmar contraseña";
            txtRecuperarConfirmarContrasena.ForeColor = Color.Gray;
            txtRecuperarConfirmarContrasena.PasswordChar = '\0';

            // Deshabilitar campos hasta validar respuesta
            txtRecuperarNuevaContrasena.Enabled = false;
            txtRecuperarConfirmarContrasena.Enabled = false;
            btnCambiarContrasena.Enabled = false;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioLogin.Text) || string.IsNullOrWhiteSpace(txtContrasenaLogin.Text))
            {
                MessageBox.Show("Debes ingresar tu usuario y contraseña.");
                return;
            }

            UsuarioService service = new UsuarioService();
            string hash = PasswordHelper.Hash(txtContrasenaLogin.Text);

            var usuario = service.Login(txtUsuarioLogin.Text, hash);

            if (usuario == null)
            {
                MessageBox.Show("Credenciales incorrectas.");
                return;
            }

            FormMain frm = new FormMain(usuario);
            frm.Show();
            panelInicioSesion.Visible = false;
        }

        private void lblIrInicioSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelRegistrarUsuario.Visible = false;
            panelInicioSesion.Visible = true;
            panelInicioSesion.BringToFront();
        }

        private void lblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelRegistrarUsuario.Visible = true;
            panelRegistrarUsuario.BringToFront();
            panelInicioSesion.Visible = false;
        }

        private void txtUsuarioRegistro_TextChanged(object sender, EventArgs e)
        {
            var service = new UsuarioService();

            if (!service.NombreUsuarioDisponible(txtUsuarioRegistro.Text))
                lblDisponible.Text = "El nombre de usuario no está disponible. Por favor ingrese otro";
            else
                lblDisponible.Text = "Nombre de usuario disponible";
        }

        private void lblIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void txtRecuperarRespuesta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            panelRecuperarContrasena.Visible = false;
            panelInicioSesion.Visible = true;
            panelInicioSesion.BringToFront();

        }

        private void btnBuscarPregunta_Click(object sender, EventArgs e)
        {
            UsuarioService servicio = new UsuarioService();
            string pregunta = servicio.ObtenerPregunta(txtRecuperarUsuario.Text);

            if (pregunta == null)
            {
                MessageBox.Show("El usuario no existe.");
                return;
            }

            lblPreguntaRecuperacion.Text = pregunta;


        }

        private void btnValidarRespuesta_Click(object sender, EventArgs e)
        {
            UsuarioService servicio = new UsuarioService();
            string hash = PasswordHelper.Hash(txtRecuperarRespuesta.Text);

            if (servicio.ValidarRespuesta(txtRecuperarUsuario.Text, hash))
            {
                txtRecuperarNuevaContrasena.Enabled = true;
                txtRecuperarConfirmarContrasena.Enabled = true;
                btnCambiarContrasena.Enabled = true;
                MessageBox.Show("Respuesta correcta.");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta.");
            }

        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            if (txtRecuperarNuevaContrasena.Text != txtRecuperarConfirmarContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            string nuevoHash = PasswordHelper.Hash(txtRecuperarNuevaContrasena.Text);
            UsuarioService servicio = new UsuarioService();

            bool cambiado = servicio.CambiarContrasena(
                txtRecuperarUsuario.Text,
                nuevoHash
            );

            if (servicio.CambiarContrasena(txtRecuperarUsuario.Text, nuevoHash))
            {
                MessageBox.Show("Contraseña cambiada exitosamente.");

                panelRecuperarContrasena.Visible = false;
                panelInicioSesion.Visible = true;
                panelInicioSesion.BringToFront();
            }
            else
            {
                MessageBox.Show("Error al cambiar la contraseña.");
            }

            /*if (cambiado)
            {
                MessageBox.Show("Contraseña actualizada exitosamente.");
                panelRecuperarContrasena.Visible = false;
                panelInicioSesion.Visible = true;
            }
            else
            {
                MessageBox.Show("Error al actualizar la contraseña.");
            }*/

        }

        private void lblOlvideContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InicializarPanelRecuperar();
            panelRecuperarContrasena.Visible = true;
        }
    }
}
