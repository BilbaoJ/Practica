namespace BancoABC
{
    partial class Form4
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
            this.txtCuentaOrigen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuentaDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoTrans = new System.Windows.Forms.TextBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTransferir);
            this.groupBox1.Controls.Add(this.txtMontoTrans);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCuentaDestino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCuentaOrigen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transferencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de cuenta de origen";
            // 
            // txtCuentaOrigen
            // 
            this.txtCuentaOrigen.Location = new System.Drawing.Point(20, 48);
            this.txtCuentaOrigen.Name = "txtCuentaOrigen";
            this.txtCuentaOrigen.Size = new System.Drawing.Size(100, 20);
            this.txtCuentaOrigen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de cuenta de destino";
            // 
            // txtCuentaDestino
            // 
            this.txtCuentaDestino.Location = new System.Drawing.Point(20, 101);
            this.txtCuentaDestino.Name = "txtCuentaDestino";
            this.txtCuentaDestino.Size = new System.Drawing.Size(100, 20);
            this.txtCuentaDestino.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monto a transferir";
            // 
            // txtMontoTrans
            // 
            this.txtMontoTrans.Location = new System.Drawing.Point(20, 154);
            this.txtMontoTrans.Name = "txtMontoTrans";
            this.txtMontoTrans.Size = new System.Drawing.Size(100, 20);
            this.txtMontoTrans.TabIndex = 5;
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(20, 193);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(75, 23);
            this.btnTransferir.TabIndex = 6;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 263);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Banco ABC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.TextBox txtMontoTrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCuentaDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCuentaOrigen;
        private System.Windows.Forms.Label label1;
    }
}