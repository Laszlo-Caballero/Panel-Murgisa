using System;
using CapaLogica;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.Personal;

namespace CapaPresentacion.Personal_Forms
{
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
            listarPersonal();
        }

        public void listarDatos()
        {
            cbCargo.DataSource = logCargo.Instancia.listarCargo();
            cbCargo.DisplayMember = "cargo";
            cbCargo.ValueMember = "id";
            cbProfesion.DataSource = logProfesion.Instancia.listarProfesion();
            cbProfesion.DisplayMember = "titulo";
            cbProfesion.ValueMember = "id";
            cbDepartamento.DataSource = logDepartamento.Instancia.listarDepartamento();
            cbDepartamento.DisplayMember = "nombre";
            cbDepartamento.ValueMember = "id";
        }

        public void listarPersonal()
        {
            dgvPersonal.DataSource = logPersonal.Instancia.listarPersonal();
        }
    }
}
