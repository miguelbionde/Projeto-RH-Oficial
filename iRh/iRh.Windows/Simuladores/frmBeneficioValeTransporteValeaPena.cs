using iRh.Windows.Cadastros.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioValeTransporteValeaPena : Form
    {
        public frmBeneficioValeTransporteValeaPena()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe seu Salário base!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDiasMes.Text))
            {
                MessageBox.Show("Informe Quantos dias do mês ultiliza O Vale Transporte!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiasMes.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassagemDia.Text))
            {
                MessageBox.Show("Informe Quantas vezes por dia ultiliza o Vale Transporte!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassagemDia.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtValorPassagem.Text))
            {
                MessageBox.Show("Informe Qual o valor da passegem!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiasMes.Focus();
                return;
            }

            try
            {
                var salario = double.Parse(txtSalario.Text);
                var valorPassagem = double.Parse(txtValorPassagem.Text);
                var diasUsados = double.Parse(txtDiasMes.Text);
                var passagemPorDia = double.Parse(txtPassagemDia.Text);
                var descontoValeTrasporte = ValeTransporte.ValeaPena(double salario, double valorPassagem, double diasUsados, double passagemPorDia);
                lblResultado.Text = "R$" + descontoValeTrasporte.ToString("c");
                lblResultado.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("informe um valor de salário Válido, ex 3500", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
