﻿using System;
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
    /// Lógica de interacción para VentaForm.xaml
    /// </summary>
    public partial class VentaForm : Window
    {
        public VentaForm()
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

        private void buttonTotal_Click(object sender, RoutedEventArgs e)
        {
            Venta v = new Venta();
            Cliente c = new Cliente();
            c = comboBox2.SelectedItem as Cliente;
            v.Tipo_moneda = Convert.ToString(comboBox1.SelectedItem);
            v.Id_cliente = c.Id;//Convert.ToInt32(comboBox2.SelectedValue);
            v.Cantidad = Convert.ToInt32(textBox1.Text);
            v.Taza = Convert.ToInt32(textBox2.Text);
            nosabo.InsertVenta(v,c);
            textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboBox2.ItemsSource = nosabo.SelectCliente();
        }
    }
}
