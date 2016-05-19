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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Reproduccion = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonabrir = new System.Windows.Forms.Button();
            this.buttonsiguiente = new System.Windows.Forms.Button();
            this.buttonanterior = new System.Windows.Forms.Button();
            this.buttoncerrar = new System.Windows.Forms.Button();
            this.buttonplay = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.Favoritos = new System.Windows.Forms.ListBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(167, 66);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(359, 243);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // Reproduccion
            // 
            this.Reproduccion.FormattingEnabled = true;
            this.Reproduccion.Location = new System.Drawing.Point(532, 66);
            this.Reproduccion.Name = "Reproduccion";
            this.Reproduccion.Size = new System.Drawing.Size(195, 238);
            this.Reproduccion.TabIndex = 1;
            this.Reproduccion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonabrir
            // 
            this.buttonabrir.Location = new System.Drawing.Point(167, 37);
            this.buttonabrir.Name = "buttonabrir";
            this.buttonabrir.Size = new System.Drawing.Size(57, 23);
            this.buttonabrir.TabIndex = 2;
            this.buttonabrir.Text = "Abrir";
            this.buttonabrir.UseVisualStyleBackColor = true;
            this.buttonabrir.Click += new System.EventHandler(this.buttonabrir_Click);
            // 
            // buttonsiguiente
            // 
            this.buttonsiguiente.Location = new System.Drawing.Point(491, 375);
            this.buttonsiguiente.Name = "buttonsiguiente";
            this.buttonsiguiente.Size = new System.Drawing.Size(75, 23);
            this.buttonsiguiente.TabIndex = 3;
            this.buttonsiguiente.Text = "Siguiente";
            this.buttonsiguiente.UseVisualStyleBackColor = true;
            this.buttonsiguiente.Click += new System.EventHandler(this.buttonsiguiente_Click);
            // 
            // buttonanterior
            // 
            this.buttonanterior.Location = new System.Drawing.Point(311, 375);
            this.buttonanterior.Name = "buttonanterior";
            this.buttonanterior.Size = new System.Drawing.Size(75, 23);
            this.buttonanterior.TabIndex = 4;
            this.buttonanterior.Text = "Anterior";
            this.buttonanterior.UseVisualStyleBackColor = true;
            this.buttonanterior.Click += new System.EventHandler(this.buttonanterior_Click);
            // 
            // buttoncerrar
            // 
            this.buttoncerrar.Location = new System.Drawing.Point(469, 37);
            this.buttoncerrar.Name = "buttoncerrar";
            this.buttoncerrar.Size = new System.Drawing.Size(57, 23);
            this.buttoncerrar.TabIndex = 5;
            this.buttoncerrar.Text = "Cerrar";
            this.buttoncerrar.UseVisualStyleBackColor = true;
            this.buttoncerrar.Click += new System.EventHandler(this.buttoncerrar_Click);
            // 
            // buttonplay
            // 
            this.buttonplay.Location = new System.Drawing.Point(399, 366);
            this.buttonplay.Name = "buttonplay";
            this.buttonplay.Size = new System.Drawing.Size(78, 32);
            this.buttonplay.TabIndex = 6;
            this.buttonplay.Text = "Play";
            this.buttonplay.UseVisualStyleBackColor = true;
            this.buttonplay.Click += new System.EventHandler(this.buttonplay_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(65, 124);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 115);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Volume";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 331);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(896, 20);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(12, 315);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(896, 45);
            this.trackBar2.TabIndex = 14;
            this.trackBar2.Value = 10;
            //this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // Favoritos
            // 
            this.Favoritos.FormattingEnabled = true;
            this.Favoritos.Location = new System.Drawing.Point(801, 66);
            this.Favoritos.Name = "Favoritos";
            this.Favoritos.Size = new System.Drawing.Size(195, 238);
            this.Favoritos.TabIndex = 15;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(939, 37);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(57, 23);
            this.botonAgregar.TabIndex = 16;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 550);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.Favoritos);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonplay);
            this.Controls.Add(this.buttoncerrar);
            this.Controls.Add(this.buttonanterior);
            this.Controls.Add(this.buttonsiguiente);
            this.Controls.Add(this.buttonabrir);
            this.Controls.Add(this.Reproduccion);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Mp3player";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox Reproduccion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonabrir;
        private System.Windows.Forms.Button buttonsiguiente;
        private System.Windows.Forms.Button buttonanterior;
        private System.Windows.Forms.Button buttoncerrar;
        private System.Windows.Forms.Button buttonplay;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox Favoritos;
        private System.Windows.Forms.Button botonAgregar;
    }
}

