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


namespace programacion2
{
    /// <summary>
    /// Lógica de interacción para Compraform.xaml
    /// </summary>
    public partial class Compraform : Window
    {
        public Compraform()
        {
            InitializeComponent();
        }
        ConexionNoSabo nosabo = new ConexionNoSabo();
        private void buttonatras_Click(object sender, RoutedEventArgs e)
        {
            cliente1 mw = new cliente1();
            mw.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboBox2.ItemsSource = nosabo.SelectCliente();
        }

        private void buttonTotal_Click(object sender, RoutedEventArgs e)
        {
            Compra cp = new Compra();
            Cliente c = new Cliente();
            c = comboBox2.SelectedItem as Cliente;
            cp.Tipo_moneda = Convert.ToString(comboBox1.SelectedItem);
            cp.Id_cliente = c.Id;
            cp.Cantidad = Convert.ToInt32(textBox1.Text);
            cp.Taza = Convert.ToInt32(textBox2.Text);
            nosabo.InsertCompra(cp,c);
            textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text));
        }
    }
}
