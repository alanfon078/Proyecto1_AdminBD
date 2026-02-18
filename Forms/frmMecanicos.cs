using Proyecto1_AdminBD.DAO;
using Proyecto1_AdminBD.ObjectsClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing; // Necesario para el diseño visual
using System.Drawing.Drawing2D; // Necesario para la rotacion de la imagen
using System.Threading.Tasks; // Necesario para el efecto de carga

namespace Proyecto1_AdminBD.Forms
{
    public partial class frmMecanicos : Form
    {
        private dao datos = new dao();

        // Variables para la animacion de carga
        private System.Windows.Forms.Timer timerAnimacion;
        private Image imagenOriginal;
        private int anguloRotacion = 0;
        private bool estaCargando = false;

        public frmMecanicos()
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
                List<Mecanico> lista = datos.ObtenerMecanicos();
                dgvMecanicos.DataSource = lista;
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
            dgvMecanicos.AutoGenerateColumns = false;

            // Columna 1 -> ID
            dgvMecanicos.Columns[0].DataPropertyName = "IdMecanico";

            // Columna 2 -> Nombre Completo
            dgvMecanicos.Columns[1].DataPropertyName = "NombreCompleto";

            // Columna 3 -> Teléfono
            dgvMecanicos.Columns[2].DataPropertyName = "Telefono";

            // Columna 4 -> Especialidad
            dgvMecanicos.Columns[3].DataPropertyName = "Especialidades";

            // Columna5 -> Estado
            dgvMecanicos.Columns[4].DataPropertyName = "EstadoTexto";
        }

        private void CargarDatos()
        {
            List<Mecanico> lista = datos.ObtenerMecanicos();
            dgvMecanicos.DataSource = lista;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}