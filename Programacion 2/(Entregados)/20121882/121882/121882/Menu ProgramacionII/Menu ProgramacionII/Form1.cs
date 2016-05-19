using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calculadora;
using Editor_de_Texto;
using NavegadorWeb;
using Aforge_Web_Cam;
using WindowsFormsApplication1;
using PicColorSetter;

namespace Menu_ProgramacionII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void button3_Click(object sender, EventArgs e)
        {
            Aforge_Web_Cam.VideoForm camara = new Aforge_Web_Cam.VideoForm();
            camara.Show();
        }

        private void buttonCalculadora_Click(object sender, EventArgs e)
        {
            Calculadora.Form1 cal = new Calculadora.Form1();
            cal.Show();
            
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNavegador_Click(object sender, EventArgs e)
        {
            NavegadorWeb.Form1 web = new NavegadorWeb.Form1();
            web.ShowDialog();
        }

        private void buttonEditorTexto_Click(object sender, EventArgs e)
        {
            Editor_de_Texto.Form1 texto = new Editor_de_Texto.Form1();
            texto.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Form1 mp3 = new WindowsFormsApplication1.Form1();
            mp3.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PicColorSetter.Form1 imagen = new PicColorSetter.Form1();
            imagen.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

    }
}
