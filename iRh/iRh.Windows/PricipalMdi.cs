using iRh.Windows.Cadastros;
using iRh.Windows.Simuladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows
{
    public partial class PricipalMdi : Form
    {
        public PricipalMdi()
        {
            InitializeComponent();
        }

        private void menuDescontoInss_Click(object sender, EventArgs e)
        {
            var form = new frmDescontoInss();
            form.MdiParent = this;
            form.Show();
        }

        private void menuDescontoIrrf_Click(object sender, EventArgs e)
        {
            var form = new frmDescontoIrrf();
            form.MdiParent = this;
            form.Show();
        }

        private void menubenefícioAdicionalNoturno_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioAdicionalNoturno();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBenefícioFGTS_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioFgts();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBenefícioFérias_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioFerias();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBenefícioHoraExtra_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioHoraExtra();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBenefícioPericulosidade_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioPericulosidade();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBenefícioPIS_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioPis();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBenefícioSeguroDesempregp_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioSeguroDesemprego();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBenefícioVAleTransporte_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioValeTransporte();
            form.MdiParent = this;
            form.Show();
        }

        private void menuFuncionarios_Click(object sender, EventArgs e)
        {
            var form = new frmFuncionarios();
            form.MdiParent = this;
            form.Show();
        }

        private void detalhamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmDetalhamento();
            form.MdiParent = this;
            form.Show();
        }
    }
}
