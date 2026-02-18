namespace Proyecto1_AdminBD.Forms
{
    partial class frmDetalleVehiculo
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
            label1 = new Label();
            cmbCliente = new ComboBox();
            label2 = new Label();
            txtSerie = new TextBox();
            label3 = new Label();
            txtPlacas = new TextBox();
            label4 = new Label();
            txtMarca = new TextBox();
            label5 = new Label();
            txtModelo = new TextBox();
            label6 = new Label();
            numAnio = new NumericUpDown();
            label7 = new Label();
            txtColor = new TextBox();
            label8 = new Label();
            numKm = new NumericUpDown();
            label9 = new Label();
            cmbTipo = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAnio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numKm).BeginInit();
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
            pnlHeader.Size = new Size(629, 67);
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
            lblTitulo.Size = new Size(167, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Detalle Vehículo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(34, 93);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 1;
            label1.Text = "Dueño (Cliente):";
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.Font = new Font("Segoe UI", 10F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(38, 117);
            cmbCliente.Margin = new Padding(3, 4, 3, 4);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(548, 31);
            cmbCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(34, 173);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "No. Serie:";
            // 
            // txtSerie
            // 
            txtSerie.Font = new Font("Segoe UI", 10F);
            txtSerie.Location = new Point(38, 197);
            txtSerie.Margin = new Padding(3, 4, 3, 4);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(262, 30);
            txtSerie.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(320, 173);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 5;
            label3.Text = "Placas:";
            // 
            // txtPlacas
            // 
            txtPlacas.Font = new Font("Segoe UI", 10F);
            txtPlacas.Location = new Point(323, 197);
            txtPlacas.Margin = new Padding(3, 4, 3, 4);
            txtPlacas.Name = "txtPlacas";
            txtPlacas.Size = new Size(262, 30);
            txtPlacas.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(34, 253);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 7;
            label4.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Segoe UI", 10F);
            txtMarca.Location = new Point(38, 277);
            txtMarca.Margin = new Padding(3, 4, 3, 4);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(262, 30);
            txtMarca.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(320, 253);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 9;
            label5.Text = "Modelo:";
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Segoe UI", 10F);
            txtModelo.Location = new Point(323, 277);
            txtModelo.Margin = new Padding(3, 4, 3, 4);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(262, 30);
            txtModelo.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(34, 333);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 11;
            label6.Text = "Año:";
            // 
            // numAnio
            // 
            numAnio.Font = new Font("Segoe UI", 10F);
            numAnio.Location = new Point(38, 357);
            numAnio.Margin = new Padding(3, 4, 3, 4);
            numAnio.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numAnio.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numAnio.Name = "numAnio";
            numAnio.Size = new Size(114, 30);
            numAnio.TabIndex = 6;
            numAnio.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(171, 333);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 13;
            label7.Text = "Color:";
            // 
            // txtColor
            // 
            txtColor.Font = new Font("Segoe UI", 10F);
            txtColor.Location = new Point(175, 357);
            txtColor.Margin = new Padding(3, 4, 3, 4);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(125, 30);
            txtColor.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(320, 333);
            label8.Name = "label8";
            label8.Size = new Size(37, 20);
            label8.TabIndex = 15;
            label8.Text = "Km:";
            // 
            // numKm
            // 
            numKm.Font = new Font("Segoe UI", 10F);
            numKm.Location = new Point(323, 357);
            numKm.Margin = new Padding(3, 4, 3, 4);
            numKm.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numKm.Name = "numKm";
            numKm.Size = new Size(114, 30);
            numKm.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(451, 333);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 17;
            label9.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            cmbTipo.Font = new Font("Segoe UI", 10F);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Sedan", "SUV", "Pickup", "Hatchback", "Coupe", "Van" });
            cmbTipo.Location = new Point(455, 356);
            cmbTipo.Margin = new Padding(3, 4, 3, 4);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(131, 31);
            cmbTipo.TabIndex = 9;
            cmbTipo.Text = "Sedan";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 122, 204);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(358, 440);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 47);
            btnGuardar.TabIndex = 10;
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
            btnCancelar.Location = new Point(479, 440);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 47);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmDetalleVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(629, 533);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbTipo);
            Controls.Add(label9);
            Controls.Add(numKm);
            Controls.Add(label8);
            Controls.Add(txtColor);
            Controls.Add(label7);
            Controls.Add(numAnio);
            Controls.Add(label6);
            Controls.Add(txtModelo);
            Controls.Add(label5);
            Controls.Add(txtMarca);
            Controls.Add(label4);
            Controls.Add(txtPlacas);
            Controls.Add(label3);
            Controls.Add(txtSerie);
            Controls.Add(label2);
            Controls.Add(cmbCliente);
            Controls.Add(label1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDetalleVehiculo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalle Vehículo";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAnio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numKm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numAnio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numKm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}