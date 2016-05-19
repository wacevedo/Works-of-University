/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.conexionbd;
 
import java.io.IOException;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author reylss
 */
public class SentenciaSQL implements InterfazDB{
     Statement stmt = null; 
      private String tipoDB;
      private String query;
      private String database;    
      private String usuario;
      private String clave;
      private String    puerto;
      private Connection conexion;
      private boolean ok;
    public void setTipoDB(String tipoDB){this.tipoDB=tipoDB;}
    public void setQuery(String query){this.query=query;}
    public void setDB(String database){this.database=database;}
    public void setPuerto(String puerto){this.puerto=puerto;}
    public void setUsuario(String usuario){this.usuario=usuario;}
    public void setClave(String clave){this.clave=clave;}
 
    private void IniciarConexion(){
        switch(tipoDB){
            case OraclDB:
                try {
                    oracleDB.setUsuarioOracle(this.usuario);
                    oracleDB.setClaveOracle(this.clave);
                    oracleDB.setPuertoOracle(OraclPuerto);
                    oracleDB.setDBOracle(OracleNomDB);
                    oracleDB.setIpOracle(OraclIP);
                    ok= oracleDB.ConectarOracleDB();
                   
                    conexion= oracleDB.getConnOracleDB();
                    this.stmt =oracleDB.getStmt();
                     
               } catch (IOException ex) {
                    Logger.getLogger(SentenciaSQL.class.getName()).log(Level.SEVERE, null, ex);
                }
               
              break;
            case ExcelDB:
                  try {
                    excelDB.setDBExcel(ExcelNomDB);
                    ok= excelDB.ConectarExcelDB();
                     conexion= excelDB.getConnExcelDB();
                   this.stmt =excelDB.getStmt();
                 
               } catch (IOException ex) {
                    Logger.getLogger(SentenciaSQL.class.getName()).log(Level.SEVERE, null, ex);
                }
                 break;
            case MySqlDB:
                try{
                    mysqlDB.setUsuarioMysql(this.usuario);
                    mysqlDB.setClaveMysql(this.clave);
                    mysqlDB.setPuertoMysql(MySqlPuerto);
                    mysqlDB.setDBMysql( MySqlNomDB);
                    mysqlDB.setIpOracle(MySqlIP);
                    ok= mysqlDB.ConectarMysqlDB();
                    conexion= mysqlDB.getConnMysqlDB();
                    this.stmt =mysqlDB.getStmt();
               } catch (IOException ex) {
                    Logger.getLogger(SentenciaSQL.class.getName()).log(Level.SEVERE, null, ex);
                }
                  break;
            default:
                 break;
        }
    
    }    
    public void CerrarConexion() {
        switch(tipoDB){
            case OraclDB:
        try {  
            oracleDB.setCloseOracleDB();
        } catch (SQLException ex) {
            Logger.getLogger(SentenciaSQL.class.getName()).log(Level.SEVERE, null, ex);
        }
               break;
            case ExcelDB:
                try {
                    excelDB.setCloseExcelDB();
                } catch (SQLException ex) {
                    Logger.getLogger(SentenciaSQL.class.getName()).log(Level.SEVERE, null, ex);
                }

                 break;
            case MySqlDB:
                 break;
            default:
                 break;
        }
    
    }      
 
   public ResultSet GetConsulta(  )  {
    try{  IniciarConexion();
        ResultSet rset = this.stmt.executeQuery(this.query);
        return rset;
        }catch(Exception e){
            System.out.println( "Error en ClaseBDOracle Metodo GetConsulta   \n"+ e.getMessage()) ;
             return null;
        }
    }
    public boolean EjecutarQuery( ) {
        try{
            IniciarConexion();
            Boolean BoValRet;
           this.stmt = this.conexion.createStatement();
            BoValRet=this.stmt.execute(this.query);
            if(BoValRet){
                return true;
            }else{
                return false;
            }
        }catch(SQLException e){
             System.out.println( e.getMessage()) ;
              return false;
        }
    }
}
