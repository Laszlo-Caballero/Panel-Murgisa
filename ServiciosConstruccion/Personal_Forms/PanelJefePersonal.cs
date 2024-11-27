using CapaPresentacion.Servicios_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Personal_Forms
{
    public partial class PanelJefePersonal : Form
    {
        public PanelJefePersonal()
        {
            InitializeComponent();
        }

        private void btnCerrarP_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizarP_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar2.Visible = false;
            btnRestaurar2.Visible = true;
        }

        private void btnRestaurarP_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnResturar.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void BarraTitulo2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizarP_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnManPersonal_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Personal());
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Cargo());
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Departamento());
        }

        private void btnProfesion_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Profesion());
        }
    }
}
