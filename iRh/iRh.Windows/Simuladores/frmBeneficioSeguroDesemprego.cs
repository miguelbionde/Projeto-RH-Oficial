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
    public partial class frmBeneficioSeguroDesemprego : Form
    {
        public frmBeneficioSeguroDesemprego()
        {
            InitializeComponent();
        }

        private void btnSeguroDesemprego_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSeguroDesemprego.Text))
            {
                MessageBox.Show("Informe quantos meses trabalhou!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSeguroDesemprego.Focus();
                return;
            }


            try
            {
                var meses = int.Parse(txtSeguroDesemprego.Text);
                if (meses >= 12)
                {
                    lblResultado.Text = "Tem direito ao Seguro-Desemprego";
                    lblResultado.Visible = true;
                }
                else
                {
                    lblResultado.Text = "Não tem direito ao Seguro-Desemprego";
                    lblResultado.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("informe uma qunatidade de meses Válido, ex 16", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
