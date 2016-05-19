using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Xml;
using System.Xml.Linq;
using System.Net;
using System.Globalization;
using System.IO;

namespace NavegadorWeb
{

    public partial class Form1 : Form
    {
        ArrayList pestanasG = new ArrayList();
        string nuevawebv;
        int contarpest;
        public static String favXml = "favorits.xml", linksXml = "links.xml";
        public WebBrowser nuevowebbrowser = new WebBrowser();
        public TabPage nuevapestana = new TabPage("Nueva Pestaña");
        List<String> urls = new List<String>();


        public Form1()
        {
            InitializeComponent();
        }

        private WebBrowser getCurrentBrowser()
        {
            return (WebBrowser)tabControl1.SelectedTab.Controls[0];
        }

        private void addFavorit(String url, string name)
        {
            XmlDocument myXml = new XmlDocument();
            XmlElement el = myXml.CreateElement("favoritos");
            el.SetAttribute("url", url);
            el.InnerText = name;
            if (!File.Exists(favXml))
            {
                XmlElement root = myXml.CreateElement("favorites");
                myXml.AppendChild(root);
                root.AppendChild(el);
            }
            else
            {
                myXml.Load(favXml);
                myXml.DocumentElement.AppendChild(el);
            }

            myXml.Save(favXml);
        }

        private void CrearPestaña()
        {
            contarpest++;
            nuevapestana = new TabPage("Nueva Pestaña" + contarpest);
            nuevowebbrowser = new WebBrowser();
            pestanasG.Add(nuevapestana);
            tabControl1.TabPages.Add(nuevapestana);
            tabControl1.SelectedTab = nuevapestana;
            nuevapestana.Controls.Add(nuevowebbrowser);
            nuevowebbrowser.Dock = DockStyle.Fill;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pantalla.Controls.Add(nuevowebbrowser);
            nuevowebbrowser.Dock = DockStyle.Fill;
            comboBox1.Text = "www.youtube.com";
            nuevowebbrowser.Navigate(Pantalla.Text);
            nuevawebv = Convert.ToString(nuevowebbrowser.Url);

            if ((nuevawebv != "about:blank") && (nuevawebv != " ") && (nuevawebv != ""))
            {
                comboBox1.Items.Add(Convert.ToString(nuevowebbrowser.Url));
            }
            Pantalla.Text = comboBox1.Text;

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            nuevowebbrowser.Navigate(comboBox1.Text);
            nuevawebv = Convert.ToString(nuevowebbrowser.Url);
            if ((nuevawebv != "about:blank") && (nuevawebv != " ") && (nuevawebv != ""))
            {
                comboBox1.Items.Add(Convert.ToString(nuevowebbrowser.Url));
            }
            if (contarpest == 0)
            {
                Pantalla.Text = comboBox1.Text;
            }
            else
            {
                nuevapestana.Text = comboBox1.Text;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            nuevowebbrowser.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            nuevowebbrowser.GoForward();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nuevowebbrowser.Navigate(comboBox1.Text);

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                nuevowebbrowser.Navigate(comboBox1.Text);
                comboBox1.Items.Add(comboBox1.Text);
            }
        }


        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (getCurrentBrowser().Url != null)
            {
                WBrowser.AddFavorites dlg = new WBrowser.AddFavorites(getCurrentBrowser().Url.ToString());
                DialogResult res = dlg.ShowDialog();

                if (res == DialogResult.OK)
                {
                    if (dlg.favFile == "Favorites")
                    {
                        addFavorit(getCurrentBrowser().Url.ToString(), dlg.favName);
                    }
                    //else {addLink(getCurrentBrowser().Url.ToString(), dlg.favName); }
                }
                dlg.Close();
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            nuevowebbrowser.GoHome();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            nuevowebbrowser.Refresh();
        }

        /*private void timer1_Tick(object sender, EventArgs e)
        {
            if((comboBox1!="about.blank")&&(comboBox1!=" ")&&(comboBox1!=""))
            {
                if ((comboBox1.Text!=Convert.ToString(nuevowebbrowser.Url))&&(
        }    

        */
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            CrearPestaña();
            comboBox1.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if((comboBox1.Text!="about.blank")&&(comboBox1.Text!=" ")&&(comboBox1.Text!=""))
           { 
                if ((comboBox1.Text!=Convert.ToString(nuevowebbrowser.Url))&&(textestado.Text!="Complete"))
                {

                    comboBox1.Text=Convert.ToString(nuevowebbrowser.Url);
                }
                textestado.Text=Convert.ToString(nuevowebbrowser.ReadyState);
           }
        }
    }
}
