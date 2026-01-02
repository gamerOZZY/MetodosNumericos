namespace MetodosNumericos
{
    partial class pivoteoEscalado
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
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvMatrizTriangular = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvMatrizOriginal = new System.Windows.Forms.DataGridView();
            this.btnAgregarFila = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilaInput = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numDimension = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizTriangular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDimension)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Location = new System.Drawing.Point(505, 479);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(83, 16);
            this.lblInstruccion.TabIndex = 23;
            this.lblInstruccion.Text = "Esperando...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(707, 334);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 23);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Reiniciar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvMatrizTriangular
            // 
            this.dgvMatrizTriangular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizTriangular.Location = new System.Drawing.Point(607, 12);
            this.dgvMatrizTriangular.Name = "dgvMatrizTriangular";
            this.dgvMatrizTriangular.RowHeadersWidth = 51;
            this.dgvMatrizTriangular.RowTemplate.Height = 24;
            this.dgvMatrizTriangular.Size = new System.Drawing.Size(308, 274);
            this.dgvMatrizTriangular.TabIndex = 20;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(254, 334);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 23);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // dgvMatrizOriginal
            // 
            this.dgvMatrizOriginal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizOriginal.Location = new System.Drawing.Point(176, 12);
            this.dgvMatrizOriginal.Name = "dgvMatrizOriginal";
            this.dgvMatrizOriginal.RowHeadersWidth = 51;
            this.dgvMatrizOriginal.RowTemplate.Height = 24;
            this.dgvMatrizOriginal.Size = new System.Drawing.Size(308, 274);
            this.dgvMatrizOriginal.TabIndex = 18;
            // 
            // btnAgregarFila
            // 
            this.btnAgregarFila.Location = new System.Drawing.Point(19, 185);
            this.btnAgregarFila.Name = "btnAgregarFila";
            this.btnAgregarFila.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarFila.TabIndex = 17;
            this.btnAgregarFila.Text = "Agregar";
            this.btnAgregarFila.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fila";
            // 
            // txtFilaInput
            // 
            this.txtFilaInput.Location = new System.Drawing.Point(19, 157);
            this.txtFilaInput.Name = "txtFilaInput";
            this.txtFilaInput.Size = new System.Drawing.Size(100, 22);
            this.txtFilaInput.TabIndex = 15;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(16, 62);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(120, 23);
            this.btnIniciar.TabIndex = 14;
            this.btnIniciar.Text = "Establecer";
            this.btnIniciar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "tamano de la matriz (nxn)";
            // 
            // numDimension
            // 
            this.numDimension.Location = new System.Drawing.Point(16, 34);
            this.numDimension.Name = "numDimension";
            this.numDimension.Size = new System.Drawing.Size(120, 22);
            this.numDimension.TabIndex = 12;
            // 
            // pivoteoEscalado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 658);
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
            this.Name = "pivoteoEscalado";
            this.Text = "pivoteoEscalado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizTriangular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDimension)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvMatrizTriangular;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvMatrizOriginal;
        private System.Windows.Forms.Button btnAgregarFila;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilaInput;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDimension;
    }
}