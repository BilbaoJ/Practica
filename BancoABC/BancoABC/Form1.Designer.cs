namespace BancoABC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumCuenta = new System.Windows.Forms.TextBox();
            this.txtNomTitular = new System.Windows.Forms.TextBox();
            this.txtIdTitular = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consignarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de la cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificación del titular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo";
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.Location = new System.Drawing.Point(27, 47);
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(112, 20);
            this.txtNumCuenta.TabIndex = 4;
            // 
            // txtNomTitular
            // 
            this.txtNomTitular.Location = new System.Drawing.Point(27, 98);
            this.txtNomTitular.Name = "txtNomTitular";
            this.txtNomTitular.Size = new System.Drawing.Size(155, 20);
            this.txtNomTitular.TabIndex = 5;
            // 
            // txtIdTitular
            // 
            this.txtIdTitular.Location = new System.Drawing.Point(27, 147);
            this.txtIdTitular.Name = "txtIdTitular";
            this.txtIdTitular.Size = new System.Drawing.Size(112, 20);
            this.txtIdTitular.TabIndex = 6;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(27, 200);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(112, 20);
            this.txtSaldo.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(27, 238);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(107, 238);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(75, 23);
            this.btnEstadisticas.TabIndex = 9;
            this.btnEstadisticas.Text = "Estadísticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(313, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consignarToolStripMenuItem,
            this.retirarToolStripMenuItem,
            this.transferirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.inicioToolStripMenuItem.Text = "Menú";
            // 
            // consignarToolStripMenuItem
            // 
            this.consignarToolStripMenuItem.Name = "consignarToolStripMenuItem";
            this.consignarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.consignarToolStripMenuItem.Text = "Consignar";
            this.consignarToolStripMenuItem.Click += new System.EventHandler(this.consignarToolStripMenuItem_Click);
            // 
            // retirarToolStripMenuItem
            // 
            this.retirarToolStripMenuItem.Name = "retirarToolStripMenuItem";
            this.retirarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.retirarToolStripMenuItem.Text = "Retirar";
            this.retirarToolStripMenuItem.Click += new System.EventHandler(this.retirarToolStripMenuItem_Click);
            // 
            // transferirToolStripMenuItem
            // 
            this.transferirToolStripMenuItem.Name = "transferirToolStripMenuItem";
            this.transferirToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.transferirToolStripMenuItem.Text = "Transferir";
            this.transferirToolStripMenuItem.Click += new System.EventHandler(this.transferirToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumCuenta);
            this.groupBox1.Controls.Add(this.btnEstadisticas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIdTitular);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSaldo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtNomTitular);
            this.groupBox1.Location = new System.Drawing.Point(29, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 282);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear cuenta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 331);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Banco ABC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumCuenta;
        private System.Windows.Forms.TextBox txtNomTitular;
        private System.Windows.Forms.TextBox txtIdTitular;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consignarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

