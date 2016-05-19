/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package crearpdf;

import java.io.*;
import java.sql.*; 

import com.itextpdf.text.*;
import com.itextpdf.text.pdf.*;
import com.conexionbd.*;

public class CrearPDF {
	
	public void crearPDF(int index){
		 switch (index) {
		case 1:{
			
			break;
			}
        case 2:{
			
			break;
			}

		default:{
			break;
			}
		}
	}
	public void prueba(){
		String select ="SELECT NOMBRE, EDAD, MES_NACIMIENTO, UNIVERSIDAD FROM PERSONAS";
		try {
			crearReportePDForacle(select);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	private void crearReportePDForacle(String select) throws Exception{
        
        Class.forName ("oracle.jdbc.OracleDriver"); //Invocamos el Driver de Oracle
        Connection con = DriverManager.getConnection("jdbc:oracle:thin:@//localhost:1521/xe", "willson"/*usuario*/, "123456"/*contraseña*/); //Creamos la conexion para acceder a la base de datos
        Statement stmt = con.createStatement();
        ResultSet resultados = stmt.executeQuery(select); //Hacemos el select de la info que extraeremos de la base de datos
        Document reportePDF = new Document(PageSize.LETTER, 88, 88, 80, 15); //Creamos un nuevo Documento usando la libreria itextpdf importada.
        PdfWriter.getInstance(reportePDF, new FileOutputStream("REPORTE.pdf"));//Instanciamos y creamos el archivo
        reportePDF.open(); //Abrimos el archivo creado arriba.
        
        
        Paragraph parrafo=new Paragraph("Reporte del dia");
        parrafo.add("Este es el repote que nos da los datos");
        parrafo.setAlignment(Element.ALIGN_CENTER);
        

        
        PdfPTable Treportes = new PdfPTable(5);//Aqui asignamos el numero de columnas que tendra la tabla, en este casi 5.
        PdfPCell celdas_tabla;//Creamos las celdas que seran llenadas con los datos extraidos
        
        //Agregamos los titulos de cada Columna                   
        Treportes.addCell ("ID");
        Treportes.addCell("Nombre");
        Treportes.addCell("Edad");
        Treportes.addCell("Mes Nacimiento");
        Treportes.addCell("Universidad");
        
         

        //ciclo para empezar a añadir los datos de la base de datos a las celdas correspondientes en el PDF
        ///System.out.println("Llenando pdf");
        while (resultados.next()) {
        	            
                        String id = resultados.getString("ID");
                        celdas_tabla=new PdfPCell(new Phrase(id));
                        Treportes.addCell(celdas_tabla);
                        String nombre=resultados.getString("NOMBRE");
                        celdas_tabla=new PdfPCell(new Phrase(nombre));
                        Treportes.addCell(celdas_tabla);
                        String edad=resultados.getString("EDAD");
                        celdas_tabla=new PdfPCell(new Phrase(edad));
                        Treportes.addCell(celdas_tabla);
                        String nacimiento=resultados.getString("MES_NACIMIENTO");
                        celdas_tabla=new PdfPCell(new Phrase(nacimiento));
                        Treportes.addCell(celdas_tabla);
                        String universidad=resultados.getString("UNIVERSIDAD");
                        celdas_tabla=new PdfPCell(new Phrase(universidad));
                        Treportes.addCell(celdas_tabla);
                        //System.out.println(id+" "+nombre+" "+edad);
                      }
       // System.out.println("Listo!");
        parrafo.add(Treportes);
        reportePDF.add(parrafo);
       
        //reportePDF.add(Treportes); //Insertamos los datos de la tabla en el PDF.                      
        reportePDF.close(); //Cerramos el archivo PDF una vez completado
        
        //Cerrar todas las conexiones
        resultados.close();
        stmt.close(); 
        con.close();               
        
}
	
        public static void main(String[] args) throws Exception{
                
                Class.forName ("oracle.jdbc.OracleDriver"); //Invocamos el Driver de Oracle
                Connection con = DriverManager.getConnection("jdbc:oracle:thin:@//localhost:1521/xe", "willson"/*usuario*/, "123456"/*contraseña*/); //Creamos la conexion para acceder a la base de datos
                Statement stmt = con.createStatement();
                ResultSet resultados = stmt.executeQuery("SELECT ID, NOMBRE, EDAD, MES_NACIMIENTO, UNIVERSIDAD FROM PERSONAS"); //Hacemos el select de la info que extraeremos de la base de datos
                Document reportePDF = new Document(PageSize.B4, 88, 88, 80, 15); //Creamos un nuevo Documento usando la libreria itextpdf importada.
                PdfWriter.getInstance(reportePDF, new FileOutputStream("REPORTE.pdf"));//Instanciamos y creamos el archivo
                reportePDF.open(); //Abrimos el archivo creado arriba.
                
                
                Paragraph parrafo=new Paragraph("Reporte del dia");
                parrafo.setAlignment(Element.ALIGN_CENTER);


                
                PdfPTable Treportes = new PdfPTable(5);//Aqui asignamos el numero de columnas que tendra la tabla, en este casi 5.
                PdfPCell celdas_tabla;//Creamos las celdas que seran llenadas con los datos extraidos
                
                //Agregamos los titulos de cada Columna                   
                Treportes.addCell ("ID");
                Treportes.addCell("Nombre");
                Treportes.addCell("Edad");
                Treportes.addCell("Mes Nacimiento");
                Treportes.addCell("Universidad");
                 

                //ciclo para empezar a añadir los datos de la base de datos a las celdas correspondientes en el PDF
                System.out.println("Llenando pdf");
                while (resultados.next()) {
                	            
                                String id = resultados.getString("ID");
                                celdas_tabla=new PdfPCell(new Phrase(id));
                                Treportes.addCell(celdas_tabla);
                                
                                String nombre=resultados.getString("NOMBRE");
                                celdas_tabla=new PdfPCell(new Phrase(nombre));
                                Treportes.addCell(celdas_tabla);
                                
                                String edad=resultados.getString("EDAD");
                                celdas_tabla=new PdfPCell(new Phrase(edad));
                                Treportes.addCell(celdas_tabla);
                                
                                String nacimiento=resultados.getString("MES_NACIMIENTO");
                                celdas_tabla=new PdfPCell(new Phrase(nacimiento));
                                Treportes.addCell(celdas_tabla);
                                
                                String universidad=resultados.getString("UNIVERSIDAD");
                                celdas_tabla=new PdfPCell(new Phrase(universidad));
                                Treportes.addCell(celdas_tabla);
                                
                                System.out.println(id+" "+nombre+" "+edad);
                              }
                System.out.println("Listo!");
                reportePDF.add(parrafo);
                reportePDF.add(Treportes); //Insertamos los datos de la tabla en el PDF.                      
                reportePDF.close(); //Cerramos el archivo PDF una vez completado
                
                //Cerrar todas las conexiones
                resultados.close();
                stmt.close(); 
                con.close();               
                
        }
}
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /*Class.forName ("oracle.jdbc.OracleDriver");

Connection conn = DriverManager.getConnection("jdbc:oracle:thin:@//localhost:1521/XE", "hr", "hr");

try {
Statement stmt = conn.createStatement();
try {
ResultSet query_set = stmt.executeQuery("select * from Personas");
try {
WebRowSetImpl my_xml_data = new WebRowSetImpl();
my_xml_data.populate(query_set);         

ByteArrayOutputStream out = new ByteArrayOutputStream();
my_xml_data.writeXml(out); 
Document sql_to_pdf=new Document();
PdfWriter.getInstance(sql_to_pdf, new FileOutputStream("SQL2PDF.pdf"));
sql_to_pdf.open();
sql_to_pdf.add(new Paragraph(out.toString()));
sql_to_pdf.close(); /* Close the document 
} 
finally {
try { query_set.close(); } catch (Exception ignore) {}
}
} 
finally {
try { stmt.close(); } catch (Exception ignore) {}
}
} 
finally {
try { conn.close(); } catch (Exception ignore) {}*/
        
        /*Document documento=new Document();
        PdfWriter.getInstance(documento, new FileOutputStream ("C:\\ITextTest.pdf"));
        documento.open();
        
        Anchor anchorTarget = new Anchor("First page of the document.");
      anchorTarget.setName("BackToTop");
      Paragraph paragraph1 = new Paragraph();

      paragraph1.setSpacingBefore(50);

      paragraph1.add(anchorTarget);
      documento.add(paragraph1);
      documento.add(new Paragraph("Probando crear un pdf", FontFactory.getFont(FontFactory.COURIER, 14, Font.BOLD, new CMYKColor(0, 255, 0, 0))));
      documento.close();*/
        
        
  //  }
    
//}
