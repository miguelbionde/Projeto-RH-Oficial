using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Cadastros
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            rbTemFilhosNão.Checked = true;
            panelExibeDadosFilhos.Visible = false;
        }

        private void rbTemFilhoSim_CheckedChanged(object sender, EventArgs e)
        {
            panelExibeDadosFilhos.Visible = true;
        }

        private void rbTemFilhosNão_CheckedChanged(object sender, EventArgs e)
        {
            panelExibeDadosFilhos.Visible = false;
        }

        private void txtFilhoDataNascimento_TextChanged(object sender, EventArgs e)
        {
            var dataNascimento = DateTime.Parse(txtFilhoDataNascimento.Text);
            var anoAtual = DateTime.Now.Year;
            lblIdade.Text = (anoAtual - dataNascimento.Year).ToString();
        }

        private void txtFilhoDataNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var dataNascimento = DateTime.Parse(txtFilhoDataNascimento.Text);
                    var anoAtual = DateTime.Now.Year;
                    lblIdade.Text = (anoAtual - dataNascimento.Year).ToString();
                }
                
                 catch (Exception ex)
                {
                    MessageBox.Show("A data de nascimento parece estar errada, detalhamento: " + ex);
                }
            }
        }
    }
}
