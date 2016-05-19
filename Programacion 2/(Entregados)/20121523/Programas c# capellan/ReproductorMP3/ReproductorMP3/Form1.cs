using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Media;
using System.IO;
using System.Xml.XPath;
using System.Xml;

namespace ReproductorMP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
        }
        int x = 0, y=0;
        string[] archivo, where;
        string endmusic;
        bool listaseleccion = false, listb2noshow = true;
        double duracion, minactual;
        int seg, segf;
        double min, minf;
        string presentarTF;
        string presentarTA;


        private void Form1_Load(object sender, EventArgs e)
        {
            listBox2.Enabled = false;
            listBox2.Hide();
            volumevalor.BackColor = Color.DimGray;
            toolStrip1.BackColor = Color.DimGray;
            toolStripButtonvol.BackColor = Color.Transparent;
            BackColor = Color.DimGray;
            listBox1.ForeColor = Color.DarkGreen;
            menuStrip1.BackColor = Color.DarkGray;
            AllowDrop = true;
            if (File.Exists("Favoritos.xml") == false)
            {
                
                    XmlDocument xmlista = new XmlDocument();
                    XmlNode nodoprincipal = xmlista.CreateElement("Lista");
                    xmlista.AppendChild(nodoprincipal);
                    XmlNode nodoruta;

                    for (int x = 0; x < listBox1.Items.Count; x++)
                    {
                        listBox2.SelectedIndex = x;
                        listBox1.SelectedIndex = x;
                        nodoruta = xmlista.CreateElement("Ruta");
                        nodoruta.InnerText = Convert.ToString(listBox2.SelectedItem);
                        nodoprincipal.AppendChild(nodoruta);
                    }
                    xmlista.Save("Favoritos.xml");
                    

                
            }
         }

        private void abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                archivo = openFile.SafeFileNames;
                where = openFile.FileNames;
                if (System.IO.Path.GetExtension(where[0]).ToUpperInvariant() == ".XML")
                {
                    XmlDocument abrirlista = new XmlDocument();
                    abrirlista.Load(where[0]);
                    XmlNode nodoprincipalabrir = abrirlista.SelectSingleNode("Lista");
                    XmlNodeList rutanodo = nodoprincipalabrir.SelectNodes("Ruta");
                    int x = 0;
                    foreach (XmlElement rutactual in rutanodo)
                    {
                        listBox2.Items.Add(rutanodo[x].InnerText);
                        listBox1.Items.Add(Path.GetFileNameWithoutExtension(rutanodo[x].InnerText));
                        x++;
                    }
                }
                    else
                    {
                    for (int i = 0; i < archivo.Length; i++)
                    {
                        listBox1.Items.Add(archivo[i]);
                        listBox2.Items.Add(where[i]);
                        x++;
                        y++;

                    }
                    foreach (string d in abrir.FileNames)
                    {
                        listBox1.Items.Add(d);

                    }
                    label1.Text = Convert.ToString("Canciones: " + listBox1.Items.Count);
                    listaseleccion = true;
                    }
                }
                if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying)

                    if (listaseleccion == true)
                    {
                        listBox1.SelectedIndex = 0;
                        listBox2.SelectedIndex = listBox1.SelectedIndex;
                        axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
                        start.Text = "Pause";

                    }
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            {

                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    start.Text = "Pause";
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    start.Text = "Play";
                }
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                start.Text = "Play";
            }
            else
            {
               start.Text = "Pause";
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = volumevalor.Value;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.settings.mute == false)
            {
                axWindowsMediaPlayer1.settings.mute = true;
                toolStripButtonvol.BackColor = Color.DarkRed;
            }
            else
            {
                axWindowsMediaPlayer1.settings.mute = false;
                toolStripButtonvol.BackColor = Color.DimGray;
            }

        }

        private void palante_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != listBox1.Items.Count - 1)
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

        private void patras_Click(object sender, EventArgs e)
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
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cambiarColorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorf = new ColorDialog();
            //colorf.ShowHelp = true;
            colorf.Color = BackColor;
            
            if((colorf.ShowDialog()==System.Windows.Forms.DialogResult.OK))
            {
                BackColor = colorf.Color;
                menuStrip1.BackColor = colorf.Color;
            
            }

        }

        private void abrir_MouseEnter(object sender, EventArgs e)
        {
            abrir.BackColor = Color.Black;
            abrir.ForeColor = Color.White;
        }

        private void abrir_MouseLeave(object sender, EventArgs e)
        {
            abrir.BackColor = Color.Empty;
            abrir.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                       
        }

        private void patras_MouseEnter(object sender, EventArgs e)
        {
            patras.BackColor = Color.Sienna;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        private void start_MouseEnter(object sender, EventArgs e)
        {
            start.BackColor = Color.Black;
            start.ForeColor = Color.White;
        }

        private void start_MouseLeave(object sender, EventArgs e)
        {
            start.BackColor = Color.Empty;
            start.ForeColor = Color.Black;
        }

        private void colorPredeterminadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.DimGray;
            menuStrip1.BackColor = Color.DarkGray;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] ListadeArch = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                
                for (int x = 0; x < ListadeArch.Length;x++)
                {
                    listBox2.Items.Add(ListadeArch[x]);
                    listBox1.Items.Add(Path.GetFileNameWithoutExtension(ListadeArch[x]));
                }
                label1.Text = Convert.ToString("Canciones: " + listBox1.Items.Count);

                if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    listBox1.SelectedIndex = 0;
                    listBox2.SelectedIndex = listBox1.SelectedIndex;
                    axWindowsMediaPlayer1.URL = Convert.ToString(listBox2.SelectedItem);
                    start.Text = "Pause";
                }

        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))

                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void tracktiempo_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = tracktiempo.Value;
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

            if (e.newState == 3)
            {
                duracion = axWindowsMediaPlayer1.currentMedia.duration;
                tracktiempo.Maximum = Convert.ToInt32(duracion);
                minf = Math.Floor(duracion / 60);
                segf = Convert.ToInt32(duracion % 60);
                if (segf < 10)
                {
                    presentarTF = Convert.ToString(minf) + ":0" + Convert.ToString(segf);
                    endmusic = Convert.ToString(minf) + ":0" + Convert.ToString(segf - 1);
                }
                else
                {
                    presentarTF = Convert.ToString(minf) + ":" + Convert.ToString(segf);
                    endmusic = Convert.ToString(minf) + ":" + Convert.ToString(segf-1);
                }


            }

                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tracktiempo.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            minactual = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            min = Math.Floor(minactual / 60);
            seg = Convert.ToInt32(minactual % 60);
            if(seg<10)
                presentarTA = Convert.ToString(min) + ":0" + Convert.ToString(seg);
            else
                presentarTA = Convert.ToString(min) + ":" + Convert.ToString(seg);

            tiempo.Text = presentarTA + " / " + presentarTF;
            if ((presentarTA == endmusic) && (presentarTF != "0:00"))
            {
                if (listBox1.SelectedIndex != listBox1.Items.Count - 1)
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

        private void button1_Click_2(object sender, EventArgs e)
        {
            XmlDocument xmlista = new XmlDocument();
            XmlNode nodoprincipal = xmlista.CreateElement("Lista");
            xmlista.AppendChild(nodoprincipal);
            XmlNode nodoruta;

            for (int x = 0; x < listBox1.Items.Count; x++)
            {
                listBox2.SelectedIndex = x;
                listBox1.SelectedIndex = x;
                nodoruta = xmlista.CreateElement("Ruta");
                nodoruta.InnerText = Convert.ToString(listBox2.SelectedItem);
                nodoprincipal.AppendChild(nodoruta);
            }

            SaveFileDialog guardarlista = new SaveFileDialog();
            guardarlista.Title = "Guardar Lista de Reproduccion";
            guardarlista.Filter = "Xml|*.xml|All Files(*.*)|*.*";
            guardarlista.FileName = "Lista_de_Canciones" + DateTime.Today.ToString("dd-mm-yyyy");
            if (guardarlista.ShowDialog() == DialogResult.OK)
            {
                xmlista.Save(guardarlista.FileName);
            }

        }

        private void borrarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument fav = new XmlDocument();
            if (File.Exists("Favoritos.xml"))
                fav.Load("Favoritos.xml");

            XmlNode nodoprincipal = fav.SelectSingleNode("Lista");
            fav.AppendChild(nodoprincipal);
            XmlNode agregarfav;

            agregarfav = fav.CreateElement("Ruta");
            agregarfav.InnerText = Convert.ToString(listBox2.SelectedItem);
            nodoprincipal.AppendChild(agregarfav);
            fav.Save("Favoritos.xml");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            if(File.Exists("Favoritos.xml"))
            {
                XmlDocument cargarfav=new XmlDocument();
                cargarfav.Load("Favoritos.xml");

                XmlNode nodoprincipal=cargarfav.SelectSingleNode("Lista");
                XmlNodeList nodorutas=nodoprincipal.SelectNodes("Ruta");
                int x=0;
                foreach (XmlElement sel in nodorutas)
                {
                    listBox2.Items.Add(nodorutas[x].InnerText);
                    listBox1.Items.Add(Path.GetFileNameWithoutExtension(nodorutas[x].InnerText));
                    x++;
                }




            }



        }

        /*All Files (*.*)|*.*|MP3 File|*.mp3|WAV File|*.wav|MP4 File|*.mp4|AVI File|*.avi|XML Lista|*.xml*/

     }
  }

