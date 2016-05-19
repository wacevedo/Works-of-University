using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotonCalc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\20130253\Calculadora\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe");
        }

        private void BotonEditor_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\20130253\Editor de Texto\Editor de Texto\bin\Debug\Editor de Texto.exe");
        }

        private void BotonMP3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\20130253\Mp3player\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe");
        }

        private void BotonNavegador_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\20130253\Navegador Web\Navegador Web\bin\Debug\Navegador Web.exe");            
        }

        private void BotonCamara_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\20130253\Aforge_Web_Cam\Aforge_Web_Cam\bin\Debug\Aforge_Web_Cam.exe");
        }     
        
        
    }
}
