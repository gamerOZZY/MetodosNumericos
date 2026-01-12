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
            this.numEcuaciones.Location = new System.Drawing.Point(129, 157);
            this.numEcuaciones.Margin = new System.Windows.Forms.Padding(2);
            this.numEcuaciones.Name = "numEcuaciones";
            this.numEcuaciones.Size = new System.Drawing.Size(90, 27);
            this.numEcuaciones.TabIndex = 0;
            this.numEcuaciones.ValueChanged += new System.EventHandler(this.numEcuaciones_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de ecuaciones";
            // 
            // txtT0
            // 
            this.txtT0.Location = new System.Drawing.Point(129, 214);
            this.txtT0.Margin = new System.Windows.Forms.Padding(2);
            this.txtT0.Name = "txtT0";
            this.txtT0.Size = new System.Drawing.Size(76, 27);
            this.txtT0.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "t0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "t final";
            // 
            // txtTf
            // 
            this.txtTf.Location = new System.Drawing.Point(129, 264);
            this.txtTf.Margin = new System.Windows.Forms.Padding(2);
            this.txtTf.Name = "txtTf";
            this.txtTf.Size = new System.Drawing.Size(76, 27);
            this.txtTf.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "h";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(129, 327);
            this.txtH.Margin = new System.Windows.Forms.Padding(2);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(76, 27);
            this.txtH.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(405, 342);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(76, 28);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(405, 396);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(76, 28);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Reiniciar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(699, 305);
            this.dgvTabla.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.RowTemplate.Height = 24;
            this.dgvTabla.Size = new System.Drawing.Size(417, 386);
            this.dgvTabla.TabIndex = 10;
            this.dgvTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_CellContentClick);
            // 
            // lblU1
            // 
            this.lblU1.AutoSize = true;
            this.lblU1.Location = new System.Drawing.Point(701, 132);
            this.lblU1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblU1.Name = "lblU1";
            this.lblU1.Size = new System.Drawing.Size(77, 20);
            this.lblU1.TabIndex = 12;
            this.lblU1.Text = "Ecuacion 1";
            // 
            // txtEc1
            // 
            this.txtEc1.Location = new System.Drawing.Point(702, 154);
            this.txtEc1.Margin = new System.Windows.Forms.Padding(2);
            this.txtEc1.Name = "txtEc1";
            this.txtEc1.Size = new System.Drawing.Size(76, 27);
            this.txtEc1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(698, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Valor inicial";
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(702, 217);
            this.txtVal1.Margin = new System.Windows.Forms.Padding(2);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(76, 27);
            this.txtVal1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(805, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Valor inicial";
            // 
            // txtVal2
            // 
            this.txtVal2.Location = new System.Drawing.Point(809, 217);
            this.txtVal2.Margin = new System.Windows.Forms.Padding(2);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(76, 27);
            this.txtVal2.TabIndex = 17;
            // 
            // lblU2
            // 
            this.lblU2.AutoSize = true;
            this.lblU2.Location = new System.Drawing.Point(806, 132);
            this.lblU2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblU2.Name = "lblU2";
            this.lblU2.Size = new System.Drawing.Size(79, 20);
            this.lblU2.TabIndex = 16;
            this.lblU2.Text = "Ecuacion 2";
            // 
            // txtEc2
            // 
            this.txtEc2.Location = new System.Drawing.Point(808, 156);
            this.txtEc2.Margin = new System.Windows.Forms.Padding(2);
            this.txtEc2.Name = "txtEc2";
            this.txtEc2.Size = new System.Drawing.Size(76, 27);
            this.txtEc2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(920, 195);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Valor inicial";
            // 
            // txtVal3
            // 
            this.txtVal3.Location = new System.Drawing.Point(924, 217);
            this.txtVal3.Margin = new System.Windows.Forms.Padding(2);
            this.txtVal3.Name = "txtVal3";
            this.txtVal3.Size = new System.Drawing.Size(76, 27);
            this.txtVal3.TabIndex = 21;
            // 
            // lblU3
            // 
            this.lblU3.AutoSize = true;
            this.lblU3.Location = new System.Drawing.Point(921, 132);
            this.lblU3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblU3.Name = "lblU3";
            this.lblU3.Size = new System.Drawing.Size(79, 20);
            this.lblU3.TabIndex = 20;
            this.lblU3.Text = "Ecuacion 3";
            // 
            // txtEc3
            // 
            this.txtEc3.Location = new System.Drawing.Point(923, 156);
            this.txtEc3.Margin = new System.Windows.Forms.Padding(2);
            this.txtEc3.Name = "txtEc3";
            this.txtEc3.Size = new System.Drawing.Size(76, 27);
            this.txtEc3.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1036, 195);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Valor inicial";
            // 
            // txtVal4
            // 
            this.txtVal4.Location = new System.Drawing.Point(1040, 217);
            this.txtVal4.Margin = new System.Windows.Forms.Padding(2);
            this.txtVal4.Name = "txtVal4";
            this.txtVal4.Size = new System.Drawing.Size(76, 27);
            this.txtVal4.TabIndex = 25;
            // 
            // lblU4
            // 
            this.lblU4.AutoSize = true;
            this.lblU4.Location = new System.Drawing.Point(1037, 132);
            this.lblU4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblU4.Name = "lblU4";
            this.lblU4.Size = new System.Drawing.Size(79, 20);
            this.lblU4.TabIndex = 24;
            this.lblU4.Text = "Ecuacion 4";
            // 
            // txtEc4
            // 
            this.txtEc4.Location = new System.Drawing.Point(1039, 156);
            this.txtEc4.Margin = new System.Windows.Forms.Padding(2);
            this.txtEc4.Name = "txtEc4";
            this.txtEc4.Size = new System.Drawing.Size(76, 27);
            this.txtEc4.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 662);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 29);
            this.button1.TabIndex = 27;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lol
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImage = global::MetodosNumericos.Properties.Resources.cuaderno;
            this.ClientSize = new System.Drawing.Size(1370, 749);
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
            this.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "lol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sistemasdeEDOSrk4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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