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
 * @author reylss
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