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
using System.Runtime.InteropServices;

namespace programlineal
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<RegresionLinealSimpleClass> items = new List<RegresionLinealSimpleClass>();
        public MainWindow()
        {
            InitializeComponent();
        }
      
        //permitir solo un punto decimal
        private bool ValidChar(string _char)
        {
            string Lista = @". 0 1 2 3 4 5 6 7 8 9 ";
            return Lista.IndexOf(_char.ToUpper()) != -1;
            //System.Text.RegularExpressions.Regex RegVal = new System.Text.RegularExpressions.Regex(@"(?<LETRAS>[A-Z]+)+(?<NUMERO>[0-9]+)+(?<CAR>[!|""|#|$|%|&|'|(|)|*|+|,|\-|.|/|:|;|<|=|>|?|@]+)+");
            //return RegVal.IsMatch(_char);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            groupBox1.Visibility = Visibility.Hidden;
            
        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dataGrid1_Loaded(object sender, RoutedEventArgs e)
        {

            
           
            

        }
        public void refreshSourse()
        {
            List<RegresionLinealSimpleClass> vacio = new List<RegresionLinealSimpleClass>();
            dataGrid1.ItemsSource = vacio;
            dataGrid1.ItemsSource = items;
        }

        private double sxy, sx, sy, sx2, sy2, n;
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if ((textBox1.Text != "")&&(textBox2.Text != ""))
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                CalcularDatosRegresionLinealSimple c = new CalcularDatosRegresionLinealSimple(x,y);
                items.Add(c.RLS);
                refreshSourse();
                n = items.Count;
                sx += c.RLS.X;
                sy += c.RLS.Y;
                sxy += c.RLS.XY;
                sx2 += c.RLS.X2;
                sy2 += c.RLS.Y2;
                textBoxSX.Text = Convert.ToString(sx);
                textBoxSY.Text = Convert.ToString(sy);
                textBoxSXY.Text = Convert.ToString(sxy);
                textBoxSX2.Text = Convert.ToString(sx2);
                textBoxSY2.Text = Convert.ToString(sy2);
                textBoxR.Text = Convert.ToString(c.calcularR(n,sxy,sx,sy,sx2,sy2));
                textBoxR2.Text = Convert.ToString(c.calcularR2(n,sxy,sx,sy,sx2,sy2));
                textBox4.Text = Convert.ToString(c.calcularXpro(n,sx));
                textBox3.Text = Convert.ToString(c.calcularYpro(n, sx));
                textBox6.Text = Convert.ToString(c.calcularA(c.calcularYpro(n, sx), c.calcularXpro(n, sx), c.calcularB(c.calcularYpro(n, sx), sxy, sx, sy, sx2)));
                textBox5.Text = Convert.ToString(c.calcularB(c.calcularYpro(n, sx), sxy, sx, sy, sx2));
  
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
        }

        private void textBoxOnlyNumber_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBoxOnlyNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!ValidChar(e.Text))
                e.Handled = true;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (groupBox1.Visibility != Visibility.Hidden)
            {
                groupBox1.Visibility = Visibility.Hidden;
            }
            else
            {
                groupBox1.Visibility = Visibility.Visible;
            }
        }
    }
}
