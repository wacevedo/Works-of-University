using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Word;
using Entidades;

namespace PlantillaBase_de_datos
{
    class Plantilla
    {
         //OBJECT OF MISSING "NULL VALUE"
 
            Object oMissing = System.Reflection.Missing.Value;

            Object oTemplatePath = "C:/Users/pc/Documents/Visual Studio 2010/Projects/PlantillaBase de datos/PlantillaBase de datos/bin/Debug/Plantilla.dotx";
 
             
            Application wordApp = new Application();
            Document wordDoc = new Document();

            public Plantilla(Paciente p)
            {
                wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

                foreach (Field myMergeField in wordDoc.Fields)
                {


                    Range rngFieldCode = myMergeField.Code;

                    String fieldText = rngFieldCode.Text;



                    // ONLY GETTING THE MAILMERGE FIELDS

                    if (fieldText.StartsWith(" MERGEFIELD"))
                    {

                        // THE TEXT COMES IN THE FORMAT OF

                        // MERGEFIELD  MyFieldName  \\* MERGEFORMAT

                        // THIS HAS TO BE EDITED TO GET ONLY THE FIELDNAME "MyFieldName"

                        Int32 endMerge = fieldText.IndexOf("\\");

                        Int32 fieldNameLength = fieldText.Length - endMerge;

                        String fieldName = fieldText.Substring(11, endMerge - 11);

                        // GIVES THE FIELDNAMES AS THE USER HAD ENTERED IN .dot FILE

                        fieldName = fieldName.Trim();

                        // **** FIELD REPLACEMENT IMPLEMENTATION GOES HERE ****//

                        // THE PROGRAMMER CAN HAVE HIS OWN IMPLEMENTATIONS HERE 

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
                
                wordDoc.SaveAs(p.Nombres1 + p.Apellidos1 + ".doc");
                wordApp.Documents.Open(p.Nombres1 + p.Apellidos1 + ".doc");
                //wordApp.Application.Quit();
            }
    }
}
