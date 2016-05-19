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
public class Ingreso {
    private int codigoIngreso;
    private String descripcionIngreso;
    private int ingreso;

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
    Ingreso datosIngreso;    
          
    Ingreso(){
    this.datosIngreso = null;}
    
    Ingreso(int codigoIngreso, String descripcionIngreso,int ingreso, String codusr, String Clave,String Tipo){
    this.codusr  =  codusr;
    this.Clave   =  Clave;
    this.Tipo    =  Tipo;
     if(getCodigoIngreso(codigoIngreso)==0){
       getSecuencia();
      }
    else{
       this.codigoIngreso = codigoIngreso;
     }
    this.descripcionIngreso = descripcionIngreso;
    this.ingreso = ingreso;
}
    public void Ingreso(){
    this.datosIngreso = null;}
    
    public void Ingreso(int codigoIngreso, String descripcionIngreso,int ingreso, String codusr, String Clave,String Tipo){
    this.codusr  =  codusr;
    this.Clave   =  Clave;
    this.Tipo    =  Tipo;
     if(getCodigoIngreso(codigoIngreso)==0){
       getSecuencia();
      }
    else{
       this.codigoIngreso = codigoIngreso;
     }
    this.descripcionIngreso = descripcionIngreso;
    this.ingreso = ingreso;
}
    public void getSecuencia() {
      try {
          SentenciaSQL sec=new SentenciaSQL();
          
          boolean   ok;
          String query="update nom_secuencia set idsecuencia=idsecuencia+1 where tabla='INGRESO'";
          String sql="select max(idsecuencia) idsecuencia "
                  + "from nom_secuencia  where tabla='INGRESO'";
           ResultSet rs ;
           sec.setUsuario(this.codusr);
           sec.setClave(this.Clave);
           sec.setTipoDB(this.Tipo);
           sec.setQuery(sql);
           rs=sec.GetConsulta();
           if(rs.next()) {
              this.codigoIngreso=   rs.getInt("idsecuencia");
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
    
    public int getCodigoIngreso(int codigoIngreso) {
       int codigo = 0; 
     try {
          SentenciaSQL sec=new SentenciaSQL();
          
          boolean   ok;
           String sql="select codigoIngreso "
                  + "from Ingreso  where codigoIngreso=" +  codigoIngreso;
           ResultSet rs ;
           sec.setUsuario(this.codusr);
           sec.setClave(this.Clave);
           sec.setTipoDB(this.Tipo);
           sec.setQuery(sql);
           rs=sec.GetConsulta();
           if(rs.next()) {
              codigo=   rs.getInt("codigoIngreso");
          }
          rs.close();
          
          sec.CerrarConexion();
          
           } catch (SQLException ex) {
          codigo=0;
      }
     return codigo;
    }    
    
    public void insertIngreso() throws IOException, SQLException{
   boolean   ok;
    //getSecuencia();
    SentenciaSQL sec=new SentenciaSQL();
    String query= "insert into Ingreso (codigoIngreso, descripcionIngreso, ingreso) values ("+
                      this.codigoIngreso +",'"+ this.descripcionIngreso + "','"+ this.ingreso + "')";
    sec.setUsuario(this.codusr);
    sec.setClave(this.Clave);
    sec.setTipoDB(this.Tipo);
    sec.setQuery(query);
    sec.EjecutarQuery();
    sec.CerrarConexion();     
 }
    
    public void updateIngreso() {
   SentenciaSQL sec=new SentenciaSQL();
     boolean   ok;

      String query="update Ingreso"
              + "    set  descripIngreso  = '" +  this.descripcionIngreso +"'"
              + "  where codigoDepartamento    =" + this.codigoIngreso   ;   
        
      /*ORACLE*/
         sec.setUsuario(this.codusr);
         sec.setClave(this.Clave);
         sec.setTipoDB(this.Tipo);
         sec.setQuery(query);
         sec.EjecutarQuery();
         sec.CerrarConexion();  
 }
    
    int getCodigoIngreso() {
    return this.codigoIngreso;
    }

    String getDescripcionIngreso() {
    return this.descripcionIngreso;
    }

    
}
