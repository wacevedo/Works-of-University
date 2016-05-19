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
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        private void AplicarEfecto(Window main)
        {
            var objBlur = new System.Windows.Media.Effects.BlurEffect();
            objBlur.Radius = 5;
            main.Effect = objBlur;
        } 
        public Home()
        {
            InitializeComponent();
        }

        public void closeit()
        {
            this.Close();
        }

        public void showa()
        {
            Home hom2 = new Home();
            hom2.Show();
            closeit();
            
        }
        public void ShowMsg()
        {
            MessageBoxResult result = MessageBox.Show("Quieres cerrar la aplicación?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {

                Application.Current.Shutdown();

            }
            else
            {
                showa();
                this.Close();

            }
            
        }

        

        private void regcl_Click(object sender, RoutedEventArgs e)
        {
            RegCliente registro = new RegCliente ();
            registro.Show();
            AplicarEfecto(this);
        }

  
        private void Main_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ShowMsg();
            
        }

        private void vent_Click(object sender, RoutedEventArgs e)
        {
            Venta vnt = new Venta();
            vnt.Show();
            AplicarEfecto(this);
        }

        private void comp_Click(object sender, RoutedEventArgs e)
        {
            Compra cmp = new Compra();
            cmp.Show();
            AplicarEfecto(this);
        }

      
    }
}

 