using Conection.Conexion;
using MySql.Data.MySqlClient;
using Proyecto1_AdminBD.DAO;
using Proyecto1_AdminBD.Forms;
using Proyecto1_AdminBD.ObjectsClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Proyecto1_AdminBD
{
    public partial class frmVehiculos : Form
    {
        private dao datos = new dao();

        // Variables para la animacion de carga
        private System.Windows.Forms.Timer timerAnimacion;
        private Image imagenOriginal;
        private int anguloRotacion = 0;
        private bool estaCargando = false;

        public frmVehiculos()
        {
            InitializeComponent();
            ConfigurarGrid();
            ConfigurarAnimacion();
            CargarDatos();
        }

        private void ConfigurarAnimacion()
        {
            imagenOriginal = btnRefrescar.Image;
            timerAnimacion = new System.Windows.Forms.Timer();
            timerAnimacion.Interval = 50;
            timerAnimacion.Tick += TimerAnimacion_Tick;
        }

        private void TimerAnimacion_Tick(object? sender, EventArgs e)
        {
            anguloRotacion += 20;
            if (anguloRotacion >= 360) anguloRotacion = 0;
            btnRefrescar.Image = RotarImagen(imagenOriginal, anguloRotacion);
        }

        /// <summary>
        /// Función auxiliar para rotar una imagen en memoria
        /// </summary>
        private Image RotarImagen(Image img, float angulo)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.TranslateTransform((float)img.Width / 2, (float)img.Height / 2);

                g.RotateTransform(angulo);

                g.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);

                g.DrawImage(img, new Point(0, 0));
            }
            return bmp;
        }


        // Evento del botón de refrescar con animación
        private async void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            if (estaCargando) return; // Evitar doble clic

            try
            {
                estaCargando = true;
                btnRefrescar.Enabled = false; // Desactivar boton mientras carga
                timerAnimacion.Start();

                // Simular tiempo de carga (2 segundos) o esperar proceso real
                await Task.Delay(2000);

                // Cargar los datos de la BD
                List<Vehiculo> lista = datos.ObtenerVehiculos();
                dgvVehiculos.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
            finally
            {
                timerAnimacion.Stop();
                btnRefrescar.Image = imagenOriginal;
                anguloRotacion = 0;
                btnRefrescar.Enabled = true;
                estaCargando = false;
            }
        }

        private void ConfigurarGrid()
        {
            dgvVehiculos.AutoGenerateColumns = false;

            // Columna 1 -> ID
            dgvVehiculos.Columns[0].DataPropertyName = "IdVehiculo";

            // Columna 2 -> Placa
            dgvVehiculos.Columns[1].DataPropertyName = "Placas";

            // Columna 3 -> Marca
            dgvVehiculos.Columns[2].DataPropertyName = "Marca";

            // Columna 4 -> Modelo
            dgvVehiculos.Columns[3].DataPropertyName = "Modelo";

            // Columna 5 -> Año
            dgvVehiculos.Columns[4].DataPropertyName = "Anio";

            // Columna 6 -> Color
            dgvVehiculos.Columns[5].DataPropertyName = "Color";

            // Columna 7 -> Cliente (Aquí se usa la propiedad compuesta)
            dgvVehiculos.Columns[6].DataPropertyName = "NombreCliente";

            // Columna 8 -> Estado
            dgvVehiculos.Columns[7].DataPropertyName = "EstadoTexto";
        }

        private void CargarDatos()
        {
            List<Vehiculo> lista = datos.ObtenerVehiculos();
            dgvVehiculos.DataSource = lista;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDetalleVehiculo frm = new frmDetalleVehiculo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (datos.InsertarVehiculo(frm.VehiculoResultante))
                {
                    MessageBox.Show("Vehículo registrado con éxito.");
                    CargarDatos();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count > 0)
            {
                Vehiculo obj = (Vehiculo)dgvVehiculos.SelectedRows[0].DataBoundItem;

                // Pasamos el vehículo al formulario para que llene los campos
                frmDetalleVehiculo frm = new frmDetalleVehiculo(obj);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (datos.ActualizarVehiculo(frm.VehiculoResultante))
                    {
                        MessageBox.Show("Vehículo actualizado correctamente.");
                        CargarDatos();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un vehículo para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count > 0)
            {
                Vehiculo obj = (Vehiculo)dgvVehiculos.SelectedRows[0].DataBoundItem;

                DialogResult r = MessageBox.Show(
                    $"¿Eliminar el vehículo con placas {obj.Placas}?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (r == DialogResult.Yes)
                {
                    if (datos.EliminarVehiculo(obj.IdVehiculo))
                    {
                        MessageBox.Show("Vehículo eliminado.");
                        CargarDatos();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un registro.");
            }
        }

    }
}