namespace Proyecto1_AdminBD.Forms
{
    public partial class frmMecanicos : Form
    {
        private Panel pnlTop;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnRefrescar;
        private TextBox txtBuscador;
        private DataGridView dgvMecanicos;

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlTop = new Panel();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnRefrescar = new Button();
            txtBuscador = new TextBox();
            dgvMecanicos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMecanicos).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(45, 45, 48);
            pnlTop.Controls.Add(btnNuevo);
            pnlTop.Controls.Add(btnEditar);
            pnlTop.Controls.Add(btnEliminar);
            pnlTop.Controls.Add(btnRefrescar);
            pnlTop.Controls.Add(txtBuscador);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Padding = new Padding(10);
            pnlTop.Size = new Size(1143, 80);
            pnlTop.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(0, 122, 204);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 10F);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Image = Properties.Resources.add_2_30dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            btnNuevo.Location = new Point(12, 25);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 30);
            btnNuevo.TabIndex = 0;
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(0, 122, 204);
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 10F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = Properties.Resources.edit_30dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            btnEditar.Location = new Point(118, 25);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 30);
            btnEditar.TabIndex = 1;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(232, 17, 35);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = Properties.Resources.delete_30dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            btnEliminar.Location = new Point(224, 25);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 2;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.FromArgb(40, 167, 69);
            btnRefrescar.Cursor = Cursors.Hand;
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI", 10F);
            btnRefrescar.ForeColor = Color.White;
            btnRefrescar.Image = Properties.Resources.refresh_30dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            btnRefrescar.Location = new Point(330, 25);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(120, 30);
            btnRefrescar.TabIndex = 3;
            btnRefrescar.UseVisualStyleBackColor = false;
            // 
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscador.BackColor = Color.FromArgb(63, 63, 70);
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 11F);
            txtBuscador.ForeColor = Color.White;
            txtBuscador.Location = new Point(860, 25);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PlaceholderText = "  Buscar...";
            txtBuscador.Size = new Size(260, 25);
            txtBuscador.TabIndex = 5;
            // 
            // dgvMecanicos
            // 
            dgvMecanicos.AllowUserToAddRows = false;
            dgvMecanicos.AllowUserToDeleteRows = false;
            dgvMecanicos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dgvMecanicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMecanicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMecanicos.BackgroundColor = Color.White;
            dgvMecanicos.BorderStyle = BorderStyle.None;
            dgvMecanicos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMecanicos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMecanicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMecanicos.ColumnHeadersHeight = 40;
            dgvMecanicos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(173, 216, 230);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMecanicos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMecanicos.Dock = DockStyle.Fill;
            dgvMecanicos.EnableHeadersVisualStyles = false;
            dgvMecanicos.Location = new Point(0, 80);
            dgvMecanicos.Name = "dgvMecanicos";
            dgvMecanicos.ReadOnly = true;
            dgvMecanicos.RowHeadersVisible = false;
            dgvMecanicos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvMecanicos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvMecanicos.RowTemplate.Height = 35;
            dgvMecanicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMecanicos.Size = new Size(1143, 720);
            dgvMecanicos.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre Completo";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Teléfono";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Especialidad";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Estado";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // Datos de ejemplo
            dgvMecanicos.Rows.Add("1", "Juan Pérez", "555-1234", "Motores", "Activo");
            dgvMecanicos.Rows.Add("2", "María García", "555-5678", "Transmisión", "Activo");
            dgvMecanicos.Rows.Add("3", "Carlos López", "555-9012", "Frenos", "Inactivo");
            dgvMecanicos.Rows.Add("4", "Ana Martínez", "555-3456", "Electricidad", "Activo");
            // 
            // frmMecanicos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 800);
            Controls.Add(dgvMecanicos);
            Controls.Add(pnlTop);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMecanicos";
            Text = "Gestión de Mecánicos";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMecanicos).EndInit();
            ResumeLayout(false);
        }
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}