using Proyecto1_AdminBD.DAO;
using Proyecto1_AdminBD.ObjectsClasses;
using System;
using System.Collections.Generic;
using System.Drawing; // Necesario para el diseño visual
using System.Drawing.Drawing2D; // Necesario para la rotacion de la imagen
using System.Threading.Tasks; // Necesario para el efecto de carga
using System.Windows.Forms;

namespace Proyecto1_AdminBD.Forms
{
    public partial class frmMecanicos : Form
    {
        private dao datos = new dao();
        private List<Mecanico> listaOriginalMecanicos = new List<Mecanico>();

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

                // Cargar los daO de la BD
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

            // Columna 0 -> ID
            dgvMecanicos.Columns[0].DataPropertyName = "IdMecanico";

            // Columna 1 -> Nombre Completo
            dgvMecanicos.Columns[1].DataPropertyName = "NombreCompleto";

            // Columna 2 -> Teléfono
            dgvMecanicos.Columns[2].DataPropertyName = "Telefono";

            // Columna 3 -> Especialidad
            dgvMecanicos.Columns[3].DataPropertyName = "Especialidades";

            // Columna 4 -> Salario 
            dgvMecanicos.Columns[4].DataPropertyName = "Salario";
            dgvMecanicos.Columns[4].DefaultCellStyle.Format = "C2"; // Formato de Moneda ($1,500.00)

            // Columna 5 -> Estado
            dgvMecanicos.Columns[5].DataPropertyName = "EstadoTexto";
        }

        private void CargarDatos()
        {
            listaOriginalMecanicos = datos.ObtenerMecanicos();
            dgvMecanicos.DataSource = listaOriginalMecanicos;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Creamos la instancia del formulario de detalle (que debes crear, ver abajo)
            frmDetalleMecanico frm = new frmDetalleMecanico();

            // Mostramos el formulario como diálogo (bloquea la ventana de atrás)
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Si el usuario dio "Guardar" en el otro form, intentamos insertar
                if (datos.InsertarMecanico(frm.MecanicoResultante))
                {
                    MessageBox.Show("Mecánico registrado con éxito.");
                    CargarDatos(); // Recargar el grid
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Validamos que haya una fila seleccionada
            if (dgvMecanicos.SelectedRows.Count > 0)
            {
                // Obtenemos el objeto Mecanico de la fila seleccionada
                Mecanico objSeleccionado = (Mecanico)dgvMecanicos.SelectedRows[0].DataBoundItem;

                // Abrimos el formulario de detalle pasándole el objeto a editar
                frmDetalleMecanico frm = new frmDetalleMecanico(objSeleccionado);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Si el usuario guarda, actualizamos
                    if (datos.ActualizarMecanico(frm.MecanicoResultante))
                    {
                        MessageBox.Show("Mecánico actualizado correctamente.");
                        CargarDatos();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un mecánico de la lista.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMecanicos.SelectedRows.Count > 0)
            {
                Mecanico obj = (Mecanico)dgvMecanicos.SelectedRows[0].DataBoundItem;

                // Preguntamos confirmación
                DialogResult respuesta = MessageBox.Show(
                    $"¿Estás seguro de eliminar a {obj.NombreCompleto}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    if (datos.EliminarMecanico(obj.IdMecanico))
                    {
                        MessageBox.Show("Mecánico eliminado.");
                        CargarDatos();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un registro para eliminar.");
            }
        }

        private void dgvMecanicos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar_Click(sender, e);
        }

        private void txtBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBoxBusqueda.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvMecanicos.DataSource = listaOriginalMecanicos;
            }
            else
            {
                // Filtramos la lista buscando coincidencias en cualquier campo
                var listaFiltrada = listaOriginalMecanicos.Where(m =>
                    m.IdMecanico.ToString().Contains(filtro) ||
                    (m.NombreCompleto != null && m.NombreCompleto.ToLower().Contains(filtro)) ||
                    (m.Telefono != null && m.Telefono.Contains(filtro)) ||
                    (m.Especialidades != null && m.Especialidades.ToLower().Contains(filtro)) ||
                    m.Salario.ToString().Contains(filtro) ||
                    (m.EstadoTexto != null && m.EstadoTexto.ToLower().Contains(filtro))
                ).ToList();

                dgvMecanicos.DataSource = listaFiltrada;
            }
        }
    }
}