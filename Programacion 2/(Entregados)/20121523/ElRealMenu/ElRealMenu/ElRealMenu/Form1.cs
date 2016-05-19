using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EditorDeTexto;
using ReproductorMP3;
using NavegadorWeb;
using EditorDeImagenes;
using Aforge_Web_Cam;
using CalculadoraParla;


namespace ElRealMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditorDeTexto.Form1 editor = new EditorDeTexto.Form1();
            editor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReproductorMP3.Form1 mp3 = new ReproductorMP3.Form1();
            mp3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavegadorWeb.Form1 navegador = new NavegadorWeb.Form1();
            navegador.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditorDeImagenes.Form1 editori = new EditorDeImagenes.Form1();
            editori.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Aforge_Web_Cam.VideoForm cama = new Aforge_Web_Cam.VideoForm();
            cama.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CalculadoraParla.Form1 calc = new CalculadoraParla.Form1();
             calc.Show();
        }
    }
}
