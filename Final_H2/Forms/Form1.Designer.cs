namespace Final_H2
{
    partial class FormRegistroLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelRegistrarUsuario = new Panel();
            lblRespuesta = new Label();
            lblDisponible = new Label();
            lblIrInicioSesion = new LinkLabel();
            lblYaTienesCuenta = new Label();
            lblPreguntaSeguridad = new Label();
            btnRegistrar = new Button();
            txtPregunta = new TextBox();
            txtRespuestaSeguridad = new TextBox();
            txtContrasenaRegistro = new TextBox();
            lblContrasenaRegistro = new Label();
            txtUsuarioRegistro = new TextBox();
            lblNombreUsuario = new Label();
            combBRol = new ComboBox();
            lblRol = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            txtSegundoApellido = new TextBox();
            lblSegundoApellido = new Label();
            txtPrimerApellido = new TextBox();
            lblPrimerApellido = new Label();
            txtSegundoNombre = new TextBox();
            lblSegundoNombre = new Label();
            txtPrimerNombre = new TextBox();
            lblPrimerNombre = new Label();
            LblRegistrarse = new Label();
            panelInicioSesion = new Panel();
            lblOlvideContrasena = new LinkLabel();
            lblRegistro = new LinkLabel();
            lblNoCuenta = new Label();
            txtContrasenaLogin = new TextBox();
            lblContrasenaLogin = new Label();
            txtUsuarioLogin = new TextBox();
            lblIniciarSesion = new Label();
            lblNombUsuario = new Label();
            btnIniciarSesion = new Button();
            panelRecuperarContrasena = new Panel();
            btnSalir = new Button();
            btnCambiarContrasena = new Button();
            btnBuscarPregunta = new Button();
            btnValidarRespuesta = new Button();
            txtRecuperarConfirmarContrasena = new TextBox();
            lblConfirmarContra = new Label();
            txtRecuperarRespuesta = new TextBox();
            txtRecuperarNuevaContrasena = new TextBox();
            lblRecuperar = new Label();
            lblPreguntaRecuperacion = new Label();
            txtRecuperarUsuario = new TextBox();
            label1 = new Label();
            lblRecuperarContrasena = new Label();
            panelRegistrarUsuario.SuspendLayout();
            panelInicioSesion.SuspendLayout();
            panelRecuperarContrasena.SuspendLayout();
            SuspendLayout();
            // 
            // panelRegistrarUsuario
            // 
            panelRegistrarUsuario.Controls.Add(lblRespuesta);
            panelRegistrarUsuario.Controls.Add(lblDisponible);
            panelRegistrarUsuario.Controls.Add(lblIrInicioSesion);
            panelRegistrarUsuario.Controls.Add(lblYaTienesCuenta);
            panelRegistrarUsuario.Controls.Add(lblPreguntaSeguridad);
            panelRegistrarUsuario.Controls.Add(btnRegistrar);
            panelRegistrarUsuario.Controls.Add(txtPregunta);
            panelRegistrarUsuario.Controls.Add(txtRespuestaSeguridad);
            panelRegistrarUsuario.Controls.Add(txtContrasenaRegistro);
            panelRegistrarUsuario.Controls.Add(lblContrasenaRegistro);
            panelRegistrarUsuario.Controls.Add(txtUsuarioRegistro);
            panelRegistrarUsuario.Controls.Add(lblNombreUsuario);
            panelRegistrarUsuario.Controls.Add(combBRol);
            panelRegistrarUsuario.Controls.Add(lblRol);
            panelRegistrarUsuario.Controls.Add(txtCorreo);
            panelRegistrarUsuario.Controls.Add(lblCorreo);
            panelRegistrarUsuario.Controls.Add(txtSegundoApellido);
            panelRegistrarUsuario.Controls.Add(lblSegundoApellido);
            panelRegistrarUsuario.Controls.Add(txtPrimerApellido);
            panelRegistrarUsuario.Controls.Add(lblPrimerApellido);
            panelRegistrarUsuario.Controls.Add(txtSegundoNombre);
            panelRegistrarUsuario.Controls.Add(lblSegundoNombre);
            panelRegistrarUsuario.Controls.Add(txtPrimerNombre);
            panelRegistrarUsuario.Controls.Add(lblPrimerNombre);
            panelRegistrarUsuario.Controls.Add(LblRegistrarse);
            panelRegistrarUsuario.Location = new Point(195, 23);
            panelRegistrarUsuario.Name = "panelRegistrarUsuario";
            panelRegistrarUsuario.Size = new Size(497, 610);
            panelRegistrarUsuario.TabIndex = 0;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRespuesta.Location = new Point(294, 361);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(92, 19);
            lblRespuesta.TabIndex = 25;
            lblRespuesta.Text = "Tu respuesta";
            // 
            // lblDisponible
            // 
            lblDisponible.AutoSize = true;
            lblDisponible.ForeColor = Color.Red;
            lblDisponible.Location = new Point(294, 165);
            lblDisponible.MaximumSize = new Size(150, 30);
            lblDisponible.MinimumSize = new Size(150, 20);
            lblDisponible.Name = "lblDisponible";
            lblDisponible.Size = new Size(150, 20);
            lblDisponible.TabIndex = 24;
            // 
            // lblIrInicioSesion
            // 
            lblIrInicioSesion.AutoSize = true;
            lblIrInicioSesion.Location = new Point(258, 544);
            lblIrInicioSesion.Name = "lblIrInicioSesion";
            lblIrInicioSesion.Size = new Size(75, 15);
            lblIrInicioSesion.TabIndex = 23;
            lblIrInicioSesion.TabStop = true;
            lblIrInicioSesion.Text = "Iniciar sesión";
            lblIrInicioSesion.LinkClicked += lblIrInicioSesion_LinkClicked;
            // 
            // lblYaTienesCuenta
            // 
            lblYaTienesCuenta.AutoSize = true;
            lblYaTienesCuenta.Location = new Point(146, 544);
            lblYaTienesCuenta.Name = "lblYaTienesCuenta";
            lblYaTienesCuenta.Size = new Size(102, 15);
            lblYaTienesCuenta.TabIndex = 22;
            lblYaTienesCuenta.Text = "¿Ya tienes cuenta?";
            // 
            // lblPreguntaSeguridad
            // 
            lblPreguntaSeguridad.Location = new Point(294, 251);
            lblPreguntaSeguridad.MaximumSize = new Size(200, 150);
            lblPreguntaSeguridad.MinimumSize = new Size(100, 60);
            lblPreguntaSeguridad.Name = "lblPreguntaSeguridad";
            lblPreguntaSeguridad.Size = new Size(174, 77);
            lblPreguntaSeguridad.TabIndex = 19;
            lblPreguntaSeguridad.Text = "Ingrese una pregunta de seguridad para que puedas recuperar la contraseña en caso de que la olvides:\r\n";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DodgerBlue;
            btnRegistrar.FlatAppearance.BorderColor = Color.White;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(192, 491);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(118, 30);
            btnRegistrar.TabIndex = 21;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtPregunta
            // 
            txtPregunta.Location = new Point(294, 331);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new Size(151, 23);
            txtPregunta.TabIndex = 20;
            txtPregunta.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRespuestaSeguridad
            // 
            txtRespuestaSeguridad.Location = new Point(294, 383);
            txtRespuestaSeguridad.Name = "txtRespuestaSeguridad";
            txtRespuestaSeguridad.Size = new Size(151, 23);
            txtRespuestaSeguridad.TabIndex = 19;
            txtRespuestaSeguridad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtContrasenaRegistro
            // 
            txtContrasenaRegistro.Location = new Point(294, 217);
            txtContrasenaRegistro.Name = "txtContrasenaRegistro";
            txtContrasenaRegistro.Size = new Size(151, 23);
            txtContrasenaRegistro.TabIndex = 16;
            txtContrasenaRegistro.UseSystemPasswordChar = true;
            // 
            // lblContrasenaRegistro
            // 
            lblContrasenaRegistro.AutoSize = true;
            lblContrasenaRegistro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContrasenaRegistro.Location = new Point(294, 195);
            lblContrasenaRegistro.Name = "lblContrasenaRegistro";
            lblContrasenaRegistro.Size = new Size(84, 19);
            lblContrasenaRegistro.TabIndex = 15;
            lblContrasenaRegistro.Text = "Contraseña";
            // 
            // txtUsuarioRegistro
            // 
            txtUsuarioRegistro.Location = new Point(294, 139);
            txtUsuarioRegistro.Name = "txtUsuarioRegistro";
            txtUsuarioRegistro.Size = new Size(151, 23);
            txtUsuarioRegistro.TabIndex = 14;
            txtUsuarioRegistro.TextChanged += txtUsuarioRegistro_TextChanged;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombreUsuario.Location = new Point(294, 117);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(139, 19);
            lblNombreUsuario.TabIndex = 13;
            lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // combBRol
            // 
            combBRol.FormattingEnabled = true;
            combBRol.Location = new Point(59, 428);
            combBRol.Name = "combBRol";
            combBRol.Size = new Size(151, 23);
            combBRol.TabIndex = 12;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.Location = new Point(59, 406);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(31, 19);
            lblRol.TabIndex = 11;
            lblRol.Text = "Rol";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(59, 369);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(151, 23);
            txtCorreo.TabIndex = 10;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCorreo.Location = new Point(59, 345);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(135, 19);
            lblCorreo.TabIndex = 9;
            lblCorreo.Text = "Correo electrónico";
            lblCorreo.Click += lblCorreo_Click;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(59, 309);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(151, 23);
            txtSegundoApellido.TabIndex = 8;
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSegundoApellido.Location = new Point(59, 287);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(127, 19);
            lblSegundoApellido.TabIndex = 7;
            lblSegundoApellido.Text = "Segundo apellido";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(59, 251);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(151, 23);
            txtPrimerApellido.TabIndex = 6;
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrimerApellido.Location = new Point(59, 229);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(114, 19);
            lblPrimerApellido.TabIndex = 5;
            lblPrimerApellido.Text = "Primer apellido";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(59, 194);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(151, 23);
            txtSegundoNombre.TabIndex = 4;
            // 
            // lblSegundoNombre
            // 
            lblSegundoNombre.AutoSize = true;
            lblSegundoNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSegundoNombre.Location = new Point(54, 172);
            lblSegundoNombre.Name = "lblSegundoNombre";
            lblSegundoNombre.Size = new Size(125, 19);
            lblSegundoNombre.TabIndex = 3;
            lblSegundoNombre.Text = "Segundo nombre";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(59, 139);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(151, 23);
            txtPrimerNombre.TabIndex = 2;
            // 
            // lblPrimerNombre
            // 
            lblPrimerNombre.AutoSize = true;
            lblPrimerNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrimerNombre.Location = new Point(54, 119);
            lblPrimerNombre.Name = "lblPrimerNombre";
            lblPrimerNombre.Size = new Size(112, 19);
            lblPrimerNombre.TabIndex = 1;
            lblPrimerNombre.Text = "Primer nombre";
            // 
            // LblRegistrarse
            // 
            LblRegistrarse.AutoSize = true;
            LblRegistrarse.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            LblRegistrarse.ForeColor = Color.DodgerBlue;
            LblRegistrarse.Location = new Point(146, 48);
            LblRegistrarse.Name = "LblRegistrarse";
            LblRegistrarse.Size = new Size(197, 46);
            LblRegistrarse.TabIndex = 0;
            LblRegistrarse.Text = "Registrarse";
            // 
            // panelInicioSesion
            // 
            panelInicioSesion.Controls.Add(lblOlvideContrasena);
            panelInicioSesion.Controls.Add(lblRegistro);
            panelInicioSesion.Controls.Add(lblNoCuenta);
            panelInicioSesion.Controls.Add(txtContrasenaLogin);
            panelInicioSesion.Controls.Add(lblContrasenaLogin);
            panelInicioSesion.Controls.Add(txtUsuarioLogin);
            panelInicioSesion.Controls.Add(lblIniciarSesion);
            panelInicioSesion.Controls.Add(lblNombUsuario);
            panelInicioSesion.Controls.Add(btnIniciarSesion);
            panelInicioSesion.Location = new Point(182, 23);
            panelInicioSesion.Name = "panelInicioSesion";
            panelInicioSesion.Size = new Size(596, 611);
            panelInicioSesion.TabIndex = 24;
            // 
            // lblOlvideContrasena
            // 
            lblOlvideContrasena.AutoSize = true;
            lblOlvideContrasena.Location = new Point(231, 436);
            lblOlvideContrasena.Name = "lblOlvideContrasena";
            lblOlvideContrasena.Size = new Size(141, 15);
            lblOlvideContrasena.TabIndex = 8;
            lblOlvideContrasena.TabStop = true;
            lblOlvideContrasena.Text = "¿Olvidaste tu contraseña?";
            lblOlvideContrasena.LinkClicked += lblOlvideContrasena_LinkClicked;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Location = new Point(354, 409);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(59, 15);
            lblRegistro.TabIndex = 7;
            lblRegistro.TabStop = true;
            lblRegistro.Text = "Registrate";
            lblRegistro.LinkClicked += lblRegistro_LinkClicked;
            // 
            // lblNoCuenta
            // 
            lblNoCuenta.AutoSize = true;
            lblNoCuenta.Location = new Point(186, 410);
            lblNoCuenta.Name = "lblNoCuenta";
            lblNoCuenta.Size = new Size(152, 15);
            lblNoCuenta.TabIndex = 6;
            lblNoCuenta.Text = "¿Aún no tienes una cuenta?";
            // 
            // txtContrasenaLogin
            // 
            txtContrasenaLogin.Location = new Point(236, 300);
            txtContrasenaLogin.Name = "txtContrasenaLogin";
            txtContrasenaLogin.Size = new Size(134, 23);
            txtContrasenaLogin.TabIndex = 5;
            txtContrasenaLogin.UseSystemPasswordChar = true;
            // 
            // lblContrasenaLogin
            // 
            lblContrasenaLogin.AutoSize = true;
            lblContrasenaLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContrasenaLogin.Location = new Point(231, 268);
            lblContrasenaLogin.Name = "lblContrasenaLogin";
            lblContrasenaLogin.Size = new Size(84, 19);
            lblContrasenaLogin.TabIndex = 4;
            lblContrasenaLogin.Text = "Contraseña";
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(231, 229);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(139, 23);
            txtUsuarioLogin.TabIndex = 3;
            // 
            // lblIniciarSesion
            // 
            lblIniciarSesion.AutoSize = true;
            lblIniciarSesion.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblIniciarSesion.ForeColor = Color.DodgerBlue;
            lblIniciarSesion.Location = new Point(209, 129);
            lblIniciarSesion.Name = "lblIniciarSesion";
            lblIniciarSesion.Size = new Size(184, 37);
            lblIniciarSesion.TabIndex = 2;
            lblIniciarSesion.Text = "Iniciar sesión";
            lblIniciarSesion.Click += lblIniciarSesion_Click;
            // 
            // lblNombUsuario
            // 
            lblNombUsuario.AutoSize = true;
            lblNombUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombUsuario.Location = new Point(231, 195);
            lblNombUsuario.Name = "lblNombUsuario";
            lblNombUsuario.Size = new Size(139, 19);
            lblNombUsuario.TabIndex = 1;
            lblNombUsuario.Text = "Nombre de usuario";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.DodgerBlue;
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(266, 350);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(80, 23);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "Ingresar";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // panelRecuperarContrasena
            // 
            panelRecuperarContrasena.Controls.Add(btnSalir);
            panelRecuperarContrasena.Controls.Add(btnCambiarContrasena);
            panelRecuperarContrasena.Controls.Add(btnBuscarPregunta);
            panelRecuperarContrasena.Controls.Add(btnValidarRespuesta);
            panelRecuperarContrasena.Controls.Add(txtRecuperarConfirmarContrasena);
            panelRecuperarContrasena.Controls.Add(lblConfirmarContra);
            panelRecuperarContrasena.Controls.Add(txtRecuperarRespuesta);
            panelRecuperarContrasena.Controls.Add(txtRecuperarNuevaContrasena);
            panelRecuperarContrasena.Controls.Add(lblRecuperar);
            panelRecuperarContrasena.Controls.Add(lblPreguntaRecuperacion);
            panelRecuperarContrasena.Controls.Add(txtRecuperarUsuario);
            panelRecuperarContrasena.Controls.Add(label1);
            panelRecuperarContrasena.Controls.Add(lblRecuperarContrasena);
            panelRecuperarContrasena.Location = new Point(182, 34);
            panelRecuperarContrasena.Name = "panelRecuperarContrasena";
            panelRecuperarContrasena.Size = new Size(528, 507);
            panelRecuperarContrasena.TabIndex = 9;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(425, 16);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCambiarContrasena
            // 
            btnCambiarContrasena.Location = new Point(188, 404);
            btnCambiarContrasena.Name = "btnCambiarContrasena";
            btnCambiarContrasena.Size = new Size(128, 23);
            btnCambiarContrasena.TabIndex = 12;
            btnCambiarContrasena.Text = "Guardar ";
            btnCambiarContrasena.UseVisualStyleBackColor = true;
            btnCambiarContrasena.Click += btnCambiarContrasena_Click;
            // 
            // btnBuscarPregunta
            // 
            btnBuscarPregunta.Location = new Point(120, 151);
            btnBuscarPregunta.Name = "btnBuscarPregunta";
            btnBuscarPregunta.Size = new Size(128, 23);
            btnBuscarPregunta.TabIndex = 11;
            btnBuscarPregunta.Text = "Buscar pregunta";
            btnBuscarPregunta.UseVisualStyleBackColor = true;
            btnBuscarPregunta.Click += btnBuscarPregunta_Click;
            // 
            // btnValidarRespuesta
            // 
            btnValidarRespuesta.Location = new Point(280, 248);
            btnValidarRespuesta.Name = "btnValidarRespuesta";
            btnValidarRespuesta.Size = new Size(139, 23);
            btnValidarRespuesta.TabIndex = 10;
            btnValidarRespuesta.Text = "Validar respuesta";
            btnValidarRespuesta.UseVisualStyleBackColor = true;
            btnValidarRespuesta.Click += btnValidarRespuesta_Click;
            // 
            // txtRecuperarConfirmarContrasena
            // 
            txtRecuperarConfirmarContrasena.Location = new Point(282, 325);
            txtRecuperarConfirmarContrasena.Name = "txtRecuperarConfirmarContrasena";
            txtRecuperarConfirmarContrasena.Size = new Size(125, 23);
            txtRecuperarConfirmarContrasena.TabIndex = 9;
            // 
            // lblConfirmarContra
            // 
            lblConfirmarContra.AutoSize = true;
            lblConfirmarContra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConfirmarContra.Location = new Point(120, 325);
            lblConfirmarContra.Name = "lblConfirmarContra";
            lblConfirmarContra.Size = new Size(154, 19);
            lblConfirmarContra.TabIndex = 8;
            lblConfirmarContra.Text = "Confirmar contraseña";
            // 
            // txtRecuperarRespuesta
            // 
            txtRecuperarRespuesta.Location = new Point(120, 248);
            txtRecuperarRespuesta.Name = "txtRecuperarRespuesta";
            txtRecuperarRespuesta.Size = new Size(128, 23);
            txtRecuperarRespuesta.TabIndex = 6;
            txtRecuperarRespuesta.Text = "Respuesta";
            txtRecuperarRespuesta.TextAlign = HorizontalAlignment.Center;
            txtRecuperarRespuesta.TextChanged += txtRecuperarRespuesta_TextChanged;
            // 
            // txtRecuperarNuevaContrasena
            // 
            txtRecuperarNuevaContrasena.Location = new Point(282, 287);
            txtRecuperarNuevaContrasena.Name = "txtRecuperarNuevaContrasena";
            txtRecuperarNuevaContrasena.Size = new Size(125, 23);
            txtRecuperarNuevaContrasena.TabIndex = 5;
            // 
            // lblRecuperar
            // 
            lblRecuperar.AutoSize = true;
            lblRecuperar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRecuperar.Location = new Point(120, 287);
            lblRecuperar.Name = "lblRecuperar";
            lblRecuperar.Size = new Size(128, 19);
            lblRecuperar.TabIndex = 4;
            lblRecuperar.Text = "Contraseña nueva";
            // 
            // lblPreguntaRecuperacion
            // 
            lblPreguntaRecuperacion.AutoSize = true;
            lblPreguntaRecuperacion.Location = new Point(280, 142);
            lblPreguntaRecuperacion.MaximumSize = new Size(300, 80);
            lblPreguntaRecuperacion.MinimumSize = new Size(100, 60);
            lblPreguntaRecuperacion.Name = "lblPreguntaRecuperacion";
            lblPreguntaRecuperacion.Size = new Size(100, 60);
            lblPreguntaRecuperacion.TabIndex = 3;
            // 
            // txtRecuperarUsuario
            // 
            txtRecuperarUsuario.Location = new Point(280, 87);
            txtRecuperarUsuario.Name = "txtRecuperarUsuario";
            txtRecuperarUsuario.Size = new Size(125, 23);
            txtRecuperarUsuario.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(120, 87);
            label1.Name = "label1";
            label1.Size = new Size(139, 19);
            label1.TabIndex = 1;
            label1.Text = "Nombre de usuario";
            // 
            // lblRecuperarContrasena
            // 
            lblRecuperarContrasena.AutoSize = true;
            lblRecuperarContrasena.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblRecuperarContrasena.ForeColor = Color.DodgerBlue;
            lblRecuperarContrasena.Location = new Point(56, 16);
            lblRecuperarContrasena.Name = "lblRecuperarContrasena";
            lblRecuperarContrasena.Size = new Size(238, 30);
            lblRecuperarContrasena.TabIndex = 0;
            lblRecuperarContrasena.Text = "Recuperar contraseña";
            // 
            // FormRegistroLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 678);
            Controls.Add(panelInicioSesion);
            Controls.Add(panelRegistrarUsuario);
            Controls.Add(panelRecuperarContrasena);
            Name = "FormRegistroLogin";
            Text = "RegistroEInicioSesion";
            Load += FormRegistroLogin_Load;
            panelRegistrarUsuario.ResumeLayout(false);
            panelRegistrarUsuario.PerformLayout();
            panelInicioSesion.ResumeLayout(false);
            panelInicioSesion.PerformLayout();
            panelRecuperarContrasena.ResumeLayout(false);
            panelRecuperarContrasena.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRegistrarUsuario;
        private TextBox txtPrimerNombre;
        private Label lblPrimerNombre;
        private Label LblRegistrarse;
        private TextBox txtSegundoApellido;
        private Label lblSegundoApellido;
        private TextBox txtPrimerApellido;
        private Label lblPrimerApellido;
        private TextBox txtSegundoNombre;
        private Label lblSegundoNombre;
        private Label lblCorreo;
        private ComboBox combBRol;
        private Label lblRol;
        private TextBox txtCorreo;
        private Label lblNombreUsuario;
        private Label lblContrasenaRegistro;
        private TextBox txtUsuarioRegistro;
        private Label lblPreguntaSeguridad;
        private TextBox txtContrasenaRegistro;
        private Button btnRegistrar;
        private TextBox txtPregunta;
        private TextBox txtRespuestaSeguridad;
        private Label lblYaTienesCuenta;
        private LinkLabel lblIrInicioSesion;
        private Panel panelInicioSesion;
        private Label lblDisponible;
        private Button btnIniciarSesion;
        private TextBox txtContrasenaLogin;
        private Label lblContrasenaLogin;
        private TextBox txtUsuarioLogin;
        private Label lblIniciarSesion;
        private Label lblNombUsuario;
        private LinkLabel lblOlvideContrasena;
        private LinkLabel lblRegistro;
        private Label lblNoCuenta;
        private Panel panelRecuperarContrasena;
        private TextBox txtRecuperarUsuario;
        private Label label1;
        private Label lblRecuperarContrasena;
        private Label lblRecuperar;
        private Label lblPreguntaRecuperacion;
        private TextBox txtRecuperarRespuesta;
        private TextBox txtRecuperarNuevaContrasena;
        private TextBox txtRecuperarConfirmarContrasena;
        private Label lblConfirmarContra;
        private Button btnCambiarContrasena;
        private Button btnBuscarPregunta;
        private Button btnValidarRespuesta;
        private Button btnSalir;
        private Label lblRespuesta;
    }
}
