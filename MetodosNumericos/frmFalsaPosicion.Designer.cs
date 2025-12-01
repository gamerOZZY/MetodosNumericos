namespace MetodosNumericos
{
    partial class frmFalsaPosicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFalsaPosicion));
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvFalsaPos = new System.Windows.Forms.DataGridView();
            this.Num_Iter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Func_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Func_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Func_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorAprox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btmCalcular = new System.Windows.Forms.Button();
            this.txtNumMaxIter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtErrorMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFalsaPos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSalir.Image = global::MetodosNumericos.Properties.Resources.fondoAmarillo;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(960, 890);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(186, 49);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvFalsaPos
            // 
            this.dgvFalsaPos.AllowUserToAddRows = false;
            this.dgvFalsaPos.AllowUserToDeleteRows = false;
            this.dgvFalsaPos.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvFalsaPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFalsaPos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_Iter,
            this.Colum_a,
            this.Colum_c,
            this.Colum_b,
            this.Func_a,
            this.Func_c,
            this.Func_b,
            this.ErrorAprox});
            this.dgvFalsaPos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvFalsaPos.Location = new System.Drawing.Point(131, 354);
            this.dgvFalsaPos.Name = "dgvFalsaPos";
            this.dgvFalsaPos.ReadOnly = true;
            this.dgvFalsaPos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvFalsaPos.RowHeadersWidth = 51;
            this.dgvFalsaPos.RowTemplate.Height = 24;
            this.dgvFalsaPos.Size = new System.Drawing.Size(1769, 472);
            this.dgvFalsaPos.TabIndex = 21;
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
            // btmCalcular
            // 
            this.btmCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btmCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCalcular.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btmCalcular.Location = new System.Drawing.Point(1688, 153);
            this.btmCalcular.Name = "btmCalcular";
            this.btmCalcular.Size = new System.Drawing.Size(233, 93);
            this.btmCalcular.TabIndex = 20;
            this.btmCalcular.Text = "Calcular Raiz";
            this.btmCalcular.UseVisualStyleBackColor = false;
            this.btmCalcular.Click += new System.EventHandler(this.btmCalcular_Click);
            // 
            // txtNumMaxIter
            // 
            this.txtNumMaxIter.BackColor = System.Drawing.Color.Wheat;
            this.txtNumMaxIter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumMaxIter.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNumMaxIter.Location = new System.Drawing.Point(848, 131);
            this.txtNumMaxIter.Name = "txtNumMaxIter";
            this.txtNumMaxIter.Size = new System.Drawing.Size(100, 38);
            this.txtNumMaxIter.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(488, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 36);
            this.label4.TabIndex = 18;
            this.label4.Text = "Num. Max. Iter =";
            // 
            // txtErrorMax
            // 
            this.txtErrorMax.BackColor = System.Drawing.Color.Wheat;
            this.txtErrorMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorMax.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtErrorMax.Location = new System.Drawing.Point(757, 232);
            this.txtErrorMax.Name = "txtErrorMax";
            this.txtErrorMax.Size = new System.Drawing.Size(191, 38);
            this.txtErrorMax.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(488, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 36);
            this.label5.TabIndex = 16;
            this.label5.Text = "Error Max =";
            // 
            // txtValorB
            // 
            this.txtValorB.BackColor = System.Drawing.Color.Wheat;
            this.txtValorB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorB.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtValorB.Location = new System.Drawing.Point(156, 234);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(100, 38);
            this.txtValorB.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(84, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "b =";
            // 
            // txtValorA
            // 
            this.txtValorA.BackColor = System.Drawing.Color.Wheat;
            this.txtValorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorA.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtValorA.Location = new System.Drawing.Point(156, 134);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(100, 38);
            this.txtValorA.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(84, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "a =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(674, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(742, 76);
            this.label1.TabIndex = 23;
            this.label1.Text = "Metodo de falsa posicion";
            // 
            // txtFuncion
            // 
            this.txtFuncion.BackColor = System.Drawing.Color.Wheat;
            this.txtFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtFuncion.Location = new System.Drawing.Point(1291, 179);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(272, 38);
            this.txtFuncion.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(1122, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 36);
            this.label6.TabIndex = 24;
            this.label6.Text = "F(x) =";
            // 
            // frmFalsaPosicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MetodosNumericos.Properties.Resources.fondoAmarillo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 988);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvFalsaPos);
            this.Controls.Add(this.btmCalcular);
            this.Controls.Add(this.txtNumMaxIter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtErrorMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFalsaPosicion";
            this.Text = "frmFalsaPosicion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFalsaPos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvFalsaPos;
        private System.Windows.Forms.Button btmCalcular;
        private System.Windows.Forms.TextBox txtNumMaxIter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtErrorMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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