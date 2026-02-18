using Proyecto1_AdminBD.ObjectsClasses;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Proyecto1_AdminBD.Forms
{
    public partial class frmDetalleMecanico : Form
    {
        public Mecanico MecanicoResultante { get; private set; }
        private bool esEdicion = false;

        // Constructor para NUEVO registro
        public frmDetalleMecanico()
        {
            InitializeComponent();
            MecanicoResultante = new Mecanico();
            lblTitulo.Text = "Nuevo Mecánico";
            esEdicion = false;
            cargarDatosPredeterminados();
        }

        // Constructor para EDITAR registro
        public frmDetalleMecanico(Mecanico m)
        {
            InitializeComponent();
            MecanicoResultante = m;
            esEdicion = true;
            lblTitulo.Text = "Editar Mecánico";
            CargarDatosEnControles();
        }

        // En Forms/frmDetalleMecanico.cs

        private void CargarDatosEnControles()
        {
            txtNoEmpleado.Text = MecanicoResultante.NoEmpleado;
            txtRfc.Text = MecanicoResultante.Rfc;
            txtNombre.Text = MecanicoResultante.NombreCompleto;
            txtTelefono.Text = MecanicoResultante.Telefono;
            numSalario.Value = MecanicoResultante.Salario;
            numExperiencia.Value = MecanicoResultante.AniosExperiencia;
            cmbEspecialidades.Text = MecanicoResultante.Especialidades;

            // El No.Empleado y RFC son únicos se bloquean en la edición
            txtNoEmpleado.Enabled = false;
            txtRfc.Enabled = false;
        }

        private void cargarDatosPredeterminados()
        {
            txtNoEmpleado.Text = "EMP";            
            numSalario.Value = 15000;

        }

        private bool ValidarDatos()
        {
            // 1. Validar que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(txtNoEmpleado.Text) ||
                string.IsNullOrWhiteSpace(txtRfc.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Todos los campos de texto son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 2. Validar No. Empleado 
            string patronEmpleado = @"^EMP\d+$";
            if (!Regex.IsMatch(txtNoEmpleado.Text.Trim().ToUpper(), patronEmpleado))
            {
                MessageBox.Show("El No. de Empleado debe tener el formato 'EMP' seguido de números (ej. EMP1, EMP12).", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 3. Validar RFC (3 o 4 letras, 6 números, 3 caracteres homoclave)
            string patronRFC = @"^[A-Z&Ñ]{3,4}\d{6}[A-Z0-9]{3}$";
            if (!Regex.IsMatch(txtRfc.Text.Trim().ToUpper(), patronRFC))
            {
                MessageBox.Show("El RFC no tiene un formato válido (12 o 13 caracteres).", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 4. Validar Teléfono - 10 dígitos
            string patronTelefono = @"^\d{10}$";
            if (!Regex.IsMatch(txtTelefono.Text.Trim(), patronTelefono))
            {
                MessageBox.Show("El teléfono debe contener exactamente 10 dígitos numéricos.", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 5. Validar Salario (Lógico)
            if (numSalario.Value <= 0)
            {
                MessageBox.Show("El salario debe ser mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // 6. Validar Especialidad
            if (cmbEspecialidades.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar una especialidad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Ejecutar las validaciones
            if (!ValidarDatos()) return;

            MecanicoResultante.NoEmpleado = txtNoEmpleado.Text.Trim().ToUpper();
            MecanicoResultante.Rfc = txtRfc.Text.Trim().ToUpper();
            MecanicoResultante.NombreCompleto = txtNombre.Text.Trim(); 
            MecanicoResultante.Telefono = txtTelefono.Text.Trim();
            MecanicoResultante.Salario = numSalario.Value;
            MecanicoResultante.AniosExperiencia = (int)numExperiencia.Value;
            MecanicoResultante.Especialidades = cmbEspecialidades.Text;
            MecanicoResultante.Activo = true;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Método para mover la ventana desde el panel superior (Opcional, mejora UX)
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