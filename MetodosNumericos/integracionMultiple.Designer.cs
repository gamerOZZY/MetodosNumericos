namespace MetodosNumericos
{
    partial class integracionMultiple
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtXb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cboMetodo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcion (x,y)";
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(34, 39);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(100, 22);
            this.txtFuncion.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(76, 323);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtXb
            // 
            this.txtXb.Location = new System.Drawing.Point(73, 137);
            this.txtXb.Name = "txtXb";
            this.txtXb.Size = new System.Drawing.Size(100, 22);
            this.txtXb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "limite superior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "para x:";
            // 
            // txtXa
            // 
            this.txtXa.Location = new System.Drawing.Point(73, 200);
            this.txtXa.Name = "txtXa";
            this.txtXa.Size = new System.Drawing.Size(100, 22);
            this.txtXa.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "limite inferior";
            // 
            // txtYc
            // 
            this.txtYc.Location = new System.Drawing.Point(201, 200);
            this.txtYc.Name = "txtYc";
            this.txtYc.Size = new System.Drawing.Size(100, 22);
            this.txtYc.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "limite inferior";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "para y:";
            // 
            // txtYd
            // 
            this.txtYd.Location = new System.Drawing.Point(201, 137);
            this.txtYd.Name = "txtYd";
            this.txtYd.Size = new System.Drawing.Size(100, 22);
            this.txtYd.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "limite superior";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(204, 323);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Reiniciar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Resultado";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(143, 417);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(119, 16);
            this.lblResultado.TabIndex = 15;
            this.lblResultado.Text = "________________";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboMetodo
            // 
            this.cboMetodo.FormattingEnabled = true;
            this.cboMetodo.Location = new System.Drawing.Point(116, 278);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.Size = new System.Drawing.Size(121, 24);
            this.cboMetodo.TabIndex = 17;
            this.cboMetodo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "metodo";
            // 
            // integracionMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1695, 857);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboMetodo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtYc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtXa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtXb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Name = "integracionMultiple";
            this.Text = "integracionMultiple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtXb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboMetodo;
        private System.Windows.Forms.Label label9;
    }
}