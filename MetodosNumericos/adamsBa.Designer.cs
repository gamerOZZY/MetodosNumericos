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
            this.cboPasos = new System.Windows.Forms.ComboBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaAdams)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEcuacion
            // 
            this.txtEcuacion.Location = new System.Drawing.Point(12, 28);
            this.txtEcuacion.Name = "txtEcuacion";
            this.txtEcuacion.Size = new System.Drawing.Size(100, 22);
            this.txtEcuacion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "f(t,y)";
            // 
            // cboPasos
            // 
            this.cboPasos.FormattingEnabled = true;
            this.cboPasos.Location = new System.Drawing.Point(672, 26);
            this.cboPasos.Name = "cboPasos";
            this.cboPasos.Size = new System.Drawing.Size(121, 24);
            this.cboPasos.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(920, 26);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Reiniciar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvTablaAdams
            // 
            this.dgvTablaAdams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaAdams.Location = new System.Drawing.Point(15, 69);
            this.dgvTablaAdams.Name = "dgvTablaAdams";
            this.dgvTablaAdams.RowHeadersWidth = 51;
            this.dgvTablaAdams.RowTemplate.Height = 24;
            this.dgvTablaAdams.Size = new System.Drawing.Size(980, 444);
            this.dgvTablaAdams.TabIndex = 4;
            // 
            // txtT0
            // 
            this.txtT0.Location = new System.Drawing.Point(141, 28);
            this.txtT0.Name = "txtT0";
            this.txtT0.Size = new System.Drawing.Size(100, 22);
            this.txtT0.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "t0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "w0";
            // 
            // txtW0
            // 
            this.txtW0.Location = new System.Drawing.Point(273, 28);
            this.txtW0.Name = "txtW0";
            this.txtW0.Size = new System.Drawing.Size(100, 22);
            this.txtW0.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "h";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(407, 28);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 22);
            this.txtH.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "t Final";
            // 
            // txtTFinal
            // 
            this.txtTFinal.Location = new System.Drawing.Point(543, 28);
            this.txtTFinal.Name = "txtTFinal";
            this.txtTFinal.Size = new System.Drawing.Size(100, 22);
            this.txtTFinal.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(669, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "t Final";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(823, 26);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adamsBa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 600);
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
            this.Controls.Add(this.cboPasos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEcuacion);
            this.Name = "adamsBa";
            this.Text = "adamsBa";
            this.Load += new System.EventHandler(this.adamsBa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaAdams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEcuacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPasos;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button button1;
    }
}