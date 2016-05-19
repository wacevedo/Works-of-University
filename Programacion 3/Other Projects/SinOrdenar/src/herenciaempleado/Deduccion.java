package herenciaempleado;

import com.conexionbd.SentenciaSQL;
import java.io.IOException;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Estela Isabel Abreu
 */
public class Deduccion {
    private int codigoDeduccion;
    private String descripcionDeduccion;
    private int deduccion;
    
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
    Deduccion datosDeduccion;    
          
    Deduccion(){
    this.datosDeduccion = null;}
    
    Deduccion(int codigoDeduccion, String descripcionDeduccion,int deduccion, String codusr, String Clave,String Tipo){
    this.codusr  =  codusr;
    this.Clave   =  Clave;
    this.Tipo    =  Tipo;
     if(getCodigoDeduccion(codigoDeduccion)==0){
       getSecuencia();
      }
    else{
       this.codigoDeduccion = codigoDeduccion;
     }
    this.descripcionDeduccion = descripcionDeduccion;
    this.deduccion = deduccion;
}
    
    public void getSecuencia() {
      try {
          SentenciaSQL sec=new SentenciaSQL();
          
          boolean   ok;
          String query="update nom_secuencia set idsecuencia=idsecuencia+1 where tabla='DEDUCCION'";
          String sql="select max(idsecuencia) idsecuencia "
                  + "from nom_secuencia  where tabla='DEDUCCION'";
           ResultSet rs ;
           sec.setUsuario(this.codusr);
           sec.setClave(this.Clave);
           sec.setTipoDB(this.Tipo);
           sec.setQuery(sql);
           rs=sec.GetConsulta();
           if(rs.next()) {
              this.codigoDeduccion=   rs.getInt("idsecuencia");
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
    
    public int getCodigoDeduccion(int codigoDeduccion) {
       int codigo = 0; 
     try {
          SentenciaSQL sec=new SentenciaSQL();
          
          boolean   ok;
           String sql="select codigoDeduccion "
                  + "from Deduccion  where codigoDeduccion=" +  codigoDeduccion;
           ResultSet rs ;
           sec.setUsuario(this.codusr);
           sec.setClave(this.Clave);
           sec.setTipoDB(this.Tipo);
           sec.setQuery(sql);
           rs=sec.GetConsulta();
           if(rs.next()) {
              codigo=   rs.getInt("codigoDeduccion");
          }
          rs.close();
          
          sec.CerrarConexion();
          
           } catch (SQLException ex) {
          codigo=0;
      }
     return codigo;
    }    
    
    public void insertDeduccion() throws IOException, SQLException{
   boolean   ok;
    //getSecuencia();
    SentenciaSQL sec=new SentenciaSQL();
    String query= "insert into Deduccion (codigoDeduccion, descripcionDeduccion, deduccion) values ("+
                      this.codigoDeduccion +",'"+ this.descripcionDeduccion + "','"+ this.deduccion + "')";
    sec.setUsuario(this.codusr);
    sec.setClave(this.Clave);
    sec.setTipoDB(this.Tipo);
    sec.setQuery(query);
    sec.EjecutarQuery();
    sec.CerrarConexion();     
 }
    
    public void updateDeduccion() {
   SentenciaSQL sec=new SentenciaSQL();
     boolean   ok;

      String query="update Deduccion"
              + "    set  descripDeduccion  = '" +  this.descripcionDeduccion +"'"
              + "  where codigoDepartamento    =" + this.codigoDeduccion   ;   
        
      /*ORACLE*/
         sec.setUsuario(this.codusr);
         sec.setClave(this.Clave);
         sec.setTipoDB(this.Tipo);
         sec.setQuery(query);
         sec.EjecutarQuery();
         sec.CerrarConexion();  
 }
    
    int getCodigoDeduccion() {
    return this.codigoDeduccion;
    }

    String getDescripcionDeduccion() {
    return this.descripcionDeduccion;
    }
}
