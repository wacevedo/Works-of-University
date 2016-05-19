namespace winmaq_player
{
    partial class MP3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MP3));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Babrir = new System.Windows.Forms.Button();
            this.Bnext = new System.Windows.Forms.Button();
            this.Bplaypause = new System.Windows.Forms.Button();
            this.Bprevious = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(407, 163);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 163);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(407, 142);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.Babrir);
            this.panel1.Controls.Add(this.Bnext);
            this.panel1.Controls.Add(this.Bplaypause);
            this.panel1.Controls.Add(this.Bprevious);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 192);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(132, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Volumen";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(217, 122);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(171, 56);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Babrir
            // 
            this.Babrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Babrir.ForeColor = System.Drawing.Color.Red;
            this.Babrir.Location = new System.Drawing.Point(10, 116);
            this.Babrir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Babrir.Name = "Babrir";
            this.Babrir.Size = new System.Drawing.Size(91, 36);
            this.Babrir.TabIndex = 3;
            this.Babrir.Text = "Abrir";
            this.Babrir.UseVisualStyleBackColor = true;
            this.Babrir.Click += new System.EventHandler(this.Babrir_Click);
            // 
            // Bnext
            // 
            this.Bnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bnext.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Bnext.ForeColor = System.Drawing.Color.Red;
            this.Bnext.Location = new System.Drawing.Point(266, 62);
            this.Bnext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bnext.Name = "Bnext";
            this.Bnext.Size = new System.Drawing.Size(96, 36);
            this.Bnext.TabIndex = 2;
            this.Bnext.Text = "8";
            this.Bnext.UseVisualStyleBackColor = true;
            this.Bnext.Click += new System.EventHandler(this.Bnext_Click);
            // 
            // Bplaypause
            // 
            this.Bplaypause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bplaypause.ForeColor = System.Drawing.Color.Red;
            this.Bplaypause.Location = new System.Drawing.Point(150, 62);
            this.Bplaypause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bplaypause.Name = "Bplaypause";
            this.Bplaypause.Size = new System.Drawing.Size(108, 36);
            this.Bplaypause.TabIndex = 1;
            this.Bplaypause.Text = "Play";
            this.Bplaypause.UseVisualStyleBackColor = true;
            this.Bplaypause.Click += new System.EventHandler(this.Bplaypause_Click);
            // 
            // Bprevious
            // 
            this.Bprevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bprevious.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Bprevious.ForeColor = System.Drawing.Color.Red;
            this.Bprevious.Location = new System.Drawing.Point(38, 62);
            this.Bprevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bprevious.Name = "Bprevious";
            this.Bprevious.Size = new System.Drawing.Size(104, 36);
            this.Bprevious.TabIndex = 0;
            this.Bprevious.Text = "7";
            this.Bprevious.UseVisualStyleBackColor = true;
            this.Bprevious.Click += new System.EventHandler(this.Bprevious_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.*";
            this.openFileDialog1.Filter = "MP3 Files|*.mp3 |WAV Files|*.wav |MP4 Files|*.mp4 |AVI Files|*.avi";
            this.openFileDialog1.Multiselect = true;
            // 
            // MP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 497);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MP3";
            this.Text = "WMPLAYER";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Babrir;
        private System.Windows.Forms.Button Bnext;
        private System.Windows.Forms.Button Bplaypause;
        private System.Windows.Forms.Button Bprevious;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

