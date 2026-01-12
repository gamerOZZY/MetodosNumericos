namespace MetodosNumericos
{
    partial class adamsBa
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
            this.txtEcuacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvTablaAdams = new System.Windows.Forms.DataGridView();
            this.txtT0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtW0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTFinal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboOrden = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaAdams)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEcuacion
            // 
            this.txtEcuacion.Location = new System.Drawing.Point(4, 84);
            this.txtEcuacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEcuacion.Name = "txtEcuacion";
            this.txtEcuacion.Size = new System.Drawing.Size(76, 27);
            this.txtEcuacion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "f(t,y)";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(775, 84);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(77, 28);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Reiniciar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvTablaAdams
            // 
            this.dgvTablaAdams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaAdams.Location = new System.Drawing.Point(11, 187);
            this.dgvTablaAdams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTablaAdams.Name = "dgvTablaAdams";
            this.dgvTablaAdams.RowHeadersWidth = 51;
            this.dgvTablaAdams.RowTemplate.Height = 24;
            this.dgvTablaAdams.Size = new System.Drawing.Size(854, 361);
            this.dgvTablaAdams.TabIndex = 4;
            // 
            // txtT0
            // 
            this.txtT0.Location = new System.Drawing.Point(101, 85);
            this.txtT0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtT0.Name = "txtT0";
            this.txtT0.Size = new System.Drawing.Size(76, 27);
            this.txtT0.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "t0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "w0";
            // 
            // txtW0
            // 
            this.txtW0.Location = new System.Drawing.Point(200, 85);
            this.txtW0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtW0.Name = "txtW0";
            this.txtW0.Size = new System.Drawing.Size(76, 27);
            this.txtW0.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "h";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(300, 85);
            this.txtH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(76, 27);
            this.txtH.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "t Final";
            // 
            // txtTFinal
            // 
            this.txtTFinal.Location = new System.Drawing.Point(402, 85);
            this.txtTFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTFinal.Name = "txtTFinal";
            this.txtTFinal.Size = new System.Drawing.Size(76, 27);
            this.txtTFinal.TabIndex = 11;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(660, 84);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(79, 28);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 708);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Orden";
            // 
            // cboOrden
            // 
            this.cboOrden.FormattingEnabled = true;
            this.cboOrden.Location = new System.Drawing.Point(497, 84);
            this.cboOrden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboOrden.Name = "cboOrden";
            this.cboOrden.Size = new System.Drawing.Size(92, 28);
            this.cboOrden.TabIndex = 2;
            // 
            // adamsBa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImage = global::MetodosNumericos.Properties.Resources.cuaderno;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtW0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtT0);
            this.Controls.Add(this.dgvTablaAdams);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cboOrden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEcuacion);
            this.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "adamsBa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adamsBa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.adamsBa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaAdams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEcuacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvTablaAdams;
        private System.Windows.Forms.TextBox txtT0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtW0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboOrden;
    }
}