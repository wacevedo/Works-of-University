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
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Pedro
 */
public class Impuesto {
    private int codigoImpuesto;
    private String descripcionImpuesto;
    private int impuesto;
    
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
    Impuesto datosImpuesto;    
          
    Impuesto(){
    this.datosImpuesto = null;}
    
    Impuesto(int codigoImpuesto, String descripcionImpuesto,int impuesto, String codusr, String Clave,String Tipo){
    this.codusr  =  codusr;
    this.Clave   =  Clave;
    this.Tipo    =  Tipo;
     if(getCodigoImpuesto(codigoImpuesto)==0){
       getSecuencia();
      }
    else{
       this.codigoImpuesto = codigoImpuesto;
     }
    this.descripcionImpuesto = descripcionImpuesto;
    this.impuesto = impuesto;
}
    
    public void getSecuencia() {
      try {
          SentenciaSQL sec=new SentenciaSQL();
          
          boolean   ok;
          String query="update nom_secuencia set idsecuencia=idsecuencia+1 where tabla='IMPUESTO'";
          String sql="select max(idsecuencia) idsecuencia "
                  + "from nom_secuencia  where tabla='IMPUESTO'";
           ResultSet rs ;
           sec.setUsuario(this.codusr);
           sec.setClave(this.Clave);
           sec.setTipoDB(this.Tipo);
           sec.setQuery(sql);
           rs=sec.GetConsulta();
           if(rs.next()) {
              this.codigoImpuesto=   rs.getInt("idsecuencia");
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
    
    public int getCodigoImpuesto(int codigoImpuesto) {
       int codigo = 0; 
     try {
          SentenciaSQL sec=new SentenciaSQL();
          
          boolean   ok;
           String sql="select codigoImpuesto "
                  + "from Impuesto  where codigoImpuesto=" +  codigoImpuesto;
           ResultSet rs ;
           sec.setUsuario(this.codusr);
           sec.setClave(this.Clave);
           sec.setTipoDB(this.Tipo);
           sec.setQuery(sql);
           rs=sec.GetConsulta();
           if(rs.next()) {
              codigo=   rs.getInt("codigoImpuesto");
          }
          rs.close();
          
          sec.CerrarConexion();
          
           } catch (SQLException ex) {
          codigo=0;
      }
     return codigo;
    }    
    
    public void insertImpuesto() throws IOException, SQLException{
   boolean   ok;
    //getSecuencia();
    SentenciaSQL sec=new SentenciaSQL();
    String query= "insert into Impuesto (codigoImpuesto, descripcionImpuesto, impuesto) values ("+
                      this.codigoImpuesto +",'"+ this.descripcionImpuesto + "','"+ this.impuesto + "')";
    sec.setUsuario(this.codusr);
    sec.setClave(this.Clave);
    sec.setTipoDB(this.Tipo);
    sec.setQuery(query);
    sec.EjecutarQuery();
    sec.CerrarConexion();     
 }
    
    public void updateImpuesto() {
   SentenciaSQL sec=new SentenciaSQL();
     boolean   ok;

      String query="update Impuesto"
              + "    set  descripImpuesto  = '" +  this.descripcionImpuesto +"'"
              + "  where codigoDepartamento    =" + this.codigoImpuesto   ;   
        
      /*ORACLE*/
         sec.setUsuario(this.codusr);
         sec.setClave(this.Clave);
         sec.setTipoDB(this.Tipo);
         sec.setQuery(query);
         sec.EjecutarQuery();
         sec.CerrarConexion();  
 }
    
    int getCodigoImpuesto() {
    return this.codigoImpuesto;
    }

    String getDescripcionImpuesto() {
    return this.descripcionImpuesto;
    }    
}
