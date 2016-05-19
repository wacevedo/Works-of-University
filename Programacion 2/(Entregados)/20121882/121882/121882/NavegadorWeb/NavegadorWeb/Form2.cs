using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace NavegadorWeb
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
            
        }


        public Form2(string stringvalor)
        {

            InitializeComponent();
            listBox1.Text = stringvalor;

        }

        public void Form2_Load(object sender, EventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }


        
    
    
    }

    
    }
