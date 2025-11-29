using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_H2.Forms;

namespace Final_H2.UserControls
{
    public partial class UC_CrearInstitucion : UserControl
    {
        private string _docente;

        public event Action<string, int, string, string> InstitucionGuardada;

        public UC_CrearInstitucion()
        {
            InitializeComponent();
        }
        public UC_CrearInstitucion(string docente)
        {
            InitializeComponent();
            _docente = docente;
            lblIdDocente.Text = docente;

            cmbTipoInstitucion.Items.Add("Universidad");
            cmbTipoInstitucion.Items.Add("Colegio");
        }

        private void btnGuardarInstitucion_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreInstitucion.Text;
            string codigo = txtCodigoInstitucion.Text;

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(codigo) ||
                cmbTipoInstitucion.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            int tipo = cmbTipoInstitucion.SelectedIndex + 1;

            string docente = _docente;

            InstitucionGuardada?.Invoke(nombre, tipo, codigo, docente);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ((FormMain)this.ParentForm).VolverAlInicio();
        }
    }
}
