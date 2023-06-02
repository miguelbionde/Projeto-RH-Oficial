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
    public partial class frmBeneficioPis : Form
    {
        public frmBeneficioPis()
        {
            InitializeComponent();
        }

        private void frmBeneficioPis_Load(object sender, EventArgs e)
        {
            rbMenosCincoAnos.Checked = true;
            panelTempoAnoBase.Visible = false;
            rbMaisUmMes.Checked = true;
            panelSalario.Visible = false;
        }

        private void rbMaiorCincoAnos_CheckedChanged(object sender, EventArgs e)
        {
            panelTempoAnoBase.Visible = true;
            panelResultado.Visible = false;
        }

        private void rbMenosCincoAnos_CheckedChanged(object sender, EventArgs e)
        {
            panelTempoAnoBase.Visible = false;
            panelResultado.Visible = true;
            lblResultado.Text = "Não tem direito ao PIS";
        }

        private void rbMaisUmMes_CheckedChanged(object sender, EventArgs e)
        {
            panelSalario.Visible = true;
            panelResultado.Visible = false;
        }

        private void rbMenosUmMes_CheckedChanged(object sender, EventArgs e)
        {
            panelSalario.Visible = false;
            panelResultado.Visible = true;
            lblResultado.Text = "Não tem direito ao PIS";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe seu Salário base!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }


            try
            {
                var salario = double.Parse(txtSalario.Text);
                var mesesTrabalhado = double.Parse(txtMesTrabalhado.Text);
                var pis = Pis.Calcular(salario, mesesTrabalhado);
                if(pis > 0)
                {
                    lblResultado.Text = "Tem direito a receber o PIS. Seu PIS é de  " + pis.ToString("C");
                    panelResultado.Visible = true;
                }
                else
                {
                    lblResultado.Text = "Não tem direito ao PIS";
                    panelResultado.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("informe um valor de salário Válido, ex 3500", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
