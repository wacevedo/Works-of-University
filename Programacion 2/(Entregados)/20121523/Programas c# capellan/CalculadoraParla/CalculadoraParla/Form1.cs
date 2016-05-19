using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace CalculadoraParla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numero1, numero2;
        string operador;
        decimal a, b;

        private void button1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
            var voice = new SpeechSynthesizer();
            voice.Speak(pantalla.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
            var voice = new SpeechSynthesizer();
            voice.Speak(pantalla.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
            var voice = new SpeechSynthesizer();
            voice.Speak(pantalla.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
            var voice = new SpeechSynthesizer();
            voice.Speak(pantalla.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
            var voice = new SpeechSynthesizer();
            voice.Speak(pantalla.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
            var voice = new SpeechSynthesizer();
            voice.Speak(pantalla.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
            var voice = new SpeechSynthesizer();
            voice.Speak(pantalla.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
            var voice = new SpeechSynthesizer();
            voice.Speak(pantalla.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
            var voice = new SpeechSynthesizer();
            voice.Speak(pantalla.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
            var voice = new SpeechSynthesizer();
            voice.Speak(pantalla.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
            var voice = new SpeechSynthesizer();
            voice.Speak(pantalla.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(pantalla.Text);
            operador = "Division";
            pantalla.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(pantalla.Text);
            operador = "Multiplicacion";
            pantalla.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(pantalla.Text);
            operador = "Resta";
            pantalla.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(pantalla.Text);
            operador = "Suma";
            pantalla.Clear();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(pantalla.Text);
            operador = "Potencia";
            pantalla.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(pantalla.Text);
            operador = "Logaritmo";
            pantalla.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            operador = "Raiz";
            numero1 = int.Parse(pantalla.Text);
            pantalla.Text = Math.Sqrt(numero1).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(pantalla.Text);
            operador = "Porc";
            a = numero1;
            pantalla.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            numero2 = int.Parse(pantalla.Text);
            b = numero2;
            pantalla.Clear();

            if (operador == "Suma")
            {
                pantalla.Text = (Convert.ToString(numero1 + numero2));
            }
            if (operador == "Resta")
            {
                pantalla.Text = (Convert.ToString(numero1 - numero2));
            }
            if (operador == "Division")
            {
                pantalla.Text = (Convert.ToString(numero1 / numero2));
            }
            if (operador == "Multiplicacion")
            {
                pantalla.Text = (Convert.ToString(numero1 * numero2));
            }
            if (operador == "Raiz")
            {
                pantalla.Text = (Convert.ToString(System.Math.Sqrt(numero1)));
            }
            if (operador == "Porc")
            {
                pantalla.Text = (Convert.ToString((b * a) / 100));
            }
            if (operador == "Potencia")
            {
                pantalla.Text = (Convert.ToString(Math.Pow(numero1, numero2)));
            }
            if (operador == "Logaritmo")
            {
                pantalla.Text = Convert.ToString(Math.Log(numero1) / Math.Log(numero2));
            }
            if (operador == "MCM")
            {
               MCMMCD MCM = new MCMMCD(numero1, numero2);
                pantalla.Text = Convert.ToString(MCM.MCM);
            }
            if (operador == "MCD")
            {
                MCMMCD MCD = new MCMMCD(numero1, numero2);
                pantalla.Text = Convert.ToString(MCD.MCD);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(pantalla.Text);
            operador = "MCM";
            pantalla.Clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(pantalla.Text);
            operador = "MCD";
            pantalla.Clear();
        }

      

            

      
    }
}
