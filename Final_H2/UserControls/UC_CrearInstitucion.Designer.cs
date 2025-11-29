namespace Final_H2.UserControls
{
    partial class UC_CrearInstitucion
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
            lblNombreInstitucion = new Label();
            txtNombreInstitucion = new TextBox();
            btnGuardarInstitucion = new Button();
            lblTipo = new Label();
            lblCodigoInstitucion = new Label();
            txtCodigoInstitucion = new TextBox();
            lblIdDocente = new Label();
            cmbTipoInstitucion = new ComboBox();
            label1 = new Label();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lblNombreInstitucion
            // 
            lblNombreInstitucion.AutoSize = true;
            lblNombreInstitucion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombreInstitucion.Location = new Point(60, 100);
            lblNombreInstitucion.Name = "lblNombreInstitucion";
            lblNombreInstitucion.Size = new Size(65, 19);
            lblNombreInstitucion.TabIndex = 0;
            lblNombreInstitucion.Text = "Nombre";
            // 
            // txtNombreInstitucion
            // 
            txtNombreInstitucion.Location = new Point(60, 131);
            txtNombreInstitucion.Name = "txtNombreInstitucion";
            txtNombreInstitucion.Size = new Size(161, 23);
            txtNombreInstitucion.TabIndex = 1;
            // 
            // btnGuardarInstitucion
            // 
            btnGuardarInstitucion.BackColor = Color.DeepSkyBlue;
            btnGuardarInstitucion.ForeColor = Color.White;
            btnGuardarInstitucion.Location = new Point(74, 326);
            btnGuardarInstitucion.Name = "btnGuardarInstitucion";
            btnGuardarInstitucion.Size = new Size(63, 25);
            btnGuardarInstitucion.TabIndex = 2;
            btnGuardarInstitucion.Text = "Guardar";
            btnGuardarInstitucion.UseVisualStyleBackColor = false;
            btnGuardarInstitucion.Click += btnGuardarInstitucion_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTipo.Location = new Point(60, 169);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(111, 19);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo institución";
            // 
            // lblCodigoInstitucion
            // 
            lblCodigoInstitucion.AutoSize = true;
            lblCodigoInstitucion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCodigoInstitucion.Location = new Point(60, 226);
            lblCodigoInstitucion.Name = "lblCodigoInstitucion";
            lblCodigoInstitucion.Size = new Size(58, 19);
            lblCodigoInstitucion.TabIndex = 5;
            lblCodigoInstitucion.Text = "Código";
            // 
            // txtCodigoInstitucion
            // 
            txtCodigoInstitucion.Location = new Point(60, 248);
            txtCodigoInstitucion.Name = "txtCodigoInstitucion";
            txtCodigoInstitucion.Size = new Size(161, 23);
            txtCodigoInstitucion.TabIndex = 6;
            // 
            // lblIdDocente
            // 
            lblIdDocente.AutoSize = true;
            lblIdDocente.Location = new Point(60, 286);
            lblIdDocente.Name = "lblIdDocente";
            lblIdDocente.Size = new Size(0, 15);
            lblIdDocente.TabIndex = 7;
            // 
            // cmbTipoInstitucion
            // 
            cmbTipoInstitucion.FormattingEnabled = true;
            cmbTipoInstitucion.Location = new Point(60, 191);
            cmbTipoInstitucion.Name = "cmbTipoInstitucion";
            cmbTipoInstitucion.Size = new Size(154, 23);
            cmbTipoInstitucion.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(47, 54);
            label1.Name = "label1";
            label1.Size = new Size(191, 25);
            label1.TabIndex = 9;
            label1.Text = "Registrar institución";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(160, 326);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(63, 25);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // UC_CrearInstitucion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            Controls.Add(cmbTipoInstitucion);
            Controls.Add(lblIdDocente);
            Controls.Add(txtCodigoInstitucion);
            Controls.Add(lblCodigoInstitucion);
            Controls.Add(lblTipo);
            Controls.Add(btnGuardarInstitucion);
            Controls.Add(txtNombreInstitucion);
            Controls.Add(lblNombreInstitucion);
            Name = "UC_CrearInstitucion";
            Size = new Size(300, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreInstitucion;
        private TextBox txtNombreInstitucion;
        private Button btnGuardarInstitucion;
        private Label lblTipo;
        private Label lblCodigoInstitucion;
        private TextBox txtCodigoInstitucion;
        private Label lblIdDocente;
        private ComboBox cmbTipoInstitucion;
        private Label label1;
        private Button btnCerrar;
    }
}
