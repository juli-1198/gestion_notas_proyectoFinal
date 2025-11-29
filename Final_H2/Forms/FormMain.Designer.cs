namespace Final_H2.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelPrincipal = new Panel();
            panelMenuLateral = new Panel();
            label1 = new Label();
            flowCursosMenu = new FlowLayoutPanel();
            panelSuperior = new Panel();
            btnMenu = new Button();
            btnCerrarSesion = new Button();
            lblTitulo = new Label();
            panelMenuLateral.SuspendLayout();
            panelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(250, 51);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(900, 621);
            panelPrincipal.TabIndex = 0;
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = SystemColors.Control;
            panelMenuLateral.Controls.Add(label1);
            panelMenuLateral.Controls.Add(flowCursosMenu);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(250, 672);
            panelMenuLateral.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(66, 10);
            label1.Name = "label1";
            label1.Size = new Size(102, 37);
            label1.TabIndex = 4;
            label1.Text = "Cursos";
            // 
            // flowCursosMenu
            // 
            flowCursosMenu.AutoScroll = true;
            flowCursosMenu.FlowDirection = FlowDirection.TopDown;
            flowCursosMenu.Location = new Point(0, 57);
            flowCursosMenu.Name = "flowCursosMenu";
            flowCursosMenu.Padding = new Padding(10);
            flowCursosMenu.Size = new Size(250, 615);
            flowCursosMenu.TabIndex = 3;
            flowCursosMenu.WrapContents = false;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.DodgerBlue;
            panelSuperior.Controls.Add(btnMenu);
            panelSuperior.Controls.Add(btnCerrarSesion);
            panelSuperior.Controls.Add(lblTitulo);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(250, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(900, 51);
            panelSuperior.TabIndex = 2;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(10, 10);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(30, 30);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "☰";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click_1;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarSesion.Location = new Point(776, 15);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(98, 23);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click_1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(62, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(143, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Académico+";
            // 
            // FormMain
            // 
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1150, 672);
            Controls.Add(panelPrincipal);
            Controls.Add(panelSuperior);
            Controls.Add(panelMenuLateral);
            Name = "FormMain";
            panelMenuLateral.ResumeLayout(false);
            panelMenuLateral.PerformLayout();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenuLateral;
        private Panel panelSuperior;
        private Label lblTitulo;
        private Button btnCerrarSesion;
        private Button btnMenu;
        private FlowLayoutPanel flowCursosMenu;
        private Panel panelPrincipal;
        private Label label1;
    }
}