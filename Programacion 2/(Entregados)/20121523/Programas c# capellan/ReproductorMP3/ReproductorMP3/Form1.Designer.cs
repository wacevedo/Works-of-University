namespace ReproductorMP3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.patras = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.palante = new System.Windows.Forms.Button();
            this.volumevalor = new System.Windows.Forms.TrackBar();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.abrir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonvol = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarColorDeFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPredeterminadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tracktiempo = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.volumevalor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracktiempo)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(218, 130);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 100);
            this.listBox1.TabIndex = 0;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // patras
            // 
            this.patras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patras.Image = ((System.Drawing.Image)(resources.GetObject("patras.Image")));
            this.patras.Location = new System.Drawing.Point(218, 48);
            this.patras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patras.Name = "patras";
            this.patras.Size = new System.Drawing.Size(44, 39);
            this.patras.TabIndex = 1;
            this.patras.UseVisualStyleBackColor = true;
            this.patras.Click += new System.EventHandler(this.patras_Click);
            // 
            // start
            // 
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(266, 48);
            this.start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(86, 39);
            this.start.TabIndex = 2;
            this.start.Text = "Play";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            this.start.MouseEnter += new System.EventHandler(this.start_MouseEnter);
            this.start.MouseLeave += new System.EventHandler(this.start_MouseLeave);
            // 
            // palante
            // 
            this.palante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.palante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.palante.Image = ((System.Drawing.Image)(resources.GetObject("palante.Image")));
            this.palante.Location = new System.Drawing.Point(356, 48);
            this.palante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.palante.Name = "palante";
            this.palante.Size = new System.Drawing.Size(45, 39);
            this.palante.TabIndex = 3;
            this.palante.UseVisualStyleBackColor = true;
            this.palante.Click += new System.EventHandler(this.palante_Click);
            // 
            // volumevalor
            // 
            this.volumevalor.AutoSize = false;
            this.volumevalor.BackColor = System.Drawing.SystemColors.Control;
            this.volumevalor.Location = new System.Drawing.Point(28, 195);
            this.volumevalor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.volumevalor.Maximum = 100;
            this.volumevalor.Name = "volumevalor";
            this.volumevalor.Size = new System.Drawing.Size(116, 22);
            this.volumevalor.TabIndex = 4;
            this.volumevalor.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 31);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(211, 199);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // abrir
            // 
            this.abrir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.abrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrir.Location = new System.Drawing.Point(9, 232);
            this.abrir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(53, 36);
            this.abrir.TabIndex = 6;
            this.abrir.Text = "Abrir";
            this.abrir.UseVisualStyleBackColor = true;
            this.abrir.Click += new System.EventHandler(this.abrir_Click);
            this.abrir.MouseEnter += new System.EventHandler(this.abrir_MouseEnter);
            this.abrir.MouseLeave += new System.EventHandler(this.abrir_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Canciones";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(300, 130);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(102, 108);
            this.listBox2.TabIndex = 8;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            this.openFile.Filter = "All Files (*.*)|*.*|MP3 File|*.mp3|WAV File|*.wav|MP4 File|*.mp4|AVI File|*.avi|X" +
                "ML Lista|*.xml";
            this.openFile.Multiselect = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonvol});
            this.toolStrip1.Location = new System.Drawing.Point(0, 195);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(213, 26);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonvol
            // 
            this.toolStripButtonvol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonvol.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonvol.Image")));
            this.toolStripButtonvol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonvol.Name = "toolStripButtonvol";
            this.toolStripButtonvol.Size = new System.Drawing.Size(23, 23);
            this.toolStripButtonvol.Text = "toolStripButton1";
            this.toolStripButtonvol.ToolTipText = "Volumen/Mute";
            this.toolStripButtonvol.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.edicionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(412, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.borrarListaToolStripMenuItem,
            this.muteToolStripMenuItem,
            this.toolStripSeparator1,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrir_Click);
            // 
            // borrarListaToolStripMenuItem
            // 
            this.borrarListaToolStripMenuItem.Name = "borrarListaToolStripMenuItem";
            this.borrarListaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.borrarListaToolStripMenuItem.Text = "Borrar Lista";
            this.borrarListaToolStripMenuItem.Click += new System.EventHandler(this.borrarListaToolStripMenuItem_Click);
            // 
            // muteToolStripMenuItem
            // 
            this.muteToolStripMenuItem.Name = "muteToolStripMenuItem";
            this.muteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.muteToolStripMenuItem.Text = "Mute/Reproducir";
            this.muteToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarColorDeFondoToolStripMenuItem,
            this.colorPredeterminadoToolStripMenuItem});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // cambiarColorDeFondoToolStripMenuItem
            // 
            this.cambiarColorDeFondoToolStripMenuItem.Name = "cambiarColorDeFondoToolStripMenuItem";
            this.cambiarColorDeFondoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.cambiarColorDeFondoToolStripMenuItem.Text = "Cambiar Color de Fondo";
            this.cambiarColorDeFondoToolStripMenuItem.Click += new System.EventHandler(this.cambiarColorDeFondoToolStripMenuItem_Click);
            // 
            // colorPredeterminadoToolStripMenuItem
            // 
            this.colorPredeterminadoToolStripMenuItem.Name = "colorPredeterminadoToolStripMenuItem";
            this.colorPredeterminadoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.colorPredeterminadoToolStripMenuItem.Text = "Color por Defecto";
            this.colorPredeterminadoToolStripMenuItem.Click += new System.EventHandler(this.colorPredeterminadoToolStripMenuItem_Click);
            // 
            // tracktiempo
            // 
            this.tracktiempo.AutoSize = false;
            this.tracktiempo.Location = new System.Drawing.Point(0, 176);
            this.tracktiempo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tracktiempo.Name = "tracktiempo";
            this.tracktiempo.Size = new System.Drawing.Size(213, 24);
            this.tracktiempo.TabIndex = 12;
            this.tracktiempo.Scroll += new System.EventHandler(this.tracktiempo_Scroll);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 11);
            this.label3.TabIndex = 14;
            // 
            // tiempo
            // 
            this.tiempo.Location = new System.Drawing.Point(146, 200);
            this.tiempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(65, 19);
            this.tiempo.TabIndex = 15;
            this.tiempo.Text = "label4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(325, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Crear Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(220, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Mostrar Favoritos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(201, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Añadir Favoritos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(412, 274);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tracktiempo);
            this.Controls.Add(this.volumevalor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abrir);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.palante);
            this.Controls.Add(this.start);
            this.Controls.Add(this.patras);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "SuperReproductor Evolution";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumevalor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracktiempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button patras;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button palante;
        private System.Windows.Forms.TrackBar volumevalor;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button abrir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonvol;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarColorDeFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorPredeterminadoToolStripMenuItem;
        private System.Windows.Forms.TrackBar tracktiempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tiempo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem borrarListaToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

