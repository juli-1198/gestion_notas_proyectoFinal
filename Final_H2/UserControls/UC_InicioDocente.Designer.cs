namespace Final_H2.UserControls
{
    partial class UC_InicioDocente
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblBienvenida = new Label();
            panelAcciones = new Panel();
            btnCrearInstitucion = new Button();
            btnCrearCurso = new Button();
            flowInstituciones = new FlowLayoutPanel();
            panelAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Dock = DockStyle.Top;
            lblBienvenida.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBienvenida.Location = new Point(0, 0);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Padding = new Padding(10);
            lblBienvenida.Size = new Size(239, 45);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "¡Bienvenido, [nombre]!";
            lblBienvenida.TextAlign = ContentAlignment.MiddleLeft;
            lblBienvenida.Click += lblBienvenida_Click;
            // 
            // panelAcciones
            // 
            panelAcciones.Controls.Add(btnCrearInstitucion);
            panelAcciones.Controls.Add(btnCrearCurso);
            panelAcciones.Dock = DockStyle.Top;
            panelAcciones.Location = new Point(0, 45);
            panelAcciones.Name = "panelAcciones";
            panelAcciones.Size = new Size(900, 60);
            panelAcciones.TabIndex = 1;
            // 
            // btnCrearInstitucion
            // 
            btnCrearInstitucion.Location = new Point(12, 14);
            btnCrearInstitucion.Name = "btnCrearInstitucion";
            btnCrearInstitucion.Size = new Size(130, 30);
            btnCrearInstitucion.TabIndex = 1;
            btnCrearInstitucion.Text = "Crear institución";
            btnCrearInstitucion.UseVisualStyleBackColor = true;
            btnCrearInstitucion.Click += btnCrearInstitucion_Click;
            // 
            // btnCrearCurso
            // 
            btnCrearCurso.Location = new Point(172, 14);
            btnCrearCurso.Name = "btnCrearCurso";
            btnCrearCurso.Size = new Size(130, 30);
            btnCrearCurso.TabIndex = 0;
            btnCrearCurso.Text = "Crear curso";
            btnCrearCurso.UseVisualStyleBackColor = true;
            btnCrearCurso.Click += btnCrearCurso_Click;
            // 
            // flowInstituciones
            // 
            flowInstituciones.AutoScroll = true;
            flowInstituciones.Dock = DockStyle.Fill;
            flowInstituciones.FlowDirection = FlowDirection.TopDown;
            flowInstituciones.Location = new Point(0, 105);
            flowInstituciones.Name = "flowInstituciones";
            flowInstituciones.Padding = new Padding(10);
            flowInstituciones.Size = new Size(900, 595);
            flowInstituciones.TabIndex = 2;
            flowInstituciones.WrapContents = false;
            // 
            // UC_InicioDocente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowInstituciones);
            Controls.Add(panelAcciones);
            Controls.Add(lblBienvenida);
            Name = "UC_InicioDocente";
            Size = new Size(900, 700);
            panelAcciones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Panel panelAcciones;
        private Button btnCrearInstitucion;
        private Button btnCrearCurso;
        private FlowLayoutPanel flowInstituciones;
    }
}
