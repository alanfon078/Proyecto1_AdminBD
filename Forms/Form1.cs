using Proyecto1_AdminBD.Forms;

namespace Proyecto1_AdminBD
{
    public partial class Form1 : Form
    {
        private Form? frmActivo;
        private Button botonActivo = null;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; 
            ActivarBoton(btnMecanicos);
            AbrirFormHijo(new frmMecanicos());
            lblTitulo.Text = "Gestión de Mecánicos";
        }
        private void ActivarBoton(Button btn)
        {
            // Restaurar color del botón anterior
            if (botonActivo != null)
            {
                botonActivo.BackColor = Color.FromArgb(30, 30, 60);
            }

            // Activar nuevo botón
            btn.BackColor = Color.FromArgb(70, 70, 130); // Color más claro para el activo
            botonActivo = btn;
        }
        private void AbrirFormHijo(object formHijo)
        {
            // Limpiar el panel contenedor
            pnlContenedor.Controls.Clear();

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None;

            pnlContenedor.Controls.Add(fh);
            pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnVehiculos);
            AbrirFormHijo(new frmVehiculos());
            lblTitulo.Text = "Gestión de Vehículos";
        }
        private void btnMecanicos_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnMecanicos);
            AbrirFormHijo(new frmMecanicos());
            lblTitulo.Text = "Gestión de Mecánicos";
        }
    }
}
