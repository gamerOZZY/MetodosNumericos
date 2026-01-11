namespace MetodosNumericos
{
    partial class frmMuller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuller));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtp0_real = new System.Windows.Forms.TextBox();
            this.txtp0_imaginaria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtp1_imaginaria = new System.Windows.Forms.TextBox();
            this.txtp1_real = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtp2_imaginaria = new System.Windows.Forms.TextBox();
            this.txtp2_real = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumMaxIter = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtErrorMax = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btmCalcular = new System.Windows.Forms.Button();
            this.dgvMuller = new System.Windows.Forms.DataGridView();
            this.NumIter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuller)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Impact", 41.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Thistle;
            this.label2.Location = new System.Drawing.Point(525, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "Método de Muller";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Thistle;
            this.label3.Location = new System.Drawing.Point(63, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "p0 = ";
            // 
            // txtp0_real
            // 
            this.txtp0_real.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp0_real.Location = new System.Drawing.Point(146, 183);
            this.txtp0_real.Margin = new System.Windows.Forms.Padding(2);
            this.txtp0_real.Name = "txtp0_real";
            this.txtp0_real.Size = new System.Drawing.Size(76, 32);
            this.txtp0_real.TabIndex = 3;
            // 
            // txtp0_imaginaria
            // 
            this.txtp0_imaginaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp0_imaginaria.Location = new System.Drawing.Point(263, 183);
            this.txtp0_imaginaria.Margin = new System.Windows.Forms.Padding(2);
            this.txtp0_imaginaria.Name = "txtp0_imaginaria";
            this.txtp0_imaginaria.Size = new System.Drawing.Size(76, 32);
            this.txtp0_imaginaria.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Thistle;
            this.label4.Location = new System.Drawing.Point(168, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "real";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Thistle;
            this.label5.Location = new System.Drawing.Point(259, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Imaginario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Thistle;
            this.label6.Location = new System.Drawing.Point(690, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Imaginario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Thistle;
            this.label7.Location = new System.Drawing.Point(608, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "real";
            // 
            // txtp1_imaginaria
            // 
            this.txtp1_imaginaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp1_imaginaria.Location = new System.Drawing.Point(695, 183);
            this.txtp1_imaginaria.Margin = new System.Windows.Forms.Padding(2);
            this.txtp1_imaginaria.Name = "txtp1_imaginaria";
            this.txtp1_imaginaria.Size = new System.Drawing.Size(76, 32);
            this.txtp1_imaginaria.TabIndex = 9;
            // 
            // txtp1_real
            // 
            this.txtp1_real.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp1_real.Location = new System.Drawing.Point(589, 183);
            this.txtp1_real.Margin = new System.Windows.Forms.Padding(2);
            this.txtp1_real.Name = "txtp1_real";
            this.txtp1_real.Size = new System.Drawing.Size(76, 32);
            this.txtp1_real.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Thistle;
            this.label8.Location = new System.Drawing.Point(485, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "p1 = ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Thistle;
            this.label9.Location = new System.Drawing.Point(1094, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Imaginario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Thistle;
            this.label10.Location = new System.Drawing.Point(1009, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "real";
            // 
            // txtp2_imaginaria
            // 
            this.txtp2_imaginaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp2_imaginaria.Location = new System.Drawing.Point(1098, 184);
            this.txtp2_imaginaria.Margin = new System.Windows.Forms.Padding(2);
            this.txtp2_imaginaria.Name = "txtp2_imaginaria";
            this.txtp2_imaginaria.Size = new System.Drawing.Size(76, 32);
            this.txtp2_imaginaria.TabIndex = 14;
            // 
            // txtp2_real
            // 
            this.txtp2_real.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp2_real.Location = new System.Drawing.Point(985, 183);
            this.txtp2_real.Margin = new System.Windows.Forms.Padding(2);
            this.txtp2_real.Name = "txtp2_real";
            this.txtp2_real.Size = new System.Drawing.Size(76, 32);
            this.txtp2_real.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Thistle;
            this.label11.Location = new System.Drawing.Point(883, 185);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 29);
            this.label11.TabIndex = 12;
            this.label11.Text = "p2 = ";
            // 
            // txtNumMaxIter
            // 
            this.txtNumMaxIter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumMaxIter.Location = new System.Drawing.Point(1077, 94);
            this.txtNumMaxIter.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumMaxIter.Name = "txtNumMaxIter";
            this.txtNumMaxIter.Size = new System.Drawing.Size(54, 32);
            this.txtNumMaxIter.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Thistle;
            this.label12.Location = new System.Drawing.Point(846, 94);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 29);
            this.label12.TabIndex = 19;
            this.label12.Text = "Num. Max. Iter =";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtErrorMax
            // 
            this.txtErrorMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorMax.Location = new System.Drawing.Point(599, 91);
            this.txtErrorMax.Margin = new System.Windows.Forms.Padding(2);
            this.txtErrorMax.Name = "txtErrorMax";
            this.txtErrorMax.Size = new System.Drawing.Size(102, 32);
            this.txtErrorMax.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Thistle;
            this.label13.Location = new System.Drawing.Point(424, 91);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 29);
            this.label13.TabIndex = 17;
            this.label13.Text = "Error Max =";
            // 
            // btmCalcular
            // 
            this.btmCalcular.BackColor = System.Drawing.Color.Black;
            this.btmCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmCalcular.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCalcular.ForeColor = System.Drawing.Color.Thistle;
            this.btmCalcular.Location = new System.Drawing.Point(1244, 140);
            this.btmCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btmCalcular.Name = "btmCalcular";
            this.btmCalcular.Size = new System.Drawing.Size(175, 76);
            this.btmCalcular.TabIndex = 21;
            this.btmCalcular.Text = "Calcular Raiz";
            this.btmCalcular.UseVisualStyleBackColor = false;
            this.btmCalcular.Click += new System.EventHandler(this.btmCalcular_Click);
            // 
            // dgvMuller
            // 
            this.dgvMuller.AllowUserToAddRows = false;
            this.dgvMuller.AllowUserToDeleteRows = false;
            this.dgvMuller.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgvMuller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumIter,
            this.p0,
            this.p1,
            this.p2,
            this.p3,
            this.ErrorAct});
            this.dgvMuller.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvMuller.Location = new System.Drawing.Point(104, 345);
            this.dgvMuller.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMuller.Name = "dgvMuller";
            this.dgvMuller.ReadOnly = true;
            this.dgvMuller.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvMuller.RowHeadersWidth = 51;
            this.dgvMuller.RowTemplate.Height = 24;
            this.dgvMuller.Size = new System.Drawing.Size(1327, 326);
            this.dgvMuller.TabIndex = 22;
            // 
            // NumIter
            // 
            this.NumIter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumIter.HeaderText = "i";
            this.NumIter.MinimumWidth = 6;
            this.NumIter.Name = "NumIter";
            this.NumIter.ReadOnly = true;
            // 
            // p0
            // 
            this.p0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p0.HeaderText = "p0";
            this.p0.MinimumWidth = 6;
            this.p0.Name = "p0";
            this.p0.ReadOnly = true;
            // 
            // p1
            // 
            this.p1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p1.HeaderText = "p1";
            this.p1.MinimumWidth = 6;
            this.p1.Name = "p1";
            this.p1.ReadOnly = true;
            // 
            // p2
            // 
            this.p2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p2.HeaderText = "p2";
            this.p2.MinimumWidth = 6;
            this.p2.Name = "p2";
            this.p2.ReadOnly = true;
            // 
            // p3
            // 
            this.p3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p3.HeaderText = "p3";
            this.p3.MinimumWidth = 6;
            this.p3.Name = "p3";
            this.p3.ReadOnly = true;
            // 
            // ErrorAct
            // 
            this.ErrorAct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ErrorAct.HeaderText = "Error";
            this.ErrorAct.MinimumWidth = 6;
            this.ErrorAct.Name = "ErrorAct";
            this.ErrorAct.ReadOnly = true;
            // 
            // txtFuncion
            // 
            this.txtFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncion.Location = new System.Drawing.Point(164, 91);
            this.txtFuncion.Margin = new System.Windows.Forms.Padding(2);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(189, 32);
            this.txtFuncion.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Thistle;
            this.label14.Location = new System.Drawing.Point(62, 94);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 29);
            this.label14.TabIndex = 23;
            this.label14.Text = "F(x) =";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Thistle;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(729, 723);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 40);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMuller
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImage = global::MetodosNumericos.Properties.Resources.cuaderno;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvMuller);
            this.Controls.Add(this.btmCalcular);
            this.Controls.Add(this.txtNumMaxIter);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtErrorMax);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtp2_imaginaria);
            this.Controls.Add(this.txtp2_real);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtp1_imaginaria);
            this.Controls.Add(this.txtp1_real);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtp0_imaginaria);
            this.Controls.Add(this.txtp0_real);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMuller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metodo de Muller";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtp0_real;
        private System.Windows.Forms.TextBox txtp0_imaginaria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtp1_imaginaria;
        private System.Windows.Forms.TextBox txtp1_real;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtp2_imaginaria;
        private System.Windows.Forms.TextBox txtp2_real;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumMaxIter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtErrorMax;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btmCalcular;
        private System.Windows.Forms.DataGridView dgvMuller;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumIter;
        private System.Windows.Forms.DataGridViewTextBoxColumn p0;
        private System.Windows.Forms.DataGridViewTextBoxColumn p1;
        private System.Windows.Forms.DataGridViewTextBoxColumn p2;
        private System.Windows.Forms.DataGridViewTextBoxColumn p3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorAct;
        private System.Windows.Forms.Button btnSalir;
    }
}