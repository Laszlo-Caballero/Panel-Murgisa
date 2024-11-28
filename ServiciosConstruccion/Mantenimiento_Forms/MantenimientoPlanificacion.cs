using CapaEntidad.MantenimientoPlanificacion;
using CapaLogica.Cliente;
using CapaLogica.Horario;
using CapaLogica.MantenimientoPlanificacion;
using CapaLogica.Personal;
using CapaLogica.Recurso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Mantenimiento_Forms
{
    public partial class MantenimientoPlanificacion : Form
    {
        public MantenimientoPlanificacion()
        {
            InitializeComponent();
        }
        private void loadDataSQL()
        {
            cbPrioridad.Items.Add("Alta");
            cbPrioridad.Items.Add("Media");
            cbPrioridad.Items.Add("Baja");
            dgvMP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMP.MultiSelect = false;
            dgvMP.ReadOnly = true;
            dgvMP.DataSource = logMantenimientoPlanificacion.Instancia.listarMantenimientoPlanificacionParaGrid();
            cbRecurso.DataSource = logRecurso.Instancia.listarRecurso();
            cbRecurso.DisplayMember = "nombre";
            cbRecurso.ValueMember = "idRecurso";

            cbPersonal.DataSource = logPersonal.Instancia.listarPersonalTecnico();
            cbPersonal.DisplayMember = "nombre_completo";
            cbPersonal.ValueMember = "idPersonal";

            cbHorario.DataSource = logHorario.Instancia.listarHorarioActivo();
            cbHorario.DisplayMember = "horario";
            cbHorario.ValueMember = "idHorario";
        }

        private void MantenimientoPlanificacion_Load(object sender, EventArgs e)
        {
            loadDataSQL();
        }

        private void btnRegistrarMP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbPrioridad.SelectedItem?.ToString()) ||
                cbRecurso.SelectedIndex == -1 ||
                cbPersonal.SelectedIndex == -1 ||
                cbHorario.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            entMantenimientoPlanificacion mp = new entMantenimientoPlanificacion();
            if (!txtIdMP.Text.Trim().Equals(""))
            {
                mp.IdPlanificacion = Convert.ToInt32(txtIdMP.Text.Trim());
            }
            mp.FechaMantenimiento = dtPickerFechaMantenimiento.Value;
            mp.Prioridad = cbPrioridad.SelectedItem.ToString();
            mp.IdRecurso = Convert.ToInt32(cbRecurso.SelectedValue);
            mp.IdPersonal = Convert.ToInt32(cbPersonal.SelectedValue);
            mp.IdHorario = Convert.ToInt32(cbHorario.SelectedValue);

            bool agregado = logMantenimientoPlanificacion.Instancia.agregarMantenimientoPlanificacion(mp);
            if (agregado)
            {
                MessageBox.Show($"Mantenimiento planificado agregado con éxito.\nIdPlanificacion: {mp.IdPlanificacion}\nFechaMantenimiento: {mp.FechaMantenimiento}\nPrioridad: {mp.Prioridad}\nIdRecurso: {mp.IdRecurso}\nIdPersonal: {mp.IdPersonal}\nIdHorario: {mp.IdHorario}");
            }
            else
            {
                MessageBox.Show("Hubo un error al intentar agregar el mantenimiento planificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvMP.DataSource = logMantenimientoPlanificacion.Instancia.listarMantenimientoPlanificacionParaGrid();
            LimpiarFormulario();
        }
        private void LimpiarFormulario()
        {
            txtIdMP.Clear();
            dtPickerFechaMantenimiento.Value = DateTime.Now;
            cbPrioridad.SelectedIndex = -1;
            cbRecurso.SelectedIndex = -1;
            cbPersonal.SelectedIndex = -1;
            cbHorario.SelectedIndex = -1;
        }

        private void btnNuevoMP_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnDesahabilitarMP_Click(object sender, EventArgs e)
        {
            if (dgvMP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un registro para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPlanificacion = Convert.ToInt32(dgvMP.SelectedRows[0].Cells["IdPlanificacion"].Value);
            MessageBox.Show("dasdas." + idPlanificacion, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnEditarMP_Click(object sender, EventArgs e)
        {
            if (dgvMP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un registro para modificar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idPlanificacion = Convert.ToInt32(dgvMP.SelectedRows[0].Cells["IdPlanificacion"].Value);
            entMantenimientoPlanificacion mantenimiento = logMantenimientoPlanificacion.Instancia.buscarPorId(idPlanificacion);

            if (mantenimiento != null)
            {
                txtIdMP.Text = mantenimiento.IdPlanificacion.ToString();
                dtPickerFechaMantenimiento.Value = mantenimiento.FechaMantenimiento ?? DateTime.Now;
                cbPrioridad.SelectedItem = mantenimiento.Prioridad;
                cbRecurso.SelectedValue = mantenimiento.IdRecurso ?? 0;
                cbPersonal.SelectedValue = mantenimiento.IdPersonal ?? 0;
                cbHorario.SelectedValue = mantenimiento.IdHorario ?? 0;
            }
            else
            {
                MessageBox.Show("No se encontró la planificación con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txtIdMP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (string.IsNullOrWhiteSpace(txtIdMP.Text))
                {
                    MessageBox.Show("Por favor, ingrese un ID de planificación válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int idPlanificacion;
                if (int.TryParse(txtIdMP.Text, out idPlanificacion))
                {
                    entMantenimientoPlanificacion mantenimiento = logMantenimientoPlanificacion.Instancia.buscarPorId(idPlanificacion);

                    if (mantenimiento != null)
                    {
                        MessageBox.Show("Se encontraron datos correctamente.", "Bien", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dtPickerFechaMantenimiento.Value = mantenimiento.FechaMantenimiento ?? DateTime.Now;
                        cbPrioridad.SelectedItem = mantenimiento.Prioridad;
                        cbRecurso.SelectedValue = mantenimiento.IdRecurso ?? 0;
                        cbPersonal.SelectedValue = mantenimiento.IdPersonal ?? 0;
                        cbHorario.SelectedValue = mantenimiento.IdHorario ?? 0;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la planificación con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El ID de planificación debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelarMP_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnModificarMP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbPrioridad.SelectedItem?.ToString()) ||
            cbRecurso.SelectedIndex == -1 ||
            cbPersonal.SelectedIndex == -1 ||
            cbHorario.SelectedIndex == -1 ||
            string.IsNullOrEmpty(txtIdMP.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            entMantenimientoPlanificacion mantenimiento = new entMantenimientoPlanificacion
            {
                IdPlanificacion = Convert.ToInt32(txtIdMP.Text),
                FechaMantenimiento = dtPickerFechaMantenimiento.Value,
                Prioridad = cbPrioridad.SelectedItem.ToString(),
                IdRecurso = Convert.ToInt32(cbRecurso.SelectedValue),
                IdPersonal = Convert.ToInt32(cbPersonal.SelectedValue),
                IdHorario = Convert.ToInt32(cbHorario.SelectedValue)
            };

            bool actualizado = logMantenimientoPlanificacion.Instancia.actualizarMantenimientoPlanificacion(mantenimiento);

            if (actualizado)
            {
                MessageBox.Show("La planificación de mantenimiento se ha actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMP.DataSource = logMantenimientoPlanificacion.Instancia.listarMantenimientoPlanificacionParaGrid();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Hubo un error al intentar actualizar la planificación de mantenimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultarMP_Click(object sender, EventArgs e)
        {
            int? idPlanificacion = null;
            DateTime? fechaMantenimiento = null;

            if (!string.IsNullOrEmpty(txtIdPlanificacion.Text))
            {
                idPlanificacion = Convert.ToInt32(txtIdPlanificacion.Text.Trim());
            }

            if (dtPickerFechaMP.Value != null)
            {
                fechaMantenimiento = dtPickerFechaMP.Value.Date;
            }

            dgvMP.DataSource = logMantenimientoPlanificacion.Instancia.listarMantenimientoPlanificacionParaGrid(idPlanificacion, fechaMantenimiento);


        }
    }
}
