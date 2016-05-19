using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio;
using Sesion;

namespace MainMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertPaciente m = new FormInsertPaciente();
            m.ShowDialog();
        }
        

        private void centroDeSaludToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertCentroS m = new FormInsertCentroS();
            m.ShowDialog();
            
        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertEspecialidad m = new FormInsertEspecialidad();
            m.ShowDialog();
        }

        private void agregarDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertDoctor m = new FormInsertDoctor();
            m.ShowDialog();
        }

        private void agregarEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertEspecialidadDoc m = new FormInsertEspecialidadDoc();
            m.ShowDialog();
        }

        private void patologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertPatologia m = new FormInsertPatologia();
            m.ShowDialog();
        }

        private void consultasfaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultas m = new FormConsultas();
            m.ShowDialog();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iNSERTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Habitacion m = new Habitacion();
            m.ShowDialog();
        }

        private void consultasYReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void pacientesConChicufaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacientesChiku m = new PacientesChiku();
            m.ShowDialog();
        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosGeneralesPacientesfaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDatosPacYCon m = new FormDatosPacYCon();
            m.ShowDialog();
        }

        private void salirfaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculadorafaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\20130253-20121993\Utilidades\calculadora.exe");
        }

        private void editorDeTextofaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\20130253-20121993\Utilidades\EditorText.exe");
        }

        private void navegadorWebfaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\20130253-20121993\Utilidades\NavegadorWeb\NavegadorWeb\bin\Debug\NavegadorWeb.exe");
        }

        private void mP3PlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\20130253-20121993\Utilidades\Mp3player\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe");
           
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Acerca m = new Acerca();
            //m.ShowDialog();          
            
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportes m = new FormReportes();
            m.ShowDialog();
        }

        private void diccionarioDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\20130253-20121993\Diccionario de datos.png");
        }

        private void diagramaEntidadRelacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\20130253-20121993\DER.png");
        }


       

        
    }
}
