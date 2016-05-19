using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sesion;
using Dominio;

namespace MainMenu
{
    public partial class PacientesChiku : Form
    {
        public PacientesChiku()
        {
            InitializeComponent();
        }
        Broker b = new Broker();
        private void PacientesChiku_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = b.ActualizarPacienteConChiku();            
        }
    }
}
