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
            OpenFileDialog open = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                archivos = openFileDialog1.SafeFileNames;
                paths = openFileDialog1.FileNames;
                for (int i = 0; i < archivos.Length; i++)
                {
                    Reproduccion.Items.Add(archivos[i]);
                }
                foreach (string d in open.FileNames)
                {
                    Reproduccion.Items.Add(d);
                }
                Reproduccion.SelectedIndex = 0;

            }





        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (Reproduccion.SelectedIndex == 0)
            {
                axWindowsMediaPlayer1.URL = paths[Reproduccion.SelectedIndex];

            }
            else
            {
                axWindowsMediaPlayer1.URL = paths[Reproduccion.SelectedIndex - 1];
            }
            progressBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
            trackBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
            trackBar2.Minimum = 0;
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


            }
        }

        private void buttonsiguiente_Click(object sender, EventArgs e)
        {
            if (Reproduccion.SelectedIndex != Reproduccion.Items.Count /*- 1*/)
            {
                Reproduccion.SelectedIndex = Reproduccion.SelectedIndex + 1;
                axWindowsMediaPlayer1.URL = paths[Reproduccion.SelectedIndex];

            }

        }

        private void buttonplay_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                buttonplay.Text = "Pause";

            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                buttonplay.Text = "Play";

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



        private void timer1_Tick(/*object sender, EventArgs e object sender, EventArgs e*/object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            trackBar2.Value = progressBar1.Value;

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            //Favoritos.Items.Add(Reproduccion.SelectedItem);

            OpenFileDialog open = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                archivos = openFileDialog1.SafeFileNames;
                paths = openFileDialog1.FileNames;
                for (int i = 0; i < archivos.Length; i++)
                {
                    Reproduccion.Items.Add(archivos[i]);
                }
                foreach (string d in open.FileNames)
                {
                    Reproduccion.Items.Add(d);
                }
                Reproduccion.SelectedIndex = 0;
            }
        }

       


    }
}