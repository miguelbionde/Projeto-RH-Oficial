namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioFerias
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
            this.lblSalario = new System.Windows.Forms.Label();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCalcularFerias = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(28, 38);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(124, 30);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Salário Base";
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(33, 241);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(200, 100);
            this.panelResultado.TabIndex = 1;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(33, 89);
            this.txtSalario.Multiline = true;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(136, 30);
            this.txtSalario.TabIndex = 2;
            // 
            // btnCalcularFerias
            // 
            this.btnCalcularFerias.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularFerias.Location = new System.Drawing.Point(33, 155);
            this.btnCalcularFerias.Name = "btnCalcularFerias";
            this.btnCalcularFerias.Size = new System.Drawing.Size(89, 65);
            this.btnCalcularFerias.TabIndex = 3;
            this.btnCalcularFerias.Text = "Calcular Férias";
            this.btnCalcularFerias.UseVisualStyleBackColor = true;
            this.btnCalcularFerias.Click += new System.EventHandler(this.btnCalcularFerias_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(16, 23);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(126, 30);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "lblResultado";
            this.lblResultado.Visible = false;
            // 
            // frmBeneficioFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularFerias);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.lblSalario);
            this.Name = "frmBeneficioFerias";
            this.Text = "frmBeneficioFerias";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcularFerias;
    }
}