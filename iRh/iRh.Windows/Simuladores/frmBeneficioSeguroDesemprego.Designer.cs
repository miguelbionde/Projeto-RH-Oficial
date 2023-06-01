namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioSeguroDesemprego
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
            this.btnSeguroDesemprego = new System.Windows.Forms.Button();
            this.lblSeguroDesemprego = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtSeguroDesemprego = new System.Windows.Forms.TextBox();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeguroDesemprego
            // 
            this.btnSeguroDesemprego.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguroDesemprego.Location = new System.Drawing.Point(30, 157);
            this.btnSeguroDesemprego.Name = "btnSeguroDesemprego";
            this.btnSeguroDesemprego.Size = new System.Drawing.Size(156, 57);
            this.btnSeguroDesemprego.TabIndex = 0;
            this.btnSeguroDesemprego.Text = "Checar Seguro-Desemprego";
            this.btnSeguroDesemprego.UseVisualStyleBackColor = true;
            this.btnSeguroDesemprego.Click += new System.EventHandler(this.btnSeguroDesemprego_Click);
            // 
            // lblSeguroDesemprego
            // 
            this.lblSeguroDesemprego.AutoSize = true;
            this.lblSeguroDesemprego.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguroDesemprego.Location = new System.Drawing.Point(25, 28);
            this.lblSeguroDesemprego.Name = "lblSeguroDesemprego";
            this.lblSeguroDesemprego.Size = new System.Drawing.Size(313, 60);
            this.lblSeguroDesemprego.TabIndex = 1;
            this.lblSeguroDesemprego.Text = "Informe a quantidade de meses \r\ntrabalhados nos últimos anos:\r\n";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 14);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(115, 25);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "lblResultado";
            this.lblResultado.Visible = false;
            // 
            // txtSeguroDesemprego
            // 
            this.txtSeguroDesemprego.Location = new System.Drawing.Point(28, 91);
            this.txtSeguroDesemprego.Multiline = true;
            this.txtSeguroDesemprego.Name = "txtSeguroDesemprego";
            this.txtSeguroDesemprego.Size = new System.Drawing.Size(201, 30);
            this.txtSeguroDesemprego.TabIndex = 3;
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(28, 239);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(359, 87);
            this.panelResultado.TabIndex = 4;
            // 
            // frmBeneficioSeguroDesemprego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 375);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.txtSeguroDesemprego);
            this.Controls.Add(this.lblSeguroDesemprego);
            this.Controls.Add(this.btnSeguroDesemprego);
            this.Name = "frmBeneficioSeguroDesemprego";
            this.Text = "frmBeneficioSeguroDesemprego";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeguroDesemprego;
        private System.Windows.Forms.Label lblSeguroDesemprego;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtSeguroDesemprego;
        private System.Windows.Forms.Panel panelResultado;
    }
}