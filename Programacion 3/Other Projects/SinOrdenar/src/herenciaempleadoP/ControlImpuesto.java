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
 * @author Pedro
 */
public class ControlImpuesto {
    Impuesto tempImpuesto;

    public static void main(String[] args) throws IOException, SQLException {
    ControlImpuesto ca = new ControlImpuesto();
    
    ca.insertImpuesto(1, "Tecnologia",599,"reylss","reylss","Oracle" );
    ca.insertImpuesto(2, "Tecnologia",616,"reylss","reylss","Oracle" );
    ca.insertImpuesto(3, "Tecnologia",6155,"reylss","reylss","Oracle" );
     
}   
 

void insertImpuesto(int codigoImpuesto, String descripcionImpuesto,int impuesto, String codusr, String Clave,String Tipo) throws IOException, SQLException {

   Impuesto imp=new Impuesto(codigoImpuesto, descripcionImpuesto, impuesto, codusr, Clave, Tipo);
    
   if (imp.getCodigoImpuesto(codigoImpuesto)==0){
       imp.insertImpuesto();
   }
   else{
       imp.updateImpuesto();
   }    
}

}


