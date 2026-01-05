namespace MetodosNumericos
{
    partial class der123
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(der123));
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lstTabla = new System.Windows.Forms.ListBox();
            this.cboPuntos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMetodos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblPasoH = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(681, 140);
            this.txtFuncion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(223, 20);
            this.txtFuncion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Función =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "x =";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(95, 138);
            this.txtX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(76, 20);
            this.txtX.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(204, 129);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 29);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(64, 643);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 33);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Reiniciar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lstTabla
            // 
            this.lstTabla.FormattingEnabled = true;
            this.lstTabla.Location = new System.Drawing.Point(64, 206);
            this.lstTabla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstTabla.Name = "lstTabla";
            this.lstTabla.Size = new System.Drawing.Size(624, 407);
            this.lstTabla.TabIndex = 6;
            // 
            // cboPuntos
            // 
            this.cboPuntos.FormattingEnabled = true;
            this.cboPuntos.Location = new System.Drawing.Point(1028, 140);
            this.cboPuntos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPuntos.Name = "cboPuntos";
            this.cboPuntos.Size = new System.Drawing.Size(92, 21);
            this.cboPuntos.TabIndex = 7;
            this.cboPuntos.SelectedIndexChanged += new System.EventHandler(this.cboPuntos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(936, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Puntos:";
            // 
            // cboMetodos
            // 
            this.cboMetodos.FormattingEnabled = true;
            this.cboMetodos.Location = new System.Drawing.Point(1250, 140);
            this.cboMetodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMetodos.Name = "cboMetodos";
            this.cboMetodos.Size = new System.Drawing.Size(92, 21);
            this.cboMetodos.TabIndex = 9;
            this.cboMetodos.SelectedIndexChanged += new System.EventHandler(this.cboMetodos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1158, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Derivada";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(758, 385);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(99, 26);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Location = new System.Drawing.Point(869, 427);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(61, 13);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "_________";
            // 
            // lblPasoH
            // 
            this.lblPasoH.AutoSize = true;
            this.lblPasoH.BackColor = System.Drawing.Color.Transparent;
            this.lblPasoH.Location = new System.Drawing.Point(869, 467);
            this.lblPasoH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasoH.Name = "lblPasoH";
            this.lblPasoH.Size = new System.Drawing.Size(73, 13);
            this.lblPasoH.TabIndex = 13;
            this.lblPasoH.Text = "___________";
            this.lblPasoH.Click += new System.EventHandler(this.lblPasoH_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(647, 694);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(487, 42);
            this.label5.TabIndex = 15;
            this.label5.Text = "Derivación 2, 3 y 5 puntos ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // der123
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPasoH);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMetodos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboPuntos);
            this.Controls.Add(this.lstTabla);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFuncion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "der123";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Derivacion 2, 3 y 5 puntos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.der123_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox lstTabla;
        private System.Windows.Forms.ComboBox cboPuntos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMetodos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPasoH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}