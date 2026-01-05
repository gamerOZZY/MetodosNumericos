namespace MetodosNumericos
{
    partial class frmPuntoFijo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuntoFijo));
            this.label2 = new System.Windows.Forms.Label();
            this.btmCalcular = new System.Windows.Forms.Button();
            this.txtNumMaxIter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtErrorMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPuntoFijo = new System.Windows.Forms.DataGridView();
            this.IterAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGuncion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoFijo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(532, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 62);
            this.label2.TabIndex = 2;
            this.label2.Text = "Metodo del punto fijo";
            // 
            // btmCalcular
            // 
            this.btmCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btmCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCalcular.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btmCalcular.Location = new System.Drawing.Point(1226, 137);
            this.btmCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btmCalcular.Name = "btmCalcular";
            this.btmCalcular.Size = new System.Drawing.Size(175, 76);
            this.btmCalcular.TabIndex = 18;
            this.btmCalcular.Text = "Calcular Raiz";
            this.btmCalcular.UseVisualStyleBackColor = false;
            this.btmCalcular.Click += new System.EventHandler(this.btmCalcular_Click);
            // 
            // txtNumMaxIter
            // 
            this.txtNumMaxIter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtNumMaxIter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumMaxIter.Location = new System.Drawing.Point(329, 119);
            this.txtNumMaxIter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumMaxIter.Name = "txtNumMaxIter";
            this.txtNumMaxIter.Size = new System.Drawing.Size(76, 32);
            this.txtNumMaxIter.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(123, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Num. Max. Iter";
            // 
            // txtErrorMax
            // 
            this.txtErrorMax.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtErrorMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorMax.Location = new System.Drawing.Point(282, 205);
            this.txtErrorMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtErrorMax.Name = "txtErrorMax";
            this.txtErrorMax.Size = new System.Drawing.Size(123, 32);
            this.txtErrorMax.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(123, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Error Max =";
            // 
            // txtValorA
            // 
            this.txtValorA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtValorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorA.Location = new System.Drawing.Point(920, 160);
            this.txtValorA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(181, 32);
            this.txtValorA.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(866, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "a =";
            // 
            // dgvPuntoFijo
            // 
            this.dgvPuntoFijo.AllowUserToAddRows = false;
            this.dgvPuntoFijo.AllowUserToDeleteRows = false;
            this.dgvPuntoFijo.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvPuntoFijo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntoFijo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IterAct,
            this.p0,
            this.p1,
            this.ErrorAct});
            this.dgvPuntoFijo.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvPuntoFijo.Location = new System.Drawing.Point(11, 275);
            this.dgvPuntoFijo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPuntoFijo.Name = "dgvPuntoFijo";
            this.dgvPuntoFijo.ReadOnly = true;
            this.dgvPuntoFijo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvPuntoFijo.RowHeadersWidth = 51;
            this.dgvPuntoFijo.RowTemplate.Height = 24;
            this.dgvPuntoFijo.Size = new System.Drawing.Size(1327, 323);
            this.dgvPuntoFijo.TabIndex = 21;
            this.dgvPuntoFijo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPuntoFijo_CellContentClick);
            // 
            // IterAct
            // 
            this.IterAct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IterAct.HeaderText = "i";
            this.IterAct.MinimumWidth = 6;
            this.IterAct.Name = "IterAct";
            this.IterAct.ReadOnly = true;
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
            this.txtFuncion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncion.Location = new System.Drawing.Point(598, 205);
            this.txtFuncion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(178, 32);
            this.txtFuncion.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(471, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 26);
            this.label6.TabIndex = 22;
            this.label6.Text = "F(x) =";
            // 
            // txtGuncion
            // 
            this.txtGuncion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtGuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuncion.Location = new System.Drawing.Point(598, 117);
            this.txtGuncion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGuncion.Name = "txtGuncion";
            this.txtGuncion.Size = new System.Drawing.Size(178, 32);
            this.txtGuncion.TabIndex = 25;
            this.txtGuncion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(471, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "g(x) =";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnSalir.Image = global::MetodosNumericos.Properties.Resources.fondoAzul;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(740, 723);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 40);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPuntoFijo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImage = global::MetodosNumericos.Properties.Resources.fondoAzul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtGuncion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvPuntoFijo);
            this.Controls.Add(this.btmCalcular);
            this.Controls.Add(this.txtNumMaxIter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtErrorMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPuntoFijo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPuntoFijo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoFijo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmCalcular;
        private System.Windows.Forms.TextBox txtNumMaxIter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtErrorMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPuntoFijo;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGuncion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IterAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn p0;
        private System.Windows.Forms.DataGridViewTextBoxColumn p1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorAct;
        private System.Windows.Forms.Button btnSalir;
    }
}