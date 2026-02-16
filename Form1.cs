namespace Proyecto1_AdminBD
{
    public partial class Form1 : Form
    {
        private Form? frmActivo;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            frmVehiculos frmVehiculos = new frmVehiculos();

            frmVehiculos.TopLevel = false;
            frmVehiculos.FormBorderStyle = FormBorderStyle.None;
            frmVehiculos.Dock = DockStyle.Fill;

            pnlContenedor.Controls.Add(frmVehiculos);
            pnlContenedor.Tag = frmVehiculos;

            frmVehiculos.BringToFront();
            frmVehiculos.Show();

            frmActivo = frmVehiculos;
        }

    }
}
