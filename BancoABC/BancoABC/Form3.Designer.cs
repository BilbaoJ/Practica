namespace BancoABC
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuentaRet = new System.Windows.Forms.TextBox();
            this.txtMontoRet = new System.Windows.Forms.TextBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRetirar);
            this.groupBox1.Controls.Add(this.txtMontoRet);
            this.groupBox1.Controls.Add(this.txtCuentaRet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retiro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto a retirar";
            // 
            // txtCuentaRet
            // 
            this.txtCuentaRet.Location = new System.Drawing.Point(27, 53);
            this.txtCuentaRet.Name = "txtCuentaRet";
            this.txtCuentaRet.Size = new System.Drawing.Size(100, 20);
            this.txtCuentaRet.TabIndex = 2;
            // 
            // txtMontoRet
            // 
            this.txtMontoRet.Location = new System.Drawing.Point(27, 113);
            this.txtMontoRet.Name = "txtMontoRet";
            this.txtMontoRet.Size = new System.Drawing.Size(100, 20);
            this.txtMontoRet.TabIndex = 3;
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(27, 149);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(75, 23);
            this.btnRetirar.TabIndex = 4;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 229);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Banco ABC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.TextBox txtMontoRet;
        private System.Windows.Forms.TextBox txtCuentaRet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}