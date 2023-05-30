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
    public partial class frmBeneficioHoraExtra : Form
    {
        public frmBeneficioHoraExtra()
        {
            InitializeComponent();
        }

        private void btnHoraExtra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValorHoraExtra.Text))
            {
                MessageBox.Show("Informe o valor da sua hora extra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorHoraExtra.Focus();
                return;
            }


            try
            {
                var valorHoraExtra = double.Parse(txtValorHoraExtra.Text);
                var horaExtra = double.Parse(txtHoraExtra.Text);
                var adicionalHoraExtra = HoraExtra.Calcular(valorHoraExtra, horaExtra);
                lblResultado.Text = "R$" + adicionalHoraExtra.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("informe um valor de salário Válido, ex 5,93", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
