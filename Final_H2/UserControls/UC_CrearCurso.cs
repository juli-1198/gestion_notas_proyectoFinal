using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_H2.Utils;
using Final_H2.Forms;

namespace Final_H2.UserControls
{
    public partial class UC_CrearCurso : UserControl
    {
        private string _docente;

        public event Action<string, string, string, string, string, string> CursoGuardado;
        public UC_CrearCurso()
        {
            InitializeComponent();
        }

        public UC_CrearCurso(string docente)
        {
            InitializeComponent();
            _docente = docente;
            lblIdDocente.Text = docente;
            lblCodigoCurso.Text = CodigoGenerador.GenerarCodigo();
        }

        public void CargarInstituciones(string[] instituciones)
        {
            cmbInstituciones.Items.Clear();
            cmbInstituciones.Items.AddRange(instituciones);
        }

        private void btnGuardarCurso_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCurso.Text;
            string numeroGrupo = txtNumeroGrupo.Text;
            string salon = txtSalon.Text;
            string docente = _docente;
            string institucion = cmbInstituciones.SelectedItem?.ToString();
            string codigo = lblCodigoCurso.Text;

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(numeroGrupo) ||
                institucion == null)
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            CursoGuardado?.Invoke(nombre, codigo, numeroGrupo, salon, docente, institucion);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ((FormMain)this.ParentForm).VolverAlInicio();
        }
    }
}
