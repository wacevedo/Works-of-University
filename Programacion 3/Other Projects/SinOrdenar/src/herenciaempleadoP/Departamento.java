/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package herenciaempleado;

import com.conexionbd.SentenciaSQL;
import java.io.IOException;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Vector;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author rsantos
 */
public class Departamento {

private int codigoDepartamento;
private String descripDepartamento;
private String codusr;
private String Clave;
private String Tipo;

public void setCodusr(String codusr){
   this.codusr=codusr;
 } 
 public void setClave(String Clave){
   this.Clave=Clave;
 } 
 public void setTipo(String Tipo){
   this.Tipo=Tipo;
 } 
Departamento datosDepartamento;

Departamento() {
    this.datosDepartamento = null;
}

Departamento(int codigoDepartamento, String descripDepartamento,String codusr,String Clave,String Tipo) {
    this.codusr  =  codusr;
    this.Clave   =  Clave;
    this.Tipo    =  Tipo;
     if(getCodigoDepartamento(codigoDepartamento)==0){
       getSecuencia();
      }
    else{
       this.codigoDepartamento = codigoDepartamento;
     }
    this.descripDepartamento = descripDepartamento;
}

int getCodigoDepartamento() {
    return this.codigoDepartamento;
}

String getDescripDepartamento() {
    return this.descripDepartamento;
}


 public void insertDepartamento() throws IOException, SQLException{
   boolean   ok;
    //getSecuencia();
    SentenciaSQL sec=new SentenciaSQL();
    String query= "insert into Departamento (codigoDepartamento,descripDepartamento) values ("+
                      this.codigoDepartamento +",'"+ this.descripDepartamento + "')";
    sec.setUsuario(this.codusr);
    sec.setClave(this.Clave);
    sec.setTipoDB(this.Tipo);
    sec.setQuery(query);
    sec.EjecutarQuery();
    sec.CerrarConexion(); 
    
 }
 public void getSecuencia() {
      try {
          SentenciaSQL sec=new SentenciaSQL();
          
          boolean   ok;
          String query="update nom_secuencia set idsecuencia=idsecuencia+1 where tabla='DEPARTAMENTO'";
          String sql="select max(idsecuencia) idsecuencia "
                  + "from nom_secuencia  where tabla='DEPARTAMENTO'";
           ResultSet rs ;
           sec.setUsuario(this.codusr);
           sec.setClave(this.Clave);
           sec.setTipoDB(this.Tipo);
           sec.setQuery(sql);
           rs=sec.GetConsulta();
           if(rs.next()) {
              this.codigoDepartamento=   rs.getInt("idsecuencia");
          }
          rs.close();
          
          sec.CerrarConexion();
          
          
          /*ORACLE*/
            sec.setUsuario(this.codusr);
            sec.setClave(this.Clave);
            sec.setTipoDB(this.Tipo);
            sec.setQuery(query);
            sec.EjecutarQuery();
            sec.CerrarConexion();
             } catch (SQLException ex) {
          Logger.getLogger(Departamento.class.getName()).log(Level.SEVERE, null, ex);
      }


    }
 public void updateDepartamento() {
   SentenciaSQL sec=new SentenciaSQL();
     boolean   ok;

      String query="update Departamento"
              + "    set  descripDepartamento  = '" +  this.descripDepartamento +"'"
              + "  where codigoDepartamento    =" + this.codigoDepartamento   ;   
        
      /*ORACLE*/
         sec.setUsuario(this.codusr);
         sec.setClave(this.Clave);
         sec.setTipoDB(this.Tipo);
         sec.setQuery(query);
         sec.EjecutarQuery();
         sec.CerrarConexion(); 
 
 }
   
 public int getCodigoDepartamento(int codigoDepartamento) {
       int codigo = 0; 
     try {
          SentenciaSQL sec=new SentenciaSQL();
          
          boolean   ok;
           String sql="select codigoDepartamento "
                  + "from Departamento  where codigoDepartamento=" +  codigoDepartamento;
           ResultSet rs ;
           sec.setUsuario(this.codusr);
           sec.setClave(this.Clave);
           sec.setTipoDB(this.Tipo);
           sec.setQuery(sql);
           rs=sec.GetConsulta();
           if(rs.next()) {
              codigo=   rs.getInt("codigoDepartamento");
          }
          rs.close();
          
          sec.CerrarConexion();
          
           } catch (SQLException ex) {
          codigo=0;
      }

     return codigo;
    } 
      
}
