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
    public partial class frmDescontoInss : Form
    {
        public frmDescontoInss()
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


            try
            {
                var salario = double.Parse(txtSalario.Text);
                if (salario <= 1302.00)
                    var desconto_1
            }
            catch (Exception)
            {
                MessageBox.Show("informe um valor de salário Válido, ex 3500", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            

        }
    }
}
