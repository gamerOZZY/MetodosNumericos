namespace MetodosNumericos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.solucionDeEcuacionesDeUnaVariableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biseccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.falsaPosicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoFijoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mullerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derivacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interpolacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInterpolacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.integracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIntegracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solucionDeEcuacionesDeUnaVariableToolStripMenuItem,
            this.derivacionToolStripMenuItem,
            this.integracionToolStripMenuItem,
            this.interpolacionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // solucionDeEcuacionesDeUnaVariableToolStripMenuItem
            // 
            this.solucionDeEcuacionesDeUnaVariableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biseccionToolStripMenuItem,
            this.secanteToolStripMenuItem,
            this.falsaPosicionToolStripMenuItem,
            this.newtonToolStripMenuItem,
            this.puntoFijoToolStripMenuItem,
            this.mullerToolStripMenuItem});
            this.solucionDeEcuacionesDeUnaVariableToolStripMenuItem.Name = "solucionDeEcuacionesDeUnaVariableToolStripMenuItem";
            this.solucionDeEcuacionesDeUnaVariableToolStripMenuItem.Size = new System.Drawing.Size(284, 24);
            this.solucionDeEcuacionesDeUnaVariableToolStripMenuItem.Text = "Solucion de ecuaciones de una variable";
            // 
            // biseccionToolStripMenuItem
            // 
            this.biseccionToolStripMenuItem.Name = "biseccionToolStripMenuItem";
            this.biseccionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.biseccionToolStripMenuItem.Text = "Biseccion";
            this.biseccionToolStripMenuItem.Click += new System.EventHandler(this.biseccionToolStripMenuItem_Click);
            // 
            // secanteToolStripMenuItem
            // 
            this.secanteToolStripMenuItem.Name = "secanteToolStripMenuItem";
            this.secanteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.secanteToolStripMenuItem.Text = "Secante";
            this.secanteToolStripMenuItem.Click += new System.EventHandler(this.secanteToolStripMenuItem_Click);
            // 
            // falsaPosicionToolStripMenuItem
            // 
            this.falsaPosicionToolStripMenuItem.Name = "falsaPosicionToolStripMenuItem";
            this.falsaPosicionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.falsaPosicionToolStripMenuItem.Text = "Falsa posicion";
            this.falsaPosicionToolStripMenuItem.Click += new System.EventHandler(this.falsaPosicionToolStripMenuItem_Click);
            // 
            // newtonToolStripMenuItem
            // 
            this.newtonToolStripMenuItem.Name = "newtonToolStripMenuItem";
            this.newtonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newtonToolStripMenuItem.Text = "Newton";
            this.newtonToolStripMenuItem.Click += new System.EventHandler(this.newtonToolStripMenuItem_Click);
            // 
            // puntoFijoToolStripMenuItem
            // 
            this.puntoFijoToolStripMenuItem.Name = "puntoFijoToolStripMenuItem";
            this.puntoFijoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.puntoFijoToolStripMenuItem.Text = "Punto fijo";
            this.puntoFijoToolStripMenuItem.Click += new System.EventHandler(this.puntoFijoToolStripMenuItem_Click);
            // 
            // mullerToolStripMenuItem
            // 
            this.mullerToolStripMenuItem.Name = "mullerToolStripMenuItem";
            this.mullerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mullerToolStripMenuItem.Text = "Muller";
            this.mullerToolStripMenuItem.Click += new System.EventHandler(this.mullerToolStripMenuItem_Click);
            // 
            // derivacionToolStripMenuItem
            // 
            this.derivacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.derivacionToolStripMenuItem.Name = "derivacionToolStripMenuItem";
            this.derivacionToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.derivacionToolStripMenuItem.Text = "Derivacion";
            this.derivacionToolStripMenuItem.Click += new System.EventHandler(this.derivacionToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.menuToolStripMenuItem.Text = "menu derivacion numerica";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // interpolacionToolStripMenuItem
            // 
            this.interpolacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInterpolacionToolStripMenuItem});
            this.interpolacionToolStripMenuItem.Name = "interpolacionToolStripMenuItem";
            this.interpolacionToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.interpolacionToolStripMenuItem.Text = "Interpolacion";
            // 
            // menuInterpolacionToolStripMenuItem
            // 
            this.menuInterpolacionToolStripMenuItem.Name = "menuInterpolacionToolStripMenuItem";
            this.menuInterpolacionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.menuInterpolacionToolStripMenuItem.Text = "Menu interpolacion";
            this.menuInterpolacionToolStripMenuItem.Click += new System.EventHandler(this.menuInterpolacionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.salirToolStripMenuItem.Text = "Opciones";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem1.Text = "salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(443, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 53);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Minecraft", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1443, 150);
            this.label3.TabIndex = 4;
            this.label3.Text = "Metodos Numericos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Minecraft", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(543, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1000, 76);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ramirez Cortes Axel Osiris.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Minecraft", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(595, 679);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(948, 76);
            this.label5.TabIndex = 6;
            this.label5.Text = "Morales Vega Juan Pablo.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Minecraft", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(570, 809);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1105, 76);
            this.label6.TabIndex = 7;
            this.label6.Text = "Edgar Andres Reynoso Pablo.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Minecraft", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(932, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 100);
            this.label7.TabIndex = 8;
            this.label7.Text = "3AM2";
            // 
            // integracionToolStripMenuItem
            // 
            this.integracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuIntegracionToolStripMenuItem});
            this.integracionToolStripMenuItem.Name = "integracionToolStripMenuItem";
            this.integracionToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.integracionToolStripMenuItem.Text = "Integracion";
            // 
            // menuIntegracionToolStripMenuItem
            // 
            this.menuIntegracionToolStripMenuItem.Name = "menuIntegracionToolStripMenuItem";
            this.menuIntegracionToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.menuIntegracionToolStripMenuItem.Text = "Menu integracion numerica";
            this.menuIntegracionToolStripMenuItem.Click += new System.EventHandler(this.menuIntegracionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MetodosNumericos.Properties.Resources.fondoMosaico;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 988);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "frm_Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem solucionDeEcuacionesDeUnaVariableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biseccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem falsaPosicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntoFijoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mullerToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem derivacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interpolacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuInterpolacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuIntegracionToolStripMenuItem;
    }
}

