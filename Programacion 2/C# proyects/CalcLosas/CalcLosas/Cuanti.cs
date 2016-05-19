using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalcLosas
{
    public partial class Cuanti : Form
    {
        public Cuanti()
        {
            InitializeComponent();
        }

        private void Cuanti_Load(object sender, EventArgs e)
        {
            textBox1.Text = label6.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
