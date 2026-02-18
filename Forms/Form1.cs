using Conection.Conexion;
using MySql.Data.MySqlClient;

namespace Proyecto1_AdminBD
{
    public partial class Form1 : Form
    {
        private Form? frmActivo;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Conection.Conexion.Conection conexion = new Conection.Conexion.Conection();
            MySqlConnection c = conexion.ObtenerConexion();

            // Verificamos si es null (nuestro indicador de error en el try-catch) 
            if (c != null && c.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Conexión exitosa a la base de datos.");
            }
            else
            {
                MessageBox.Show("Error al conectar. Revisa la consola de salida para ver el detalle del error.");
            }
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

            ConfigurarHover(btnVehiculos);
            ConfigurarHover(btnMecanicos);



            frmActivo = frmVehiculos;
        }


        private void ConfigurarHover(Button btn)
        {
            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(90, 90, 120);
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(30, 30, 60);
            };
        }


    }
}
