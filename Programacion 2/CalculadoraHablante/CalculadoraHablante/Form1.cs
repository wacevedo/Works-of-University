using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis; //agregar libreria para que hable

namespace CalculadoraHablante
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1, num2;//crear variables para almacenar los numeros en memoria
        float num3,num4; //variable secundarias para valores flotantes
        string memo,opertador; //variables de almacenamiento de memoria(M) y del operador

        private void button2_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "1";
            var voice = new SpeechSynthesizer();
            voice.Speak(resultado.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "2";
            var voice = new SpeechSynthesizer();
            voice.Speak(resultado.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //resultado.Text += "4";
            resultado.Text = resultado.Text + "4";
            var voice = new SpeechSynthesizer();
            voice.Speak(resultado.Text);
        }

        private void botonCE_Click(object sender, EventArgs e)
        {
            resultado.Clear();
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "3"; 
            var voice = new SpeechSynthesizer();
            voice.Speak(resultado.Text);
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "5";
            var voice = new SpeechSynthesizer();
            voice.Speak(resultado.Text);
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "0";
            var voice = new SpeechSynthesizer();
            voice.Speak(resultado.Text);
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "7";
            var voice = new SpeechSynthesizer();
            voice.Speak(resultado.Text);
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "8";
            var voice = new SpeechSynthesizer();
            voice.Speak(resultado.Text);
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "9";
            var voice = new SpeechSynthesizer();
            voice.Speak(resultado.Text);
        }

        private void botondiv_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(resultado.Text);
            opertador = "Division";
            var voice = new SpeechSynthesizer();
            voice.Speak("Entre");
            resultado.Clear();
        }

        private void botonpor_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(resultado.Text);
            opertador = "Multiplicacion";
            var voice = new SpeechSynthesizer();
            voice.Speak("Por");
            resultado.Clear();
        }

        private void botonmenos_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(resultado.Text);
            opertador = "Menos";
            resultado.Clear();
        }

        private void botonmas_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(resultado.Text);
            opertador = "Mas";
            resultado.Clear();
        }

        private void botonpunto_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + ".";            
        }        

        private void botonigual_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "")
            {
                num2 = int.Parse(resultado.Text);
                num4 = float.Parse(resultado.Text);
            }
            else 
            {
                MessageBox.Show("ERROR: pantalla vacia");
            }
            resultado.Clear();
            if (opertador == "porciento")
            {
                resultado.Text = (Convert.ToString((num3 * num4)/100));
            }

            if(opertador=="Mas")
            { 
                resultado.Text=(Convert.ToString(num1+num2));            
            }
                
            if(opertador=="Menos")
            { 
                resultado.Text=(Convert.ToString(num1-num2));
            
            }
            if(opertador=="Multiplicacion")
            { 
                resultado.Text=(Convert.ToString(num1*num2));
            
            }
            if (opertador == "Division")
            {
                resultado.Text = (Convert.ToString(num1 / num2));

            }
            if (opertador == "MCM")
            {
                mcmmcd mcm= new mcmmcd(num1, num2);
                resultado.Text = (Convert.ToString(mcm.MCM));
            }
            if (opertador == "MCD")
            {
                mcmmcd mcd = new mcmmcd(num1, num2);
                resultado.Text = (Convert.ToString(mcd.MCD));
                
            }
            if (opertador == "X^Y")
            {
                XelevadoY XY = new XelevadoY(num1, num2);
                resultado.Text = (Convert.ToString(XY.PotencResult));
            }
            var voice = new SpeechSynthesizer();
            voice.Speak(resultado.Text);
        }

        private void botonraiz_Click_1(object sender, EventArgs e)
        {
            opertador = "raiz";
            num1 = int.Parse(resultado.Text);
            resultado.Text = Math.Sqrt(num1).ToString();
            var voice = new SpeechSynthesizer();
            voice.Speak(resultado.Text);
        }

        private void MCM_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(resultado.Text);
            opertador = "MCM";
            var voice = new SpeechSynthesizer();
            voice.Speak("MCM");
            resultado.Clear();
        }

        private void MCD_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(resultado.Text);
            opertador = "MCD";
            var voice = new SpeechSynthesizer();
            voice.Speak("MCD");
            resultado.Clear();
        }

        private void PotenciaXY_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(resultado.Text);
            opertador = "X^Y";
            var voice = new SpeechSynthesizer();
            voice.Speak("X^Y");
            resultado.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultado.Text = "";
        }

        private void BotonLog10_Click(object sender, EventArgs e)
        {   
            num3 = float.Parse(resultado.Text);
            resultado.Text = (Convert.ToString(Math.Log10(num3)));
            var voice = new SpeechSynthesizer();
            voice.Speak("base 10 logarithm is");            
            voice.Speak(resultado.Text);
        }

        private void botonNegativo_Click(object sender, EventArgs e)
        {
            resultado.Text = "-"+resultado.Text ;
            var voice = new SpeechSynthesizer();
            voice.Speak(resultado.Text);
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "")
            {
                memo = (resultado.Text);
                resultado.Clear();
            }
           if (resultado.Text == "") 
           { 
               resultado.Text = (memo);
               var voice = new SpeechSynthesizer();
               voice.Speak(resultado.Text);
           }
        }

        private void buttonPorciento_Click(object sender, EventArgs e)
        {
            num3 = float.Parse(resultado.Text);
            opertador = "porciento";
            var voice = new SpeechSynthesizer();
            voice.Speak(resultado.Text+"% of");
            resultado.Clear();
        }

        private void buttonMmas_Click(object sender, EventArgs e)
        {
            if (resultado.Text == memo)
            {
                num1 = int.Parse(memo);
                num1 += num1;
                memo = Convert.ToString(num1);
                resultado.Text = memo;
                var voice = new SpeechSynthesizer();
                voice.Speak("Memory =" + memo);
            }
            else
            {
                num1 = int.Parse(memo);
                num1 += num1;
                memo = Convert.ToString(num1);
            }
        }

        private void buttonMmenos_Click(object sender, EventArgs e)
        {

            if (resultado.Text == memo)
            {
                num1 = int.Parse(memo);
                num1 -= num1;
                memo = Convert.ToString(num1);
                resultado.Text = memo;
                var voice = new SpeechSynthesizer();
                voice.Speak("Memory =" + memo);
            }
            else
            {
                num1 = int.Parse(memo);
                num1 -= num1;
                memo = Convert.ToString(num1); 
            }
            
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "6";
            var voice = new SpeechSynthesizer();
            voice.Speak(resultado.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ceil = System.Math.Ceiling(Convert.ToDouble(resultado.Text));
            resultado.Text = Convert.ToString(ceil);
            var voice = new SpeechSynthesizer();
            voice.Speak(resultado.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double floor = System.Math.Floor(Convert.ToDouble(resultado.Text));
            resultado.Text = Convert.ToString(floor);
            var voice = new SpeechSynthesizer();
            voice.Speak(resultado.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double ro = System.Math.Round(Convert.ToDouble(resultado.Text));
            resultado.Text = Convert.ToString(ro);
            var voice = new SpeechSynthesizer();
            voice.Speak(resultado.Text);
        }

        
    }
}
