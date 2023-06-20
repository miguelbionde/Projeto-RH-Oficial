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
    public partial class frmDetalhamento : Form
    {
        public frmDetalhamento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValorHora.Text))
            {
                MessageBox.Show("Informe o valor da sua hora trabalhada!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorHora.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtHoraExtra.Text))
            {
                MessageBox.Show("Informe quantas horas extras trabalhou!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoraExtra.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtAdicionalNoturno.Text))
            {
                MessageBox.Show("Informe quantas horas noturnas trabalhou!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdicionalNoturno.Focus();
                return;
            }


            try
            {
                var valorHora = double.Parse(txtValorHora.Text);
                var horaExtra = double.Parse(txtHoraExtra.Text);
                var adicionalNoturno = double.Parse(txtAdicionalNoturno.Text);
                var horaTrabalhada = double.Parse(txtHoraTrabalhada.Text);

                var salarioBruto = valorHora * horaTrabalhada;
                var resultadoHoraExtra = HoraExtra.Calcular(valorHora, horaExtra);
                var resultadoAdicionalNoturno = AdicionalNoturno.Calcular(valorHora, adicionalNoturno);
                var resultadoPericulosidade = Periculosidade.Calcular(salarioBruto);
                var resultadoFgts = Fgts.Calcular(salarioBruto);
                var resultadoValeTransporte = ValeTransporte.Calcular(salarioBruto);
                var resultadoInss = Inss.Calcular(salarioBruto);
                var resultadoIr = Irrf.Calcular(salarioBruto);
                var resultadoTotalAdicionais = 
                lblResultadoSalarioBruto.Text = "R$" + salarioBruto;
                lblResultadoHoraExtra.Text = "R$" + resultadoHoraExtra;
                lblResultadoSalarioBruto.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("informe um valor de Hora Trabalhada Válido, ex 3500", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
