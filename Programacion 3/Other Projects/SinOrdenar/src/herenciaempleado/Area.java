
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
public class Area extends Departamento {

private int codigoArea;
private String descripArea;
private int codigoDepartamento;
Area datosArea;
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
Area() {
    super();
    this.datosArea = null;
}

Area(int codigoArea, String descripArea, int codigoDepartamento, String descripDepartamento,String codusr,String Clave,String Tipo) {
     super(codigoDepartamento, descripDepartamento, codusr, Clave, Tipo);
    this.codusr   =  codusr;
    this.Clave    =  Clave;
    this.Tipo     =  Tipo;
    if(getCodigoArea(codigoArea) ==0){
       getSecuencia();
       this.codigoDepartamento=super.getCodigoDepartamento();
      }
    else{
      this.codigoArea = codigoArea;
     }
    this.descripArea = descripArea;
    
}

int getCodigoArea() {
    return this.codigoArea;
}

String getDescripArea() {
    return this.descripArea;
}


 public void insertArea() throws IOException, SQLException{
   boolean   ok;
   // getSecuencia();
    SentenciaSQL sec=new SentenciaSQL();
    String query= "insert into Area (codigoArea,codigoDepartamento,descripArea) values ("+
                     this.codigoArea +","+ this.codigoDepartamento +",'"+ this.descripArea + "')";
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
          String query="update nom_secuencia set idsecuencia=idsecuencia+1 where tabla='AREA'";
          String sql="select max(idsecuencia) idsecuencia "
                  + "from nom_secuencia  where tabla='AREA'";
           ResultSet rs ;
           sec.setUsuario(this.codusr);
           sec.setClave(this.Clave);
           sec.setTipoDB(this.Tipo);
           sec.setQuery(sql);
           rs=sec.GetConsulta();
           if(rs.next()) {
              this.codigoArea=   rs.getInt("idsecuencia");
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
 public void updateArea() {
   SentenciaSQL sec=new SentenciaSQL();
     boolean   ok;

      String query="update Area"
              + "    set  descripArea        = '" + this.descripArea +"'"
              + "  where  codigoDepartamento = "  + this.codigoDepartamento 
              + "    and  this.codigoArea    = "  + this.codigoArea;   
        
      /*ORACLE*/
         sec.setUsuario(this.codusr);
         sec.setClave(this.Clave);
         sec.setTipoDB(this.Tipo);
         sec.setQuery(query);
         sec.EjecutarQuery();
         sec.CerrarConexion(); 
  
 }
   
 public int getCodigoArea(int codigoArea) {
       int codigo = 0; 
     try {
          SentenciaSQL sec=new SentenciaSQL();
          
          boolean   ok;
           String sql="select codigoArea "
                  + "from Area  where codigoArea=" +  codigoArea;
           ResultSet rs ;
           sec.setUsuario(this.codusr);
           sec.setClave(this.Clave);
           sec.setTipoDB(this.Tipo);
           sec.setQuery(sql);
           rs=sec.GetConsulta();
           if(rs.next()) {
              codigo=   rs.getInt("codigoArea");
          }
          rs.close();
          
          sec.CerrarConexion();
          
           } catch (SQLException ex) {
          codigo=0;
      }

     return codigo;
    } 


}
