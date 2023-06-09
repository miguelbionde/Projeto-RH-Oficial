﻿using iRh.Windows.Cadastros.Core;
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

                var resultadoValeTransporte = 0.0;
                var resultadoPericulosidade = 0.0;
                var salarioBruto = Detalhamento.ResultadoSalarioBruto(valorHora, horaTrabalhada);
                var resultadoHoraExtra = HoraExtra.Calcular(valorHora, horaExtra);
                var resultadoAdicionalNoturno = AdicionalNoturno.Calcular(valorHora, adicionalNoturno);
                var resultadoFgts = Fgts.Calcular(salarioBruto);
                if (cmbValeTransporte.Text == "Sim")
                {
                    resultadoPericulosidade = Periculosidade.Calcular(salarioBruto);
                }
                else
                {
                    resultadoPericulosidade = 0.0;
                }                
                if (cmbValeTransporte.Text == "Sim")
                {
                    resultadoValeTransporte = ValeTransporte.Calcular(salarioBruto);
                }
                else
                {
                    resultadoValeTransporte = 0.0;
                }
                var resultadoInss = Inss.Calcular(salarioBruto);
                var resultadoIr = Irrf.Calcular(salarioBruto);
                var resultadoTotalAdicionais = Detalhamento.ResultadoAdicionais(valorHora, horaExtra, adicionalNoturno, horaTrabalhada, resultadoPericulosidade);
                var resultadoTotalDescontos = Detalhamento.ResultadoDescontos(salarioBruto, resultadoValeTransporte);
                var resultadoSalarioLiquido = Detalhamento.ResultadoSalarioLiquido(salarioBruto, resultadoTotalAdicionais, resultadoTotalDescontos);

                pnlResultado.Visible = true;
                lblResultadoSalarioBruto.Text = "Salário base: + " + salarioBruto.ToString("C");
                lblResultadoHoraExtra.Text = "Horas extras: + " + resultadoHoraExtra.ToString("C");
                lblResultadoAdicionalNoturno.Text = "Noturno: + " + resultadoAdicionalNoturno.ToString("C");
                lblResultdoPericulosidade.Text = "Periculosidade: + " + resultadoPericulosidade.ToString("C");
                lblResultadoFgts.Text = "FGTS: + " + resultadoFgts.ToString("C");
                lblResultadoValeTrasnporte.Text = "Vale transporte: - " + resultadoValeTransporte.ToString("C");
                lblResultadoInss.Text = "INSS: - " + resultadoInss.ToString("C");
                lblResultadoIr.Text = "Imposto de Renda: - " + resultadoIr.ToString("C");
                lblResultadoAdicionais.Text = "Total adicionais: " + resultadoTotalAdicionais.ToString("C");
                lblResultadoDescontos.Text = "Total descontos: " + resultadoTotalDescontos.ToString("C");
                lblResultadoSalarioLiquido.Text = "Salário líquido: " + resultadoSalarioLiquido.ToString("C"); 
            }
            catch (Exception)
            {
                MessageBox.Show("informe um valor de Hora Trabalhada Válido, ex 3500", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
