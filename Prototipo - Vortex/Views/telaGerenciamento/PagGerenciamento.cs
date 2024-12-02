using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo___Vortex { 
    public partial class PagGerenciamento : Form {
        public PagGerenciamento() {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }
        private void pagInicial_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PagInicial pagInicial = new PagInicial();
            pagInicial.Show();
            this.Hide();
        }
        private void pagHistorico_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PagHistorico pagHistorico = new PagHistorico();
            pagHistorico.Show();
            this.Hide();
        }
        private void pagGerenciamento_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PagGerenciamento pagGerenciamento = new PagGerenciamento();
            pagGerenciamento.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}