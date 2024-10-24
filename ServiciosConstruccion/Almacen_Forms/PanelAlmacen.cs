using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaPresentacion.Almacen_Forms
{
    public partial class PanelAlmacen : Form
    {
        public PanelAlmacen()
        {
            InitializeComponent();
        }

        private void btnMaximizar1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnResturar1.Visible = true;
            btnMaximizar1.Visible = false;

        }

        private void btnResturar1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnResturar1.Visible = false;
            btnMaximizar1.Visible = true;
        }

        private void btnMinimizar1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

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

        private void btnNotaDeIngreso_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new NotaIngresoForm());
        }

        private void btnNotaSalida_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new NotaSalidaForm());
        }
    }
}
