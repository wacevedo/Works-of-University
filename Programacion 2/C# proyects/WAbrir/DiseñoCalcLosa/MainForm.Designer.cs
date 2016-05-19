namespace WAbrir
{
    partial class WForm
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
            this.rectangleMain = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleTitulo = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttSalir = new System.Windows.Forms.Button();
            this.buttMini = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttMax = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rectangleMain
            // 
            this.rectangleMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleMain.FillColor = System.Drawing.Color.CadetBlue;
            this.rectangleMain.FillGradientColor = System.Drawing.Color.LightGreen;
            this.rectangleMain.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical;
            this.rectangleMain.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleMain.Location = new System.Drawing.Point(7, 33);
            this.rectangleMain.Name = "rectangleMain";
            this.rectangleMain.Size = new System.Drawing.Size(772, 417);
            // 
            // rectangleTitulo
            // 
            this.rectangleTitulo.FillColor = System.Drawing.Color.CadetBlue;
            this.rectangleTitulo.FillGradientColor = System.Drawing.Color.LightGreen;
            this.rectangleTitulo.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleTitulo.Location = new System.Drawing.Point(7, 5);
            this.rectangleTitulo.Name = "rectangleTitulo";
            this.rectangleTitulo.SelectionColor = System.Drawing.Color.Transparent;
            this.rectangleTitulo.Size = new System.Drawing.Size(575, 25);
            this.rectangleTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rectangleTitulo_MouseDown);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.CadetBlue;
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTitulo.Location = new System.Drawing.Point(255, 10);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(36, 13);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Form1";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // buttSalir
            // 
            this.buttSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttSalir.BackColor = System.Drawing.Color.Tomato;
            this.buttSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttSalir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttSalir.Location = new System.Drawing.Point(746, 5);
            this.buttSalir.Name = "buttSalir";
            this.buttSalir.Size = new System.Drawing.Size(34, 26);
            this.buttSalir.TabIndex = 2;
            this.buttSalir.Text = "X";
            this.buttSalir.UseVisualStyleBackColor = false;
            this.buttSalir.Click += new System.EventHandler(this.buttSalir_Click);
            // 
            // buttMini
            // 
            this.buttMini.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttMini.BackColor = System.Drawing.Color.CadetBlue;
            this.buttMini.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttMini.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttMini.Location = new System.Drawing.Point(670, 5);
            this.buttMini.Name = "buttMini";
            this.buttMini.Size = new System.Drawing.Size(34, 26);
            this.buttMini.TabIndex = 3;
            this.buttMini.Text = "_";
            this.buttMini.UseVisualStyleBackColor = false;
            this.buttMini.Click += new System.EventHandler(this.buttMini_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttMax);
            this.panel1.Controls.Add(this.buttSalir);
            this.panel1.Controls.Add(this.buttMini);
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 458);
            this.panel1.TabIndex = 4;
            // 
            // buttMax
            // 
            this.buttMax.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttMax.BackColor = System.Drawing.Color.CadetBlue;
            this.buttMax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttMax.Font = new System.Drawing.Font("Wingdings 2", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttMax.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttMax.Location = new System.Drawing.Point(708, 5);
            this.buttMax.Name = "buttMax";
            this.buttMax.Size = new System.Drawing.Size(34, 26);
            this.buttMax.TabIndex = 4;
            this.buttMax.Text = "¢";
            this.buttMax.UseVisualStyleBackColor = false;
            this.buttMax.Click += new System.EventHandler(this.buttMax_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape1,
            this.rectangleTitulo,
            this.rectangleMain});
            this.shapeContainer2.Size = new System.Drawing.Size(785, 458);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(24, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ù";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackColor = System.Drawing.Color.Teal;
            this.ovalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape1.FillColor = System.Drawing.Color.DarkGreen;
            this.ovalShape1.FillGradientColor = System.Drawing.Color.Lime;
            this.ovalShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central;
            this.ovalShape1.Location = new System.Drawing.Point(67, 50);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(38, 34);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(75, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ù";
            // 
            // WForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 458);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        public Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleMain;
        public Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleTitulo;
        public System.Windows.Forms.Label labelTitulo;
        public System.Windows.Forms.Button buttSalir;
        public System.Windows.Forms.Button buttMini;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button buttMax;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
    }
}

