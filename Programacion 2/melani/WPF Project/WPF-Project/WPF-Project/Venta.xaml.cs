using System;
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
    /// Lógica de interacción para Venta.xaml
    /// </summary>
    public partial class Venta : Window
    {
        public Venta()
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
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WPF_Project.no_saboDataSet no_saboDataSet = ((WPF_Project.no_saboDataSet)(this.FindResource("no_saboDataSet")));
            // Cargar datos en la tabla Cliente. Puede modificar este código según sea necesario.
            WPF_Project.no_saboDataSetTableAdapters.ClienteTableAdapter no_saboDataSetClienteTableAdapter = new WPF_Project.no_saboDataSetTableAdapters.ClienteTableAdapter();
            no_saboDataSetClienteTableAdapter.Fill(no_saboDataSet.Cliente);
            System.Windows.Data.CollectionViewSource clienteViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clienteViewSource")));
            clienteViewSource.View.MoveCurrentToFirst();
        }

    }
}
