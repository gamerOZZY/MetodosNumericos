namespace MetodosNumericos
{
    partial class RKF
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtTFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtW0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtT0 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEcuacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFactor = new System.Windows.Forms.TextBox();
            this.dgvTablaRKF = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaRKF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(962, 27);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(81, 35);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Reiniciar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "x final";
            // 
            // txtTFinal
            // 
            this.txtTFinal.Location = new System.Drawing.Point(394, 35);
            this.txtTFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTFinal.Name = "txtTFinal";
            this.txtTFinal.Size = new System.Drawing.Size(76, 27);
            this.txtTFinal.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "h";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(304, 35);
            this.txtH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(76, 27);
            this.txtH.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "y0";
            // 
            // txtW0
            // 
            this.txtW0.Location = new System.Drawing.Point(211, 35);
            this.txtW0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtW0.Name = "txtW0";
            this.txtW0.Size = new System.Drawing.Size(76, 27);
            this.txtW0.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "t0";
            // 
            // txtT0
            // 
            this.txtT0.Location = new System.Drawing.Point(120, 35);
            this.txtT0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtT0.Name = "txtT0";
            this.txtT0.Size = new System.Drawing.Size(76, 27);
            this.txtT0.TabIndex = 16;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(816, 27);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(85, 35);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "f(t,y)";
            // 
            // txtEcuacion
            // 
            this.txtEcuacion.Location = new System.Drawing.Point(11, 35);
            this.txtEcuacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEcuacion.Name = "txtEcuacion";
            this.txtEcuacion.Size = new System.Drawing.Size(76, 27);
            this.txtEcuacion.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Error maximo";
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Location = new System.Drawing.Point(494, 35);
            this.txtTolerancia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(76, 27);
            this.txtTolerancia.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Factor de ajuste (q)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtFactor
            // 
            this.txtFactor.Location = new System.Drawing.Point(621, 35);
            this.txtFactor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFactor.Name = "txtFactor";
            this.txtFactor.Size = new System.Drawing.Size(92, 27);
            this.txtFactor.TabIndex = 27;
            // 
            // dgvTablaRKF
            // 
            this.dgvTablaRKF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaRKF.Location = new System.Drawing.Point(3, 107);
            this.dgvTablaRKF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTablaRKF.Name = "dgvTablaRKF";
            this.dgvTablaRKF.RowHeadersWidth = 51;
            this.dgvTablaRKF.RowTemplate.Height = 24;
            this.dgvTablaRKF.Size = new System.Drawing.Size(1426, 394);
            this.dgvTablaRKF.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 673);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 37);
            this.button1.TabIndex = 30;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RKF
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImage = global::MetodosNumericos.Properties.Resources.cuaderno;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTablaRKF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFactor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTolerancia);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtW0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtT0);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEcuacion);
            this.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RKF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RKF";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RKF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaRKF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtW0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtT0;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEcuacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTolerancia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFactor;
        private System.Windows.Forms.DataGridView dgvTablaRKF;
        private System.Windows.Forms.Button button1;
    }
}