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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            btnMecanicos = new Button();
            btnVehiculos = new Button();
            pnlLogo = new Panel();
            lblLogo = new Label();
            pnlContenedor = new Panel();
            pnlHeader = new Panel();
            lblTitulo = new Label();
            panelMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlContenedor.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(30, 30, 60);
            panelMenu.Controls.Add(btnMecanicos);
            panelMenu.Controls.Add(btnVehiculos);
            panelMenu.Controls.Add(pnlLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 808);
            panelMenu.TabIndex = 1;
            // 
            // btnMecanicos
            // 
            btnMecanicos.Cursor = Cursors.Hand;
            btnMecanicos.Dock = DockStyle.Top;
            btnMecanicos.FlatAppearance.BorderSize = 0;
            btnMecanicos.FlatStyle = FlatStyle.Flat;
            btnMecanicos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMecanicos.ForeColor = Color.White;
            btnMecanicos.Image = (Image)resources.GetObject("btnMecanicos.Image");
            btnMecanicos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMecanicos.Location = new Point(0, 190);
            btnMecanicos.Name = "btnMecanicos";
            btnMecanicos.Padding = new Padding(20, 0, 0, 0);
            btnMecanicos.Size = new Size(220, 70);
            btnMecanicos.TabIndex = 0;
            btnMecanicos.Text = "   Mecánicos";
            btnMecanicos.Click += btnMecanicos_Click;
            // 
            // btnVehiculos
            // 
            btnVehiculos.Cursor = Cursors.Hand;
            btnVehiculos.Dock = DockStyle.Top;
            btnVehiculos.FlatAppearance.BorderSize = 0;
            btnVehiculos.FlatStyle = FlatStyle.Flat;
            btnVehiculos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVehiculos.ForeColor = Color.White;
            btnVehiculos.Image = Properties.Resources.car_gear_50dp_E3E3E3_FILL0_wght400_GRAD0_opsz48;
            btnVehiculos.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehiculos.Location = new Point(0, 120);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Padding = new Padding(20, 0, 0, 0);
            btnVehiculos.Size = new Size(220, 70);
            btnVehiculos.TabIndex = 1;
            btnVehiculos.Text = "   Vehículos";
            btnVehiculos.Click += btnVehiculos_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(lblLogo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(220, 120);
            pnlLogo.TabIndex = 2;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Fill;
            lblLogo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(220, 120);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "TALLER\nADMIN";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.FromArgb(245, 247, 250);
            pnlContenedor.Controls.Add(pnlHeader);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(220, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1133, 808);
            pnlContenedor.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(25, 0, 0, 0);
            pnlHeader.Size = new Size(1133, 78);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 60);
            lblTitulo.Location = new Point(25, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(451, 78);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Administración";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
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
            panelMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlContenedor.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private Panel pnlContenedor;
        private Panel panel2;
        private Button button2;
        private Button btnVehiculos;
        private Label lblTitulo;
        private Panel panelMenu;
        private Button btnMecanicos;
        private Panel pnlHeader;
        private Label lblLogo;
        private Panel pnlLogo;
    }
}