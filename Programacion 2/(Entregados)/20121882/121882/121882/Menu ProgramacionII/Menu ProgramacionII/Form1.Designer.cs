﻿namespace Menu_ProgramacionII
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
            this.buttonCalculadora = new System.Windows.Forms.Button();
            this.buttonEditorTexto = new System.Windows.Forms.Button();
            this.buttonNavegador = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalculadora
            // 
            this.buttonCalculadora.Location = new System.Drawing.Point(149, 98);
            this.buttonCalculadora.Name = "buttonCalculadora";
            this.buttonCalculadora.Size = new System.Drawing.Size(94, 41);
            this.buttonCalculadora.TabIndex = 0;
            this.buttonCalculadora.Text = "Calculadora";
            this.buttonCalculadora.UseVisualStyleBackColor = true;
            this.buttonCalculadora.Click += new System.EventHandler(this.buttonCalculadora_Click);
            // 
            // buttonEditorTexto
            // 
            this.buttonEditorTexto.Location = new System.Drawing.Point(149, 165);
            this.buttonEditorTexto.Name = "buttonEditorTexto";
            this.buttonEditorTexto.Size = new System.Drawing.Size(94, 41);
            this.buttonEditorTexto.TabIndex = 1;
            this.buttonEditorTexto.Text = "Editor Texto";
            this.buttonEditorTexto.UseVisualStyleBackColor = true;
            this.buttonEditorTexto.Click += new System.EventHandler(this.buttonEditorTexto_Click);
            // 
            // buttonNavegador
            // 
            this.buttonNavegador.Location = new System.Drawing.Point(149, 230);
            this.buttonNavegador.Name = "buttonNavegador";
            this.buttonNavegador.Size = new System.Drawing.Size(94, 41);
            this.buttonNavegador.TabIndex = 2;
            this.buttonNavegador.Text = "Navegador Web";
            this.buttonNavegador.UseVisualStyleBackColor = true;
            this.buttonNavegador.Click += new System.EventHandler(this.buttonNavegador_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(149, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Camara";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(149, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "Reproductor MP3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(149, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 41);
            this.button5.TabIndex = 5;
            this.button5.Text = "Editor Imagenes";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(295, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-123, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 559);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(396, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonNavegador);
            this.Controls.Add(this.buttonEditorTexto);
            this.Controls.Add(this.buttonCalculadora);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(406, 543);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal 2012-1882";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculadora;
        private System.Windows.Forms.Button buttonEditorTexto;
        private System.Windows.Forms.Button buttonNavegador;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

