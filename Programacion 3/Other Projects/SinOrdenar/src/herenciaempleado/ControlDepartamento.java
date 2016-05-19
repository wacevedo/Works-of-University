package herenciaempleado;

import java.io.IOException;
import java.sql.SQLException;

/**
 *
 * @author Estela Isabel Abreu
 */
public class ControlDepartamento {
 public static void main(String[] args) throws IOException, SQLException {
    ControlDepartamento ca = new ControlDepartamento();
    
    ca.insertDepartamento(1, "Tecnologia","reylss","reylss","Oracle" );
    ca.insertDepartamento(2, "Tecnologia","reylss","reylss","Oracle" );
    ca.insertDepartamento(3, "Tecnologia","reylss","reylss","Oracle" );
     
}   
 

void insertDepartamento(int codDepto, String descripDepto,String codusr,String Clave, String Tipo) throws IOException, SQLException {

   Departamento depto=new Departamento(codDepto, descripDepto,codusr,Clave, Tipo); 
     
    if(depto.getCodigoDepartamento(codDepto)==0){
     depto.insertDepartamento();
    }
   else{
   depto.updateDepartamento(); 
   }

}
 
}