using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_H2.Models;

namespace Final_H2.Forms
{
    public partial class FormMain : Form
    {
        private Usuario _usuario;
        public FormMain(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;  
            CargarInterfazSegunRol();
        }

        private void CargarInterfazSegunRol()
        {
            if (_usuario.Rol == "DOCENTE")
            {
                // Mostrar menú de docente
            }
            else if (_usuario.Rol == "ESTUDIANTE")
            {
                // Mostrar menú de estudiante
            }
        }




        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
