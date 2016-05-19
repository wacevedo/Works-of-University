using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.XPath;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
        }
        //int[] songplayed;
        int y = 0;
        string finalcancion,opciondeboton3="none";
        string[] archivos, paths;
        bool listafueseleccionada = false, listBox2escondido=true,randomlist=false,full=false;
        // Create an ArrayList object that will hold the numbers
        ArrayList lstNumbers;
        // The Random class will be used to generate numbers
        Random rnd;
        
        public int RandomNumbers(int max)
        {
            

            // Generate a random number between 0 and the Max
            int number; 
            
            do // Repeatedly...
            {
                // ... generate a random number between 1 and the Max
                number = rnd.Next(0,max);

                if (lstNumbers.Count == max)
                {
                    lstNumbers.Clear();

                }

                // If the newly generated number in not yet in the list...
                if (!lstNumbers.Contains(number))
                {
                    // ... add it
                    lstNumbers.Add(number);
                    break;
                }               

            } while (true); // Do that again

            // Once the list is built, return it
            return number;
        }


        private void cargarultimoenrep()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ultimoenreproducirce.xml");

            XmlNode node = doc.SelectSingleNode("Lista");

            XmlNodeList prop = node.SelectNodes("Path");
            int i = 0;
            foreach (XmlElement item in prop)
            {
                listBox2.Items.Add(prop[i].InnerText);
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(prop[i].InnerText));
                i++;
            }
           // duracion_total();
            
        }
        private void cargarcongi()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Config.xml");
            
            XmlNode node = doc.SelectSingleNode("Confi");

            XmlNodeList prop = node.SelectNodes("Color");
            //int i = 0;              

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonBackFull.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            trackBar3.Hide();
            listBox4.Enabled = false;
            listBox4.Hide();
            listBox3.Hide();
            listBox2.Enabled = false;
            listBox2.Hide();
            numericUpDown1.Hide();
            groupBox1.Hide();
            //pictureBox1.Hide();
            lstNumbers = new ArrayList();
            rnd = new Random();

            if (File.Exists("ultimoenreproducirce.xml") == true)
            { 
              cargarultimoenrep();              
            }

            /*if (File.Exists("Config.xml") == true)
            { cargarcongi(); }*/
        }

        #region
        /*private void SetAlbumArt()
        {

            if (listBox2.SelectedItem != null)
            {
                TagLib.File file = TagLib.File.Create(listBox2.SelectedItem.ToString());
                if (file.Tag.Pictures.Length > 0)
                {
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    pictureBox1.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(100, 100, null, IntPtr.Zero);

                }
                else
                {
                    pictureBox1.Hide();
                }
            }
            
        }*/

        #endregion//para album

       

        private void buttonabrir_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                archivos=openFileDialog1.SafeFileNames;
                paths= openFileDialog1.FileNames;
                for (int i = 0; i < archivos.Length; i++)
                {
                    listBox2.Items.Add(paths[i]);
                    listBox1.Items.Add(archivos[i]);
                  
                }
                

               foreach (string d in open.FileNames)
                {
                    listBox1.Items.Add(d);
                    
                }
                listafueseleccionada = true;
            }
            if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (listafueseleccionada == true)
                {
                    listBox1.SelectedIndex = 0;
                    listBox2.SelectedIndex = listBox1.SelectedIndex;
                    axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
                    buttonplay.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14);
                    buttonplay.Text = "II";                   
                    
                }
            }
            //duracion_total();
            
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();            
            //axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                
                buttonplay.Font = new System.Drawing.Font("Wingdings 3", 14);
                buttonplay.Text = "u";
            }
            else
            {
                buttonplay.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14);
                buttonplay.Text = "II";
                
            }
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
            
        }

        private void buttonanterior_Click(object sender, EventArgs e)
        {
           /* if (progressBar1.Value >= progressBar1.Value / 2)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                listBox2.SelectedIndex = listBox1.SelectedIndex;
                axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem); 
            }
            else*/
            if (randomlist == false)
            {
                if (listBox1.SelectedIndex > 0)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
                    listBox2.SelectedIndex = listBox1.SelectedIndex;
                    axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
                    
                }
                else
                {
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    listBox2.SelectedIndex = listBox1.SelectedIndex;
                    axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
                    
                }
            }else
            {
                listBox1.SelectedIndex = RandomNumbers(listBox1.Items.Count);
                listBox2.SelectedIndex = listBox1.SelectedIndex;
                axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
                y++;

            }
        }

        private void buttonsiguiente_Click(object sender, EventArgs e)
        {
            if (randomlist == false)
            {
                if (listBox1.SelectedIndex != listBox1.Items.Count - 1)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                    listBox2.SelectedIndex = listBox1.SelectedIndex;
                    axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
                    //axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
                }
                else
                {
                    listBox1.SelectedIndex = 0;
                    listBox2.SelectedIndex = listBox1.SelectedIndex;
                    axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
                    //axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
                }
            }
            else
            {








                        listBox1.SelectedIndex = RandomNumbers(listBox1.Items.Count);
                        listBox2.SelectedIndex = listBox1.SelectedIndex;
                        axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
                        y++;                        
                    
                }

        }

        private void buttonplay_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsUndefined)
            {

                if (listBox1.SelectedIndex >= 0)
                {
                    listBox2.SelectedIndex = listBox1.SelectedIndex;
                    axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
                }
                else
                if (label2.Text == "0:00")
                {
                    listBox1.SelectedIndex = 0;
                    listBox2.SelectedIndex = listBox1.SelectedIndex;
                    axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem); 
                }
                
                buttonplay.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14);
                buttonplay.Text = "II";
            }
            else
            {

                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    buttonplay.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14);
                    buttonplay.Text = "II";

                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    buttonplay.Font = new System.Drawing.Font("Wingdings 3", 14);
                    buttonplay.Text = "u";
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void buttoncerrar_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Lista");
            xmlDoc.AppendChild(rootNode);
            XmlNode userNode;
            XmlAttribute attribute;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.SelectedIndex = i;
                listBox1.SelectedIndex = i;
                userNode = xmlDoc.CreateElement("Path");
                attribute = xmlDoc.CreateAttribute("Time");
                attribute.Value = DateTime.Now.ToString("hhmmss");
                userNode.Attributes.Append(attribute);
                userNode.InnerText = Convert.ToString(listBox2.SelectedItem);
                rootNode.AppendChild(userNode);

            }
            
            

            xmlDoc.Save("ultimoenreproducirce.xml");

            XmlDocument ConfiDoc = new XmlDocument();
            XmlNode rootNodeconfi = ConfiDoc.CreateElement("Confi");
            ConfiDoc.AppendChild(rootNodeconfi);
            XmlNode userNodeconfi;
            XmlAttribute attributeconfi;

            userNodeconfi = ConfiDoc.CreateElement("Color");
            attributeconfi = ConfiDoc.CreateAttribute("Time");
            attributeconfi.Value = DateTime.Now.ToString("hhmmss");
            userNodeconfi.Attributes.Append(attributeconfi);
            Color c = this.BackColor;
            userNodeconfi.InnerText = c.Name;
            rootNodeconfi.AppendChild(userNodeconfi);

            ConfiDoc.Save("Config.xml");

            Close();
        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

            if (e.newState == 3)
            {
                if ((System.IO.Path.GetExtension(Convert.ToString(listBox2.SelectedItem)).ToUpperInvariant() == ".WMV") || (System.IO.Path.GetExtension(Convert.ToString(listBox2.SelectedItem)).ToUpperInvariant() == ".AVI"))
                {
                    axWindowsMediaPlayer1.fullScreen = true;
                    MessageBox.Show("Alt+Enter Para salir de pantalla completa", "Para Salir", MessageBoxButtons.OK);
                }
                int seg;
                double min;
                double dur = axWindowsMediaPlayer1.currentMedia.duration;
                numericUpDown1.Maximum =Convert.ToDecimal(dur);
                trackBar2.Maximum =Convert.ToInt32(dur);
                numericUpDown1.Value = 0;
                progressBar1.Maximum = (int)dur;
                

                min = Math.Floor(dur/ 60) ;                
                seg = Convert.ToInt32(dur % 60);
                if (seg < 10)
                {
                    label2.Text = Convert.ToString(min) + ":0" + Convert.ToString(seg);
                    finalcancion = Convert.ToString(min) + ":0" + Convert.ToString(seg - 1);
                }
                else 
                {
                   label2.Text = Convert.ToString(min) + ":" + Convert.ToString(seg);
                   finalcancion = Convert.ToString(min) + ":" + Convert.ToString(seg-1);
                }
                //hola
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int seg;
            double min,dur;
            progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            trackBar2.Value = progressBar1.Value;
            dur = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            
            
            min = Math.Floor(dur / 60);
            seg = Convert.ToInt32(progressBar1.Value-min*60);
            if(seg<10)
            label3.Text = Convert.ToString(min) + ":0" + Convert.ToString(seg);
            else
            label3.Text = Convert.ToString(min) + ":" + Convert.ToString(seg);
            if (randomlist == false)
            {
                if (label2.Text != "0:00")
                {
                    if (label3.Text == finalcancion)
                    {
                        if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                        {
                            listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                            listBox2.SelectedIndex = listBox1.SelectedIndex;
                            axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
                        }
                        else
                        {
                            listBox1.SelectedIndex = 0;
                            listBox2.SelectedIndex = listBox1.SelectedIndex;
                            axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
                        }
                    }
                }
            }
            else
            {
                
                
                if (label2.Text != "0:00")
                {
                    if (label3.Text == finalcancion)
                    {



                        listBox1.SelectedIndex = RandomNumbers(listBox1.Items.Count);
                        listBox2.SelectedIndex = listBox1.SelectedIndex;
                        axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
                        y++;                        
                    }
                }
            }    
        }

        private void toolStripLabel4_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel4.ForeColor = Color.Red;
        }

        private void toolStripLabel4_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel4.ForeColor = Color.Turquoise;
        }

        private void toolStripLabel2_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel2.ForeColor = Color.Red;
        }

        private void toolStripLabel2_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel2.ForeColor = Color.Turquoise;
        }

        private void buttonplay_MouseEnter(object sender, EventArgs e)
        {
            buttonplay.ForeColor = Color.Red;
        }

        private void buttonplay_MouseLeave(object sender, EventArgs e)
        {
            buttonplay.ForeColor = Color.Turquoise;
        }

        private void buttonsiguiente_MouseEnter(object sender, EventArgs e)
        {
            buttonsiguiente.ForeColor = Color.Red;
        }

        private void buttonsiguiente_MouseLeave(object sender, EventArgs e)
        {
            buttonsiguiente.ForeColor = Color.Turquoise;
        }

        private void buttonanterior_MouseEnter(object sender, EventArgs e)
        {
            buttonanterior.ForeColor = Color.Red;
        }

        private void buttonanterior_MouseLeave(object sender, EventArgs e)
        {
            buttonanterior.ForeColor = Color.Turquoise;
        }

        private void mostrarRutaDeLaCancionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox2escondido == true)
            {
                listBox2.Show();
                listBox2escondido = false;
                mostrarRutaDeLaCancionToolStripMenuItem.Text = "Esconder Ruta de la cancion";
            }
            else
            {
                listBox2.Hide();
                listBox2escondido = true;
                mostrarRutaDeLaCancionToolStripMenuItem.Text = "Mostrar Ruta de la cancion";
            }
        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            { if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                buttonplay.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14);
                buttonplay.Text = "II";

            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                buttonplay.Font = new System.Drawing.Font("Wingdings 3", 14);
                buttonplay.Text = "u";
            }}
            if ((e.KeyChar == 127)||(e.KeyChar == 8))
            {
                listBox2.SelectedIndex = listBox1.SelectedIndex;
                listBox2.Items.Remove(listBox2.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            if (e.KeyChar == 13)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                //axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
                listBox2.SelectedIndex = listBox1.SelectedIndex;
                axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
                {

                    buttonplay.Font = new System.Drawing.Font("Wingdings 3", 14);
                    buttonplay.Text = "u";
                }
                else
                {
                    buttonplay.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14);
                    buttonplay.Text = "II";

                }
 
            }
            
        }

        private void bloquearListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Enabled == true)
            {
                
                listBox1.Enabled = false;
                bloquearListaToolStripMenuItem.Text = "Desbloquear lista";
            }
            else
            {
                listBox1.Enabled = true;
                bloquearListaToolStripMenuItem.Text = "Bloquear lista";
            }
        }

        private void trackBar1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void trackBar1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Turquoise;
        }
        

        
        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] Filelist = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (System.IO.Path.GetExtension(Filelist[0]).ToUpperInvariant() != ".XML")
            {
                for (int i = 0; i < Filelist.Length; i++)
                {
                    listBox2.Items.Add(Filelist[i]);
                    listBox1.Items.Add(Path.GetFileNameWithoutExtension(Filelist[i]));

                }
            }
            else if (System.IO.Path.GetExtension(Filelist[0]).ToUpperInvariant() == ".XML")
            {
               
                XmlDocument doc = new XmlDocument();
                doc.Load(Filelist[0]);

                XmlNode node = doc.SelectSingleNode("Lista");

                XmlNodeList prop = node.SelectNodes("Path");
                int i = 0;
                foreach (XmlElement item in prop)
                {
                    listBox2.Items.Add(prop[i].InnerText);
                    listBox1.Items.Add(Path.GetFileNameWithoutExtension(prop[i].InnerText));
                    i++;
                }
            }
            
            listafueseleccionada = true;          

            //Pantalla.Image = Image.FromFile(Filelist[0]);
            //Img = Pantalla.Image;

            if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (listafueseleccionada == true)
                {
                    listBox1.SelectedIndex = 0;
                    listBox2.SelectedIndex = listBox1.SelectedIndex;
                    axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
                    buttonplay.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14);
                    buttonplay.Text = "II";
                }
                //duracion_total();
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                        
                e.Effect = DragDropEffects.Copy;
            
            else
                e.Effect = DragDropEffects.None;
            
        }

        private void limpiarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {           
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                buttonplay.Font = new System.Drawing.Font("Wingdings 3", 14);
                buttonplay.Text = "u";
            
        }

        private void cambiarColorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog Colordiag = new ColorDialog();
            Colordiag.ShowDialog();
            this.BackColor=Colordiag.Color;
            listBox1.BackColor = Colordiag.Color;
            listBox2.BackColor = Colordiag.Color;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.settings.mute == false)
            {
                axWindowsMediaPlayer1.settings.mute = true;                
                label1.Text = "Xr";
            }
            else
            {
                axWindowsMediaPlayer1.settings.mute = false;
                label1.Text = "X~";
            }
        }

        private void reproduccionPantallaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.fullScreen = true;
                MessageBox.Show("Alt+Enter Para salir de pantalla completa", "Para Salir", MessageBoxButtons.OK);

            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (randomlist == false)
            {
                button6.BackColor = Color.DarkRed;
                randomlist = true;
            }
            else
            {
                button6.BackColor = Color.Transparent;
                randomlist = false;
                lstNumbers.Clear();
            }
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            //label4.ForeColor = Color.Red;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            if (randomlist == false)
            {
                
                //label4.ForeColor = Color.Turquoise;
            }
            else
            {
                //label4.ForeColor = Color.DeepPink;
                
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {           
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToDouble(numericUpDown1.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBar2.Value;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Lista");
            xmlDoc.AppendChild(rootNode);
            XmlNode userNode;
            XmlAttribute attribute;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.SelectedIndex = i;
                listBox1.SelectedIndex=i;
                userNode = xmlDoc.CreateElement("Path");
                attribute = xmlDoc.CreateAttribute("Time");
                attribute.Value = DateTime.Now.ToString("hhmmss");
                userNode.Attributes.Append(attribute);
                userNode.InnerText = Convert.ToString(listBox2.SelectedItem);
                rootNode.AppendChild(userNode);

            }
            //xmlDoc.Save("ListSong" + DateTime.Now.ToString("hhmmss") + ".xml"); 
            SaveFileDialog Save = new SaveFileDialog();
            Save.Title = "Save ListSong Files";
            Save.Filter = "Xml|*.xml|All files(*.*)|*.*";
            Save.FileName = "ListSong" + DateTime.Now.ToString("hhmmss");
            if (Save.ShowDialog() == DialogResult.OK)
            {
                xmlDoc.Save(Save.FileName);
            } 

        }

        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            /*listBox1.Items.Clear();
            listBox2.Items.Clear();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            buttonplay.Font = new System.Drawing.Font("Wingdings 3", 14);
            buttonplay.Text = "u";*/
            if (File.Exists("ListSong.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("ListSong.xml");

                XmlNode node = doc.SelectSingleNode("Lista");

                XmlNodeList prop = node.SelectNodes("Path");
                int i = 0;
                foreach (XmlElement item in prop)
                {
                    listBox2.Items.Add(prop[i].InnerText);
                    listBox1.Items.Add(Path.GetFileNameWithoutExtension(prop[i].InnerText));
                    i++;
                }
                //duracion_total();
            }
        }


        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openXml = new OpenFileDialog();
            openXml.Title = "Open ListSong Files";
            openXml.Filter = "Xml|*.xml|All files(*.*)|*.*";

            if (openXml.ShowDialog() == DialogResult.OK)
            {
                           
                XmlDocument doc = new XmlDocument();
                doc.Load(openXml.FileName);

                XmlNode node = doc.SelectSingleNode("Lista");

                XmlNodeList prop = node.SelectNodes("Path");
                int i = 0;
                foreach (XmlElement item in prop)
                {
                    listBox2.Items.Add(prop[i].InnerText);
                    listBox1.Items.Add(Path.GetFileNameWithoutExtension(prop[i].InnerText));
                    i++;
                }
                //duracion_total();
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            if (File.Exists("ListSong.xml"))
            doc.Load("ListSong.xml");

            XmlNode rootNode = doc.SelectSingleNode("Lista");
            doc.AppendChild(rootNode);
            XmlNode userNode;
            XmlAttribute attribute;            
                
            userNode = doc.CreateElement("Path");
            attribute = doc.CreateAttribute("Number");
            attribute.Value = DateTime.Now.ToString("hhmmss");
            userNode.Attributes.Append(attribute);
            userNode.InnerText = Convert.ToString(listBox2.SelectedItem);
            rootNode.AppendChild(userNode);
            doc.Save("ListSong.xml");
           
            //xmlDoc.Save("ListSong" + DateTime.Now.ToString("hhmmss") + ".xml");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            listBox3.Items.Clear();
            XmlDocument doc = new XmlDocument();
            if (File.Exists("ListSong.xml"))
            doc.Load("ListSong.xml");

            XmlNode node = doc.SelectSingleNode("Lista");

            XmlNodeList prop = node.SelectNodes("Path");
            int i = 0;
            foreach (XmlElement item in prop)
            {
                listBox4.Items.Add(prop[i].InnerText);
                listBox3.Items.Add(Path.GetFileNameWithoutExtension(prop[i].InnerText));
                i++;
            }

            groupBox1.Show();
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();        
            listBox4.Show();
            listBox3.Show();
            
        }

        private void listBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 127) || (e.KeyChar == 8))
            {                
                listBox4.SelectedIndex = listBox3.SelectedIndex;
                listBox4.Items.Remove(listBox4.SelectedItem);
                listBox3.Items.Remove(listBox3.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox4.SelectedIndex = listBox3.SelectedIndex;
            listBox4.Items.Remove(listBox4.SelectedItem);
            listBox3.Items.Remove(listBox3.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Lista");
            xmlDoc.AppendChild(rootNode);
            XmlNode userNode;
            XmlAttribute attribute;

            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                listBox4.SelectedIndex = i;
                listBox3.SelectedIndex = i;
                userNode = xmlDoc.CreateElement("Path");
                attribute = xmlDoc.CreateAttribute("Time");
                attribute.Value = DateTime.Now.ToString("hhmmss");
                userNode.Attributes.Append(attribute);
                userNode.InnerText = Convert.ToString(listBox4.SelectedItem);
                rootNode.AppendChild(userNode);

            }
            xmlDoc.Save("ListSong.xml");
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            listBox4.Hide();
            listBox3.Hide();
            groupBox1.Hide();
             
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Lista");
            xmlDoc.AppendChild(rootNode);
            XmlNode userNode;
            XmlAttribute attribute;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.SelectedIndex = i;
                listBox1.SelectedIndex = i;
                userNode = xmlDoc.CreateElement("Path");
                attribute = xmlDoc.CreateAttribute("Time");
                attribute.Value = DateTime.Now.ToString("hhmmss");
                userNode.Attributes.Append(attribute);
                userNode.InnerText = Convert.ToString(listBox2.SelectedItem);
                rootNode.AppendChild(userNode);

            }
            xmlDoc.Save("ultimoenreproducirce.xml");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            button3.Hide();
            button1.Hide();
            button2.Hide();
            button4.Hide();
            button5.Hide();
            listBox4.Hide();
            listBox3.Hide();
            groupBox1.Hide();

            //axWindowsMediaPlayer1.settings.balance
            
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.balance = trackBar3.Value;
        }

        private void trackBar3_MouseLeave(object sender, EventArgs e)
        {
            trackBar3.Hide();
        }

        private void regularBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trackBar3.Show();
        }

        public void MoveUp()
        {
            MoveItem(-1);
        }

        public void MoveDown()
        {
            MoveItem(1);
        }

        public void MoveItem(int direction)
        {
            // Checking selected item
            if (listBox3.SelectedItem == null || listBox3.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = listBox3.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBox3.Items.Count)
                return; // Index out of range - nothing to do

            object selected = listBox3.SelectedItem;
            object selected2 = listBox4.SelectedItem;


            // Removing removable element
            listBox3.Items.Remove(selected);
            listBox4.Items.Remove(selected2);

            // Insert it in new position
            listBox3.Items.Insert(newIndex, selected);
            listBox4.Items.Insert(newIndex, selected2);

            // Restore selection
            listBox3.SetSelected(newIndex, true);
            listBox4.SetSelected(newIndex, true);
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.SelectedIndex = listBox3.SelectedIndex;
        }

        private void buttonBackFull_Click(object sender, EventArgs e)
        {
            buttonBackFull.Hide();
            //axWindowsMediaPlayer1.Dock = dis;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Normal;
        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            if (buttonBackFull.Visible == false)
            {
                buttonBackFull.Show();
                //axWindowsMediaPlayer1.Dock = DockStyle.Fill;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                buttonBackFull.Hide();
                //axWindowsMediaPlayer1.Dock = dis;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void toolStripLabel1_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel1.ForeColor = Color.Red;
        }

        private void toolStripLabel1_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel1.ForeColor = Color.Turquoise;
        }

        

        














        
    }
}