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
            InicializarEstadoInicial();
        }


        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!RegistroValidator.Validar(
                txtPrimerNombre,
                txtPrimerApellido,
                txtCorreo,
                txtUsuarioRegistro,
                txtContrasenaRegistro,
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

            if (!service.CorreoDisponible(txtCorreo.Text))
            {
                MessageBox.Show("Este correo ya está registrado. Usa otro.");
                return;
            }



            Usuario u = new Usuario
            {
                primerNombre = txtPrimerNombre.Text,
                segundoNombre = txtSegundoNombre.Text,
                primerApellido = txtPrimerApellido.Text,
                segundoApellido = txtSegundoApellido.Text,
                correo = txtCorreo.Text,
                nombreUsuario = txtUsuarioRegistro.Text,
                contrasenaHash = PasswordHelper.Hash(txtContrasenaRegistro.Text),
                rol = combBRol.Text,
                preguntaSeguridad = txtPregunta.Text,
                respuestaSeguridadHash = PasswordHelper.Hash(txtRespuestaSeguridad.Text)

            };

            try
            {
                int id = service.RegistrarUsuario(u);

                if (id > 0)
                {
                    MessageBox.Show("Usuario registrado correctamente.");
                    panelRegistrarUsuario.Visible = false;
                    panelInicioSesion.Visible = true;
                    panelInicioSesion.BringToFront();
                }
                else
                {
                    MessageBox.Show("Error registrando usuario.");
                    return;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

        }

        private void InicializarEstadoInicial()
        {
            lblDisponible.Visible = false;

            panelInicioSesion.Visible = true;
            panelInicioSesion.BringToFront();

            panelRegistrarUsuario.Visible = false;
            panelRecuperarContrasena.Visible = false;

            combBRol.Items.Clear();
            combBRol.Items.Add("DOCENTE");
            combBRol.Items.Add("ESTUDIANTE");
            combBRol.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void InicializarPanelRecuperar()
        {

            panelRecuperarContrasena.Visible = false;


            txtRecuperarUsuario.Text = "Escriba aquí";
            txtRecuperarUsuario.ForeColor = Color.Gray;

            txtRecuperarRespuesta.Text = "Escriba aquí";
            txtRecuperarRespuesta.ForeColor = Color.Gray;

            txtRecuperarNuevaContrasena.Text = "Escriba aquí";
            txtRecuperarNuevaContrasena.ForeColor = Color.Gray;
            txtRecuperarNuevaContrasena.PasswordChar = '\0';

            txtRecuperarConfirmarContrasena.Text = "Escriba aquí";
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
            this.Hide();
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

        }

        private void lblOlvideContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InicializarPanelRecuperar();
            panelRecuperarContrasena.Visible = true;
            panelRecuperarContrasena.BringToFront();
        }

        private void FormRegistroLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
