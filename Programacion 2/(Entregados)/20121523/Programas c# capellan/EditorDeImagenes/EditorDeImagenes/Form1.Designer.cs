namespace EditorDeImagenes
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
            this.Pantalla = new System.Windows.Forms.PictureBox();
            this.trackBarC = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarS = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Vertical = new System.Windows.Forms.Button();
            this.Horizontal = new System.Windows.Forms.Button();
            this.RotarIzq = new System.Windows.Forms.Button();
            this.RotarDer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCortar = new System.Windows.Forms.Button();
            this.mnuBrightness = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox4 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.Pantalla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarS)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pantalla.Location = new System.Drawing.Point(25, 15);
            this.Pantalla.Margin = new System.Windows.Forms.Padding(2);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(580, 337);
            this.Pantalla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pantalla.TabIndex = 0;
            this.Pantalla.TabStop = false;
            this.Pantalla.DragDrop += new System.Windows.Forms.DragEventHandler(this.Pantalla_DragDrop);
            this.Pantalla.DragEnter += new System.Windows.Forms.DragEventHandler(this.Pantalla_DragEnter);
            this.Pantalla.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pantalla_MouseClick);
            this.Pantalla.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.Pantalla.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.Pantalla.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // trackBarC
            // 
            this.trackBarC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBarC.AutoSize = false;
            this.trackBarC.Location = new System.Drawing.Point(785, 106);
            this.trackBarC.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarC.Maximum = 15;
            this.trackBarC.Minimum = -15;
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.Size = new System.Drawing.Size(128, 23);
            this.trackBarC.TabIndex = 3;
            this.trackBarC.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Pantalla);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(9, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 357);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Texto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBarB
            // 
            this.trackBarB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBarB.AutoSize = false;
            this.trackBarB.Location = new System.Drawing.Point(785, 78);
            this.trackBarB.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarB.Maximum = 5;
            this.trackBarB.Minimum = -5;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(128, 24);
            this.trackBarB.TabIndex = 5;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBarS
            // 
            this.trackBarS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBarS.AutoSize = false;
            this.trackBarS.Location = new System.Drawing.Point(785, 133);
            this.trackBarS.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarS.Maximum = 35;
            this.trackBarS.Minimum = -35;
            this.trackBarS.Name = "trackBarS";
            this.trackBarS.Size = new System.Drawing.Size(128, 24);
            this.trackBarS.TabIndex = 6;
            this.trackBarS.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Brillo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(729, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraste";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(723, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Saturacion";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.toolStripSeparator1,
            this.cerrarToolStripMenuItem,
            this.restaurarImagenToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // restaurarImagenToolStripMenuItem
            // 
            this.restaurarImagenToolStripMenuItem.Name = "restaurarImagenToolStripMenuItem";
            this.restaurarImagenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.restaurarImagenToolStripMenuItem.Text = "Restaurar Imagen";
            this.restaurarImagenToolStripMenuItem.Click += new System.EventHandler(this.restaurarImagenToolStripMenuItem_Click);
            // 
            // Vertical
            // 
            this.Vertical.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Vertical.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Vertical.Location = new System.Drawing.Point(813, 230);
            this.Vertical.Margin = new System.Windows.Forms.Padding(2);
            this.Vertical.Name = "Vertical";
            this.Vertical.Size = new System.Drawing.Size(56, 19);
            this.Vertical.TabIndex = 25;
            this.Vertical.Text = "Vert";
            this.Vertical.UseVisualStyleBackColor = true;
            this.Vertical.Click += new System.EventHandler(this.Vertical_Click);
            // 
            // Horizontal
            // 
            this.Horizontal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Horizontal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Horizontal.Location = new System.Drawing.Point(752, 230);
            this.Horizontal.Margin = new System.Windows.Forms.Padding(2);
            this.Horizontal.Name = "Horizontal";
            this.Horizontal.Size = new System.Drawing.Size(56, 19);
            this.Horizontal.TabIndex = 24;
            this.Horizontal.Text = "Horiz";
            this.Horizontal.UseVisualStyleBackColor = true;
            this.Horizontal.Click += new System.EventHandler(this.Horizontal_Click);
            // 
            // RotarIzq
            // 
            this.RotarIzq.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RotarIzq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RotarIzq.Location = new System.Drawing.Point(813, 187);
            this.RotarIzq.Margin = new System.Windows.Forms.Padding(2);
            this.RotarIzq.Name = "RotarIzq";
            this.RotarIzq.Size = new System.Drawing.Size(66, 38);
            this.RotarIzq.TabIndex = 23;
            this.RotarIzq.Text = "Rotar Izquierda";
            this.RotarIzq.UseVisualStyleBackColor = true;
            this.RotarIzq.Click += new System.EventHandler(this.RotarIzq_Click);
            // 
            // RotarDer
            // 
            this.RotarDer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RotarDer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RotarDer.Location = new System.Drawing.Point(742, 187);
            this.RotarDer.Margin = new System.Windows.Forms.Padding(2);
            this.RotarDer.Name = "RotarDer";
            this.RotarDer.Size = new System.Drawing.Size(66, 38);
            this.RotarDer.TabIndex = 22;
            this.RotarDer.Text = "Rotar Derecha";
            this.RotarDer.UseVisualStyleBackColor = true;
            this.RotarDer.Click += new System.EventHandler(this.RotarDer_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.Location = new System.Drawing.Point(813, 275);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 27;
            this.button3.Text = "Zoom -";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(755, 275);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 26;
            this.button2.Text = "Zoom +";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCortar
            // 
            this.buttonCortar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCortar.Location = new System.Drawing.Point(815, 318);
            this.buttonCortar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCortar.Name = "buttonCortar";
            this.buttonCortar.Size = new System.Drawing.Size(56, 19);
            this.buttonCortar.TabIndex = 29;
            this.buttonCortar.Text = "Recortar";
            this.buttonCortar.UseVisualStyleBackColor = true;
            this.buttonCortar.Click += new System.EventHandler(this.buttonCortar_Click);
            // 
            // mnuBrightness
            // 
            this.mnuBrightness.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mnuBrightness.Location = new System.Drawing.Point(737, 318);
            this.mnuBrightness.Margin = new System.Windows.Forms.Padding(2);
            this.mnuBrightness.Name = "mnuBrightness";
            this.mnuBrightness.Size = new System.Drawing.Size(74, 19);
            this.mnuBrightness.TabIndex = 28;
            this.mnuBrightness.Text = "Seleccionar";
            this.mnuBrightness.UseVisualStyleBackColor = true;
            this.mnuBrightness.Click += new System.EventHandler(this.btnMakeSelection_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripComboBox1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(234, 25);
            this.toolStrip2.TabIndex = 31;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(99, 22);
            this.toolStripLabel2.Text = "Sombra de Texto:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "NW",
            "NE",
            "N",
            "S",
            "E",
            "W",
            "SE",
            "SW",
            "None"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.Text = "SE";
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripTextBox2,
            this.toolStripLabel4,
            this.toolStripComboBox2,
            this.toolStripLabel5,
            this.toolStripComboBox3,
            this.toolStripLabel6,
            this.toolStripComboBox4,
            this.toolStripButton7,
            this.toolStripButton8});
            this.toolStrip3.Location = new System.Drawing.Point(0, 49);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(957, 25);
            this.toolStrip3.TabIndex = 32;
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(89, 22);
            this.toolStripLabel3.Text = "Texto a Dibujar:";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox2.ToolTipText = "Digite aqui el Texto que desea colocar en pantalla";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(109, 22);
            this.toolStripLabel4.Text = "Nombre de Fuente:";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox2.ToolTipText = "Fuentes Disponibles";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(106, 22);
            this.toolStripLabel5.Text = "Tamaño de Fuente";
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "28",
            "36",
            "48",
            "72"});
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox3.Text = "12";
            this.toolStripComboBox3.ToolTipText = "Elegir Tamaño de Fuente";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel6.Text = "Estilo de Fuente:";
            // 
            // toolStripComboBox4
            // 
            this.toolStripComboBox4.Items.AddRange(new object[] {
            "Bold",
            "Italic",
            "Underline",
            "Regular",
            "Strikeout"});
            this.toolStripComboBox4.Name = "toolStripComboBox4";
            this.toolStripComboBox4.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox4.Text = "Regular";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Colocar Texto";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Apply";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 442);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.buttonCortar);
            this.Controls.Add(this.mnuBrightness);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Vertical);
            this.Controls.Add(this.Horizontal);
            this.Controls.Add(this.RotarIzq);
            this.Controls.Add(this.RotarDer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarS);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBarC);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "El ImageNator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pantalla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarS)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pantalla;
        private System.Windows.Forms.TrackBar trackBarC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Button Vertical;
        private System.Windows.Forms.Button Horizontal;
        private System.Windows.Forms.Button RotarIzq;
        private System.Windows.Forms.Button RotarDer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button buttonCortar;
        private System.Windows.Forms.Button mnuBrightness;
        private System.Windows.Forms.ToolStripMenuItem restaurarImagenToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox4;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
    }
}

