namespace MetodosNumericos
{
    partial class eulerEDO
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvTablaEuler = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXFinal = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaEuler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEcuacion
            // 
            this.txtEcuacion.Location = new System.Drawing.Point(9, 28);
            this.txtEcuacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEcuacion.Name = "txtEcuacion";
            this.txtEcuacion.Size = new System.Drawing.Size(76, 31);
            this.txtEcuacion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "f(t,y)";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(243, 116);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(87, 33);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvTablaEuler
            // 
            this.dgvTablaEuler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaEuler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaEuler.Location = new System.Drawing.Point(356, 51);
            this.dgvTablaEuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTablaEuler.Name = "dgvTablaEuler";
            this.dgvTablaEuler.RowHeadersWidth = 51;
            this.dgvTablaEuler.RowTemplate.Height = 24;
            this.dgvTablaEuler.Size = new System.Drawing.Size(654, 566);
            this.dgvTablaEuler.TabIndex = 3;
            this.dgvTablaEuler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaEuler_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "t0";
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(123, 80);
            this.txtX0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(76, 31);
            this.txtX0.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "y0";
            // 
            // txtY0
            // 
            this.txtY0.Location = new System.Drawing.Point(123, 146);
            this.txtY0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtY0.Name = "txtY0";
            this.txtY0.Size = new System.Drawing.Size(76, 31);
            this.txtY0.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "h";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(123, 221);
            this.txtH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(76, 31);
            this.txtH.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "t final";
            // 
            // txtXFinal
            // 
            this.txtXFinal.Location = new System.Drawing.Point(124, 289);
            this.txtXFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtXFinal.Name = "txtXFinal";
            this.txtXFinal.Size = new System.Drawing.Size(76, 31);
            this.txtXFinal.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(243, 177);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 34);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Reiniciar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1260, 346);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eulerEDO
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImage = global::MetodosNumericos.Properties.Resources.cuaderno;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtXFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtY0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.dgvTablaEuler);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEcuacion);
            this.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "eulerEDO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eulerEDO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.eulerEDO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaEuler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEcuacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvTablaEuler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtY0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXFinal;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
    }
}