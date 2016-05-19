package herenciaempleado;

import java.io.IOException;
import java.sql.SQLException;

/**
 *
 * @author Estela Isabel Abreu
 */
public class ControlArea {

Area tempArea;

public static void main(String[] args) throws IOException, SQLException {
    ControlArea ca = new ControlArea();
    ca.insertArea(1, "CONTABILIDAD", 10, "Soporte","EstelaIsabelA","EstelaIsabelA","Mantenimiento");
    ca.insertArea(2, "MERCADEO", 11, "Soporte","EstelaIsabelA","EstelaIsabelA","Redes");
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
 
 
