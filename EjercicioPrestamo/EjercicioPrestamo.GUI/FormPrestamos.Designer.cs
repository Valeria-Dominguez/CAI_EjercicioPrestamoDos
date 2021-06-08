
namespace EjercicioPrestamo.GUI
{
    partial class FormPrestamos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstTipoPrestamos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTNA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPLazo = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCuotaCapital = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCuotaInteres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCuotaTotal = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComisionTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAlta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCuotaTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCuotaInteres);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCuotaCapital);
            this.groupBox1.Controls.Add(this.btnSimular);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPLazo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTNA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLinea);
            this.groupBox1.Controls.Add(this.lstTipoPrestamos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 393);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPOS PRESTAMO";
            // 
            // lstTipoPrestamos
            // 
            this.lstTipoPrestamos.FormattingEnabled = true;
            this.lstTipoPrestamos.Location = new System.Drawing.Point(6, 19);
            this.lstTipoPrestamos.Name = "lstTipoPrestamos";
            this.lstTipoPrestamos.Size = new System.Drawing.Size(254, 355);
            this.lstTipoPrestamos.TabIndex = 1;
            this.lstTipoPrestamos.SelectedIndexChanged += new System.EventHandler(this.lstTipoPrestamos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Linea";
            // 
            // txtLinea
            // 
            this.txtLinea.Enabled = false;
            this.txtLinea.Location = new System.Drawing.Point(405, 19);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.ReadOnly = true;
            this.txtLinea.Size = new System.Drawing.Size(100, 20);
            this.txtLinea.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TNA";
            // 
            // txtTNA
            // 
            this.txtTNA.Enabled = false;
            this.txtTNA.Location = new System.Drawing.Point(405, 54);
            this.txtTNA.Name = "txtTNA";
            this.txtTNA.ReadOnly = true;
            this.txtTNA.Size = new System.Drawing.Size(100, 20);
            this.txtTNA.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(405, 91);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Plazo";
            // 
            // txtPLazo
            // 
            this.txtPLazo.Location = new System.Drawing.Point(405, 129);
            this.txtPLazo.Name = "txtPLazo";
            this.txtPLazo.Size = new System.Drawing.Size(100, 20);
            this.txtPLazo.TabIndex = 8;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(281, 171);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(224, 23);
            this.btnSimular.TabIndex = 9;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cuota (Capital)";
            // 
            // txtCuotaCapital
            // 
            this.txtCuotaCapital.Enabled = false;
            this.txtCuotaCapital.Location = new System.Drawing.Point(405, 223);
            this.txtCuotaCapital.Name = "txtCuotaCapital";
            this.txtCuotaCapital.ReadOnly = true;
            this.txtCuotaCapital.Size = new System.Drawing.Size(100, 20);
            this.txtCuotaCapital.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cuota (Interés)";
            // 
            // txtCuotaInteres
            // 
            this.txtCuotaInteres.Enabled = false;
            this.txtCuotaInteres.Location = new System.Drawing.Point(405, 259);
            this.txtCuotaInteres.Name = "txtCuotaInteres";
            this.txtCuotaInteres.ReadOnly = true;
            this.txtCuotaInteres.Size = new System.Drawing.Size(100, 20);
            this.txtCuotaInteres.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "CUOTA TOTAL";
            // 
            // txtCuotaTotal
            // 
            this.txtCuotaTotal.Enabled = false;
            this.txtCuotaTotal.Location = new System.Drawing.Point(405, 296);
            this.txtCuotaTotal.Name = "txtCuotaTotal";
            this.txtCuotaTotal.ReadOnly = true;
            this.txtCuotaTotal.Size = new System.Drawing.Size(100, 20);
            this.txtCuotaTotal.TabIndex = 15;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(281, 334);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(224, 40);
            this.btnAlta.TabIndex = 16;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lstPrestamos);
            this.groupBox2.Controls.Add(this.txtComisionTotal);
            this.groupBox2.Location = new System.Drawing.Point(540, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 393);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRESTAMOS DADOS DE ALTA";
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.Location = new System.Drawing.Point(20, 19);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(357, 316);
            this.lstPrestamos.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Comisión Total";
            // 
            // txtComisionTotal
            // 
            this.txtComisionTotal.Enabled = false;
            this.txtComisionTotal.Location = new System.Drawing.Point(167, 354);
            this.txtComisionTotal.Name = "txtComisionTotal";
            this.txtComisionTotal.ReadOnly = true;
            this.txtComisionTotal.Size = new System.Drawing.Size(163, 20);
            this.txtComisionTotal.TabIndex = 18;
            // 
            // FormPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrestamos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrestamos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCuotaTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCuotaInteres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCuotaCapital;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPLazo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTNA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.ListBox lstTipoPrestamos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.TextBox txtComisionTotal;
    }
}

