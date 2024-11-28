using CapaEntidad.MantenimientoPlanificacion;
using CapaEntidad.OrdenMantenimientoPreventivo;
using CapaLogica.Horario;
using CapaLogica.MantenimientoPlanificacion;
using CapaLogica.OrdenMantenimientoPreventivo;
using CapaLogica.Personal;
using CapaLogica.Recurso;
using CapaLogica.Mantenimiento.TipoMan;
using CapaPresentacion.Personal_Forms;

namespace CapaPresentacion.Mantenimiento_Forms
{
    public partial class MantenimientoPreventivo : Form
    {
        public MantenimientoPreventivo()
        {
            InitializeComponent();
        }

        private void MantenimientoPreventivo_Load(object sender, EventArgs e)
        {
            loadDataSQL();
        }

        private void loadDataSQL()
        {
            dgvMP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMP.MultiSelect = false;
            dgvMP.ReadOnly = true;
            dgvMP.DataSource = logOrdenMantenimientoPreventivo.Instancia.listarMantenimientoPreventivoParaGrid();
            cbPlanificacion.DataSource = logMantenimientoPlanificacion.Instancia.listarMantenimientoPlanificacionParaGrid();
            cbPlanificacion.DisplayMember = "idPlanificacion";
            cbPlanificacion.ValueMember = "idPlanificacion";

        }
        private void btnRegistrarMp_Click(object sender, EventArgs e)
        {
            if (cbPlanificacion.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una planificación.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtResultadoEjecucion.Text.Trim()))
            {
                MessageBox.Show("Por favor, ingrese el resultado de ejecución.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResultadoEjecucion.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtComentarios.Text.Trim()))
            {
                MessageBox.Show("Por favor, ingrese los comentarios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtComentarios.Focus();
                return;
            }
            double? duracionEstimada = null;
            if (!string.IsNullOrEmpty(txtDuracionEstimada.Text.Trim()))
            {
                if (!double.TryParse(txtDuracionEstimada.Text.Trim(), out double duracion))
                {
                    MessageBox.Show("Por favor, ingrese una duración estimada válida en horas.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDuracionEstimada.Focus();
                    return;
                }
                duracionEstimada = duracion;
            }
            entOrdenMantenimientoPreventivo mp = new entOrdenMantenimientoPreventivo
            {
                idPlanificacion = Convert.ToInt32(cbPlanificacion.SelectedValue),
                fecha = dtPickerFechaMantenimiento.Value,
                ResultadoEjecucion = txtResultadoEjecucion.Text.Trim(),
                Comentarios = txtComentarios.Text.Trim(),
                RequerimientosEspeciales = txtRequerimientosEspeciales.Text.Trim(),
                DuracionEstimadaHoras = duracionEstimada
            };
            bool agregado = logOrdenMantenimientoPreventivo.Instancia.agregarOrdenMantenimientoPreventivo(mp);

            if (agregado)
            {
                MessageBox.Show($"Mantenimiento Preventivo agregado con éxito.\nIdPlanificacion: {mp.idPlanificacion}\nFechaMantenimiento: {mp.fecha}\nResultado: {mp.ResultadoEjecucion}\nComentarios: {mp.Comentarios}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al intentar agregar el mantenimiento planificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvMP.DataSource = logOrdenMantenimientoPreventivo.Instancia.listarMantenimientoPreventivoParaGrid();
            LimpiarFormulario();

        }
        private void LimpiarFormulario()
        {
            txtId.Text="";
            txtResultadoEjecucion.Clear();
            txtComentarios.Clear();
            txtRequerimientosEspeciales.Clear();
            txtDuracionEstimada.Clear();
            cbPlanificacion.SelectedIndex = -1;
            dtPickerFechaMantenimiento.Value = DateTime.Now;
        }
        private void btnModificarMp_Click(object sender, EventArgs e)
        {
            if (cbPlanificacion.SelectedIndex == -1 ||
        string.IsNullOrEmpty(txtResultadoEjecucion.Text.Trim()) ||
        string.IsNullOrEmpty(txtComentarios.Text.Trim()))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            entOrdenMantenimientoPreventivo mantenimiento = new entOrdenMantenimientoPreventivo
            {
                idOrdenMantenimiento = Convert.ToInt32(txtId.Text),
                idPlanificacion = Convert.ToInt32(cbPlanificacion.SelectedValue),
                fecha = dtPickerFechaMantenimiento.Value,
                ResultadoEjecucion = txtResultadoEjecucion.Text.Trim(),
                Comentarios = txtComentarios.Text.Trim(),
                RequerimientosEspeciales = txtRequerimientosEspeciales.Text.Trim(),
            };
            if (!string.IsNullOrEmpty(txtDuracionEstimada.Text.Trim()))
            {
                if (double.TryParse(txtDuracionEstimada.Text.Trim(), out double duracionEstimada))
                {
                    mantenimiento.DuracionEstimadaHoras = duracionEstimada;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una duración estimada válida en horas.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDuracionEstimada.Focus();
                    return;
                }
            }
            bool actualizado = logOrdenMantenimientoPreventivo.Instancia.actualizarOrdenMantenimientoPreventivo(mantenimiento);
            if (actualizado)
            {
                MessageBox.Show("La orden de mantenimiento preventivo se ha actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMP.DataSource = logOrdenMantenimientoPreventivo.Instancia.listarMantenimientoPreventivoParaGrid();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Hubo un error al intentar actualizar la orden de mantenimiento preventivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarMp_Click(object sender, EventArgs e)
        {

            if (dgvMP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un registro para modificar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idOrden = Convert.ToInt32(dgvMP.SelectedRows[0].Cells["idOrdenMantenimiento"].Value);
            txtId.Text = idOrden.ToString();
            entOrdenMantenimientoPreventivo mantenimiento = logOrdenMantenimientoPreventivo.Instancia.buscarPorId(idOrden);

            if (mantenimiento != null)
            {
                cbPlanificacion.SelectedValue = mantenimiento.idPlanificacion;
                dtPickerFechaMantenimiento.Value = mantenimiento.fecha ?? DateTime.Now;
                txtResultadoEjecucion.Text = mantenimiento.ResultadoEjecucion;
                txtComentarios.Text = mantenimiento.Comentarios;
                txtRequerimientosEspeciales.Text = mantenimiento.RequerimientosEspeciales;
                txtDuracionEstimada.Text = mantenimiento.DuracionEstimadaHoras?.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró el mantenimiento preventivo con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesahabilitarMp_Click(object sender, EventArgs e)
        {
            if (dgvMP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un registro para deshabilitar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idOrden = Convert.ToInt32(dgvMP.SelectedRows[0].Cells["idOrdenMantenimiento"].Value);
            bool deshabilitado = logOrdenMantenimientoPreventivo.Instancia.deshablitarMantenimientoPreventivo(idOrden);

            if (deshabilitado)
            {
                MessageBox.Show("Mantenimiento preventivo deshabilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMP.DataSource = logOrdenMantenimientoPreventivo.Instancia.listarMantenimientoPreventivoParaGrid();
            }
            else
            {
                MessageBox.Show("Hubo un error al deshabilitar el mantenimiento preventivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnConsultarMp_Click(object sender, EventArgs e)
        {
            int? ID = null;
            DateTime? fechaMantenimiento = null;

            if (!string.IsNullOrEmpty(txtIDSearch.Text))
            {
                ID = Convert.ToInt32(txtIDSearch.Text.Trim());
            }
            if (dtPickerFechaMp.Value != null)
            {
                fechaMantenimiento = dtPickerFechaMp.Value.Date;
            }
            dgvMP.DataSource = logOrdenMantenimientoPreventivo.Instancia.listarMantenimientoPreventivoParaGrid(ID, fechaMantenimiento);
        }
        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Por favor, ingrese un ID válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int idPlanificacion;
                if (int.TryParse(txtId.Text.Trim(), out idPlanificacion))
                {
                    try
                    {
                        entOrdenMantenimientoPreventivo mantenimiento = logOrdenMantenimientoPreventivo.Instancia.buscarPorId(idPlanificacion);
                        if (mantenimiento != null)
                        {
                            MessageBox.Show("Se encontraron datos correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mantenimiento.idPlanificacion = Convert.ToInt32(cbPlanificacion.SelectedValue);
                            mantenimiento.fecha = dtPickerFechaMantenimiento.Value;
                            mantenimiento.ResultadoEjecucion = txtResultadoEjecucion.Text.Trim();
                            mantenimiento.Comentarios = txtComentarios.Text.Trim();
                            mantenimiento.RequerimientosEspeciales = txtRequerimientosEspeciales.Text.Trim();
                            if (!string.IsNullOrEmpty(txtDuracionEstimada.Text.Trim()))
                            {
                                double duracionEstimada = Convert.ToDouble(txtDuracionEstimada.Text.Trim());
                                mantenimiento.DuracionEstimadaHoras = duracionEstimada;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la planificación con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al intentar obtener la planificación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El ID de planificación debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevoMp_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
