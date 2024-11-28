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
using CapaPresentacion;
using CapaPresentacion.Mantenimiento_Forms;

namespace CapaPresentacion
{
    public partial class PanelMantenimiento : Form
    {
        public PanelMantenimiento()
        {
            InitializeComponent();
        }

        private void btnCerrarr_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurarr_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaziminizarr.Visible = true;
            btnRestaurarr.Visible = false;
        }

        private void btnMinimizarr_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaziminizarr_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaziminizarr.Visible = false;
            btnRestaurarr.Visible = true;
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
            if (this.PanelContenedorM.Controls.Count > 0)
                this.PanelContenedorM.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedorM.Controls.Add(fh);
            this.PanelContenedorM.Tag = fh;
            fh.Show();

        }

        private void btnPreventivo_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new MantenimientoPreventivo());
        }

        private void btnCorrectivo_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new MantenimientoCorrectivo());
        }



        private void btnTipo_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new TipoMantenimiento());
        }

        private void btnMotivo_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Motivo());
        }

    }
}
