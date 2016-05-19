using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using Entidades;


namespace programacion2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        ConexionNoSabo nosabo = new ConexionNoSabo();
      //  double valormoneda;
        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
           // comboBox1.DataContext = nosabo.SelectCliente();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            /*Venta v = new Venta();
            Cliente c = new Cliente();
            c = comboBox1.SelectedItem as Cliente;

            v.Id_cliente = c.Id;
            v.Cantidad = Convert.ToInt32(textBox1.Text);
            v.Taza = Convert.ToInt32(textBox2.Text);*/


        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*switch(comboBox2.Text)
            {
                case "Euro":
                    { valormoneda = 53; break; }
                case "Dolar":
                    { valormoneda = 53; break; }
                default:
                    { valormoneda = 0; break; }
            }*/
        }

        private void llamadaCliente_Click(object sender, RoutedEventArgs e)
        {
            cliente1 cep = new cliente1();
            cep.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
           Compraform cep = new Compraform();
            cep.Show();
            this.Close();
        }

        private void buttonVenta_Click(object sender, RoutedEventArgs e)
        {
            VentaForm cep = new VentaForm();
            cep.Show();
            this.Close();
        }
    }
}
