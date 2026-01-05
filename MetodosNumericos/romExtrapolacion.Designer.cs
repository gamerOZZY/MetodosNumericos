namespace MetodosNumericos
{
    partial class romExtrapolacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(romExtrapolacion));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNiveles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRomberg = new System.Windows.Forms.DataGridView();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picGrafica = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRomberg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(460, 373);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(56, 19);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Reiniciar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(97, 186);
            this.txtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(76, 20);
            this.txtB.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(95, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "limite superior";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(97, 233);
            this.txtA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(76, 20);
            this.txtA.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(95, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "limite inferior";
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(97, 140);
            this.txtFuncion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(76, 20);
            this.txtFuncion.TabIndex = 17;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(206, 373);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(56, 19);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(95, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Funcion";
            // 
            // cboNiveles
            // 
            this.cboNiveles.FormattingEnabled = true;
            this.cboNiveles.Location = new System.Drawing.Point(97, 281);
            this.cboNiveles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboNiveles.Name = "cboNiveles";
            this.cboNiveles.Size = new System.Drawing.Size(92, 21);
            this.cboNiveles.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(97, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "niveles";
            // 
            // dgvRomberg
            // 
            this.dgvRomberg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRomberg.Location = new System.Drawing.Point(206, 125);
            this.dgvRomberg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRomberg.Name = "dgvRomberg";
            this.dgvRomberg.RowHeadersWidth = 51;
            this.dgvRomberg.RowTemplate.Height = 24;
            this.dgvRomberg.Size = new System.Drawing.Size(464, 219);
            this.dgvRomberg.TabIndex = 27;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(727, 236);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(85, 13);
            this.lblResultado.TabIndex = 28;
            this.lblResultado.Text = "_____________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(727, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Resultado";
            // 
            // picGrafica
            // 
            this.picGrafica.Location = new System.Drawing.Point(827, 125);
            this.picGrafica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picGrafica.Name = "picGrafica";
            this.picGrafica.Size = new System.Drawing.Size(407, 239);
            this.picGrafica.TabIndex = 30;
            this.picGrafica.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 667);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 31;
            this.button1.Text = "salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(577, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 42);
            this.label6.TabIndex = 32;
            this.label6.Text = "Extrapolación";
            // 
            // romExtrapolacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picGrafica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.dgvRomberg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboNiveles);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "romExtrapolacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "romExtrapolacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvRomberg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNiveles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvRomberg;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picGrafica;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}