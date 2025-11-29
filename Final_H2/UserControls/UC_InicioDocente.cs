using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_H2.UserControls
{
    public partial class UC_InicioDocente : UserControl
    {

        private string _docente;

        public event EventHandler CrearInstitucionClick;
        public event EventHandler CrearCursoClick;
        public event Action<string> InstitucionSeleccionada;


        //constructor
        public UC_InicioDocente(string docente)
        {
            InitializeComponent();
            _docente = docente;
            ConfigurarVista();

            flowInstituciones.FlowDirection = FlowDirection.LeftToRight;
            flowInstituciones.WrapContents = true;
            flowInstituciones.AutoScroll = true;
        }

        private void ConfigurarVista()
        {
            lblBienvenida.Text = $"¡Bienvenido, {_docente}!";
        }

        public void AgregarInstitucion(string nombre, string tipo, string codigo)
        {
            Panel card = new Panel
            {
                Width = 360,
                Height = 140,
                BackColor = Color.FromArgb(180, 205, 255),
                Margin = new Padding(10),
                Cursor = Cursors.Hand
            };

            Label lbl = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Text = $"{nombre}\nTipo: {tipo}\nCódigo: {codigo}",
                Cursor = Cursors.Hand
            };

            card.Controls.Add(lbl);

            card.Click += (s, e) => InstitucionSeleccionada?.Invoke(nombre);
            lbl.Click += (s, e) => InstitucionSeleccionada?.Invoke(nombre);

            flowInstituciones.Controls.Add(card);
        }

        public void CargarInstitucionesDesdeBD(List<(string nombre, int tipo, string codigo)> lista)
        {
            flowInstituciones.Controls.Clear();

            foreach (var inst in lista)
            {
                string tipoTexto = inst.tipo == 1 ? "Universidad" : "Colegio";
                AgregarInstitucion(inst.nombre, tipoTexto, inst.codigo);
            }
        }


        private void btnCrearInstitucion_Click(object sender, EventArgs e)
        {
            CrearInstitucionClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            CrearCursoClick?.Invoke(this, EventArgs.Empty);
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }
    }
}
