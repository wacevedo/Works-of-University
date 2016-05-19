using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        
        int numero1 = 0, numero2 = 0, memory = 0, temp = 0;
        string operador;    
        
        private void boton1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
            
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void botonCE_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
           
            
        }

        private void botondiv_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(Pantalla.Text);
            operador = "Division";
            Pantalla.Clear();
        }

        private void botonmult_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(Pantalla.Text);
            operador = "Multiplicacion";
            Pantalla.Clear();
        }

        private void botonresta_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(Pantalla.Text);
            operador = "Resta";
            Pantalla.Clear();
        }

        private void botonsuma_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(Pantalla.Text);
            operador = "Suma";
            Pantalla.Clear();
        }

        private void botonigual_Click(object sender, EventArgs e)
        {
            numero2 = int.Parse(Pantalla.Text);
            Pantalla.Clear();

            if (operador == "Suma")
            {
                Pantalla.Text = (Convert.ToString(numero1 + numero2));
            }

            if (operador == "Resta")
            {
                Pantalla.Text = (Convert.ToString(numero1 - numero2));
            }

            if (operador == "Multiplicacion")
            {
                Pantalla.Text = (Convert.ToString(numero1 * numero2));
            }

            if (operador == "Division")
            {
                Pantalla.Text = (Convert.ToString(numero1 / numero2));
            }
            
            if (operador == "Potencia")
            {
                Pantalla.Text = (Convert.ToString(Math.Pow(numero1, numero2)));
            }

            if (operador == "MCM")
            { 
               mcmmcd MC = new mcmmcd(numero1, numero2);
               Pantalla.Text = Convert.ToString(MC.MCM);
            }
            if (operador == "MCD")
            {
                mcmmcd MC = new mcmmcd(numero1, numero2);
                Pantalla.Text = Convert.ToString(MC.MCD);
            }
            if (operador == "LOG")
            {
                Pantalla.Text = Convert.ToString(Math.Log(numero1, numero2));
            }
            if (operador == "PORC")
            {
                
                double n1, n2;
                n1 = Convert.ToDouble(numero1);
                n2 = Convert.ToDouble(numero2);
                            
               Pantalla.Text = Convert.ToString((n1 / 100) * n2);       
               
            }
        }

        private void botonraiz_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(Pantalla.Text);
            operador = "Raiz";
            Pantalla.Text = Math.Sqrt(numero1).ToString();
        }

        

        private void botonMC_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void botonMmas_Click(object sender, EventArgs e)
        {

            if (Pantalla.Text == "") { MessageBox.Show("Debe insertar un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                temp = int.Parse(Pantalla.Text); //Si no hay nada en la pantalla, tira error.
                Pantalla.Text = (Convert.ToString(0)); // porque se esta combirtiendo a int " "
                memory = memory + temp;
                Pantalla.Text = (Convert.ToString(memory));
            }
        }

        private void botonMmenos_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "")
            {
                MessageBox.Show("Debe insertar un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                memory = memory - int.Parse(Pantalla.Text);
                Pantalla.Text = (Convert.ToString(memory));
            }
        }

        
        bool x = false; 
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();

       

            
            if (x == true)
            {
                boton0.Enabled = true;
                boton1.Enabled = true;
                boton2.Enabled = true;
                boton3.Enabled = true;
                boton4.Enabled = true;
                boton5.Enabled = true;
                boton6.Enabled = true;
                boton7.Enabled = true;
                boton8.Enabled = true;
                boton9.Enabled = true;
                botonCE.Enabled = true;
                botondiv.Enabled = true;
                botonigual.Enabled = true;
                botonMC.Enabled = true;
                botonMmas.Enabled = true;
                botonMmenos.Enabled = true;
                botonmult.Enabled = true;
                botonpunto.Enabled = true;
                botonraiz.Enabled = true;
                botonresta.Enabled = true;
                botonsuma.Enabled = true;
                Pantalla.Enabled = true;
                botonMR.Enabled = true;

                botonPorciento.Enabled = true;
                botonPotencia.Enabled = true;
                botonLog.Enabled = true;
                botonMCD.Enabled = true;
                botonMCM.Enabled = true;

                pictureBox2.Show();
                pictureBox1.Hide();
                x = false;
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (x == false)
            {
                boton0.Enabled = false;
                boton1.Enabled = false;
                boton2.Enabled = false;
                boton3.Enabled = false;
                boton4.Enabled = false;
                boton5.Enabled = false;
                boton6.Enabled = false;
                boton7.Enabled = false;
                boton8.Enabled = false;
                boton9.Enabled = false;
                botonCE.Enabled = false;
                botondiv.Enabled = false;
                botonigual.Enabled = false;
                botonMC.Enabled = false;
                botonMmas.Enabled = false;
                botonMmenos.Enabled = false;
                botonmult.Enabled = false;
                botonpunto.Enabled = false;
                botonraiz.Enabled = false;
                botonresta.Enabled = false;
                botonsuma.Enabled = false;
                Pantalla.Enabled = false;
                botonMR.Enabled = false;
                botonPorciento.Enabled = false;
                botonPotencia.Enabled = false;
                botonLog.Enabled = false;
                botonMCD.Enabled = false;
                botonMCM.Enabled = false;
                pictureBox1.Show();
                pictureBox2.Hide();
                x = true;

            }
        }

        private void botonMR_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Convert.ToString(memory);
        }

        private void botonMCD_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(Pantalla.Text);
            operador = "MCD";
            Pantalla.Clear();
        }

        private void botonPotencia_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(Pantalla.Text);
            operador = "Potencia";
            Pantalla.Clear();
        }

             
        private void botonMCM_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(Pantalla.Text);
            operador = "MCM";
            Pantalla.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Close();         
        }

        private void acercaDeCalculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
                       
            Acercade f = new Acercade();
            f.ShowDialog();
        }

        private void botonLog_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(Pantalla.Text);
            operador = "LOG";
            Pantalla.Clear();
            
        }

        private void botonPorciento_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(Pantalla.Text);
            operador = "PORC";
            Pantalla.Clear();
        }

        

        
       

        

        
    }
}
