using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Aforge_Web_Cam
{
    class ImagenFiltro
    {
        //public Bitmap ImageFiltered;
        public Bitmap img;        
        
        public ImagenFiltro(Bitmap _img,string filtername)
        {
            switch (filtername)
            {
                case "Rio":
                    {

                        float[][] colorMatrixElements = {
	                    new float[] {1.4f,0.05f,0.05f,0,0},            
                        new float[] {0.05f,1.05f,0.05f,0,0},
                        new float[] {0.05f,0.05f,0.8f,0,0},
                        new float[] {0,0,0,1,0},
                        new float[] {0.25f,0.20f,0.20f,-0.055f,1}
            
                                            };
                        ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                        ImageAttributes imageAttributes = new ImageAttributes();
                        imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        //Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

                        Graphics _g = default(Graphics);
                        Bitmap ImageFiltered = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                        _g = Graphics.FromImage(ImageFiltered);
                        _g.DrawImage(_img, new Rectangle(0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1), 0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                        img = ImageFiltered;
                        break;
                    }
                case "Janeiro":
                    {

                        float[][] colorMatrixElements = {
	                    new float[] {1.4f,0.05f,0.05f,0,0},            
                        new float[] {0.05f,1.05f,0.05f,0,0},
                        new float[] {0.05f,0.05f,1.05f,0,0},
                        new float[] {0,0,0,1,0},
                        new float[] {0.25f,0.25f,0.25f,-0.05f,1}
            
                                            };
                        ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                        ImageAttributes imageAttributes = new ImageAttributes();
                        imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        //Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

                        Graphics _g = default(Graphics);
                        Bitmap ImageFiltered = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                        _g = Graphics.FromImage(ImageFiltered);
                        _g.DrawImage(_img, new Rectangle(0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1), 0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                        img = ImageFiltered;
                        break;
                    }

                case "Wasatch":
                    {

                        float[][] colorMatrixElements = {
	                    new float[] {1.3f,0.2f,0.05f,5,0},            
                        new float[] {0.25f,1.3f,0.05f,0,0},
                        new float[] {0.05f,0.05f,1.3f,0,0},
                        new float[] {0.05f,0.05f,0.05f,1.2f,0},
                        new float[] {-0.35f,-0.35f,-0.35f,-0.3f,1}
            
                                            };
                        ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                        ImageAttributes imageAttributes = new ImageAttributes();
                        imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        //Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

                        Graphics _g = default(Graphics);
                        Bitmap ImageFiltered = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                        _g = Graphics.FromImage(ImageFiltered);
                        _g.DrawImage(_img, new Rectangle(0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1), 0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                        img = ImageFiltered;
                        break;
                    }
                case "1980":
                    {

                        float[][] colorMatrixElements = {
	                    new float[] {1.4f,0.05f,0.05f,0,0},            
                        new float[] {0.05f,1.4f,0.05f,0,0},
                        new float[] {0.05f,0,1.4f,0,0},
                        new float[] {-0.05f,0,0,1,0},
                        new float[] {-0.3f,-0.3f,-0.3f,0,1}
            
                                            };
                        ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                        ImageAttributes imageAttributes = new ImageAttributes();
                        imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        //Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

                        Graphics _g = default(Graphics);
                        Bitmap ImageFiltered = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                        _g = Graphics.FromImage(ImageFiltered);
                        _g.DrawImage(_img, new Rectangle(0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1), 0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                        img = ImageFiltered;
                        break;
                    }

                case "NeonWhite":
                    {

                        float[][] colorMatrixElements = {
	                    new float[] {1.75f,0.05f,0,0,0},            
                        new float[] {0.05f,1.5f,0,0,0},
                        new float[] {0.05f,0,1.55f,0,0},
                        new float[] {0,0,0,1.5f,0},
                        new float[] {0,	0,0,0,1.5f}
            
                                            };
                        ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                        ImageAttributes imageAttributes = new ImageAttributes();
                        imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        //Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

                        Graphics _g = default(Graphics);
                        Bitmap ImageFiltered = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                        _g = Graphics.FromImage(ImageFiltered);
                        _g.DrawImage(_img, new Rectangle(0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1), 0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                        img = ImageFiltered;
                        break;
                    }
                    case "Aspen":
                    {
                        
                        float[][] colorMatrixElements = {
	                    new float[] {1.15f, -0.05f, 0.7f, 0.05f, 0.05f},
                        new float[] {0, 1.15f, -0.35f, -0.05f, 0.05f},
                        new float[] {0.15f, 0.05f, 1.15f, -0.05f, 0.05f},
                        new float[] {0,0,0,0.95f,0.05f},
                        new float[] {-0.15f,0.05f,0.15f,0.05f,1}            
                                            };
                        ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                        ImageAttributes imageAttributes = new ImageAttributes();
                        imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        //Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

                        Graphics _g = default(Graphics);
                        Bitmap ImageFiltered = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                        _g = Graphics.FromImage(ImageFiltered);
                        _g.DrawImage(_img, new Rectangle(0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1), 0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                        img = ImageFiltered;
                        break;
	    
                    }
                case "Sepia":
                    {
                        
                        float[][] colorMatrixElements = {
	                    new float[] {.393f, .349f, .272f, 0, 0},
                        new float[] {.769f, .686f, .534f, 0, 0},
                        new float[] {.189f, .168f, .131f, 0, 0},
                        new float[] {0,0,0,1,0},
                        new float[] {0,	0,0,0,1}            
                                            };
                        ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                        ImageAttributes imageAttributes = new ImageAttributes();
                        imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        //Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

                        Graphics _g = default(Graphics);
                        Bitmap ImageFiltered = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                        _g = Graphics.FromImage(ImageFiltered);
                        _g.DrawImage(_img, new Rectangle(0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1), 0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                        img = ImageFiltered;
                        break;
	    
                    }
                case "EscalaGris":
                    {
                        float[][] colorMatrixElements = {
	                    new float[] {.3f, .3f, .3f, 0, 0},
                        new float[] {.59f, .59f, .59f, 0, 0},
                        new float[] {.11f, .11f, .11f, 0, 0},
                        new float[] {0,0,0,1,0},
                        new float[] {0,	0,0,0,1}            
                                            };
                        ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                        ImageAttributes imageAttributes = new ImageAttributes();
                        imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        //Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

                        Graphics _g = default(Graphics);
                        Bitmap ImageFiltered = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                        _g = Graphics.FromImage(ImageFiltered);
                        _g.DrawImage(_img, new Rectangle(0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1), 0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                        img = ImageFiltered; 
                        break;
 
                    }
                case "Soleado":
                    {
                        float lumR = 0.3086f;  //or  0.2125
                        float lumG = 0.6094f;  //or  0.7154
                        float lumB = 0.0820f;  //or  0.0721
                        float V = 3 * 0.05f;
                        float Sr = (1 - V) * lumR;
                        float Sg = (1 - V) * lumG;
                        float Sb = (1 - V) * lumB;
                        float t = ((1.0f - 3) / 2.0f) * 0.05f;
                        float[][] colorMatrixElements = {
	                    new float[] {1.25f+V,(V*Sr),(V*Sr),0,0},            
                        new float[] {0.2f+V,(V*Sg)+1,(V*Sg),0,0},
                        new float[] {(V*Sb),(V*Sb),(V*Sb)+1f,0,0},
                        new float[] {0,0.1f,0,1,0},
                        new float[] {t,t,t,0,1}
            
                                            };
                        ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                        ImageAttributes imageAttributes = new ImageAttributes();
                        imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        //Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

                        Graphics _g = default(Graphics);
                        Bitmap ImageFiltered = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                        _g = Graphics.FromImage(ImageFiltered);
                        _g.DrawImage(_img, new Rectangle(0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1), 0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                        img = ImageFiltered; 
                        break;

                    }
                case "Orange":
                    {
                        float value = 3 * 0.05f;
                        float[][] colorMatrixElements = {
	                    new float[] {1,0,0,0,0},            
                        new float[] {0,1,0,0,0},
                        new float[] {value,0,1,0,0},
                        new float[] {value,0,0,1,0},
                        new float[] {value,	value,value,0,1}
            
                                            };
                        ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                        ImageAttributes imageAttributes = new ImageAttributes();
                        imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        //Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

                        Graphics _g = default(Graphics);
                        Bitmap ImageFiltered = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                        _g = Graphics.FromImage(ImageFiltered);
                        _g.DrawImage(_img, new Rectangle(0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1), 0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                        img = ImageFiltered;
                        break;
                    }
                case "Cloudy":
                    {
                        float value = -3 * 0.05f;
                        float[][] colorMatrixElements = {
	                    new float[] {1,0,0,0,0},            
                        new float[] {0,1,0,0,0},
                        new float[] {value,0,1,0,0},
                        new float[] {value,0,0,1,0},
                        new float[] {value,	value,value,0,1}
            
                                            };
                        ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                        ImageAttributes imageAttributes = new ImageAttributes();
                        imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        //Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

                        Graphics _g = default(Graphics);
                        Bitmap ImageFiltered = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                        _g = Graphics.FromImage(ImageFiltered);
                        _g.DrawImage(_img, new Rectangle(0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1), 0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                        img = ImageFiltered;
                        break;
                    }
                case "Normal":
                    {
                        
                        float[][] colorMatrixElements = {
	                    new float[] {1,0,0,0,0},            
                        new float[] {0,1,0,0,0},
                        new float[] {0,0,1,0,0},
                        new float[] {0,0,0,1,0},
                        new float[] {0,	0,0,0,1}
            
                                            };
                        ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                        ImageAttributes imageAttributes = new ImageAttributes();
                        imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        //Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

                        Graphics _g = default(Graphics);
                        Bitmap ImageFiltered = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
                        _g = Graphics.FromImage(ImageFiltered);
                        _g.DrawImage(_img, new Rectangle(0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1), 0, 0, ImageFiltered.Width + 1, ImageFiltered.Height + 1, GraphicsUnit.Pixel, imageAttributes);
                        img = ImageFiltered;
                        break;
                    }

                default:
                    {
                      
                        img  = _img;
                        break;

                    }
                    
            }
 
        }
    }
}
