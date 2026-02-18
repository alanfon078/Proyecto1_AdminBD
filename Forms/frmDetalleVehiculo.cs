using Conection.Conexion;
using MySql.Data.MySqlClient;
using Proyecto1_AdminBD.DAO;
using Proyecto1_AdminBD.ObjectsClasses;
using System;
using System.Data;
using System.Text.RegularExpressions;
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

            // Si es edición no se permite cambiar el Número de Serie o el Cliente
            txtSerie.Enabled = false; 
            cmbCliente.Enabled = false;
        }
        private bool ValidarDatosVehiculo()
        {
            // 1. Validar Cliente Seleccionado
            if (cmbCliente.SelectedIndex == -1 || cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un cliente (Dueño) de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 2. Validar campos vacíos básicos
            if (string.IsNullOrWhiteSpace(txtSerie.Text) ||
                string.IsNullOrWhiteSpace(txtPlacas.Text) ||
                string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("El Número de Serie, Placas, Marca y Modelo son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 3. Validar Placas (Letras, números y guiones, sin caracteres especiales raros)`
            string patronPlacas = @"^[A-Z0-9-]{3,12}$";
            if (!Regex.IsMatch(txtPlacas.Text.Trim().ToUpper(), patronPlacas))
            {
                MessageBox.Show("Las placas contienen caracteres inválidos o longitud incorrecta.", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 4. Validar Año
            int anioActual = DateTime.Now.Year;
            if (numAnio.Value < 1980 || numAnio.Value > (anioActual + 1))
            {
                MessageBox.Show($"El año del vehículo debe estar entre 1980 y {anioActual + 1}.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 5. Validar Kilometraje
            if (numKm.Value < 0)
            {
                MessageBox.Show("El kilometraje no puede ser negativo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Ejecutar validaciones
            if (!ValidarDatosVehiculo()) return;

            // Asignación de datos limpios
            VehiculoResultante.IdCliente = Convert.ToInt32(cmbCliente.SelectedValue);

            // Convertir a mayúsculas Serie y Placas para uniformidad en BD
            VehiculoResultante.NumeroSerie = txtSerie.Text.Trim().ToUpper();
            VehiculoResultante.Placas = txtPlacas.Text.Trim().ToUpper();

            // Marca y Modelo en formato Título o Mayúsculas según preferencia
            VehiculoResultante.Marca = txtMarca.Text.Trim();
            VehiculoResultante.Modelo = txtModelo.Text.Trim();

            VehiculoResultante.Anio = (int)numAnio.Value;
            VehiculoResultante.Color = txtColor.Text.Trim();
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