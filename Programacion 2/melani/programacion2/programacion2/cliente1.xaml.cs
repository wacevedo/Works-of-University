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
using System.Windows.Shapes;
using System.Data;
namespace programacion2
{
    /// <summary>
    /// Interaction logic for cliente1.xaml
    /// </summary>
    public partial class cliente1 : Window
    {
        public cliente1()
        {
            InitializeComponent();
        }
        ConexionNoSabo nosabo = new ConexionNoSabo();

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           /* int id = nosabo.ObtenerIdCliente();
            IdClienteR.Text = IdClienteR.Text + " " + Convert.ToString(id+1);*/

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
         
            Cliente c = new Cliente();
           
            c.Nombre = textBoxNombre.Text;
            c.Cedula = textBoxCedula.Text;
            nosabo.InsertCliente(c);

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void buttonCompra_Click(object sender, RoutedEventArgs e)
        {
            Compraform mw = new Compraform();
            mw.Show();
            this.Close();
        }

        private void buttonVenta_Click(object sender, RoutedEventArgs e)
        {
            VentaForm mw = new VentaForm();
            mw.Show();
            this.Close();
        }
    }
}
