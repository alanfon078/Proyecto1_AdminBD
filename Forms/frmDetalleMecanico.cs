using Proyecto1_AdminBD.ObjectsClasses;
using System;
using System.Windows.Forms;

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

        private void CargarDatosEnControles()
        {
            txtNoEmpleado.Text = MecanicoResultante.NoEmpleado;
            txtRfc.Text = MecanicoResultante.Rfc;
            txtNombre.Text = MecanicoResultante.NombreCompleto;
            txtTelefono.Text = MecanicoResultante.Telefono;
            numSalario.Value = MecanicoResultante.Salario;
            numExperiencia.Value = MecanicoResultante.AniosExperiencia;

            // Nota: El No. Empleado y RFC suelen ser únicos, a veces se bloquean en edición
            // txtNoEmpleado.Enabled = false; 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtRfc.Text))
            {
                MessageBox.Show("El Nombre y el RFC son obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Asignar valores al objeto
            MecanicoResultante.NoEmpleado = txtNoEmpleado.Text;
            MecanicoResultante.Rfc = txtRfc.Text;
            MecanicoResultante.NombreCompleto = txtNombre.Text;
            MecanicoResultante.Telefono = txtTelefono.Text;
            MecanicoResultante.Salario = numSalario.Value;
            MecanicoResultante.AniosExperiencia = (int)numExperiencia.Value;
            MecanicoResultante.Activo = true; // Por defecto

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