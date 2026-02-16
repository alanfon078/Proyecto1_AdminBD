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
            panel1 = new Panel();
            panel2 = new Panel();
            btnVehiculos = new Button();
            btnMecanicos = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(171, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1587, 866);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnMecanicos);
            panel2.Controls.Add(btnVehiculos);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 863);
            panel2.TabIndex = 1;
            // 
            // btnVehiculos
            // 
            btnVehiculos.Location = new Point(39, 114);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(94, 29);
            btnVehiculos.TabIndex = 0;
            btnVehiculos.Text = "button1";
            btnVehiculos.UseVisualStyleBackColor = true;
            // 
            // btnMecanicos
            // 
            btnMecanicos.Location = new Point(39, 417);
            btnMecanicos.Name = "btnMecanicos";
            btnMecanicos.Size = new Size(94, 29);
            btnMecanicos.TabIndex = 1;
            btnMecanicos.Text = "button1";
            btnMecanicos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1760, 859);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Button btnVehiculos;
        private Button btnMecanicos;
    }
}
