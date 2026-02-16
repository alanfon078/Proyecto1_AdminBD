namespace Proyecto1_AdminBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlContenedor = new Panel();
            lblTitulo = new Label();
            panelMenu = new Panel();
            btnMecanicos = new Button();
            btnVehiculos = new Button();
            pnlContenedor.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.White;
            pnlContenedor.Controls.Add(lblTitulo);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(220, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1133, 808);
            pnlContenedor.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 60);
            lblTitulo.Location = new Point(50, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(446, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Administración";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(30, 30, 60);
            panelMenu.Controls.Add(btnMecanicos);
            panelMenu.Controls.Add(btnVehiculos);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 808);
            panelMenu.TabIndex = 1;
            // 
            // btnMecanicos
            // 
            btnMecanicos.BackColor = Color.FromArgb(30, 30, 60);
            btnMecanicos.Dock = DockStyle.Top;
            btnMecanicos.FlatAppearance.BorderSize = 0;
            btnMecanicos.FlatStyle = FlatStyle.Flat;
            btnMecanicos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnMecanicos.ForeColor = Color.White;
            btnMecanicos.Location = new Point(0, 60);
            btnMecanicos.Name = "btnMecanicos";
            btnMecanicos.Size = new Size(220, 60);
            btnMecanicos.TabIndex = 0;
            btnMecanicos.Text = "🔧  Mecánicos";
            btnMecanicos.UseVisualStyleBackColor = false;
            // 
            // btnVehiculos
            // 
            btnVehiculos.BackColor = Color.FromArgb(30, 30, 60);
            btnVehiculos.Dock = DockStyle.Top;
            btnVehiculos.FlatAppearance.BorderSize = 0;
            btnVehiculos.FlatStyle = FlatStyle.Flat;
            btnVehiculos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVehiculos.ForeColor = Color.White;
            btnVehiculos.Location = new Point(0, 0);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(220, 60);
            btnVehiculos.TabIndex = 1;
            btnVehiculos.Text = "🚗  Vehículos";
            btnVehiculos.UseVisualStyleBackColor = false;
            btnVehiculos.Click += btnVehiculos_Click;
            // 
            // Form1
            // 
            BackColor = Color.White;
            ClientSize = new Size(1353, 808);
            Controls.Add(pnlContenedor);
            Controls.Add(panelMenu);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Taller Mecánico";
            WindowState = FormWindowState.Maximized;
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private Panel pnlContenedor;
        private Panel panel2;
        private Button button2;
        private Button btnVehiculos;
        private Button btnMecanicos;
        private Label lblTitulo;
        private Panel panelMenu;
    }
}
