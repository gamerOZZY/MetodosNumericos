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
            ((System.ComponentModel.ISupportInitialize)(this.numDimension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizTriangular)).BeginInit();
            this.SuspendLayout();
            // 
            // numDimension
            // 
            this.numDimension.Location = new System.Drawing.Point(24, 40);
            this.numDimension.Name = "numDimension";
            this.numDimension.Size = new System.Drawing.Size(120, 22);
            this.numDimension.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "tamano de la matriz (nxn)";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(24, 68);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(120, 23);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Establecer";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtFilaInput
            // 
            this.txtFilaInput.Location = new System.Drawing.Point(27, 163);
            this.txtFilaInput.Name = "txtFilaInput";
            this.txtFilaInput.Size = new System.Drawing.Size(100, 22);
            this.txtFilaInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fila";
            // 
            // btnAgregarFila
            // 
            this.btnAgregarFila.Location = new System.Drawing.Point(27, 191);
            this.btnAgregarFila.Name = "btnAgregarFila";
            this.btnAgregarFila.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarFila.TabIndex = 5;
            this.btnAgregarFila.Text = "Agregar";
            this.btnAgregarFila.UseVisualStyleBackColor = true;
            this.btnAgregarFila.Click += new System.EventHandler(this.btnAgregarFila_Click);
            // 
            // dgvMatrizOriginal
            // 
            this.dgvMatrizOriginal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizOriginal.Location = new System.Drawing.Point(184, 18);
            this.dgvMatrizOriginal.Name = "dgvMatrizOriginal";
            this.dgvMatrizOriginal.RowHeadersWidth = 51;
            this.dgvMatrizOriginal.RowTemplate.Height = 24;
            this.dgvMatrizOriginal.Size = new System.Drawing.Size(308, 274);
            this.dgvMatrizOriginal.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(262, 340);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvMatrizTriangular
            // 
            this.dgvMatrizTriangular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizTriangular.Location = new System.Drawing.Point(615, 18);
            this.dgvMatrizTriangular.Name = "dgvMatrizTriangular";
            this.dgvMatrizTriangular.RowHeadersWidth = 51;
            this.dgvMatrizTriangular.RowTemplate.Height = 24;
            this.dgvMatrizTriangular.Size = new System.Drawing.Size(308, 274);
            this.dgvMatrizTriangular.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(715, 340);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Reiniciar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Location = new System.Drawing.Point(513, 485);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(83, 16);
            this.lblInstruccion.TabIndex = 11;
            this.lblInstruccion.Text = "Esperando...";
            // 
            // pivoteoParcial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 649);
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
            this.Name = "pivoteoParcial";
            this.Text = "pivoteoParcial";
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
    }
}