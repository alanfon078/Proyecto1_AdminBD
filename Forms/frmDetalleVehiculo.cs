using Conection.Conexion;
using MySql.Data.MySqlClient;
using Proyecto1_AdminBD.DAO;
using Proyecto1_AdminBD.ObjectsClasses;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto1_AdminBD.Forms
{
    public partial class frmDetalleVehiculo : Form
    {
        public Vehiculo VehiculoResultante { get; private set; }
        private bool esEdicion = false;
        private dao datos = new dao();

        public frmDetalleVehiculo()
        {
            InitializeComponent();
            VehiculoResultante = new Vehiculo();
            lblTitulo.Text = "Nuevo Vehículo";
            CargarClientes();
            esEdicion = false;
        }

        public frmDetalleVehiculo(Vehiculo v)
        {
            InitializeComponent();
            VehiculoResultante = v;
            lblTitulo.Text = "Editar Vehículo";
            CargarClientes();
            esEdicion = true;
            CargarDatosEnControles();
        }

        private void CargarClientes()
        {
            // Usamos el método helper del DAO
            DataTable dt = datos.ObtenerClientesParaCombo();
            cmbCliente.DataSource = dt;
            cmbCliente.DisplayMember = "NombreCompleto"; // Nombre de la columna en el SELECT
            cmbCliente.ValueMember = "ID_Cliente";       // Nombre de la columna ID
            cmbCliente.SelectedIndex = -1; // Ninguno seleccionado al inicio
        }

        private void CargarDatosEnControles()
        {
            cmbCliente.SelectedValue = VehiculoResultante.IdCliente;
            txtSerie.Text = VehiculoResultante.NumeroSerie;
            txtPlacas.Text = VehiculoResultante.Placas;
            txtMarca.Text = VehiculoResultante.Marca;
            txtModelo.Text = VehiculoResultante.Modelo;
            numAnio.Value = VehiculoResultante.Anio > 0 ? VehiculoResultante.Anio : DateTime.Now.Year;
            txtColor.Text = VehiculoResultante.Color;
            numKm.Value = VehiculoResultante.Kilometraje;
            cmbTipo.Text = VehiculoResultante.TipoVehiculo;

            // Si es edición, a veces no se permite cambiar el Número de Serie o el Cliente
            // txtSerie.Enabled = false; 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPlacas.Text) || string.IsNullOrWhiteSpace(txtSerie.Text))
            {
                MessageBox.Show("Placas y Número de Serie son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            VehiculoResultante.IdCliente = Convert.ToInt32(cmbCliente.SelectedValue);
            VehiculoResultante.NumeroSerie = txtSerie.Text;
            VehiculoResultante.Placas = txtPlacas.Text;
            VehiculoResultante.Marca = txtMarca.Text;
            VehiculoResultante.Modelo = txtModelo.Text;
            VehiculoResultante.Anio = (int)numAnio.Value;
            VehiculoResultante.Color = txtColor.Text;
            VehiculoResultante.Kilometraje = (int)numKm.Value;
            VehiculoResultante.TipoVehiculo = cmbTipo.Text;
            VehiculoResultante.Activo = true;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Mover ventana
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}