using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double cantidad1;
        double cantidad2;
        double resultado;
        double memoria;
        string operador;


        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Sin(cantidad1).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            btnPunto.Enabled = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            operador = "+";
            cantidad1 = double.Parse(textBox1.Text);
            textBox1.Clear();

        }

        private void button31_Click(object sender, EventArgs e)
        {
            operador = "-";
            cantidad1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            operador = "*";
            cantidad1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            operador = "/";
            cantidad1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            cantidad2 = double.Parse(textBox1.Text);
            switch (operador)
            {
                case "+":
                    resultado = cantidad1 + cantidad2;
                    textBox1.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = cantidad1 + cantidad2;
                    textBox1.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = cantidad1 + cantidad2;
                    textBox1.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = cantidad1 + cantidad2;
                    textBox1.Text = resultado.ToString();
                    break;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Sqrt(cantidad1).ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Pow(cantidad1, 2).ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Pow(cantidad1, 3).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Pow(cantidad1, -1).ToString();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Exp(cantidad1).ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Log(cantidad1).ToString();

        }

        private void button38_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Pow(10, cantidad1).ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {

            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Tan(cantidad1).ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Cos(cantidad1).ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {

            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Tanh(cantidad1).ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Cosh(cantidad1).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Sinh(cantidad1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            memoria = memoria - Convert.ToDouble(textBox1.Text);
            //this.

            memoria += cantidad2;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            memoria = memoria + Convert.ToDouble(textBox1.Text);
            //this.

            memoria += cantidad2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
