using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Word;//agregar referencia Microsoft.Office.Interop.Word 
using Entidades; //de aqui se saca la clase paciente para llenar la plantilla, esto cambia segun el objeto

/*antes que nada es necesario crear una plantilla de word para utilizar esta clase*/

namespace PlantillaBase_de_datos //arreglar namespace para que funcione en el proyecto deseado
{
    class Plantilla
    {
        
            // creando objeto de salida
            Object oMissing = System.Reflection.Missing.Value;
            
            // localizando el objeto de salido con la ruta
            Object oTemplatePath = "C:/PlantillaBase de datos/PlantillaBase de datos/bin/Debug/Plantilla.dotx";//arreglar // o \\ 
 
            //creando instancia de aplicacion que se usara 
            Application wordApp = new Application();
            // creando instancia del documento
            Document wordDoc = new Document();
            
            //metodo constructos... se puede cambiar para que la clase trabaje con diferentes metodos y funciones para difentetes plantillas
            public Plantilla(Paciente p)
            {
                //agregando la ruta y otros espesificaciones a la instancia del documento
                wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

                //for que recorre cada campo de la plantilla del documento
                foreach (Field myMergeField in wordDoc.Fields)
                {


                    Range rngFieldCode = myMergeField.Code; 

                    String fieldText = rngFieldCode.Text;





                    if (fieldText.StartsWith(" MERGEFIELD"))//validacion para llenar campos que sean MERGEFIELD
                    {

                        

                                            

                        Int32 endMerge = fieldText.IndexOf("\\"); // final del campo

                        Int32 fieldNameLength = fieldText.Length - endMerge; //tamaño del campo a llenar

                        String fieldName = fieldText.Substring(11, endMerge - 11);//corte del nombre del campo por defecto

                       
                      fieldName = fieldName.Trim(); //se eleminan espacios en blanco

                  
                        //se llena cada campo con su respectivo dato
                        if (fieldName == "fNombre") 
                        {
                            myMergeField.Select();
                            wordApp.Selection.TypeText(p.Nombres1);
                        }

                        if (fieldName == "fApellido")
                        {
                            myMergeField.Select();
                            wordApp.Selection.TypeText(p.Apellidos1);
                        }

                        if (fieldName == "fCedula")
                        {
                            myMergeField.Select();
                            wordApp.Selection.TypeText(p.Cedula1);
                        }

                        if (fieldName == "fTipoSangre")
                        {
                            myMergeField.Select();
                            wordApp.Selection.TypeText(p.TipoSangre1);
                        }

                        if (fieldName == "fPeso")
                        {
                            myMergeField.Select();
                            wordApp.Selection.TypeText(Convert.ToString(p.Peso1));
                        }
                        

                        

                    }

                }
                
                wordDoc.SaveAs(p.Nombres1 + p.Apellidos1 + ".doc");//save as
                wordApp.Documents.Open(p.Nombres1 + p.Apellidos1 + ".doc");//opcional: abre el documento para visualizar despues de haber guardado
                //wordApp.Application.Quit();
            }
    }
}
