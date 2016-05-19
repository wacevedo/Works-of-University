/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package herenciaempleado;

import java.io.IOException;
import java.sql.SQLException;

/**
 *
 * @author rsantos
 */
public class ControlArea {

Area tempArea;

public static void main(String[] args) throws IOException, SQLException {
    ControlArea ca = new ControlArea();
    ca.insertArea(1, "CONTABILIDAD", 10, "Soporte","reylss","reylss","Oracle");
    ca.insertArea(2, "MERCADEO", 11, "Soporte","reylss","reylss","Oracle");
  }

void insertArea(int codDepto, String descripDepto, int codArea, String descripArea,String codusr,String Clave, String Tipo) throws IOException, SQLException {
   Area area = new Area(codArea, descripArea, codDepto, descripDepto,codusr,Clave,Tipo);
   
    if(area.getCodigoDepartamento(codDepto)==0){
     area.insertDepartamento();
    }
   else{
      area.updateDepartamento(); 
    }  
   if(area.getCodigoArea(codArea)==0){
     area.insertArea();
    }
   else{
      area.updateArea(); 
    } 
}
}
 
 
