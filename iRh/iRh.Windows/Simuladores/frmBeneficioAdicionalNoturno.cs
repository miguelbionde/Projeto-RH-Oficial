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
    public partial class frmBeneficioAdicionalNoturno : Form
    {
        public frmBeneficioAdicionalNoturno()
        {
            InitializeComponent();
        }

        private void btnAdicionalNoturno_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValorHoraNoturna.Text))
            {
                MessageBox.Show("Informe o valor da sua hora noturna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorHoraNoturna.Focus();
                return;
            }


            try
            {
                var valorHoraNoturna = double.Parse(txtValorHoraNoturna.Text);
                var horaNoturna = double.Parse(txtHoraNoturna.Text);
                var adicionalHoraExtra = AdicionalNoturno.Calcular(valorHoraNoturna, horaNoturna);
                lblResultado.Text = "R$" + adicionalHoraExtra.ToString();
                lblResultado.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("informe um valor de hora Válido, ex 5,93", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
