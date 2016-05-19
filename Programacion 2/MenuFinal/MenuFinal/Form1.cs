using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EditorText;
using VisualisadorImagen;
using Aforge_Web_Cam;
using NavegadorWeb;
using WindowsFormsApplication1;
using CalculadoraHablante;


using System.Threading;

namespace MenuFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditorText.Form1 Ed = new EditorText.Form1();
            Ed.Show();
            //this.Hide();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VisualisadorImagen.Form1 Vi = new VisualisadorImagen.Form1();
            Vi.Show();
        }

        private void buttonCamara_Click(object sender, EventArgs e)
        {
            Aforge_Web_Cam.VideoForm Cam = new VideoForm();
            Cam.Show();
        }

        private void dbutton3_Click(object sender, EventArgs e)
        {
            NavegadorWeb.Form1 NW = new NavegadorWeb.Form1();
            NW.Show();           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Form1 mp3play = new WindowsFormsApplication1.Form1();
            mp3play.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculadoraHablante.Form1 calc = new CalculadoraHablante.Form1();
            calc.Show();
        }
        
        private Color GetRandomColor()
        {
            Random random=new Random();
            return Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            // The error is here
        }  
        private void Form1_Load(object sender, EventArgs e)
        {/*
            button1.BackColor = GetRandomColor();
            button2.BackColor = GetRandomColor();
            button3.BackColor = GetRandomColor();
            button4.BackColor = GetRandomColor();
            button5.BackColor = GetRandomColor();
            button6.BackColor = GetRandomColor();
            button7.BackColor = GetRandomColor();
            Random random=new Random();
            do{
            toolStripContainer1.ContentPanel.BackColor = Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random.Next(100, 255));
            } while (toolStripContainer1.ContentPanel.BackColor == button7.BackColor);*/
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            ColorDialog newbackcolor = new ColorDialog();
            newbackcolor.ShowDialog();
            toolStripContainer1.ContentPanel.BackColor = newbackcolor.Color;
            

        }

        private void cambiarColorDeIconosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog newiconcolor = new ColorDialog();
            newiconcolor.ShowDialog();
            button1.BackColor = newiconcolor.Color;
            button2.BackColor = newiconcolor.Color;
            button3.BackColor = newiconcolor.Color;
            button4.BackColor = newiconcolor.Color;
            button5.BackColor = newiconcolor.Color;
            button6.BackColor = newiconcolor.Color;
            button7.BackColor = newiconcolor.Color;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
