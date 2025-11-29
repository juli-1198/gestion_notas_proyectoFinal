namespace Final_H2.UserControls
{
    partial class UC_CrearCurso
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
            lblNombreCurso = new Label();
            txtNombreCurso = new TextBox();
            lblNumeroGrupo = new Label();
            txtNumeroGrupo = new TextBox();
            lblSalon = new Label();
            txtSalon = new TextBox();
            lblInstitucion = new Label();
            cmbInstituciones = new ComboBox();
            lblIdDocente = new Label();
            lblCodigoCurso = new Label();
            btnGuardarCurso = new Button();
            label1 = new Label();
            btnCerrar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblNombreCurso
            // 
            lblNombreCurso.AutoSize = true;
            lblNombreCurso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombreCurso.Location = new Point(77, 95);
            lblNombreCurso.Name = "lblNombreCurso";
            lblNombreCurso.Size = new Size(65, 19);
            lblNombreCurso.TabIndex = 0;
            lblNombreCurso.Text = "Nombre";
            // 
            // txtNombreCurso
            // 
            txtNombreCurso.Location = new Point(77, 122);
            txtNombreCurso.Name = "txtNombreCurso";
            txtNombreCurso.Size = new Size(141, 23);
            txtNombreCurso.TabIndex = 1;
            // 
            // lblNumeroGrupo
            // 
            lblNumeroGrupo.AutoSize = true;
            lblNumeroGrupo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNumeroGrupo.Location = new Point(77, 157);
            lblNumeroGrupo.Name = "lblNumeroGrupo";
            lblNumeroGrupo.Size = new Size(130, 19);
            lblNumeroGrupo.TabIndex = 2;
            lblNumeroGrupo.Text = "Número de grupo";
            // 
            // txtNumeroGrupo
            // 
            txtNumeroGrupo.Location = new Point(77, 179);
            txtNumeroGrupo.Name = "txtNumeroGrupo";
            txtNumeroGrupo.Size = new Size(141, 23);
            txtNumeroGrupo.TabIndex = 3;
            // 
            // lblSalon
            // 
            lblSalon.AutoSize = true;
            lblSalon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSalon.Location = new Point(77, 213);
            lblSalon.Name = "lblSalon";
            lblSalon.Size = new Size(46, 19);
            lblSalon.TabIndex = 4;
            lblSalon.Text = "Salón";
            // 
            // txtSalon
            // 
            txtSalon.Location = new Point(77, 235);
            txtSalon.Name = "txtSalon";
            txtSalon.Size = new Size(141, 23);
            txtSalon.TabIndex = 5;
            // 
            // lblInstitucion
            // 
            lblInstitucion.AutoSize = true;
            lblInstitucion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInstitucion.Location = new Point(77, 270);
            lblInstitucion.Name = "lblInstitucion";
            lblInstitucion.Size = new Size(77, 19);
            lblInstitucion.TabIndex = 6;
            lblInstitucion.Text = "Institución";
            // 
            // cmbInstituciones
            // 
            cmbInstituciones.FormattingEnabled = true;
            cmbInstituciones.Location = new Point(77, 292);
            cmbInstituciones.Name = "cmbInstituciones";
            cmbInstituciones.Size = new Size(141, 23);
            cmbInstituciones.TabIndex = 7;
            // 
            // lblIdDocente
            // 
            lblIdDocente.AutoSize = true;
            lblIdDocente.Location = new Point(169, 329);
            lblIdDocente.Name = "lblIdDocente";
            lblIdDocente.Size = new Size(38, 15);
            lblIdDocente.TabIndex = 8;
            lblIdDocente.Text = "label1";
            // 
            // lblCodigoCurso
            // 
            lblCodigoCurso.AutoSize = true;
            lblCodigoCurso.Location = new Point(169, 361);
            lblCodigoCurso.Name = "lblCodigoCurso";
            lblCodigoCurso.Size = new Size(38, 15);
            lblCodigoCurso.TabIndex = 9;
            lblCodigoCurso.Text = "label1";
            // 
            // btnGuardarCurso
            // 
            btnGuardarCurso.BackColor = Color.DodgerBlue;
            btnGuardarCurso.ForeColor = Color.White;
            btnGuardarCurso.Location = new Point(43, 395);
            btnGuardarCurso.Name = "btnGuardarCurso";
            btnGuardarCurso.Size = new Size(99, 32);
            btnGuardarCurso.TabIndex = 10;
            btnGuardarCurso.Text = "Registrar";
            btnGuardarCurso.UseVisualStyleBackColor = false;
            btnGuardarCurso.Click += btnGuardarCurso_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(64, 48);
            label1.Name = "label1";
            label1.Size = new Size(169, 30);
            label1.TabIndex = 11;
            label1.Text = "Registrar curso";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(160, 395);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(99, 32);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 330);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 13;
            label2.Text = "label2";
            // 
            // UC_CrearCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            Controls.Add(btnGuardarCurso);
            Controls.Add(lblCodigoCurso);
            Controls.Add(lblIdDocente);
            Controls.Add(cmbInstituciones);
            Controls.Add(lblInstitucion);
            Controls.Add(txtSalon);
            Controls.Add(lblSalon);
            Controls.Add(txtNumeroGrupo);
            Controls.Add(lblNumeroGrupo);
            Controls.Add(txtNombreCurso);
            Controls.Add(lblNombreCurso);
            Name = "UC_CrearCurso";
            Size = new Size(300, 460);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreCurso;
        private TextBox txtNombreCurso;
        private Label lblNumeroGrupo;
        private TextBox txtNumeroGrupo;
        private Label lblSalon;
        private TextBox txtSalon;
        private Label lblInstitucion;
        private ComboBox cmbInstituciones;
        private Label lblIdDocente;
        private Label lblCodigoCurso;
        private Button btnGuardarCurso;
        private Label label1;
        private Button btnCerrar;
        private Label label2;
    }
}
