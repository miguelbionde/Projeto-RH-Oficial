namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioValeTransporteValeaPena
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
            this.lblPassagemDia = new System.Windows.Forms.Label();
            this.lblDiasMes = new System.Windows.Forms.Label();
            this.txtPassagemDia = new System.Windows.Forms.TextBox();
            this.txtDiasMes = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblValorPassagem = new System.Windows.Forms.Label();
            this.txtValorPassagem = new System.Windows.Forms.TextBox();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPassagemDia
            // 
            this.lblPassagemDia.AutoSize = true;
            this.lblPassagemDia.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassagemDia.Location = new System.Drawing.Point(7, 118);
            this.lblPassagemDia.Name = "lblPassagemDia";
            this.lblPassagemDia.Size = new System.Drawing.Size(307, 30);
            this.lblPassagemDia.TabIndex = 0;
            this.lblPassagemDia.Text = "Quantas Passagem por dia usa?";
            // 
            // lblDiasMes
            // 
            this.lblDiasMes.AutoSize = true;
            this.lblDiasMes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasMes.Location = new System.Drawing.Point(7, 188);
            this.lblDiasMes.Name = "lblDiasMes";
            this.lblDiasMes.Size = new System.Drawing.Size(307, 30);
            this.lblDiasMes.TabIndex = 1;
            this.lblDiasMes.Text = "Quantos dias por mês trabalha?";
            // 
            // txtPassagemDia
            // 
            this.txtPassagemDia.Location = new System.Drawing.Point(12, 151);
            this.txtPassagemDia.Multiline = true;
            this.txtPassagemDia.Name = "txtPassagemDia";
            this.txtPassagemDia.Size = new System.Drawing.Size(195, 34);
            this.txtPassagemDia.TabIndex = 2;
            // 
            // txtDiasMes
            // 
            this.txtDiasMes.Location = new System.Drawing.Point(12, 221);
            this.txtDiasMes.Multiline = true;
            this.txtDiasMes.Name = "txtDiasMes";
            this.txtDiasMes.Size = new System.Drawing.Size(195, 34);
            this.txtDiasMes.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(12, 367);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(109, 44);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblValorPassagem
            // 
            this.lblValorPassagem.AutoSize = true;
            this.lblValorPassagem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPassagem.Location = new System.Drawing.Point(7, 267);
            this.lblValorPassagem.Name = "lblValorPassagem";
            this.lblValorPassagem.Size = new System.Drawing.Size(280, 30);
            this.lblValorPassagem.TabIndex = 5;
            this.lblValorPassagem.Text = "Qual é o valor da passagem?";
            // 
            // txtValorPassagem
            // 
            this.txtValorPassagem.Location = new System.Drawing.Point(12, 300);
            this.txtValorPassagem.Multiline = true;
            this.txtValorPassagem.Name = "txtValorPassagem";
            this.txtValorPassagem.Size = new System.Drawing.Size(195, 37);
            this.txtValorPassagem.TabIndex = 6;
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(380, 285);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(289, 125);
            this.panelResultado.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 30);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(126, 30);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "lblResultado";
            this.lblResultado.Visible = false;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(9, 43);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(199, 30);
            this.lblSalario.TabIndex = 8;
            this.lblSalario.Text = "Qual o salário base?";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(12, 76);
            this.txtSalario.Multiline = true;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(196, 39);
            this.txtSalario.TabIndex = 9;
            // 
            // frmBeneficioValeTransporteValeaPena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.txtValorPassagem);
            this.Controls.Add(this.lblValorPassagem);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDiasMes);
            this.Controls.Add(this.txtPassagemDia);
            this.Controls.Add(this.lblDiasMes);
            this.Controls.Add(this.lblPassagemDia);
            this.Name = "frmBeneficioValeTransporteValeaPena";
            this.Text = "frmBeneficioValeTransporteValeaPena";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassagemDia;
        private System.Windows.Forms.Label lblDiasMes;
        private System.Windows.Forms.TextBox txtPassagemDia;
        private System.Windows.Forms.TextBox txtDiasMes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblValorPassagem;
        private System.Windows.Forms.TextBox txtValorPassagem;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
    }
}