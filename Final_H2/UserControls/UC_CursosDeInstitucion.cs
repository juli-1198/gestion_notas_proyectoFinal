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
    public partial class UC_CursosDeInstitucion : UserControl
    {
        private string _institucion;
        public UC_CursosDeInstitucion()
        {
            InitializeComponent();
        }

        public UC_CursosDeInstitucion(string institucion)
        {
            InitializeComponent();
            _institucion = institucion;

            flowCursos.FlowDirection = FlowDirection.LeftToRight;
            flowCursos.WrapContents = true;
            flowCursos.AutoScroll = true;
        }

        public void AgregarCurso(string nombre, string codigo, string grupo, string salon, string docente)
        {
            Panel card = new Panel
            {
                Width = 360,
                Height = 180,
                BackColor = Color.FromArgb(180,205,255),
                Margin = new Padding(10),
                Cursor = Cursors.Hand
            };

            Label lbl = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Text = $"{nombre}\nCódigo: {codigo}\nGrupo: {grupo}\nSalón: {salon}\nDocente: {docente}"
            };

            card.Controls.Add(lbl);

            flowCursos.Controls.Add(card);
        }

        private void flowCursos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
