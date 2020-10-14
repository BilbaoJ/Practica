namespace BancoABC
{
    partial class Form2
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
            this.btnConsignar = new System.Windows.Forms.Button();
            this.txtMontoCon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuentaCon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsignar);
            this.groupBox1.Controls.Add(this.txtMontoCon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCuentaCon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consignación";
            // 
            // btnConsignar
            // 
            this.btnConsignar.Location = new System.Drawing.Point(32, 132);
            this.btnConsignar.Name = "btnConsignar";
            this.btnConsignar.Size = new System.Drawing.Size(75, 23);
            this.btnConsignar.TabIndex = 4;
            this.btnConsignar.Text = "Consignar";
            this.btnConsignar.UseVisualStyleBackColor = true;
            this.btnConsignar.Click += new System.EventHandler(this.btnConsignar_Click);
            // 
            // txtMontoCon
            // 
            this.txtMontoCon.Location = new System.Drawing.Point(32, 94);
            this.txtMontoCon.Name = "txtMontoCon";
            this.txtMontoCon.Size = new System.Drawing.Size(100, 20);
            this.txtMontoCon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto a consignar";
            // 
            // txtCuentaCon
            // 
            this.txtCuentaCon.Location = new System.Drawing.Point(29, 41);
            this.txtCuentaCon.Name = "txtCuentaCon";
            this.txtCuentaCon.Size = new System.Drawing.Size(100, 20);
            this.txtCuentaCon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de cuenta";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 198);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Banco ABC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsignar;
        private System.Windows.Forms.TextBox txtMontoCon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCuentaCon;
        private System.Windows.Forms.Label label1;
    }
}