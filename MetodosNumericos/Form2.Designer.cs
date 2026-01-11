using System;

namespace MetodosNumericos
{
    partial class frmBiseccion
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


        //  correcion de error: return this.txtValorA.TextChanged += new System.EventHandler(this.txtValorA_TextChanged); cambios en la 26, 39 y 106

        private void GetV()
        {
            this.txtValorA.TextChanged += new System.EventHandler(this.txtValorA_TextChanged);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// corrección de error raro ? este era el anterior private void InitializeComponent(void v)
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBiseccion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumMaxIter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtErrorMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btmCalcular = new System.Windows.Forms.Button();
            this.dgvBiseccion = new System.Windows.Forms.DataGridView();
            this.Num_Iter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Func_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Func_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Func_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorAprox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiseccion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Impact", 41.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(538, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Método de bisección";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(414, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "a =";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtValorA
            // 
            this.txtValorA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtValorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorA.Location = new System.Drawing.Point(469, 99);
            this.txtValorA.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(113, 32);
            this.txtValorA.TabIndex = 2;
            // 
            // txtValorB
            // 
            this.txtValorB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtValorB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorB.Location = new System.Drawing.Point(469, 167);
            this.txtValorB.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(113, 32);
            this.txtValorB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(415, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "b =";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNumMaxIter
            // 
            this.txtNumMaxIter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNumMaxIter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumMaxIter.Location = new System.Drawing.Point(847, 99);
            this.txtNumMaxIter.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumMaxIter.Name = "txtNumMaxIter";
            this.txtNumMaxIter.Size = new System.Drawing.Size(123, 32);
            this.txtNumMaxIter.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(641, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Num. Max. Iter =";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtErrorMax
            // 
            this.txtErrorMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtErrorMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorMax.Location = new System.Drawing.Point(847, 166);
            this.txtErrorMax.Margin = new System.Windows.Forms.Padding(2);
            this.txtErrorMax.Name = "txtErrorMax";
            this.txtErrorMax.Size = new System.Drawing.Size(123, 32);
            this.txtErrorMax.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(641, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 34);
            this.label5.TabIndex = 5;
            this.label5.Text = "Error Max         =";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btmCalcular
            // 
            this.btmCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btmCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmCalcular.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCalcular.Location = new System.Drawing.Point(1029, 107);
            this.btmCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btmCalcular.Name = "btmCalcular";
            this.btmCalcular.Size = new System.Drawing.Size(175, 76);
            this.btmCalcular.TabIndex = 9;
            this.btmCalcular.Text = "Calcular Raiz";
            this.btmCalcular.UseVisualStyleBackColor = false;
            this.btmCalcular.Click += new System.EventHandler(this.btmCalcular_Click);
            // 
            // dgvBiseccion
            // 
            this.dgvBiseccion.AllowUserToAddRows = false;
            this.dgvBiseccion.AllowUserToDeleteRows = false;
            this.dgvBiseccion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvBiseccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBiseccion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvBiseccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBiseccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_Iter,
            this.Colum_a,
            this.Colum_c,
            this.Colum_b,
            this.Func_a,
            this.Func_c,
            this.Func_b,
            this.ErrorAprox});
            this.dgvBiseccion.GridColor = System.Drawing.Color.Black;
            this.dgvBiseccion.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvBiseccion.Location = new System.Drawing.Point(11, 218);
            this.dgvBiseccion.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBiseccion.Name = "dgvBiseccion";
            this.dgvBiseccion.ReadOnly = true;
            this.dgvBiseccion.RowHeadersWidth = 51;
            this.dgvBiseccion.RowTemplate.Height = 24;
            this.dgvBiseccion.ShowRowErrors = false;
            this.dgvBiseccion.Size = new System.Drawing.Size(1327, 384);
            this.dgvBiseccion.TabIndex = 10;
            this.dgvBiseccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBiseccion_CellContentClick);
            // 
            // Num_Iter
            // 
            this.Num_Iter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Num_Iter.HeaderText = "i";
            this.Num_Iter.MinimumWidth = 6;
            this.Num_Iter.Name = "Num_Iter";
            this.Num_Iter.ReadOnly = true;
            // 
            // Colum_a
            // 
            this.Colum_a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colum_a.HeaderText = "a";
            this.Colum_a.MinimumWidth = 6;
            this.Colum_a.Name = "Colum_a";
            this.Colum_a.ReadOnly = true;
            // 
            // Colum_c
            // 
            this.Colum_c.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colum_c.HeaderText = "c";
            this.Colum_c.MinimumWidth = 6;
            this.Colum_c.Name = "Colum_c";
            this.Colum_c.ReadOnly = true;
            // 
            // Colum_b
            // 
            this.Colum_b.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colum_b.HeaderText = "b";
            this.Colum_b.MinimumWidth = 6;
            this.Colum_b.Name = "Colum_b";
            this.Colum_b.ReadOnly = true;
            // 
            // Func_a
            // 
            this.Func_a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Func_a.HeaderText = "f(a)";
            this.Func_a.MinimumWidth = 6;
            this.Func_a.Name = "Func_a";
            this.Func_a.ReadOnly = true;
            // 
            // Func_c
            // 
            this.Func_c.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Func_c.HeaderText = "f(c)";
            this.Func_c.MinimumWidth = 6;
            this.Func_c.Name = "Func_c";
            this.Func_c.ReadOnly = true;
            // 
            // Func_b
            // 
            this.Func_b.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Func_b.HeaderText = "f(b)";
            this.Func_b.MinimumWidth = 6;
            this.Func_b.Name = "Func_b";
            this.Func_b.ReadOnly = true;
            // 
            // ErrorAprox
            // 
            this.ErrorAprox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ErrorAprox.HeaderText = "Error Aprox";
            this.ErrorAprox.MinimumWidth = 6;
            this.ErrorAprox.Name = "ErrorAprox";
            this.ErrorAprox.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(644, 663);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 40);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtFuncion
            // 
            this.txtFuncion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncion.Location = new System.Drawing.Point(172, 130);
            this.txtFuncion.Margin = new System.Windows.Forms.Padding(2);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(200, 32);
            this.txtFuncion.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(45, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 34);
            this.label6.TabIndex = 12;
            this.label6.Text = "F(x) =";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // frmBiseccion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvBiseccion);
            this.Controls.Add(this.btmCalcular);
            this.Controls.Add(this.txtNumMaxIter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtErrorMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBiseccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBiseccion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBiseccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiseccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtValorA_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumMaxIter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtErrorMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btmCalcular;
        private System.Windows.Forms.DataGridView dgvBiseccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Iter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn Func_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Func_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Func_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorAprox;
    }
}