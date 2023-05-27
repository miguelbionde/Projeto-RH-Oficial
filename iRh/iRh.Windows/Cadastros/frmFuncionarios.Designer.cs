namespace iRh.Windows.Cadastros
{
    partial class frmFuncionarios
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
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.rbTemFilhoSim = new System.Windows.Forms.RadioButton();
            this.rbTemFilhosNão = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilhoNome = new System.Windows.Forms.TextBox();
            this.lblFilhoNome = new System.Windows.Forms.Label();
            this.lblFilhoDataNascimento = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.panelExibeDadosFilhos = new System.Windows.Forms.Panel();
            this.txtFilhoDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.panelExibeDadosFilhos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Neutro",
            "Prefiro Não Dizer",
            "Outros"});
            this.cmbGenero.Location = new System.Drawing.Point(41, 29);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(207, 21);
            this.cmbGenero.TabIndex = 0;
            // 
            // rbTemFilhoSim
            // 
            this.rbTemFilhoSim.AutoSize = true;
            this.rbTemFilhoSim.Location = new System.Drawing.Point(41, 158);
            this.rbTemFilhoSim.Name = "rbTemFilhoSim";
            this.rbTemFilhoSim.Size = new System.Drawing.Size(42, 17);
            this.rbTemFilhoSim.TabIndex = 1;
            this.rbTemFilhoSim.TabStop = true;
            this.rbTemFilhoSim.Text = "Sim";
            this.rbTemFilhoSim.UseVisualStyleBackColor = true;
            this.rbTemFilhoSim.CheckedChanged += new System.EventHandler(this.rbTemFilhoSim_CheckedChanged);
            // 
            // rbTemFilhosNão
            // 
            this.rbTemFilhosNão.AutoSize = true;
            this.rbTemFilhosNão.Location = new System.Drawing.Point(89, 158);
            this.rbTemFilhosNão.Name = "rbTemFilhosNão";
            this.rbTemFilhosNão.Size = new System.Drawing.Size(45, 17);
            this.rbTemFilhosNão.TabIndex = 2;
            this.rbTemFilhosNão.TabStop = true;
            this.rbTemFilhosNão.Text = "Não";
            this.rbTemFilhosNão.UseVisualStyleBackColor = true;
            this.rbTemFilhosNão.CheckedChanged += new System.EventHandler(this.rbTemFilhosNão_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Você tem filhos?";
            // 
            // txtFilhoNome
            // 
            this.txtFilhoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFilhoNome.Location = new System.Drawing.Point(9, 44);
            this.txtFilhoNome.Name = "txtFilhoNome";
            this.txtFilhoNome.Size = new System.Drawing.Size(100, 20);
            this.txtFilhoNome.TabIndex = 4;
            // 
            // lblFilhoNome
            // 
            this.lblFilhoNome.AutoSize = true;
            this.lblFilhoNome.Location = new System.Drawing.Point(6, 19);
            this.lblFilhoNome.Name = "lblFilhoNome";
            this.lblFilhoNome.Size = new System.Drawing.Size(92, 13);
            this.lblFilhoNome.TabIndex = 6;
            this.lblFilhoNome.Text = "Nome do seu filho";
            // 
            // lblFilhoDataNascimento
            // 
            this.lblFilhoDataNascimento.AutoSize = true;
            this.lblFilhoDataNascimento.Location = new System.Drawing.Point(127, 19);
            this.lblFilhoDataNascimento.Name = "lblFilhoDataNascimento";
            this.lblFilhoDataNascimento.Size = new System.Drawing.Size(102, 13);
            this.lblFilhoDataNascimento.TabIndex = 7;
            this.lblFilhoDataNascimento.Text = "Data de nascimento";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(236, 47);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(44, 13);
            this.lblIdade.TabIndex = 8;
            this.lblIdade.Text = "lblIdade";
            // 
            // panelExibeDadosFilhos
            // 
            this.panelExibeDadosFilhos.Controls.Add(this.txtFilhoDataNascimento);
            this.panelExibeDadosFilhos.Controls.Add(this.lblIdade);
            this.panelExibeDadosFilhos.Controls.Add(this.txtFilhoNome);
            this.panelExibeDadosFilhos.Controls.Add(this.lblFilhoDataNascimento);
            this.panelExibeDadosFilhos.Controls.Add(this.lblFilhoNome);
            this.panelExibeDadosFilhos.Location = new System.Drawing.Point(26, 181);
            this.panelExibeDadosFilhos.Name = "panelExibeDadosFilhos";
            this.panelExibeDadosFilhos.Size = new System.Drawing.Size(283, 108);
            this.panelExibeDadosFilhos.TabIndex = 9;
            // 
            // txtFilhoDataNascimento
            // 
            this.txtFilhoDataNascimento.Location = new System.Drawing.Point(130, 44);
            this.txtFilhoDataNascimento.Mask = "00/00/0000";
            this.txtFilhoDataNascimento.Name = "txtFilhoDataNascimento";
            this.txtFilhoDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtFilhoDataNascimento.TabIndex = 10;
            this.txtFilhoDataNascimento.ValidatingType = typeof(System.DateTime);
            this.txtFilhoDataNascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilhoDataNascimento_KeyDown);
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelExibeDadosFilhos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbTemFilhosNão);
            this.Controls.Add(this.rbTemFilhoSim);
            this.Controls.Add(this.cmbGenero);
            this.Name = "frmFuncionarios";
            this.Text = "frmFuncionarios";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.panelExibeDadosFilhos.ResumeLayout(false);
            this.panelExibeDadosFilhos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.RadioButton rbTemFilhoSim;
        private System.Windows.Forms.RadioButton rbTemFilhosNão;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilhoNome;
        private System.Windows.Forms.Label lblFilhoNome;
        private System.Windows.Forms.Label lblFilhoDataNascimento;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Panel panelExibeDadosFilhos;
        private System.Windows.Forms.MaskedTextBox txtFilhoDataNascimento;
    }
}