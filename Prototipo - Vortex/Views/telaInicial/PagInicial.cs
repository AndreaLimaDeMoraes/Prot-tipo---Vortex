﻿using System;
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
    public partial class PagInicial : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public PagInicial()
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

        private void PagInicial_Load(object sender, EventArgs e)
        {
            
                // Criando o FlowLayoutPanel para os novos requerimentos
                FlowLayoutPanel flowPanelNovos = new FlowLayoutPanel();
                flowPanelNovos.FlowDirection = FlowDirection.LeftToRight;
                flowPanelNovos.WrapContents = true;
                flowPanelNovos.AutoScroll = true;
                flowPanelNovos.Dock = DockStyle.Fill;

            // Adiciona o FlowLayoutPanel ao GroupBox de novos requerimentos
                //gboxNovosReq.Controls.Add(flowPanelNovos);

                // Criando blocos de solicitação como exemplo
                for (int i = 0; i < 4; i++)
                {
                    Panel bloco = new Panel();
                    bloco.Size = new Size(200, 100); // Tamanho de cada bloco
                    bloco.BackColor = Color.LightGray;

                    Label titulo = new Label();
                    titulo.Text = "Requerimento " + (i + 1);
                    titulo.Location = new Point(10, 10);

                    Button alterarStatus = new Button();
                    alterarStatus.Text = "Alterar Status";
                    alterarStatus.Location = new Point(10, 60);

                    bloco.Controls.Add(titulo);
                    bloco.Controls.Add(alterarStatus);

                    // Adiciona o bloco ao FlowLayoutPanel
                    flowPanelNovos.Controls.Add(bloco);
                
            }

        }

        private void btnSimularNovoRequerimento_Click(object sender, EventArgs e)
        {
            //Esse botão serve para simular um novo requerimento aparecendo para a tela inicial. Será alimentado com as informções do BD.



                // Cria um novo Panel para o requerimento
                Panel panelRequerimento = new Panel();
                panelRequerimento.Size = new Size(322, 159);
                panelRequerimento.BorderStyle = BorderStyle.FixedSingle;
                panelRequerimento.Padding = new Padding(5);

                // Adiciona um label para o nome do requerimento
                Label lblRequerimento = new Label();
                lblRequerimento.Text = "Requerimento: \"nome do negocio\"";
                lblRequerimento.Font = new Font("Arial Rounded MT", 13, FontStyle.Bold);
                lblRequerimento.Location = new Point(0, 12);
                lblRequerimento.AutoSize = true;
                panelRequerimento.Controls.Add(lblRequerimento);

                // Adiciona um label para o tipo do requerimento
                Label lblTipo = new Label();
                lblTipo.Text = "\"tipo\"";
                lblTipo.Font = new Font("Microsoft Tai Le", 12);
                lblTipo.Location = new Point(146, 47);
                lblTipo.Size =  new Size(49, 21);
                panelRequerimento.Controls.Add(lblTipo);

                // Adiciona um botão "Acessar Dados"
                Button btnAcessarDados = new Button();
                btnAcessarDados.Text = "Acessar Dados";
                btnAcessarDados.Font = new Font("Microsoft Tai Le", 12); 
                btnAcessarDados.Location = new Point(95, 72);
                btnAcessarDados.Size = new Size(145, 28);
                panelRequerimento.Controls.Add(btnAcessarDados);

            // Adiciona um label para o status
                Label lblStatus = new Label();
                lblStatus.Text = "Status: \"inserir status\"";
                lblStatus.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
                lblStatus.BackColor = Color.LightSteelBlue;
                lblStatus.ForeColor = Color.Black;
                lblStatus.Location = new Point(6, 125);
                lblStatus.AutoSize = true;
                lblStatus.Padding = new Padding(3);
                panelRequerimento.Controls.Add(lblStatus);

            // Adiciona um botão "Enviar Documento"
                Button btnEnviarDocumento = new Button();
                btnEnviarDocumento.Text = "Enviar Documentos";
                btnEnviarDocumento.Font = new Font("Microsoft Sans Serif", 8);
                btnEnviarDocumento.Location = new Point(191, 124);
                btnEnviarDocumento.Size = new Size(125, 28);
                panelRequerimento.Controls.Add(btnEnviarDocumento);

                // Adiciona o panel ao FlowLayoutPanel
                //flpNovosReq.Controls.Add(panelRequerimento);
        }

        private void pagInicial_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PagInicial pagInicial = new PagInicial();
            pagInicial.Show();
            this.Close();
        }
        private void pagHistorico_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            PagHistorico pagHistorico = new PagHistorico();
            pagHistorico.Show();
            this.Close();
        }
        private void pagGerenciamento_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PagGerenciamento pagGerenciamento = new PagGerenciamento();
            pagGerenciamento.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void lblAndamento_Click(object sender, EventArgs e)
        {

        }
    }
}
