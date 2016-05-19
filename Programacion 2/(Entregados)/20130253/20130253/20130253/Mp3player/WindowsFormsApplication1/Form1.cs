using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
        }

        string[] archivos, paths;      

        public void buttonabrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            OpenFileDialog open = new OpenFileDialog();
            int j = 0;
            j = Reproduccion.Items.Count + 1;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                archivos = openFileDialog1.SafeFileNames;
                paths = openFileDialog1.FileNames;
                
                 if (Reproduccion.Items.Count == 0)
                    {
                        for (int i = 0; i < archivos.Length; i++)
                        {
                            Reproduccion.Items.Add(archivos[i]);
                            ListPaths.Items.Add(paths[i]);                            
                        }
                    }
                 else                   
                    {
                        for (int i = 0; i < archivos.Length; i++)
                        {
                            Reproduccion.Items.Add(archivos[j]);
                            ListPaths.Items.Add(paths[i]);
                            j++;
                        }
                    }
                }
                foreach (string d in open.FileNames)
                {
                    Reproduccion.Items.Add(d);                   
                }                
                //Reproduccion.SelectedIndex = 0; 
                progressBar1.Value = 0;
                m = 0;
                s = 0;
                if (Reproduccion.Items.Count >= 1)
                {
                    botonAgregar.Enabled = true;
                    agregarToolStripMenuItem1.Enabled = true;
                }
                abrirToolStripMenuItem.Enabled = false;
                buttonabrir.Enabled = false;
            }          
              
       private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {                                 
            axWindowsMediaPlayer1.URL = paths[Reproduccion.SelectedIndex];                       
            buttonplay.Text = "Pause";
            playToolStripMenuItem.Text = "Pause";
            progressBar1.Value = 0;
            s = 0;
            m = 0;           
            progressBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);      
            label3.Text = Convert.ToString(Convert.ToInt32(Math.Truncate(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration / 60) /*minutos*/) + ":" + Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration % 60)/*segundos*/);
            timer1.Start(); 
        }
        private void Reproduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[Reproduccion.SelectedIndex];
        }

        private void buttonanterior_Click(object sender, EventArgs e)
        {
            if (Reproduccion.SelectedIndex > 0)
            {
                Reproduccion.SelectedIndex = Reproduccion.SelectedIndex - 1;
                axWindowsMediaPlayer1.URL = paths[Reproduccion.SelectedIndex];
                //=====================================                            
                buttonplay.Text = "Pause";
                playToolStripMenuItem.Text = "Pause";
                progressBar1.Value = 0;
                m = 0;
                s = 0;                
                progressBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                label3.Text = Convert.ToString(Convert.ToInt32(Math.Truncate(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration / 60) /*minutos*/) + ":" + Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration % 60)/*segundos*/);
                timer1.Start();
                 }            
        }

        private void buttonsiguiente_Click(object sender, EventArgs e)
        {
            if (Reproduccion.SelectedIndex != Reproduccion.Items.Count - 1)
            {
                Reproduccion.SelectedIndex = Reproduccion.SelectedIndex + 1;
                axWindowsMediaPlayer1.URL = paths[Reproduccion.SelectedIndex];
                //=====================================                              
                buttonplay.Text = "Pause";
                playToolStripMenuItem.Text = "Pause";
                progressBar1.Value = 0;
                m = 0;
                s = 0;              
                progressBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                label3.Text = Convert.ToString(Convert.ToInt32(Math.Truncate(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration / 60) /*minutos*/) + ":" + Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration % 60)/*segundos*/);
                timer1.Start();
                }
        }

        private void buttonplay_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                buttonplay.Text = "Pause";
                playToolStripMenuItem.Text = "Pause";
                timer1.Start();                
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                buttonplay.Text = "Play";
                playToolStripMenuItem.Text = "Play";
                timer1.Stop();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void buttoncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        int m = 0, s = 0; //minutos y segundos

        private void timer1_Tick(/*object sender, EventArgs e object sender, EventArgs e*/object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            s++;
            if (s == 60) //un for mara que cuando llegue a 60 segundos, se aumente un minuto
            {
                s = 0;
                m++;
            }            
             label2.Text = Convert.ToString(m +":" + s); //imprimir los m:s
        }        
        
        private void botonAgregar_Click(object sender, EventArgs e)
        {            
            Favoritos.Items.Add(Reproduccion.SelectedItem); //agrega el nombre al box             
            FavoritosPaths.Items.Add(ListPaths.Items[Reproduccion.SelectedIndex]); //agrega el path al pathbox
            if (Favoritos.Items.Count >= 1)
            {
                quitarToolStripMenuItem.Enabled = true;
                botonQuitar.Enabled = true;                
            }
            Favoritos.SelectedIndex = Favoritos.Items.Count - 1;            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            botonQuitar.Enabled = false;
            quitarToolStripMenuItem.Enabled = false;
            botonAgregar.Enabled = false;
            agregarToolStripMenuItem1.Enabled = false;
        }

        private void Favoritos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            axWindowsMediaPlayer1.URL = Convert.ToString(FavoritosPaths.Items[Favoritos.SelectedIndex]);
            buttonplay.Text = "Pause";
            playToolStripMenuItem.Text = "Pause";
            progressBar1.Value = 0;
            m = 0;
            s = 0;
            progressBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
            label3.Text = Convert.ToString(Convert.ToInt32(Math.Truncate(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration / 60) /*minutos*/) + ":" + Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration % 60)/*segundos*/);
            timer1.Start();
            }

        private void quitarToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            FavoritosPaths.Items.Remove(FavoritosPaths.Items[Favoritos.SelectedIndex]);
            Favoritos.Items.Remove(Favoritos.SelectedItem);
            if (Favoritos.Items.Count == 0)
            {
                quitarToolStripMenuItem.Enabled = false;
                botonQuitar.Enabled = false;
            }
            Favoritos.SelectedIndex = Favoritos.Items.Count - 1;            
        }    
    }
}