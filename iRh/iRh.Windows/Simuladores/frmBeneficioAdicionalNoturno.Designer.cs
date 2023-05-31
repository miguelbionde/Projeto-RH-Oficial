namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioAdicionalNoturno
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
            this.btnAdicionalNoturno = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtHoraNoturna = new System.Windows.Forms.TextBox();
            this.txtValorHoraNoturna = new System.Windows.Forms.TextBox();
            this.lblHoraNoturna = new System.Windows.Forms.Label();
            this.lblValorHoraNoturna = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionalNoturno
            // 
            this.btnAdicionalNoturno.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionalNoturno.Location = new System.Drawing.Point(31, 205);
            this.btnAdicionalNoturno.Name = "btnAdicionalNoturno";
            this.btnAdicionalNoturno.Size = new System.Drawing.Size(114, 62);
            this.btnAdicionalNoturno.TabIndex = 11;
            this.btnAdicionalNoturno.Text = "Calcular \r\nAdicional Noturno";
            this.btnAdicionalNoturno.UseVisualStyleBackColor = true;
            this.btnAdicionalNoturno.Click += new System.EventHandler(this.btnAdicionalNoturno_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(31, 284);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(200, 100);
            this.panelResultado.TabIndex = 6;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(20, 22);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(126, 30);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "lblResultado";
            this.lblResultado.Visible = false;
            // 
            // txtHoraNoturna
            // 
            this.txtHoraNoturna.Location = new System.Drawing.Point(31, 155);
            this.txtHoraNoturna.Multiline = true;
            this.txtHoraNoturna.Name = "txtHoraNoturna";
            this.txtHoraNoturna.Size = new System.Drawing.Size(158, 29);
            this.txtHoraNoturna.TabIndex = 15;
            // 
            // txtValorHoraNoturna
            // 
            this.txtValorHoraNoturna.Location = new System.Drawing.Point(29, 68);
            this.txtValorHoraNoturna.Multiline = true;
            this.txtValorHoraNoturna.Name = "txtValorHoraNoturna";
            this.txtValorHoraNoturna.Size = new System.Drawing.Size(160, 27);
            this.txtValorHoraNoturna.TabIndex = 14;
            // 
            // lblHoraNoturna
            // 
            this.lblHoraNoturna.AutoSize = true;
            this.lblHoraNoturna.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraNoturna.Location = new System.Drawing.Point(26, 111);
            this.lblHoraNoturna.Name = "lblHoraNoturna";
            this.lblHoraNoturna.Size = new System.Drawing.Size(393, 30);
            this.lblHoraNoturna.TabIndex = 13;
            this.lblHoraNoturna.Text = "Digite quantas horas noturnas trabalhou:";
            // 
            // lblValorHoraNoturna
            // 
            this.lblValorHoraNoturna.AutoSize = true;
            this.lblValorHoraNoturna.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHoraNoturna.Location = new System.Drawing.Point(24, 24);
            this.lblValorHoraNoturna.Name = "lblValorHoraNoturna";
            this.lblValorHoraNoturna.Size = new System.Drawing.Size(324, 30);
            this.lblValorHoraNoturna.TabIndex = 12;
            this.lblValorHoraNoturna.Text = "Digite o valor da hora trabalhada:";
            // 
            // frmBeneficioAdicionalNoturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHoraNoturna);
            this.Controls.Add(this.txtValorHoraNoturna);
            this.Controls.Add(this.lblHoraNoturna);
            this.Controls.Add(this.lblValorHoraNoturna);
            this.Controls.Add(this.btnAdicionalNoturno);
            this.Controls.Add(this.panelResultado);
            this.Name = "frmBeneficioAdicionalNoturno";
            this.Text = "frmAdicionalNoturno";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionalNoturno;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtHoraNoturna;
        private System.Windows.Forms.TextBox txtValorHoraNoturna;
        private System.Windows.Forms.Label lblHoraNoturna;
        private System.Windows.Forms.Label lblValorHoraNoturna;
    }
}