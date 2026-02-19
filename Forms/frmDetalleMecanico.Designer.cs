namespace Proyecto1_AdminBD.Forms
{
    partial class frmDetalleMecanico
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitulo = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtRfc = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            numSalario = new NumericUpDown();
            label6 = new Label();
            numExperiencia = new NumericUpDown();
            btnGuardar = new Button();
            btnCancelar = new Button();
            cmbEspecialidades = new ComboBox();
            label7 = new Label();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSalario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numExperiencia).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 30, 60);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(514, 67);
            pnlHeader.TabIndex = 0;
            pnlHeader.MouseDown += pnlHeader_MouseDown;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(14, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(177, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Detalle Mecánico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(31, 173);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 3;
            label2.Text = "*RFC:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(38, 111);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(441, 30);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(30, 87);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 5;
            label3.Text = "*Nombre Completo:";
            // 
            // txtRfc
            // 
            txtRfc.Font = new Font("Segoe UI", 10F);
            txtRfc.Location = new Point(38, 197);
            txtRfc.Margin = new Padding(3, 4, 3, 4);
            txtRfc.Name = "txtRfc";
            txtRfc.Size = new Size(205, 30);
            txtRfc.TabIndex = 3;
            txtRfc.KeyDown += txtNombre_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(34, 253);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 7;
            label4.Text = "*Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10F);
            txtTelefono.Location = new Point(38, 277);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(205, 30);
            txtTelefono.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(263, 253);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 9;
            label5.Text = "*Salario:";
            // 
            // numSalario
            // 
            numSalario.DecimalPlaces = 2;
            numSalario.Font = new Font("Segoe UI", 10F);
            numSalario.Location = new Point(266, 279);
            numSalario.Margin = new Padding(3, 4, 3, 4);
            numSalario.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numSalario.Minimum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSalario.Name = "numSalario";
            numSalario.Size = new Size(206, 30);
            numSalario.TabIndex = 5;
            numSalario.TextAlign = HorizontalAlignment.Right;
            numSalario.Value = new decimal(new int[] { 15000, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(34, 333);
            label6.Name = "label6";
            label6.Size = new Size(138, 20);
            label6.TabIndex = 11;
            label6.Text = "*Años Experiencia:";
            // 
            // numExperiencia
            // 
            numExperiencia.Font = new Font("Segoe UI", 10F);
            numExperiencia.Location = new Point(38, 357);
            numExperiencia.Margin = new Padding(3, 4, 3, 4);
            numExperiencia.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numExperiencia.Name = "numExperiencia";
            numExperiencia.Size = new Size(114, 30);
            numExperiencia.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 122, 204);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(243, 440);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 47);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(365, 440);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 47);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbEspecialidades
            // 
            cmbEspecialidades.AutoCompleteCustomSource.AddRange(new string[] { "Motor General", "Transmisiones", "Frenos ABS", "Sistema Eléctrico", "Suspensión y Dirección" });
            cmbEspecialidades.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidades.Font = new Font("Segoe UI", 10F);
            cmbEspecialidades.FormattingEnabled = true;
            cmbEspecialidades.Items.AddRange(new object[] { "Motor General", "Transmisiones", "Frenos ABS", "Sistema Eléctrico", "Suspensión y Dirección" });
            cmbEspecialidades.Location = new Point(266, 357);
            cmbEspecialidades.Margin = new Padding(3, 4, 3, 4);
            cmbEspecialidades.Name = "cmbEspecialidades";
            cmbEspecialidades.Size = new Size(205, 31);
            cmbEspecialidades.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(262, 333);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 13;
            label7.Text = "*Especialidad:";
            // 
            // frmDetalleMecanico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(514, 533);
            Controls.Add(cmbEspecialidades);
            Controls.Add(label7);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(numExperiencia);
            Controls.Add(label6);
            Controls.Add(numSalario);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtRfc);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDetalleMecanico";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalle Mecánico";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSalario).EndInit();
            ((System.ComponentModel.ISupportInitialize)numExperiencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSalario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numExperiencia;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private ComboBox cmbEspecialidades;
        private Label label7;
    }
}