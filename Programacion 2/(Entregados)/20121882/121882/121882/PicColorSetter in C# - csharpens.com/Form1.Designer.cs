namespace PicColorSetter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SavePicBtn = new System.Windows.Forms.Button();
            this.SelectedColor = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BrightnessSelection = new System.Windows.Forms.HScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.BlueSelection = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.GreenSelection = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.RedSelection = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picToned = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Horizontal = new System.Windows.Forms.Button();
            this.Vertical = new System.Windows.Forms.Button();
            this.Izquierda = new System.Windows.Forms.Button();
            this.Derecha = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedColor)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picToned)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // SavePicBtn
            // 
            this.SavePicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePicBtn.Location = new System.Drawing.Point(592, 38);
            this.SavePicBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SavePicBtn.Name = "SavePicBtn";
            this.SavePicBtn.Size = new System.Drawing.Size(84, 29);
            this.SavePicBtn.TabIndex = 8;
            this.SavePicBtn.Text = "Guardar";
            this.SavePicBtn.UseVisualStyleBackColor = true;
            this.SavePicBtn.Click += new System.EventHandler(this.SavePicBtn_Click);
            // 
            // SelectedColor
            // 
            this.SelectedColor.BackColor = System.Drawing.Color.LightBlue;
            this.SelectedColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SelectedColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectedColor.Location = new System.Drawing.Point(368, 15);
            this.SelectedColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SelectedColor.Name = "SelectedColor";
            this.SelectedColor.Size = new System.Drawing.Size(50, 68);
            this.SelectedColor.TabIndex = 7;
            this.SelectedColor.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SelectedColor);
            this.groupBox3.Controls.Add(this.BrightnessSelection);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.BlueSelection);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.GreenSelection);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.RedSelection);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(7, 340);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(424, 90);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Colores";
            // 
            // BrightnessSelection
            // 
            this.BrightnessSelection.Location = new System.Drawing.Point(62, 71);
            this.BrightnessSelection.Maximum = 264;
            this.BrightnessSelection.Name = "BrightnessSelection";
            this.BrightnessSelection.Size = new System.Drawing.Size(296, 14);
            this.BrightnessSelection.TabIndex = 21;
            this.BrightnessSelection.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrColorComponent_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Brillo:";
            // 
            // BlueSelection
            // 
            this.BlueSelection.Location = new System.Drawing.Point(62, 54);
            this.BlueSelection.Maximum = 264;
            this.BlueSelection.Name = "BlueSelection";
            this.BlueSelection.Size = new System.Drawing.Size(296, 14);
            this.BlueSelection.TabIndex = 19;
            this.BlueSelection.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrColorComponent_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Azul:";
            // 
            // GreenSelection
            // 
            this.GreenSelection.Location = new System.Drawing.Point(62, 35);
            this.GreenSelection.Maximum = 264;
            this.GreenSelection.Name = "GreenSelection";
            this.GreenSelection.Size = new System.Drawing.Size(296, 14);
            this.GreenSelection.TabIndex = 17;
            this.GreenSelection.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrColorComponent_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Verde:";
            // 
            // RedSelection
            // 
            this.RedSelection.Location = new System.Drawing.Point(62, 16);
            this.RedSelection.Maximum = 264;
            this.RedSelection.Name = "RedSelection";
            this.RedSelection.Size = new System.Drawing.Size(296, 14);
            this.RedSelection.TabIndex = 15;
            this.RedSelection.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrColorComponent_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rojo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picToned);
            this.groupBox2.Location = new System.Drawing.Point(301, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(284, 333);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Despues";
            // 
            // picToned
            // 
            this.picToned.Location = new System.Drawing.Point(10, 17);
            this.picToned.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picToned.Name = "picToned";
            this.picToned.Size = new System.Drawing.Size(262, 306);
            this.picToned.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picToned.TabIndex = 5;
            this.picToned.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picOriginal);
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(286, 333);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Antes";
            // 
            // picOriginal
            // 
            this.picOriginal.Image = ((System.Drawing.Image)(resources.GetObject("picOriginal.Image")));
            this.picOriginal.InitialImage = ((System.Drawing.Image)(resources.GetObject("picOriginal.InitialImage")));
            this.picOriginal.Location = new System.Drawing.Point(12, 16);
            this.picOriginal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(262, 306);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginal.TabIndex = 4;
            this.picOriginal.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(591, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 27;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Horizontal
            // 
            this.Horizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Horizontal.AutoSize = true;
            this.Horizontal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Horizontal.Location = new System.Drawing.Point(99, 56);
            this.Horizontal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Horizontal.Name = "Horizontal";
            this.Horizontal.Size = new System.Drawing.Size(74, 29);
            this.Horizontal.TabIndex = 31;
            this.Horizontal.Text = "Horizontal";
            this.Horizontal.UseVisualStyleBackColor = true;
            this.Horizontal.Click += new System.EventHandler(this.Horizontal_Click);
            // 
            // Vertical
            // 
            this.Vertical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Vertical.AutoSize = true;
            this.Vertical.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vertical.Location = new System.Drawing.Point(13, 56);
            this.Vertical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vertical.Name = "Vertical";
            this.Vertical.Size = new System.Drawing.Size(69, 29);
            this.Vertical.TabIndex = 30;
            this.Vertical.Text = "Vertical";
            this.Vertical.UseVisualStyleBackColor = true;
            this.Vertical.Click += new System.EventHandler(this.Vertical_Click);
            // 
            // Izquierda
            // 
            this.Izquierda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Izquierda.AutoSize = true;
            this.Izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Izquierda.Location = new System.Drawing.Point(13, 18);
            this.Izquierda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Izquierda.Name = "Izquierda";
            this.Izquierda.Size = new System.Drawing.Size(69, 29);
            this.Izquierda.TabIndex = 29;
            this.Izquierda.Text = "Izquierda";
            this.Izquierda.UseVisualStyleBackColor = true;
            this.Izquierda.Click += new System.EventHandler(this.Izquierda_Click);
            // 
            // Derecha
            // 
            this.Derecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Derecha.AutoSize = true;
            this.Derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Derecha.Location = new System.Drawing.Point(99, 18);
            this.Derecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Derecha.Name = "Derecha";
            this.Derecha.Size = new System.Drawing.Size(74, 29);
            this.Derecha.TabIndex = 28;
            this.Derecha.Text = "Derecha";
            this.Derecha.UseVisualStyleBackColor = true;
            this.Derecha.Click += new System.EventHandler(this.Derecha_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Horizontal);
            this.groupBox4.Controls.Add(this.Derecha);
            this.groupBox4.Controls.Add(this.Vertical);
            this.groupBox4.Controls.Add(this.Izquierda);
            this.groupBox4.Location = new System.Drawing.Point(438, 340);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 90);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Girar";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(591, 218);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 33;
            this.button2.Text = "Restablecer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(681, 437);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SavePicBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pic Color Setter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedColor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picToned)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SavePicBtn;
        private System.Windows.Forms.PictureBox SelectedColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.HScrollBar BrightnessSelection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HScrollBar BlueSelection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar GreenSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar RedSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picToned;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Horizontal;
        private System.Windows.Forms.Button Vertical;
        private System.Windows.Forms.Button Izquierda;
        private System.Windows.Forms.Button Derecha;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;

    }
}

