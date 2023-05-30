namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioHoraExtra
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
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblValorHoraExtra = new System.Windows.Forms.Label();
            this.lblHoraExtra = new System.Windows.Forms.Label();
            this.txtValorHoraExtra = new System.Windows.Forms.TextBox();
            this.txtHoraExtra = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnHoraExtra = new System.Windows.Forms.Button();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(33, 275);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(200, 100);
            this.panelResultado.TabIndex = 0;
            // 
            // lblValorHoraExtra
            // 
            this.lblValorHoraExtra.AutoSize = true;
            this.lblValorHoraExtra.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHoraExtra.Location = new System.Drawing.Point(28, 31);
            this.lblValorHoraExtra.Name = "lblValorHoraExtra";
            this.lblValorHoraExtra.Size = new System.Drawing.Size(324, 30);
            this.lblValorHoraExtra.TabIndex = 1;
            this.lblValorHoraExtra.Text = "Digite o valor da hora trabalhada:";
            // 
            // lblHoraExtra
            // 
            this.lblHoraExtra.AutoSize = true;
            this.lblHoraExtra.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraExtra.Location = new System.Drawing.Point(30, 118);
            this.lblHoraExtra.Name = "lblHoraExtra";
            this.lblHoraExtra.Size = new System.Drawing.Size(305, 30);
            this.lblHoraExtra.TabIndex = 2;
            this.lblHoraExtra.Text = "Digite quantas horas extras fez:";
            // 
            // txtValorHoraExtra
            // 
            this.txtValorHoraExtra.Location = new System.Drawing.Point(33, 75);
            this.txtValorHoraExtra.Multiline = true;
            this.txtValorHoraExtra.Name = "txtValorHoraExtra";
            this.txtValorHoraExtra.Size = new System.Drawing.Size(160, 27);
            this.txtValorHoraExtra.TabIndex = 3;
            // 
            // txtHoraExtra
            // 
            this.txtHoraExtra.Location = new System.Drawing.Point(35, 162);
            this.txtHoraExtra.Multiline = true;
            this.txtHoraExtra.Name = "txtHoraExtra";
            this.txtHoraExtra.Size = new System.Drawing.Size(158, 29);
            this.txtHoraExtra.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(20, 22);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(65, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "lblResultado";
            // 
            // btnHoraExtra
            // 
            this.btnHoraExtra.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoraExtra.Location = new System.Drawing.Point(33, 207);
            this.btnHoraExtra.Name = "btnHoraExtra";
            this.btnHoraExtra.Size = new System.Drawing.Size(114, 62);
            this.btnHoraExtra.TabIndex = 5;
            this.btnHoraExtra.Text = "Calcular \r\nHora Extra";
            this.btnHoraExtra.UseVisualStyleBackColor = true;
            this.btnHoraExtra.Click += new System.EventHandler(this.btnHoraExtra_Click);
            // 
            // frmBeneficioHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHoraExtra);
            this.Controls.Add(this.txtHoraExtra);
            this.Controls.Add(this.txtValorHoraExtra);
            this.Controls.Add(this.lblHoraExtra);
            this.Controls.Add(this.lblValorHoraExtra);
            this.Controls.Add(this.panelResultado);
            this.Name = "frmBeneficioHoraExtra";
            this.Text = "frmBeneficioHoraExtra";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblValorHoraExtra;
        private System.Windows.Forms.Label lblHoraExtra;
        private System.Windows.Forms.TextBox txtValorHoraExtra;
        private System.Windows.Forms.TextBox txtHoraExtra;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnHoraExtra;
    }
}