namespace MetodosNumericos
{
    partial class pivoteoParcial
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
            this.numDimension = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtFilaInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarFila = new System.Windows.Forms.Button();
            this.dgvMatrizOriginal = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvMatrizTriangular = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.cboMetodo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDimension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizTriangular)).BeginInit();
            this.SuspendLayout();
            // 
            // numDimension
            // 
            this.numDimension.Location = new System.Drawing.Point(85, 210);
            this.numDimension.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numDimension.Name = "numDimension";
            this.numDimension.Size = new System.Drawing.Size(90, 27);
            this.numDimension.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "tamano de la matriz (nxn)";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(230, 211);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(90, 26);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Establecer";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtFilaInput
            // 
            this.txtFilaInput.Location = new System.Drawing.Point(85, 296);
            this.txtFilaInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFilaInput.Name = "txtFilaInput";
            this.txtFilaInput.Size = new System.Drawing.Size(76, 27);
            this.txtFilaInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fila";
            // 
            // btnAgregarFila
            // 
            this.btnAgregarFila.Location = new System.Drawing.Point(230, 296);
            this.btnAgregarFila.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarFila.Name = "btnAgregarFila";
            this.btnAgregarFila.Size = new System.Drawing.Size(90, 35);
            this.btnAgregarFila.TabIndex = 5;
            this.btnAgregarFila.Text = "Agregar";
            this.btnAgregarFila.UseVisualStyleBackColor = true;
            this.btnAgregarFila.Click += new System.EventHandler(this.btnAgregarFila_Click);
            // 
            // dgvMatrizOriginal
            // 
            this.dgvMatrizOriginal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizOriginal.Location = new System.Drawing.Point(411, 194);
            this.dgvMatrizOriginal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMatrizOriginal.Name = "dgvMatrizOriginal";
            this.dgvMatrizOriginal.RowHeadersWidth = 51;
            this.dgvMatrizOriginal.RowTemplate.Height = 24;
            this.dgvMatrizOriginal.Size = new System.Drawing.Size(251, 240);
            this.dgvMatrizOriginal.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(411, 455);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 32);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvMatrizTriangular
            // 
            this.dgvMatrizTriangular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizTriangular.Location = new System.Drawing.Point(801, 194);
            this.dgvMatrizTriangular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMatrizTriangular.Name = "dgvMatrizTriangular";
            this.dgvMatrizTriangular.RowHeadersWidth = 51;
            this.dgvMatrizTriangular.RowTemplate.Height = 24;
            this.dgvMatrizTriangular.Size = new System.Drawing.Size(250, 240);
            this.dgvMatrizTriangular.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(801, 455);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 32);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Reiniciar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 710);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Location = new System.Drawing.Point(645, 557);
            this.lblInstruccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(87, 20);
            this.lblInstruccion.TabIndex = 11;
            this.lblInstruccion.Text = "Esperando...";
            // 
            // cboMetodo
            // 
            this.cboMetodo.FormattingEnabled = true;
            this.cboMetodo.Location = new System.Drawing.Point(230, 380);
            this.cboMetodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.Size = new System.Drawing.Size(92, 28);
            this.cboMetodo.TabIndex = 12;
            this.cboMetodo.SelectedIndexChanged += new System.EventHandler(this.cboMetodo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 383);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Metodo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "matriz original";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(806, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "matriz triangular superior";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(649, 60);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pivoteo Parcial, total y escalado";
            // 
            // pivoteoParcial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImage = global::MetodosNumericos.Properties.Resources.cuaderno;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboMetodo);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvMatrizTriangular);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvMatrizOriginal);
            this.Controls.Add(this.btnAgregarFila);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilaInput);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDimension);
            this.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "pivoteoParcial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pivoteoParcial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.numDimension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizTriangular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numDimension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtFilaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarFila;
        private System.Windows.Forms.DataGridView dgvMatrizOriginal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvMatrizTriangular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.ComboBox cboMetodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}