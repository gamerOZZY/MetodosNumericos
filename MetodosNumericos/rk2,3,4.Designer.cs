namespace MetodosNumericos
{
    partial class rk2_3_4
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtW0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtT0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEcuacion = new System.Windows.Forms.TextBox();
            this.cboMetodoRK = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTablaRK = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaRK)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(932, 36);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Reiniciar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(832, 36);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "t final";
            // 
            // txtTFinal
            // 
            this.txtTFinal.Location = new System.Drawing.Point(551, 36);
            this.txtTFinal.Name = "txtTFinal";
            this.txtTFinal.Size = new System.Drawing.Size(100, 22);
            this.txtTFinal.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "h";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(418, 36);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 22);
            this.txtH.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "w0";
            // 
            // txtW0
            // 
            this.txtW0.Location = new System.Drawing.Point(287, 36);
            this.txtW0.Name = "txtW0";
            this.txtW0.Size = new System.Drawing.Size(100, 22);
            this.txtW0.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "t0";
            // 
            // txtT0
            // 
            this.txtT0.Location = new System.Drawing.Point(152, 36);
            this.txtT0.Name = "txtT0";
            this.txtT0.Size = new System.Drawing.Size(100, 22);
            this.txtT0.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "f(t,y)";
            // 
            // txtEcuacion
            // 
            this.txtEcuacion.Location = new System.Drawing.Point(20, 36);
            this.txtEcuacion.Name = "txtEcuacion";
            this.txtEcuacion.Size = new System.Drawing.Size(100, 22);
            this.txtEcuacion.TabIndex = 12;
            // 
            // cboMetodoRK
            // 
            this.cboMetodoRK.FormattingEnabled = true;
            this.cboMetodoRK.Location = new System.Drawing.Point(681, 36);
            this.cboMetodoRK.Name = "cboMetodoRK";
            this.cboMetodoRK.Size = new System.Drawing.Size(121, 24);
            this.cboMetodoRK.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(678, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Metodo";
            // 
            // dgvTablaRK
            // 
            this.dgvTablaRK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaRK.Location = new System.Drawing.Point(20, 77);
            this.dgvTablaRK.Name = "dgvTablaRK";
            this.dgvTablaRK.RowHeadersWidth = 51;
            this.dgvTablaRK.RowTemplate.Height = 24;
            this.dgvTablaRK.Size = new System.Drawing.Size(987, 400);
            this.dgvTablaRK.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rk2_3_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 601);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTablaRK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboMetodoRK);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtW0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtT0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEcuacion);
            this.Name = "rk2_3_4";
            this.Text = "rk2_3_4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaRK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtW0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtT0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEcuacion;
        private System.Windows.Forms.ComboBox cboMetodoRK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTablaRK;
        private System.Windows.Forms.Button button1;
    }
}