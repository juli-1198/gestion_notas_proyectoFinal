using System;
using System.Drawing;
using System.Windows.Forms;
using Final_H2.Models;
using Final_H2.Services;
using Final_H2.UserControls;

namespace Final_H2.Forms
{
    public partial class FormMain : Form
    {
        private readonly Usuario usuarioActual;
        private readonly InstitucionService institucionService;
        private readonly CursoService cursoService;

        private bool menuVisible = true;
        


        public FormMain(Usuario usuario)
        {
            InitializeComponent();

            usuarioActual = usuario ?? throw new ArgumentNullException(nameof(usuario));
            institucionService = new InstitucionService();
            cursoService = new CursoService();

            ConfigurarFormMain();

            panelMenuLateral.Visible = false;
            menuVisible = false;
        }


        // CONFIGURACIÓN INICIAL
        private void ConfigurarFormMain()
        {
            CargarCursosMenuDesdeBD();
            CargarUC_InicioDocente(usuarioActual.NombreCompleto);
        }

        // CARGA CURSOS DEL MENÚ LATERAL DESDE BD
        private void CargarCursosMenuDesdeBD()
        {
            flowCursosMenu.Controls.Clear();

            var instituciones = institucionService.ObtenerInstitucionesDocente(usuarioActual.NombreCompleto);

            foreach (var inst in instituciones)
            {
                var cursos = cursoService.ObtenerCursosInstitucion(inst.idInstitucion);

                foreach (var c in cursos)
                    AgregarCursoMenu(c.nombreCurso, c.numeroGrupo.ToString());
            }
        }


        // CARGA GENÉRICA DE USERCONTROLS
        private void CargarVista(UserControl uc)
        {
            panelPrincipal.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(uc);
        }


        // VISTA: INICIO DOCENTE
        private void CargarUC_InicioDocente(string docente)
        {
            MostrarCursosEnMenu();
            var uc = new UC_InicioDocente(docente);

            // Cargar instituciones desde PostgreSQL
            var lista = institucionService.ObtenerInstitucionesDocente(docente);
            var datos = new List<(string nombre, int tipo, string codigo)>();

            foreach (var inst in lista)
                datos.Add((inst.nombre, inst.tipoInstitucion, inst.codigoInstitucion));

            uc.CargarInstitucionesDesdeBD(datos);

            // Eventos
            uc.CrearInstitucionClick += (s, e) =>
            {
                CargarUC_CrearInstitucion(docente);
            };

            uc.CrearCursoClick += (s, e) =>
            {
                CargarUC_CrearCurso(docente);
            };

            uc.InstitucionSeleccionada += (institucion) =>
            {
                CargarUC_CursosDeInstitucion(institucion);
            };

            CargarVista(uc);
        }


        // VISTA: CREAR INSTITUCIÓN
        private void CargarUC_CrearInstitucion(string docente)
        {
            var uc = new UC_CrearInstitucion(docente);

            uc.InstitucionGuardada += (nombre, tipo, codigo, doc) =>
            {
                int id = institucionService.CrearInstitucion(nombre, tipo, codigo, doc);

                if (id > 0)
                {
                    MessageBox.Show("Institución creada exitosamente.");
                    ConfigurarFormMain();
                }
                else
                    MessageBox.Show("Error al crear institución.");
            };

            CargarVista(uc);
        }

        // VISTA: CREAR CURSO
        private void CargarUC_CrearCurso(string docente)
        {
            var uc = new UC_CrearCurso(docente);

            // Cargar instituciones desde BD
            var lista = institucionService.ObtenerInstitucionesDocente(docente);
            uc.CargarInstituciones(lista.ConvertAll(x => x.nombre).ToArray());

            uc.CursoGuardado += (nombre, codigo, grupo, salon, doc, inst) =>
            {
                int idInst = institucionService.ObtenerIdPorNombre(inst);

                int idCurso = cursoService.CrearCurso(
                    nombre,
                    int.Parse(grupo),
                    salon,
                    doc,
                    idInst
                );

                if (idCurso > 0)
                {
                    MessageBox.Show("Curso creado exitosamente.");
                    ConfigurarFormMain();
                    CargarUC_CursosDeInstitucion(inst);
                }
                else
                    MessageBox.Show("Error al crear curso.");
            };

            CargarVista(uc);
        }

        // VISTA: CURSOS DE UNA INSTITUCIÓN
        private void CargarUC_CursosDeInstitucion(string nombreInst)
        {
            MostrarInstitucionesEnMenu();
            var uc = new UC_CursosDeInstitucion(nombreInst);

            int idInst = institucionService.ObtenerIdPorNombre(nombreInst);
            var cursos = cursoService.ObtenerCursosInstitucion(idInst);

            foreach (var c in cursos)
            {
                uc.AgregarCurso(
                    c.nombreCurso,
                    c.codigoCurso,
                    c.numeroGrupo.ToString(),
                    c.salon,
                    c.idDocente
                );
            }

            CargarVista(uc);
        }


        //carga instituciones en el menu lateral
        private void AgregarInstitucionMenu(string nombre, string codigo)
        {
            Panel card = new Panel
            {
                Width = 200,
                Height = 75,
                BackColor = Color.FromArgb(200, 220, 255),
                Margin = new Padding(8),
                BorderStyle = BorderStyle.FixedSingle,
                Cursor = Cursors.Hand
            };

            Label lbl = new Label
            {
                Text = $"{nombre}\nCódigo: {codigo}",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9),
                TextAlign = ContentAlignment.MiddleCenter
            };

            card.Controls.Add(lbl);

            
            card.Click += (s, e) =>
            {
                CargarUC_CursosDeInstitucion(nombre);
            };

            flowCursosMenu.Controls.Add(card);
        }


        // MENÚ LATERAL (MINI CARDS DE CURSOS)
        private void AgregarCursoMenu(string nombre, string grupo)
        {
            var card = new Panel
            {
                Width = 200,
                Height = 75,
                BackColor = Color.White,
                Margin = new Padding(8),
                BorderStyle = BorderStyle.FixedSingle,
                Cursor = Cursors.Hand
            };

            var lbl = new Label
            {
                Text = $"{nombre}\nGrupo {grupo}",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9),
                TextAlign = ContentAlignment.MiddleCenter
            };

            card.Controls.Add(lbl);

            card.Click += (s, e) =>
            {
                CargarUC_CursosDeInstitucion(nombre);
            };

            flowCursosMenu.Controls.Add(card);
        }

        private void MostrarInstitucionesEnMenu()
        {
            flowCursosMenu.Controls.Clear();

            InstitucionService instService = new InstitucionService();

            var instituciones = instService.ObtenerInstitucionesDocente(usuarioActual.NombreCompleto);

            foreach (var inst in instituciones)
            {
                AgregarInstitucionMenu(inst.nombre, inst.codigoInstitucion);
            }
        }

        private void MostrarCursosEnMenu()
        {
            flowCursosMenu.Controls.Clear();

            CursoService cursoService = new CursoService();

            var cursos = cursoService.ObtenerCursosDocente(usuarioActual.NombreCompleto);

            foreach (var c in cursos)
            {
                AgregarCursoMenu(c.nombreCurso, c.numeroGrupo.ToString());
            }
        }

        // BOTONES SUPERIORES

        public void VolverAlInicio()
        {
            string nombre = usuarioActual.NombreCompleto;
            CargarUC_InicioDocente(nombre);
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            menuVisible = !menuVisible;
            panelMenuLateral.Visible = menuVisible;
        }
    }
}
