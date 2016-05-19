namespace CalculadoraHablante
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
            this.resultado = new System.Windows.Forms.TextBox();
            this.boton0 = new System.Windows.Forms.Button();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton8 = new System.Windows.Forms.Button();
            this.boton9 = new System.Windows.Forms.Button();
            this.boton5 = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.boton6 = new System.Windows.Forms.Button();
            this.boton7 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.botonigual = new System.Windows.Forms.Button();
            this.botonpor = new System.Windows.Forms.Button();
            this.botonCE = new System.Windows.Forms.Button();
            this.botondiv = new System.Windows.Forms.Button();
            this.botonmenos = new System.Windows.Forms.Button();
            this.botonmas = new System.Windows.Forms.Button();
            this.botonpunto = new System.Windows.Forms.Button();
            this.botonraiz = new System.Windows.Forms.Button();
            this.MCM = new System.Windows.Forms.Button();
            this.MCD = new System.Windows.Forms.Button();
            this.PotenciaXY = new System.Windows.Forms.Button();
            this.BotonLog10 = new System.Windows.Forms.Button();
            this.botonNegativo = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonPorciento = new System.Windows.Forms.Button();
            this.buttonMmenos = new System.Windows.Forms.Button();
            this.buttonMmas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.SystemColors.Window;
            this.resultado.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(17, 15);
            this.resultado.Margin = new System.Windows.Forms.Padding(4);
            this.resultado.Multiline = true;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(297, 45);
            this.resultado.TabIndex = 0;
            this.resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boton0
            // 
            this.boton0.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton0.Location = new System.Drawing.Point(17, 328);
            this.boton0.Margin = new System.Windows.Forms.Padding(4);
            this.boton0.Name = "boton0";
            this.boton0.Size = new System.Drawing.Size(111, 42);
            this.boton0.TabIndex = 1;
            this.boton0.Text = "0";
            this.boton0.UseVisualStyleBackColor = true;
            this.boton0.Click += new System.EventHandler(this.boton0_Click);
            // 
            // boton1
            // 
            this.boton1.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.Location = new System.Drawing.Point(17, 276);
            this.boton1.Margin = new System.Windows.Forms.Padding(4);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(53, 44);
            this.boton1.TabIndex = 2;
            this.boton1.Text = "1";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.button2_Click);
            // 
            // boton8
            // 
            this.boton8.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton8.Location = new System.Drawing.Point(75, 173);
            this.boton8.Margin = new System.Windows.Forms.Padding(4);
            this.boton8.Name = "boton8";
            this.boton8.Size = new System.Drawing.Size(53, 44);
            this.boton8.TabIndex = 3;
            this.boton8.Text = "8";
            this.boton8.UseVisualStyleBackColor = true;
            this.boton8.Click += new System.EventHandler(this.boton8_Click);
            // 
            // boton9
            // 
            this.boton9.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton9.Location = new System.Drawing.Point(133, 173);
            this.boton9.Margin = new System.Windows.Forms.Padding(4);
            this.boton9.Name = "boton9";
            this.boton9.Size = new System.Drawing.Size(53, 44);
            this.boton9.TabIndex = 4;
            this.boton9.Text = "9";
            this.boton9.UseVisualStyleBackColor = true;
            this.boton9.Click += new System.EventHandler(this.boton9_Click);
            // 
            // boton5
            // 
            this.boton5.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton5.Location = new System.Drawing.Point(75, 224);
            this.boton5.Margin = new System.Windows.Forms.Padding(4);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(53, 44);
            this.boton5.TabIndex = 5;
            this.boton5.Text = "5";
            this.boton5.UseVisualStyleBackColor = true;
            this.boton5.Click += new System.EventHandler(this.boton5_Click);
            // 
            // boton4
            // 
            this.boton4.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton4.Location = new System.Drawing.Point(17, 224);
            this.boton4.Margin = new System.Windows.Forms.Padding(4);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(53, 44);
            this.boton4.TabIndex = 6;
            this.boton4.Text = "4";
            this.boton4.UseVisualStyleBackColor = true;
            this.boton4.Click += new System.EventHandler(this.button6_Click);
            // 
            // boton6
            // 
            this.boton6.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton6.Location = new System.Drawing.Point(133, 224);
            this.boton6.Margin = new System.Windows.Forms.Padding(4);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(53, 44);
            this.boton6.TabIndex = 7;
            this.boton6.Text = "6";
            this.boton6.UseVisualStyleBackColor = true;
            this.boton6.Click += new System.EventHandler(this.boton6_Click);
            // 
            // boton7
            // 
            this.boton7.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton7.Location = new System.Drawing.Point(17, 173);
            this.boton7.Margin = new System.Windows.Forms.Padding(4);
            this.boton7.Name = "boton7";
            this.boton7.Size = new System.Drawing.Size(53, 44);
            this.boton7.TabIndex = 8;
            this.boton7.Text = "7";
            this.boton7.UseVisualStyleBackColor = true;
            this.boton7.Click += new System.EventHandler(this.boton7_Click);
            // 
            // boton2
            // 
            this.boton2.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.Location = new System.Drawing.Point(75, 276);
            this.boton2.Margin = new System.Windows.Forms.Padding(4);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(53, 44);
            this.boton2.TabIndex = 9;
            this.boton2.Text = "2";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.button9_Click);
            // 
            // boton3
            // 
            this.boton3.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton3.Location = new System.Drawing.Point(133, 276);
            this.boton3.Margin = new System.Windows.Forms.Padding(4);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(53, 44);
            this.boton3.TabIndex = 10;
            this.boton3.Text = "3";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // botonigual
            // 
            this.botonigual.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonigual.Location = new System.Drawing.Point(249, 225);
            this.botonigual.Margin = new System.Windows.Forms.Padding(4);
            this.botonigual.Name = "botonigual";
            this.botonigual.Size = new System.Drawing.Size(65, 145);
            this.botonigual.TabIndex = 11;
            this.botonigual.Text = "=";
            this.botonigual.UseVisualStyleBackColor = true;
            this.botonigual.Click += new System.EventHandler(this.botonigual_Click);
            // 
            // botonpor
            // 
            this.botonpor.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonpor.Location = new System.Drawing.Point(192, 224);
            this.botonpor.Margin = new System.Windows.Forms.Padding(4);
            this.botonpor.Name = "botonpor";
            this.botonpor.Size = new System.Drawing.Size(51, 44);
            this.botonpor.TabIndex = 12;
            this.botonpor.Text = "*";
            this.botonpor.UseVisualStyleBackColor = true;
            this.botonpor.Click += new System.EventHandler(this.botonpor_Click);
            // 
            // botonCE
            // 
            this.botonCE.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCE.Location = new System.Drawing.Point(17, 125);
            this.botonCE.Margin = new System.Windows.Forms.Padding(4);
            this.botonCE.Name = "botonCE";
            this.botonCE.Size = new System.Drawing.Size(53, 44);
            this.botonCE.TabIndex = 13;
            this.botonCE.Text = "CE";
            this.botonCE.UseVisualStyleBackColor = true;
            this.botonCE.Click += new System.EventHandler(this.botonCE_Click);
            // 
            // botondiv
            // 
            this.botondiv.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botondiv.Location = new System.Drawing.Point(191, 173);
            this.botondiv.Margin = new System.Windows.Forms.Padding(4);
            this.botondiv.Name = "botondiv";
            this.botondiv.Size = new System.Drawing.Size(51, 44);
            this.botondiv.TabIndex = 15;
            this.botondiv.Text = "/";
            this.botondiv.UseVisualStyleBackColor = true;
            this.botondiv.Click += new System.EventHandler(this.botondiv_Click);
            // 
            // botonmenos
            // 
            this.botonmenos.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonmenos.Location = new System.Drawing.Point(192, 276);
            this.botonmenos.Margin = new System.Windows.Forms.Padding(4);
            this.botonmenos.Name = "botonmenos";
            this.botonmenos.Size = new System.Drawing.Size(51, 44);
            this.botonmenos.TabIndex = 16;
            this.botonmenos.Text = "-";
            this.botonmenos.UseVisualStyleBackColor = true;
            this.botonmenos.Click += new System.EventHandler(this.botonmenos_Click);
            // 
            // botonmas
            // 
            this.botonmas.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonmas.Location = new System.Drawing.Point(192, 328);
            this.botonmas.Margin = new System.Windows.Forms.Padding(4);
            this.botonmas.Name = "botonmas";
            this.botonmas.Size = new System.Drawing.Size(51, 42);
            this.botonmas.TabIndex = 17;
            this.botonmas.Text = "+";
            this.botonmas.UseVisualStyleBackColor = true;
            this.botonmas.Click += new System.EventHandler(this.botonmas_Click);
            // 
            // botonpunto
            // 
            this.botonpunto.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonpunto.Location = new System.Drawing.Point(133, 328);
            this.botonpunto.Margin = new System.Windows.Forms.Padding(4);
            this.botonpunto.Name = "botonpunto";
            this.botonpunto.Size = new System.Drawing.Size(53, 42);
            this.botonpunto.TabIndex = 18;
            this.botonpunto.Text = ".";
            this.botonpunto.UseVisualStyleBackColor = true;
            this.botonpunto.Click += new System.EventHandler(this.botonpunto_Click);
            // 
            // botonraiz
            // 
            this.botonraiz.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonraiz.Location = new System.Drawing.Point(133, 125);
            this.botonraiz.Margin = new System.Windows.Forms.Padding(4);
            this.botonraiz.Name = "botonraiz";
            this.botonraiz.Size = new System.Drawing.Size(53, 44);
            this.botonraiz.TabIndex = 19;
            this.botonraiz.Text = "√";
            this.botonraiz.UseVisualStyleBackColor = true;
            this.botonraiz.Click += new System.EventHandler(this.botonraiz_Click_1);
            // 
            // MCM
            // 
            this.MCM.Font = new System.Drawing.Font("Snap ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCM.Location = new System.Drawing.Point(75, 77);
            this.MCM.Margin = new System.Windows.Forms.Padding(4);
            this.MCM.Name = "MCM";
            this.MCM.Size = new System.Drawing.Size(61, 44);
            this.MCM.TabIndex = 20;
            this.MCM.Text = "MCM";
            this.MCM.UseVisualStyleBackColor = true;
            this.MCM.Click += new System.EventHandler(this.MCM_Click);
            // 
            // MCD
            // 
            this.MCD.Font = new System.Drawing.Font("Snap ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCD.Location = new System.Drawing.Point(17, 77);
            this.MCD.Margin = new System.Windows.Forms.Padding(4);
            this.MCD.Name = "MCD";
            this.MCD.Size = new System.Drawing.Size(53, 44);
            this.MCD.TabIndex = 21;
            this.MCD.Text = "MCD";
            this.MCD.UseVisualStyleBackColor = true;
            this.MCD.Click += new System.EventHandler(this.MCD_Click);
            // 
            // PotenciaXY
            // 
            this.PotenciaXY.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotenciaXY.Location = new System.Drawing.Point(191, 125);
            this.PotenciaXY.Margin = new System.Windows.Forms.Padding(4);
            this.PotenciaXY.Name = "PotenciaXY";
            this.PotenciaXY.Size = new System.Drawing.Size(51, 44);
            this.PotenciaXY.TabIndex = 22;
            this.PotenciaXY.Text = "^";
            this.PotenciaXY.UseVisualStyleBackColor = true;
            this.PotenciaXY.Click += new System.EventHandler(this.PotenciaXY_Click);
            // 
            // BotonLog10
            // 
            this.BotonLog10.Font = new System.Drawing.Font("Snap ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonLog10.Location = new System.Drawing.Point(250, 173);
            this.BotonLog10.Margin = new System.Windows.Forms.Padding(4);
            this.BotonLog10.Name = "BotonLog10";
            this.BotonLog10.Size = new System.Drawing.Size(65, 44);
            this.BotonLog10.TabIndex = 23;
            this.BotonLog10.Text = "Log10";
            this.BotonLog10.UseVisualStyleBackColor = true;
            this.BotonLog10.Click += new System.EventHandler(this.BotonLog10_Click);
            // 
            // botonNegativo
            // 
            this.botonNegativo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonNegativo.Location = new System.Drawing.Point(75, 125);
            this.botonNegativo.Margin = new System.Windows.Forms.Padding(4);
            this.botonNegativo.Name = "botonNegativo";
            this.botonNegativo.Size = new System.Drawing.Size(53, 44);
            this.botonNegativo.TabIndex = 24;
            this.botonNegativo.Text = "(-)";
            this.botonNegativo.UseVisualStyleBackColor = true;
            this.botonNegativo.Click += new System.EventHandler(this.botonNegativo_Click);
            // 
            // buttonM
            // 
            this.buttonM.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM.Location = new System.Drawing.Point(144, 77);
            this.buttonM.Margin = new System.Windows.Forms.Padding(4);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(42, 44);
            this.buttonM.TabIndex = 25;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // buttonPorciento
            // 
            this.buttonPorciento.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPorciento.Location = new System.Drawing.Point(249, 125);
            this.buttonPorciento.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPorciento.Name = "buttonPorciento";
            this.buttonPorciento.Size = new System.Drawing.Size(65, 44);
            this.buttonPorciento.TabIndex = 26;
            this.buttonPorciento.Text = "%";
            this.buttonPorciento.UseVisualStyleBackColor = true;
            this.buttonPorciento.Click += new System.EventHandler(this.buttonPorciento_Click);
            // 
            // buttonMmenos
            // 
            this.buttonMmenos.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMmenos.Location = new System.Drawing.Point(192, 77);
            this.buttonMmenos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMmenos.Name = "buttonMmenos";
            this.buttonMmenos.Size = new System.Drawing.Size(52, 44);
            this.buttonMmenos.TabIndex = 27;
            this.buttonMmenos.Text = "M-";
            this.buttonMmenos.UseVisualStyleBackColor = true;
            this.buttonMmenos.Click += new System.EventHandler(this.buttonMmenos_Click);
            // 
            // buttonMmas
            // 
            this.buttonMmas.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMmas.Location = new System.Drawing.Point(252, 77);
            this.buttonMmas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMmas.Name = "buttonMmas";
            this.buttonMmas.Size = new System.Drawing.Size(63, 44);
            this.buttonMmas.TabIndex = 28;
            this.buttonMmas.Text = "M+";
            this.buttonMmas.UseVisualStyleBackColor = true;
            this.buttonMmas.Click += new System.EventHandler(this.buttonMmas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 385);
            this.Controls.Add(this.buttonMmas);
            this.Controls.Add(this.buttonMmenos);
            this.Controls.Add(this.buttonPorciento);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.botonNegativo);
            this.Controls.Add(this.BotonLog10);
            this.Controls.Add(this.PotenciaXY);
            this.Controls.Add(this.MCD);
            this.Controls.Add(this.MCM);
            this.Controls.Add(this.botonraiz);
            this.Controls.Add(this.botonpunto);
            this.Controls.Add(this.botonmas);
            this.Controls.Add(this.botonmenos);
            this.Controls.Add(this.botondiv);
            this.Controls.Add(this.botonCE);
            this.Controls.Add(this.botonpor);
            this.Controls.Add(this.botonigual);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton7);
            this.Controls.Add(this.boton6);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.boton9);
            this.Controls.Add(this.boton8);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.boton0);
            this.Controls.Add(this.resultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora Hablante";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button boton0;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton8;
        private System.Windows.Forms.Button boton9;
        private System.Windows.Forms.Button boton5;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button boton6;
        private System.Windows.Forms.Button boton7;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button botonigual;
        private System.Windows.Forms.Button botonpor;
        private System.Windows.Forms.Button botonCE;
        private System.Windows.Forms.Button botondiv;
        private System.Windows.Forms.Button botonmenos;
        private System.Windows.Forms.Button botonmas;
        private System.Windows.Forms.Button botonpunto;
        private System.Windows.Forms.Button botonraiz;
        private System.Windows.Forms.Button MCM;
        private System.Windows.Forms.Button MCD;
        private System.Windows.Forms.Button PotenciaXY;
        private System.Windows.Forms.Button BotonLog10;
        private System.Windows.Forms.Button botonNegativo;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonPorciento;
        private System.Windows.Forms.Button buttonMmenos;
        private System.Windows.Forms.Button buttonMmas;
    }
}

