namespace MetodosNumericos
{
    partial class lol
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
            this.numEcuaciones = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtT0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.lblU1 = new System.Windows.Forms.Label();
            this.txtEc1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.lblU2 = new System.Windows.Forms.Label();
            this.txtEc2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVal3 = new System.Windows.Forms.TextBox();
            this.lblU3 = new System.Windows.Forms.Label();
            this.txtEc3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVal4 = new System.Windows.Forms.TextBox();
            this.lblU4 = new System.Windows.Forms.Label();
            this.txtEc4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numEcuaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // numEcuaciones
            // 
            this.numEcuaciones.Location = new System.Drawing.Point(16, 32);
            this.numEcuaciones.Name = "numEcuaciones";
            this.numEcuaciones.Size = new System.Drawing.Size(120, 22);
            this.numEcuaciones.TabIndex = 0;
            this.numEcuaciones.ValueChanged += new System.EventHandler(this.numEcuaciones_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de ecuaciones";
            // 
            // txtT0
            // 
            this.txtT0.Location = new System.Drawing.Point(16, 85);
            this.txtT0.Name = "txtT0";
            this.txtT0.Size = new System.Drawing.Size(100, 22);
            this.txtT0.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "t0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "t final";
            // 
            // txtTf
            // 
            this.txtTf.Location = new System.Drawing.Point(16, 138);
            this.txtTf.Name = "txtTf";
            this.txtTf.Size = new System.Drawing.Size(100, 22);
            this.txtTf.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "h";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(16, 195);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 22);
            this.txtH.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 248);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(16, 296);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Reiniciar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(200, 138);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.RowTemplate.Height = 24;
            this.dgvTabla.Size = new System.Drawing.Size(556, 181);
            this.dgvTabla.TabIndex = 10;
            // 
            // lblU1
            // 
            this.lblU1.AutoSize = true;
            this.lblU1.Location = new System.Drawing.Point(202, 13);
            this.lblU1.Name = "lblU1";
            this.lblU1.Size = new System.Drawing.Size(73, 16);
            this.lblU1.TabIndex = 12;
            this.lblU1.Text = "Ecuacion 1";
            // 
            // txtEc1
            // 
            this.txtEc1.Location = new System.Drawing.Point(205, 32);
            this.txtEc1.Name = "txtEc1";
            this.txtEc1.Size = new System.Drawing.Size(100, 22);
            this.txtEc1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Valor inicial";
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(205, 89);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(100, 22);
            this.txtVal1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Valor inicial";
            // 
            // txtVal2
            // 
            this.txtVal2.Location = new System.Drawing.Point(348, 89);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(100, 22);
            this.txtVal2.TabIndex = 17;
            // 
            // lblU2
            // 
            this.lblU2.AutoSize = true;
            this.lblU2.Location = new System.Drawing.Point(345, 13);
            this.lblU2.Name = "lblU2";
            this.lblU2.Size = new System.Drawing.Size(73, 16);
            this.lblU2.TabIndex = 16;
            this.lblU2.Text = "Ecuacion 2";
            // 
            // txtEc2
            // 
            this.txtEc2.Location = new System.Drawing.Point(348, 32);
            this.txtEc2.Name = "txtEc2";
            this.txtEc2.Size = new System.Drawing.Size(100, 22);
            this.txtEc2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(498, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Valor inicial";
            // 
            // txtVal3
            // 
            this.txtVal3.Location = new System.Drawing.Point(501, 89);
            this.txtVal3.Name = "txtVal3";
            this.txtVal3.Size = new System.Drawing.Size(100, 22);
            this.txtVal3.TabIndex = 21;
            // 
            // lblU3
            // 
            this.lblU3.AutoSize = true;
            this.lblU3.Location = new System.Drawing.Point(498, 13);
            this.lblU3.Name = "lblU3";
            this.lblU3.Size = new System.Drawing.Size(73, 16);
            this.lblU3.TabIndex = 20;
            this.lblU3.Text = "Ecuacion 3";
            // 
            // txtEc3
            // 
            this.txtEc3.Location = new System.Drawing.Point(501, 32);
            this.txtEc3.Name = "txtEc3";
            this.txtEc3.Size = new System.Drawing.Size(100, 22);
            this.txtEc3.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(653, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Valor inicial";
            // 
            // txtVal4
            // 
            this.txtVal4.Location = new System.Drawing.Point(656, 89);
            this.txtVal4.Name = "txtVal4";
            this.txtVal4.Size = new System.Drawing.Size(100, 22);
            this.txtVal4.TabIndex = 25;
            // 
            // lblU4
            // 
            this.lblU4.AutoSize = true;
            this.lblU4.Location = new System.Drawing.Point(653, 13);
            this.lblU4.Name = "lblU4";
            this.lblU4.Size = new System.Drawing.Size(73, 16);
            this.lblU4.TabIndex = 24;
            this.lblU4.Text = "Ecuacion 4";
            // 
            // txtEc4
            // 
            this.txtEc4.Location = new System.Drawing.Point(656, 32);
            this.txtEc4.Name = "txtEc4";
            this.txtEc4.Size = new System.Drawing.Size(100, 22);
            this.txtEc4.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1050, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 777);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVal4);
            this.Controls.Add(this.lblU4);
            this.Controls.Add(this.txtEc4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVal3);
            this.Controls.Add(this.lblU3);
            this.Controls.Add(this.txtEc3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVal2);
            this.Controls.Add(this.lblU2);
            this.Controls.Add(this.txtEc2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVal1);
            this.Controls.Add(this.lblU1);
            this.Controls.Add(this.txtEc1);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtT0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numEcuaciones);
            this.Name = "lol";
            this.Text = "sistemasdeEDOSrk4";
            ((System.ComponentModel.ISupportInitialize)(this.numEcuaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numEcuaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtT0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Label lblU1;
        private System.Windows.Forms.TextBox txtEc1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.Label lblU2;
        private System.Windows.Forms.TextBox txtEc2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVal3;
        private System.Windows.Forms.Label lblU3;
        private System.Windows.Forms.TextBox txtEc3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVal4;
        private System.Windows.Forms.Label lblU4;
        private System.Windows.Forms.TextBox txtEc4;
        private System.Windows.Forms.Button button1;
    }
}