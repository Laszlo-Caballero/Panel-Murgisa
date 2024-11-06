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
using CapaPresentacion;

namespace Capa_Presentacion
{
    public partial class PanelVendedor : Form
    {
        public PanelVendedor()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnResturar.Visible = true;
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnResturar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnResturar.Visible = false;
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
        private void btnVenta_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Venta());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Cliente());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Ventas());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Servicios());
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new RealizarPago());
        }

        private void btnFormaDePago_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormadePago());
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
