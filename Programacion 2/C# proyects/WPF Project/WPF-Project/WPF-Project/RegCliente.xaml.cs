﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Project
{
    /// <summary>
    /// Lógica de interacción para RegCliente.xaml
    /// </summary>
    public partial class RegCliente : Window
    {
        public RegCliente()
        {
            InitializeComponent();
        }

        public void abrirhome()
        {
            Home hom = new Home();
            hom.Show();
        }
       
        private void Window_Closed(object sender, EventArgs e)
        {
            abrirhome();
            this.Close();
        }
    }
}
