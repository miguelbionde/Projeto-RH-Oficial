namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioPis
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
            this.lblTempoInscrito = new System.Windows.Forms.Label();
            this.rbMaiorCincoAnos = new System.Windows.Forms.RadioButton();
            this.rbMenosCincoAnos = new System.Windows.Forms.RadioButton();
            this.panelTempoAnoBase = new System.Windows.Forms.Panel();
            this.rbMaisUmMes = new System.Windows.Forms.RadioButton();
            this.lblAnoBase = new System.Windows.Forms.Label();
            this.rbMenosUmMes = new System.Windows.Forms.RadioButton();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelSalario = new System.Windows.Forms.Panel();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMesTrabalhado = new System.Windows.Forms.Label();
            this.txtMesTrabalhado = new System.Windows.Forms.TextBox();
            this.panelTempoAnoBase.SuspendLayout();
            this.panelSalario.SuspendLayout();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTempoInscrito
            // 
            this.lblTempoInscrito.AutoSize = true;
            this.lblTempoInscrito.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoInscrito.Location = new System.Drawing.Point(32, 43);
            this.lblTempoInscrito.Name = "lblTempoInscrito";
            this.lblTempoInscrito.Size = new System.Drawing.Size(329, 50);
            this.lblTempoInscrito.TabIndex = 0;
            this.lblTempoInscrito.Text = "Informe a quanto tempo a sua pessoa\r\nestá inscrito no PIS:";
            // 
            // rbMaiorCincoAnos
            // 
            this.rbMaiorCincoAnos.AutoSize = true;
            this.rbMaiorCincoAnos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaiorCincoAnos.Location = new System.Drawing.Point(37, 109);
            this.rbMaiorCincoAnos.Name = "rbMaiorCincoAnos";
            this.rbMaiorCincoAnos.Size = new System.Drawing.Size(141, 25);
            this.rbMaiorCincoAnos.TabIndex = 2;
            this.rbMaiorCincoAnos.TabStop = true;
            this.rbMaiorCincoAnos.Text = "Mais que 5 anos";
            this.rbMaiorCincoAnos.UseVisualStyleBackColor = true;
            this.rbMaiorCincoAnos.CheckedChanged += new System.EventHandler(this.rbMaiorCincoAnos_CheckedChanged);
            // 
            // rbMenosCincoAnos
            // 
            this.rbMenosCincoAnos.AutoSize = true;
            this.rbMenosCincoAnos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMenosCincoAnos.Location = new System.Drawing.Point(184, 109);
            this.rbMenosCincoAnos.Name = "rbMenosCincoAnos";
            this.rbMenosCincoAnos.Size = new System.Drawing.Size(155, 25);
            this.rbMenosCincoAnos.TabIndex = 3;
            this.rbMenosCincoAnos.TabStop = true;
            this.rbMenosCincoAnos.Text = "Menos que 5 anos";
            this.rbMenosCincoAnos.UseVisualStyleBackColor = true;
            this.rbMenosCincoAnos.CheckedChanged += new System.EventHandler(this.rbMenosCincoAnos_CheckedChanged);
            // 
            // panelTempoAnoBase
            // 
            this.panelTempoAnoBase.Controls.Add(this.rbMaisUmMes);
            this.panelTempoAnoBase.Controls.Add(this.lblAnoBase);
            this.panelTempoAnoBase.Controls.Add(this.rbMenosUmMes);
            this.panelTempoAnoBase.Location = new System.Drawing.Point(37, 164);
            this.panelTempoAnoBase.Name = "panelTempoAnoBase";
            this.panelTempoAnoBase.Size = new System.Drawing.Size(280, 100);
            this.panelTempoAnoBase.TabIndex = 5;
            this.panelTempoAnoBase.Visible = false;
            // 
            // rbMaisUmMes
            // 
            this.rbMaisUmMes.AutoSize = true;
            this.rbMaisUmMes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaisUmMes.Location = new System.Drawing.Point(3, 37);
            this.rbMaisUmMes.Name = "rbMaisUmMes";
            this.rbMaisUmMes.Size = new System.Drawing.Size(123, 21);
            this.rbMaisUmMes.TabIndex = 6;
            this.rbMaisUmMes.TabStop = true;
            this.rbMaisUmMes.Text = "Mais de um mês";
            this.rbMaisUmMes.UseVisualStyleBackColor = true;
            this.rbMaisUmMes.CheckedChanged += new System.EventHandler(this.rbMaisUmMes_CheckedChanged);
            // 
            // lblAnoBase
            // 
            this.lblAnoBase.AutoSize = true;
            this.lblAnoBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoBase.Location = new System.Drawing.Point(3, 0);
            this.lblAnoBase.Name = "lblAnoBase";
            this.lblAnoBase.Size = new System.Drawing.Size(275, 21);
            this.lblAnoBase.TabIndex = 1;
            this.lblAnoBase.Text = "Quanto tempo Trabalhou no ano base:";
            // 
            // rbMenosUmMes
            // 
            this.rbMenosUmMes.AutoSize = true;
            this.rbMenosUmMes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMenosUmMes.Location = new System.Drawing.Point(132, 37);
            this.rbMenosUmMes.Name = "rbMenosUmMes";
            this.rbMenosUmMes.Size = new System.Drawing.Size(135, 21);
            this.rbMenosUmMes.TabIndex = 5;
            this.rbMenosUmMes.TabStop = true;
            this.rbMenosUmMes.Text = "Menos de um mês";
            this.rbMenosUmMes.UseVisualStyleBackColor = true;
            this.rbMenosUmMes.CheckedChanged += new System.EventHandler(this.rbMenosUmMes_CheckedChanged);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(3, 3);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(94, 21);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "Salário Base";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(3, 25);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(96, 21);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "lblResultado";
            // 
            // panelSalario
            // 
            this.panelSalario.Controls.Add(this.txtMesTrabalhado);
            this.panelSalario.Controls.Add(this.lblMesTrabalhado);
            this.panelSalario.Controls.Add(this.button1);
            this.panelSalario.Controls.Add(this.txtSalario);
            this.panelSalario.Controls.Add(this.lblSalario);
            this.panelSalario.Location = new System.Drawing.Point(399, 43);
            this.panelSalario.Name = "panelSalario";
            this.panelSalario.Size = new System.Drawing.Size(338, 179);
            this.panelSalario.TabIndex = 8;
            this.panelSalario.Visible = false;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(7, 30);
            this.txtSalario.Multiline = true;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(113, 28);
            this.txtSalario.TabIndex = 10;
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(367, 255);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(406, 100);
            this.panelResultado.TabIndex = 9;
            this.panelResultado.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(204, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calcular PIS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMesTrabalhado
            // 
            this.lblMesTrabalhado.AutoSize = true;
            this.lblMesTrabalhado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesTrabalhado.Location = new System.Drawing.Point(4, 80);
            this.lblMesTrabalhado.Name = "lblMesTrabalhado";
            this.lblMesTrabalhado.Size = new System.Drawing.Size(183, 34);
            this.lblMesTrabalhado.TabIndex = 12;
            this.lblMesTrabalhado.Text = "Digite a quantidade de meses\r\n trabalhados no ano-base:";
            // 
            // txtMesTrabalhado
            // 
            this.txtMesTrabalhado.Location = new System.Drawing.Point(7, 124);
            this.txtMesTrabalhado.Multiline = true;
            this.txtMesTrabalhado.Name = "txtMesTrabalhado";
            this.txtMesTrabalhado.Size = new System.Drawing.Size(113, 29);
            this.txtMesTrabalhado.TabIndex = 13;
            // 
            // frmBeneficioPis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.panelSalario);
            this.Controls.Add(this.panelTempoAnoBase);
            this.Controls.Add(this.rbMenosCincoAnos);
            this.Controls.Add(this.rbMaiorCincoAnos);
            this.Controls.Add(this.lblTempoInscrito);
            this.Name = "frmBeneficioPis";
            this.Text = "frmBeneficioPis";
            this.Load += new System.EventHandler(this.frmBeneficioPis_Load);
            this.panelTempoAnoBase.ResumeLayout(false);
            this.panelTempoAnoBase.PerformLayout();
            this.panelSalario.ResumeLayout(false);
            this.panelSalario.PerformLayout();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTempoInscrito;
        private System.Windows.Forms.RadioButton rbMaiorCincoAnos;
        private System.Windows.Forms.RadioButton rbMenosCincoAnos;
        private System.Windows.Forms.Panel panelTempoAnoBase;
        private System.Windows.Forms.RadioButton rbMaisUmMes;
        private System.Windows.Forms.Label lblAnoBase;
        private System.Windows.Forms.RadioButton rbMenosUmMes;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel panelSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMesTrabalhado;
        private System.Windows.Forms.Label lblMesTrabalhado;
    }
}