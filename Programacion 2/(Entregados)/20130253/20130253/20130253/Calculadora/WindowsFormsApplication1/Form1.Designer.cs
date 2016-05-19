namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.botonCE = new System.Windows.Forms.Button();
            this.botondiv = new System.Windows.Forms.Button();
            this.botonmult = new System.Windows.Forms.Button();
            this.botonresta = new System.Windows.Forms.Button();
            this.boton7 = new System.Windows.Forms.Button();
            this.boton8 = new System.Windows.Forms.Button();
            this.boton9 = new System.Windows.Forms.Button();
            this.botonsuma = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.boton5 = new System.Windows.Forms.Button();
            this.boton6 = new System.Windows.Forms.Button();
            this.botonraiz = new System.Windows.Forms.Button();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.botonigual = new System.Windows.Forms.Button();
            this.boton0 = new System.Windows.Forms.Button();
            this.botonpunto = new System.Windows.Forms.Button();
            this.botonMmas = new System.Windows.Forms.Button();
            this.botonMC = new System.Windows.Forms.Button();
            this.botonMmenos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.botonMR = new System.Windows.Forms.Button();
            this.botonPorciento = new System.Windows.Forms.Button();
            this.botonPotencia = new System.Windows.Forms.Button();
            this.botonMCM = new System.Windows.Forms.Button();
            this.botonLog = new System.Windows.Forms.Button();
            this.botonMCD = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeCalculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.Location = new System.Drawing.Point(12, 27);
            this.Pantalla.Multiline = true;
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(224, 29);
            this.Pantalla.TabIndex = 0;
            // 
            // botonCE
            // 
            this.botonCE.ForeColor = System.Drawing.Color.Black;
            this.botonCE.Location = new System.Drawing.Point(12, 108);
            this.botonCE.Name = "botonCE";
            this.botonCE.Size = new System.Drawing.Size(40, 40);
            this.botonCE.TabIndex = 1;
            this.botonCE.Text = "CE";
            this.botonCE.UseVisualStyleBackColor = true;
            this.botonCE.Click += new System.EventHandler(this.botonCE_Click);
            // 
            // botondiv
            // 
            this.botondiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botondiv.Location = new System.Drawing.Point(58, 108);
            this.botondiv.Name = "botondiv";
            this.botondiv.Size = new System.Drawing.Size(40, 40);
            this.botondiv.TabIndex = 2;
            this.botondiv.Text = "/";
            this.botondiv.UseVisualStyleBackColor = true;
            this.botondiv.Click += new System.EventHandler(this.botondiv_Click);
            // 
            // botonmult
            // 
            this.botonmult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonmult.Location = new System.Drawing.Point(104, 108);
            this.botonmult.Name = "botonmult";
            this.botonmult.Size = new System.Drawing.Size(40, 40);
            this.botonmult.TabIndex = 3;
            this.botonmult.Text = "*";
            this.botonmult.UseVisualStyleBackColor = true;
            this.botonmult.Click += new System.EventHandler(this.botonmult_Click);
            // 
            // botonresta
            // 
            this.botonresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonresta.Location = new System.Drawing.Point(150, 107);
            this.botonresta.Name = "botonresta";
            this.botonresta.Size = new System.Drawing.Size(40, 40);
            this.botonresta.TabIndex = 4;
            this.botonresta.Text = "-";
            this.botonresta.UseVisualStyleBackColor = true;
            this.botonresta.Click += new System.EventHandler(this.botonresta_Click);
            // 
            // boton7
            // 
            this.boton7.Location = new System.Drawing.Point(12, 154);
            this.boton7.Name = "boton7";
            this.boton7.Size = new System.Drawing.Size(40, 40);
            this.boton7.TabIndex = 5;
            this.boton7.Text = "7";
            this.boton7.UseVisualStyleBackColor = true;
            this.boton7.Click += new System.EventHandler(this.boton7_Click);
            // 
            // boton8
            // 
            this.boton8.Location = new System.Drawing.Point(58, 154);
            this.boton8.Name = "boton8";
            this.boton8.Size = new System.Drawing.Size(40, 40);
            this.boton8.TabIndex = 6;
            this.boton8.Text = "8";
            this.boton8.UseVisualStyleBackColor = true;
            this.boton8.Click += new System.EventHandler(this.boton8_Click);
            // 
            // boton9
            // 
            this.boton9.Location = new System.Drawing.Point(104, 154);
            this.boton9.Name = "boton9";
            this.boton9.Size = new System.Drawing.Size(40, 40);
            this.boton9.TabIndex = 7;
            this.boton9.Text = "9";
            this.boton9.UseVisualStyleBackColor = true;
            this.boton9.Click += new System.EventHandler(this.boton9_Click);
            // 
            // botonsuma
            // 
            this.botonsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonsuma.Location = new System.Drawing.Point(150, 153);
            this.botonsuma.Name = "botonsuma";
            this.botonsuma.Size = new System.Drawing.Size(40, 40);
            this.botonsuma.TabIndex = 8;
            this.botonsuma.Text = "+";
            this.botonsuma.UseVisualStyleBackColor = true;
            this.botonsuma.Click += new System.EventHandler(this.botonsuma_Click);
            // 
            // boton4
            // 
            this.boton4.Location = new System.Drawing.Point(12, 200);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(40, 40);
            this.boton4.TabIndex = 9;
            this.boton4.Text = "4";
            this.boton4.UseVisualStyleBackColor = true;
            this.boton4.Click += new System.EventHandler(this.boton4_Click);
            // 
            // boton5
            // 
            this.boton5.Location = new System.Drawing.Point(58, 200);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(40, 40);
            this.boton5.TabIndex = 10;
            this.boton5.Text = "5";
            this.boton5.UseVisualStyleBackColor = true;
            this.boton5.Click += new System.EventHandler(this.boton5_Click);
            // 
            // boton6
            // 
            this.boton6.Location = new System.Drawing.Point(104, 200);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(40, 40);
            this.boton6.TabIndex = 11;
            this.boton6.Text = "6";
            this.boton6.UseVisualStyleBackColor = true;
            this.boton6.Click += new System.EventHandler(this.boton6_Click);
            // 
            // botonraiz
            // 
            this.botonraiz.Location = new System.Drawing.Point(150, 200);
            this.botonraiz.Name = "botonraiz";
            this.botonraiz.Size = new System.Drawing.Size(40, 40);
            this.botonraiz.TabIndex = 12;
            this.botonraiz.Text = "RAIZ";
            this.botonraiz.UseVisualStyleBackColor = true;
            this.botonraiz.Click += new System.EventHandler(this.botonraiz_Click);
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(12, 246);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(40, 40);
            this.boton1.TabIndex = 13;
            this.boton1.Text = "1";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(58, 246);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(40, 40);
            this.boton2.TabIndex = 14;
            this.boton2.Text = "2";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(104, 246);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(40, 40);
            this.boton3.TabIndex = 15;
            this.boton3.Text = "3";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // botonigual
            // 
            this.botonigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonigual.Location = new System.Drawing.Point(150, 246);
            this.botonigual.Name = "botonigual";
            this.botonigual.Size = new System.Drawing.Size(40, 86);
            this.botonigual.TabIndex = 16;
            this.botonigual.Text = "=";
            this.botonigual.UseVisualStyleBackColor = true;
            this.botonigual.Click += new System.EventHandler(this.botonigual_Click);
            // 
            // boton0
            // 
            this.boton0.Location = new System.Drawing.Point(12, 292);
            this.boton0.Name = "boton0";
            this.boton0.Size = new System.Drawing.Size(86, 40);
            this.boton0.TabIndex = 17;
            this.boton0.Text = "0";
            this.boton0.UseVisualStyleBackColor = true;
            // 
            // botonpunto
            // 
            this.botonpunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonpunto.Location = new System.Drawing.Point(104, 292);
            this.botonpunto.Name = "botonpunto";
            this.botonpunto.Size = new System.Drawing.Size(40, 40);
            this.botonpunto.TabIndex = 18;
            this.botonpunto.Text = ".";
            this.botonpunto.UseVisualStyleBackColor = true;
            // 
            // botonMmas
            // 
            this.botonMmas.Location = new System.Drawing.Point(104, 62);
            this.botonMmas.Name = "botonMmas";
            this.botonMmas.Size = new System.Drawing.Size(40, 40);
            this.botonMmas.TabIndex = 19;
            this.botonMmas.Text = "M+";
            this.botonMmas.UseVisualStyleBackColor = true;
            this.botonMmas.Click += new System.EventHandler(this.botonMmas_Click);
            // 
            // botonMC
            // 
            this.botonMC.Location = new System.Drawing.Point(58, 62);
            this.botonMC.Name = "botonMC";
            this.botonMC.Size = new System.Drawing.Size(40, 40);
            this.botonMC.TabIndex = 20;
            this.botonMC.Text = "MC";
            this.botonMC.UseVisualStyleBackColor = true;
            this.botonMC.Click += new System.EventHandler(this.botonMC_Click);
            // 
            // botonMmenos
            // 
            this.botonMmenos.Location = new System.Drawing.Point(150, 62);
            this.botonMmenos.Name = "botonMmenos";
            this.botonMmenos.Size = new System.Drawing.Size(40, 40);
            this.botonMmenos.TabIndex = 21;
            this.botonMmenos.Text = "M-";
            this.botonMmenos.UseVisualStyleBackColor = true;
            this.botonMmenos.Click += new System.EventHandler(this.botonMmenos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(196, 292);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // botonMR
            // 
            this.botonMR.Location = new System.Drawing.Point(12, 62);
            this.botonMR.Name = "botonMR";
            this.botonMR.Size = new System.Drawing.Size(40, 40);
            this.botonMR.TabIndex = 25;
            this.botonMR.Text = "MR";
            this.botonMR.UseVisualStyleBackColor = true;
            this.botonMR.Click += new System.EventHandler(this.botonMR_Click);
            // 
            // botonPorciento
            // 
            this.botonPorciento.Location = new System.Drawing.Point(196, 247);
            this.botonPorciento.Name = "botonPorciento";
            this.botonPorciento.Size = new System.Drawing.Size(40, 40);
            this.botonPorciento.TabIndex = 26;
            this.botonPorciento.Text = "%";
            this.botonPorciento.UseVisualStyleBackColor = true;
            this.botonPorciento.Click += new System.EventHandler(this.botonPorciento_Click);
            // 
            // botonPotencia
            // 
            this.botonPotencia.Location = new System.Drawing.Point(196, 201);
            this.botonPotencia.Name = "botonPotencia";
            this.botonPotencia.Size = new System.Drawing.Size(40, 40);
            this.botonPotencia.TabIndex = 27;
            this.botonPotencia.Text = "^";
            this.botonPotencia.UseVisualStyleBackColor = true;
            this.botonPotencia.Click += new System.EventHandler(this.botonPotencia_Click);
            // 
            // botonMCM
            // 
            this.botonMCM.Location = new System.Drawing.Point(197, 108);
            this.botonMCM.Name = "botonMCM";
            this.botonMCM.Size = new System.Drawing.Size(40, 40);
            this.botonMCM.TabIndex = 28;
            this.botonMCM.Text = "MCM";
            this.botonMCM.UseVisualStyleBackColor = true;
            this.botonMCM.Click += new System.EventHandler(this.botonMCM_Click);
            // 
            // botonLog
            // 
            this.botonLog.Location = new System.Drawing.Point(196, 153);
            this.botonLog.Name = "botonLog";
            this.botonLog.Size = new System.Drawing.Size(40, 40);
            this.botonLog.TabIndex = 29;
            this.botonLog.Text = "Log";
            this.botonLog.UseVisualStyleBackColor = true;
            this.botonLog.Click += new System.EventHandler(this.botonLog_Click);
            // 
            // botonMCD
            // 
            this.botonMCD.Location = new System.Drawing.Point(197, 62);
            this.botonMCD.Name = "botonMCD";
            this.botonMCD.Size = new System.Drawing.Size(40, 40);
            this.botonMCD.TabIndex = 30;
            this.botonMCD.Text = "MCD";
            this.botonMCD.UseVisualStyleBackColor = true;
            this.botonMCD.Click += new System.EventHandler(this.botonMCD_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(249, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeCalculadoraToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeCalculadoraToolStripMenuItem
            // 
            this.acercaDeCalculadoraToolStripMenuItem.Name = "acercaDeCalculadoraToolStripMenuItem";
            this.acercaDeCalculadoraToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.acercaDeCalculadoraToolStripMenuItem.Text = "Acerca de Calculadora";
            this.acercaDeCalculadoraToolStripMenuItem.Click += new System.EventHandler(this.acercaDeCalculadoraToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 338);
            this.Controls.Add(this.botonMCD);
            this.Controls.Add(this.botonLog);
            this.Controls.Add(this.botonMCM);
            this.Controls.Add(this.botonPotencia);
            this.Controls.Add(this.botonPorciento);
            this.Controls.Add(this.botonMR);
            this.Controls.Add(this.botonMmenos);
            this.Controls.Add(this.botonMC);
            this.Controls.Add(this.botonMmas);
            this.Controls.Add(this.botonpunto);
            this.Controls.Add(this.boton0);
            this.Controls.Add(this.botonigual);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.botonraiz);
            this.Controls.Add(this.boton6);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.botonsuma);
            this.Controls.Add(this.boton9);
            this.Controls.Add(this.boton8);
            this.Controls.Add(this.boton7);
            this.Controls.Add(this.botonresta);
            this.Controls.Add(this.botonmult);
            this.Controls.Add(this.botondiv);
            this.Controls.Add(this.botonCE);
            this.Controls.Add(this.Pantalla);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button botonCE;
        private System.Windows.Forms.Button botondiv;
        private System.Windows.Forms.Button botonmult;
        private System.Windows.Forms.Button botonresta;
        private System.Windows.Forms.Button boton7;
        private System.Windows.Forms.Button boton8;
        private System.Windows.Forms.Button boton9;
        private System.Windows.Forms.Button botonsuma;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button boton5;
        private System.Windows.Forms.Button boton6;
        private System.Windows.Forms.Button botonraiz;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button botonigual;
        private System.Windows.Forms.Button boton0;
        private System.Windows.Forms.Button botonpunto;
        private System.Windows.Forms.Button botonMmas;
        private System.Windows.Forms.Button botonMC;
        private System.Windows.Forms.Button botonMmenos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button botonMR;
        private System.Windows.Forms.Button botonPorciento;
        private System.Windows.Forms.Button botonPotencia;
        private System.Windows.Forms.Button botonMCM;
        private System.Windows.Forms.Button botonLog;
        private System.Windows.Forms.Button botonMCD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeCalculadoraToolStripMenuItem;
    }
}

