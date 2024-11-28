using CapaPresentacion.Mantenimiento_Forms;
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

namespace CapaPresentacion
{
    public partial class PanelJefeServicio : Form
    {
        public PanelJefeServicio()
        {
            InitializeComponent();
        }

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar2_Click(object sender, EventArgs e)
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

        private void btnMaximizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar2.Visible = false;
            btnRestaurar2.Visible = true;
        }

        private void btnMinimizar2_Click(object sender, EventArgs e)
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

        private void btnROrdendeServicio_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new RealizarOrdenDeServicio());
        }


        private void btnMaquinaria_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new MaquinariaFormServicio());
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new MantenedorPersonal());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Servicios());
        }

        private void btnRecursos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new RecursosFormServicio());
        }
        private void btnPedidoMantenimientoCorrectivo_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new PedidoMantenimientoCorrectivo());
        }
    }
}
