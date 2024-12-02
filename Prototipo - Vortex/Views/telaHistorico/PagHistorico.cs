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

namespace Prototipo___Vortex
{
    public partial class PagHistorico : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public PagHistorico()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            if (!this.DesignMode)
            {
                ApplyRoundedCorners();
            }
        }

        private void ApplyRoundedCorners()
        {
            this.panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            this.panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
            this.panel3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 20, 20));
            this.panel4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 20, 20));
            this.panel5.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 20, 20));
            this.panel6.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 20, 20));
            this.panel7.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));
            this.panel8.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, 20, 20));
            this.panel9.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel9.Width, panel9.Height, 20, 20));
            this.panel10.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel10.Width, panel10.Height, 20, 20));
        }

        private void pagInicial_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PagInicial pagInicial = new PagInicial();
            pagInicial.Show();
            this.Hide();
        }
        private void pagHistorico_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PagHistorico PagHistorico = new PagHistorico();
            PagHistorico.Show();
            this.Hide();
        }
        private void pagGerenciamento_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PagGerenciamento pagGerenciamento = new PagGerenciamento();
            pagGerenciamento.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
