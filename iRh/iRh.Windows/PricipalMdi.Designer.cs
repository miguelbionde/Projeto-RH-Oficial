namespace iRh.Windows
{
    partial class PricipalMdi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PricipalMdi));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.simuladoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDescontoInss = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDescontoIrrf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menubenefícioAdicionalNoturno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBenefícioFGTS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBenefícioFérias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBenefícioHoraExtra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBenefícioPericulosidade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBenefícioPIS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBenefícioSeguroDesempregp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBenefícioVAleTransporte = new System.Windows.Forms.ToolStripMenuItem();
            this.detalhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.simuladoresToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFuncionarios});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.funcionáriosToolStripMenuItem.Text = "Cadastros";
            // 
            // menuFuncionarios
            // 
            this.menuFuncionarios.Name = "menuFuncionarios";
            this.menuFuncionarios.Size = new System.Drawing.Size(142, 22);
            this.menuFuncionarios.Text = "Funcionários";
            this.menuFuncionarios.Click += new System.EventHandler(this.menuFuncionarios_Click);
            // 
            // simuladoresToolStripMenuItem
            // 
            this.simuladoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDescontoInss,
            this.menuDescontoIrrf,
            this.toolStripSeparator1,
            this.menubenefícioAdicionalNoturno,
            this.menuBenefícioFGTS,
            this.menuBenefícioFérias,
            this.menuBenefícioHoraExtra,
            this.menuBenefícioPericulosidade,
            this.menuBenefícioPIS,
            this.menuBenefícioSeguroDesempregp,
            this.menuBenefícioVAleTransporte,
            this.detalhamentoToolStripMenuItem});
            this.simuladoresToolStripMenuItem.Name = "simuladoresToolStripMenuItem";
            this.simuladoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.simuladoresToolStripMenuItem.Text = "Simuladores";
            // 
            // menuDescontoInss
            // 
            this.menuDescontoInss.Name = "menuDescontoInss";
            this.menuDescontoInss.Size = new System.Drawing.Size(249, 22);
            this.menuDescontoInss.Text = "Desconto de INSS";
            this.menuDescontoInss.Click += new System.EventHandler(this.menuDescontoInss_Click);
            // 
            // menuDescontoIrrf
            // 
            this.menuDescontoIrrf.Name = "menuDescontoIrrf";
            this.menuDescontoIrrf.Size = new System.Drawing.Size(249, 22);
            this.menuDescontoIrrf.Text = "Desconto de IRRF";
            this.menuDescontoIrrf.Click += new System.EventHandler(this.menuDescontoIrrf_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(246, 6);
            // 
            // menubenefícioAdicionalNoturno
            // 
            this.menubenefícioAdicionalNoturno.Name = "menubenefícioAdicionalNoturno";
            this.menubenefícioAdicionalNoturno.Size = new System.Drawing.Size(249, 22);
            this.menubenefícioAdicionalNoturno.Text = "Benefício de Adicional Noturno";
            this.menubenefícioAdicionalNoturno.Click += new System.EventHandler(this.menubenefícioAdicionalNoturno_Click);
            // 
            // menuBenefícioFGTS
            // 
            this.menuBenefícioFGTS.Name = "menuBenefícioFGTS";
            this.menuBenefícioFGTS.Size = new System.Drawing.Size(249, 22);
            this.menuBenefícioFGTS.Text = "Benefício de Depósito FGTS";
            this.menuBenefícioFGTS.Click += new System.EventHandler(this.menuBenefícioFGTS_Click);
            // 
            // menuBenefícioFérias
            // 
            this.menuBenefícioFérias.Name = "menuBenefícioFérias";
            this.menuBenefícioFérias.Size = new System.Drawing.Size(249, 22);
            this.menuBenefícioFérias.Text = "Benefício Férias";
            this.menuBenefícioFérias.Click += new System.EventHandler(this.menuBenefícioFérias_Click);
            // 
            // menuBenefícioHoraExtra
            // 
            this.menuBenefícioHoraExtra.Name = "menuBenefícioHoraExtra";
            this.menuBenefícioHoraExtra.Size = new System.Drawing.Size(249, 22);
            this.menuBenefícioHoraExtra.Text = "Benefício de Hora Extra";
            this.menuBenefícioHoraExtra.Click += new System.EventHandler(this.menuBenefícioHoraExtra_Click);
            // 
            // menuBenefícioPericulosidade
            // 
            this.menuBenefícioPericulosidade.Name = "menuBenefícioPericulosidade";
            this.menuBenefícioPericulosidade.Size = new System.Drawing.Size(249, 22);
            this.menuBenefícioPericulosidade.Text = "Benefício de Periculosidade";
            this.menuBenefícioPericulosidade.Click += new System.EventHandler(this.menuBenefícioPericulosidade_Click);
            // 
            // menuBenefícioPIS
            // 
            this.menuBenefícioPIS.Name = "menuBenefícioPIS";
            this.menuBenefícioPIS.Size = new System.Drawing.Size(249, 22);
            this.menuBenefícioPIS.Text = "Benefício de PIS";
            this.menuBenefícioPIS.Click += new System.EventHandler(this.menuBenefícioPIS_Click);
            // 
            // menuBenefícioSeguroDesempregp
            // 
            this.menuBenefícioSeguroDesempregp.Name = "menuBenefícioSeguroDesempregp";
            this.menuBenefícioSeguroDesempregp.Size = new System.Drawing.Size(249, 22);
            this.menuBenefícioSeguroDesempregp.Text = "Benefício de Seguro Desemprego";
            this.menuBenefícioSeguroDesempregp.Click += new System.EventHandler(this.menuBenefícioSeguroDesempregp_Click);
            // 
            // menuBenefícioVAleTransporte
            // 
            this.menuBenefícioVAleTransporte.Name = "menuBenefícioVAleTransporte";
            this.menuBenefícioVAleTransporte.Size = new System.Drawing.Size(249, 22);
            this.menuBenefícioVAleTransporte.Text = "Benefício de Vale Transporte";
            this.menuBenefícioVAleTransporte.Click += new System.EventHandler(this.menuBenefícioVAleTransporte_Click);
            // 
            // detalhamentoToolStripMenuItem
            // 
            this.detalhamentoToolStripMenuItem.Name = "detalhamentoToolStripMenuItem";
            this.detalhamentoToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.detalhamentoToolStripMenuItem.Text = "Detalhamento";
            this.detalhamentoToolStripMenuItem.Click += new System.EventHandler(this.detalhamentoToolStripMenuItem_Click);
            // 
            // PricipalMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "PricipalMdi";
            this.Text = "PricipalMdi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem simuladoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDescontoInss;
        private System.Windows.Forms.ToolStripMenuItem menuDescontoIrrf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menubenefícioAdicionalNoturno;
        private System.Windows.Forms.ToolStripMenuItem menuBenefícioFGTS;
        private System.Windows.Forms.ToolStripMenuItem menuBenefícioFérias;
        private System.Windows.Forms.ToolStripMenuItem menuBenefícioHoraExtra;
        private System.Windows.Forms.ToolStripMenuItem menuBenefícioPericulosidade;
        private System.Windows.Forms.ToolStripMenuItem menuBenefícioPIS;
        private System.Windows.Forms.ToolStripMenuItem menuBenefícioSeguroDesempregp;
        private System.Windows.Forms.ToolStripMenuItem menuBenefícioVAleTransporte;
        private System.Windows.Forms.ToolStripMenuItem detalhamentoToolStripMenuItem;
    }
}