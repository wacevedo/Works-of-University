using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winmaq_player
{
    public partial class MP3 : Form
    {
        public MP3()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
        }
        string[] archivo, paths;
        int lastsong;
        private void Babrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            
            if (openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                
            {
                archivo = openFileDialog1.SafeFileNames;
                paths = openFileDialog1.FileNames;
                for (int i = 0; i < archivo.Length; i++)
                {
                    listBox1.Items.Add(archivo[i]);
                    
                }
                foreach (string d in open.FileNames)
                {
                    listBox1.Items.Add(d);
                    lastsong++;
                }
            }

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];


        }

        private void Bprevious_Click(object sender, EventArgs e)
        {
            
            //codigo para retroceder musica//
            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
                axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
            }
            
        }

        private void Bnext_Click(object sender, EventArgs e)
        {
            //este if es para adelantar musica//
            if (listBox1.SelectedIndex != listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
            }
        }

        private void Bplaypause_Click(object sender, EventArgs e)
        {
            // este codigo es de pausar y darle play a la musica//
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                Bplaypause.Text = "pause";
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                Bplaypause.Text = "Play";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
