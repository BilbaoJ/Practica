namespace BancoABC
{
    partial class Form5
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
            this.btnTotalConsig = new System.Windows.Forms.Button();
            this.btnTotalRetiros = new System.Windows.Forms.Button();
            this.btnTotalOperaciones = new System.Windows.Forms.Button();
            this.btnMayorConsig = new System.Windows.Forms.Button();
            this.txtTotalConsig = new System.Windows.Forms.TextBox();
            this.txtTotalRetiros = new System.Windows.Forms.TextBox();
            this.txtTotalOperaciones = new System.Windows.Forms.TextBox();
            this.txtMayorConsig = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMayorConsig);
            this.groupBox1.Controls.Add(this.txtTotalOperaciones);
            this.groupBox1.Controls.Add(this.txtTotalRetiros);
            this.groupBox1.Controls.Add(this.txtTotalConsig);
            this.groupBox1.Controls.Add(this.btnMayorConsig);
            this.groupBox1.Controls.Add(this.btnTotalOperaciones);
            this.groupBox1.Controls.Add(this.btnTotalRetiros);
            this.groupBox1.Controls.Add(this.btnTotalConsig);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadísticas";
            // 
            // btnTotalConsig
            // 
            this.btnTotalConsig.Location = new System.Drawing.Point(18, 32);
            this.btnTotalConsig.Name = "btnTotalConsig";
            this.btnTotalConsig.Size = new System.Drawing.Size(101, 36);
            this.btnTotalConsig.TabIndex = 0;
            this.btnTotalConsig.Text = "Valor total de consignaciones";
            this.btnTotalConsig.UseVisualStyleBackColor = true;
            this.btnTotalConsig.Click += new System.EventHandler(this.btnTotalConsig_Click);
            // 
            // btnTotalRetiros
            // 
            this.btnTotalRetiros.Location = new System.Drawing.Point(18, 74);
            this.btnTotalRetiros.Name = "btnTotalRetiros";
            this.btnTotalRetiros.Size = new System.Drawing.Size(102, 38);
            this.btnTotalRetiros.TabIndex = 1;
            this.btnTotalRetiros.Text = "Valor total de retiros";
            this.btnTotalRetiros.UseVisualStyleBackColor = true;
            this.btnTotalRetiros.Click += new System.EventHandler(this.btnTotalRetiros_Click);
            // 
            // btnTotalOperaciones
            // 
            this.btnTotalOperaciones.Location = new System.Drawing.Point(18, 118);
            this.btnTotalOperaciones.Name = "btnTotalOperaciones";
            this.btnTotalOperaciones.Size = new System.Drawing.Size(102, 51);
            this.btnTotalOperaciones.TabIndex = 2;
            this.btnTotalOperaciones.Text = "Total de operaciones realizadas";
            this.btnTotalOperaciones.UseVisualStyleBackColor = true;
            this.btnTotalOperaciones.Click += new System.EventHandler(this.btnTotalOperaciones_Click);
            // 
            // btnMayorConsig
            // 
            this.btnMayorConsig.Location = new System.Drawing.Point(17, 175);
            this.btnMayorConsig.Name = "btnMayorConsig";
            this.btnMayorConsig.Size = new System.Drawing.Size(102, 50);
            this.btnMayorConsig.TabIndex = 3;
            this.btnMayorConsig.Text = "Cliente que realizó la mayor consignación";
            this.btnMayorConsig.UseVisualStyleBackColor = true;
            this.btnMayorConsig.Click += new System.EventHandler(this.btnMayorConsig_Click);
            // 
            // txtTotalConsig
            // 
            this.txtTotalConsig.Enabled = false;
            this.txtTotalConsig.Location = new System.Drawing.Point(125, 41);
            this.txtTotalConsig.Name = "txtTotalConsig";
            this.txtTotalConsig.Size = new System.Drawing.Size(115, 20);
            this.txtTotalConsig.TabIndex = 4;
            // 
            // txtTotalRetiros
            // 
            this.txtTotalRetiros.Enabled = false;
            this.txtTotalRetiros.Location = new System.Drawing.Point(126, 84);
            this.txtTotalRetiros.Name = "txtTotalRetiros";
            this.txtTotalRetiros.Size = new System.Drawing.Size(114, 20);
            this.txtTotalRetiros.TabIndex = 5;
            // 
            // txtTotalOperaciones
            // 
            this.txtTotalOperaciones.Enabled = false;
            this.txtTotalOperaciones.Location = new System.Drawing.Point(126, 134);
            this.txtTotalOperaciones.Name = "txtTotalOperaciones";
            this.txtTotalOperaciones.Size = new System.Drawing.Size(115, 20);
            this.txtTotalOperaciones.TabIndex = 6;
            // 
            // txtMayorConsig
            // 
            this.txtMayorConsig.Enabled = false;
            this.txtMayorConsig.Location = new System.Drawing.Point(125, 191);
            this.txtMayorConsig.Name = "txtMayorConsig";
            this.txtMayorConsig.Size = new System.Drawing.Size(115, 20);
            this.txtMayorConsig.TabIndex = 7;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 257);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Banco ABC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMayorConsig;
        private System.Windows.Forms.TextBox txtTotalOperaciones;
        private System.Windows.Forms.TextBox txtTotalRetiros;
        private System.Windows.Forms.TextBox txtTotalConsig;
        private System.Windows.Forms.Button btnMayorConsig;
        private System.Windows.Forms.Button btnTotalOperaciones;
        private System.Windows.Forms.Button btnTotalRetiros;
        private System.Windows.Forms.Button btnTotalConsig;
    }
}