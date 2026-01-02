namespace MetodosNumericos
{
    partial class factorizaciones
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
            this.cboMetodo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMatrizOriginal = new System.Windows.Forms.DataGridView();
            this.dgvMatrizL = new System.Windows.Forms.DataGridView();
            this.dgvMatrizU = new System.Windows.Forms.DataGridView();
            this.dgvMatrizP = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lol = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblU = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDimension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizP)).BeginInit();
            this.SuspendLayout();
            // 
            // numDimension
            // 
            this.numDimension.Location = new System.Drawing.Point(12, 32);
            this.numDimension.Name = "numDimension";
            this.numDimension.Size = new System.Drawing.Size(120, 22);
            this.numDimension.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dimension";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 61);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtFilaInput
            // 
            this.txtFilaInput.Enabled = false;
            this.txtFilaInput.Location = new System.Drawing.Point(12, 119);
            this.txtFilaInput.Name = "txtFilaInput";
            this.txtFilaInput.Size = new System.Drawing.Size(100, 22);
            this.txtFilaInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fila";
            // 
            // btnAgregarFila
            // 
            this.btnAgregarFila.Enabled = false;
            this.btnAgregarFila.Location = new System.Drawing.Point(12, 147);
            this.btnAgregarFila.Name = "btnAgregarFila";
            this.btnAgregarFila.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarFila.TabIndex = 5;
            this.btnAgregarFila.Text = "Agregar";
            this.btnAgregarFila.UseVisualStyleBackColor = true;
            this.btnAgregarFila.Click += new System.EventHandler(this.AgregarFila_Click);
            // 
            // cboMetodo
            // 
            this.cboMetodo.Enabled = false;
            this.cboMetodo.FormattingEnabled = true;
            this.cboMetodo.Location = new System.Drawing.Point(12, 209);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.Size = new System.Drawing.Size(121, 24);
            this.cboMetodo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Metodo";
            // 
            // dgvMatrizOriginal
            // 
            this.dgvMatrizOriginal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizOriginal.Location = new System.Drawing.Point(195, 61);
            this.dgvMatrizOriginal.Name = "dgvMatrizOriginal";
            this.dgvMatrizOriginal.RowHeadersWidth = 51;
            this.dgvMatrizOriginal.RowTemplate.Height = 24;
            this.dgvMatrizOriginal.Size = new System.Drawing.Size(426, 278);
            this.dgvMatrizOriginal.TabIndex = 8;
            // 
            // dgvMatrizL
            // 
            this.dgvMatrizL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizL.Location = new System.Drawing.Point(679, 61);
            this.dgvMatrizL.Name = "dgvMatrizL";
            this.dgvMatrizL.RowHeadersWidth = 51;
            this.dgvMatrizL.RowTemplate.Height = 24;
            this.dgvMatrizL.Size = new System.Drawing.Size(426, 278);
            this.dgvMatrizL.TabIndex = 9;
            // 
            // dgvMatrizU
            // 
            this.dgvMatrizU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizU.Location = new System.Drawing.Point(195, 386);
            this.dgvMatrizU.Name = "dgvMatrizU";
            this.dgvMatrizU.RowHeadersWidth = 51;
            this.dgvMatrizU.RowTemplate.Height = 24;
            this.dgvMatrizU.Size = new System.Drawing.Size(426, 278);
            this.dgvMatrizU.TabIndex = 10;
            // 
            // dgvMatrizP
            // 
            this.dgvMatrizP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizP.Location = new System.Drawing.Point(679, 386);
            this.dgvMatrizP.Name = "dgvMatrizP";
            this.dgvMatrizP.RowHeadersWidth = 51;
            this.dgvMatrizP.RowTemplate.Height = 24;
            this.dgvMatrizP.Size = new System.Drawing.Size(426, 278);
            this.dgvMatrizP.TabIndex = 11;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Location = new System.Drawing.Point(16, 268);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(16, 316);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Reiniciar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lol
            // 
            this.lol.AutoSize = true;
            this.lol.Location = new System.Drawing.Point(378, 34);
            this.lol.Name = "lol";
            this.lol.Size = new System.Drawing.Size(89, 16);
            this.lol.TabIndex = 14;
            this.lol.Text = "Matriz original";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(868, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Matriz L";
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Location = new System.Drawing.Point(378, 367);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(55, 16);
            this.lblU.TabIndex = 16;
            this.lblU.Text = "Matriz U";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(827, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Matriz de permutaciones";
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Location = new System.Drawing.Point(16, 386);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(83, 16);
            this.lblInstruccion.TabIndex = 18;
            this.lblInstruccion.Text = "Esperando...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // factorizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 730);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvMatrizP);
            this.Controls.Add(this.dgvMatrizU);
            this.Controls.Add(this.dgvMatrizL);
            this.Controls.Add(this.dgvMatrizOriginal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboMetodo);
            this.Controls.Add(this.btnAgregarFila);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilaInput);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDimension);
            this.Name = "factorizaciones";
            this.Text = "factorizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.numDimension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizP)).EndInit();
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
        private System.Windows.Forms.ComboBox cboMetodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMatrizOriginal;
        private System.Windows.Forms.DataGridView dgvMatrizL;
        private System.Windows.Forms.DataGridView dgvMatrizU;
        private System.Windows.Forms.DataGridView dgvMatrizP;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Button button1;
    }
}