namespace MetodosNumericos
{
    partial class lagranje
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPuntoInteres = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtEcuacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picGrafica = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(31, 173);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Reiniciar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(185, 12);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(444, 213);
            this.dgvDatos.TabIndex = 24;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(31, 133);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "introducir";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "x";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(31, 105);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 22);
            this.txtX.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "funcion";
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(31, 48);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(100, 22);
            this.txtFuncion.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "punto de interes";
            // 
            // txtPuntoInteres
            // 
            this.txtPuntoInteres.Location = new System.Drawing.Point(31, 304);
            this.txtPuntoInteres.Name = "txtPuntoInteres";
            this.txtPuntoInteres.Size = new System.Drawing.Size(100, 22);
            this.txtPuntoInteres.TabIndex = 26;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(31, 356);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 28;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtEcuacion
            // 
            this.txtEcuacion.Location = new System.Drawing.Point(294, 567);
            this.txtEcuacion.Multiline = true;
            this.txtEcuacion.Name = "txtEcuacion";
            this.txtEcuacion.Size = new System.Drawing.Size(981, 58);
            this.txtEcuacion.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ecuacion";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(29, 583);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(77, 16);
            this.lblResultado.TabIndex = 32;
            this.lblResultado.Text = "__________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "resultado";
            // 
            // picGrafica
            // 
            this.picGrafica.Location = new System.Drawing.Point(652, 105);
            this.picGrafica.Name = "picGrafica";
            this.picGrafica.Size = new System.Drawing.Size(892, 410);
            this.picGrafica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGrafica.TabIndex = 34;
            this.picGrafica.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1362, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lagranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 881);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picGrafica);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEcuacion);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPuntoInteres);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFuncion);
            this.Name = "lagranje";
            this.Text = "lagranje";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPuntoInteres;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtEcuacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picGrafica;
        private System.Windows.Forms.Button button1;
    }
}