/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.conexionbd;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;
import oracle.sql.*;
import oracle.jdbc.connector.*;
/**
 *
 * @author reylss
 */
public class ConexionOracle {
private String   database;    
private String   usuario;
private String   clave;
private String   puerto;
private String   ip;
private Connection conexion;
private Statement stmt;
    
    
public void setDBOracle(String database){this.database=database;}
public void setUsuarioOracle(String usuario){this.usuario=usuario;}
public void setClaveOracle(String clave){this.clave=clave;}
public void setPuertoOracle(String puerto){this.puerto=puerto;}
public void setIpOracle(String ip){this.ip=ip;}
public Statement  getStmt(){return this.stmt;}

public ConexionOracle() {
        try{
            Class.forName("oracle.jdbc.driver.OracleDriver");
           }catch (Exception e){
                   e.printStackTrace() ;
         }
    }
     public Boolean ConectarOracleDB() throws IOException{
        try{
             conexion= DriverManager.getConnection("jdbc:oracle:thin:@127.0.0.1:"  + this.puerto + ":" + this.database ,this.usuario,this.clave);
             this.stmt = conexion.createStatement(ResultSet.TYPE_SCROLL_SENSITIVE, ResultSet.CONCUR_UPDATABLE);//declaración
                 
             return true;
        }catch(Exception e){
             e.printStackTrace();
            return false;
        }
    }
     public boolean getEstadoOracleDB(){
        try{
            Boolean BoEstado=conexion.isClosed();
            if(!BoEstado){
               return true;
            }else{
               return false;
            }
        }catch(Exception e){
            System.out.println("Error en ClaseBDOracle Metodo GetEstadoDeConeccion  \n"+ e);
            return false;
        }
   }
     public void setCloseOracleDB() throws SQLException{
          conexion.close();
   
    }
   public Connection getConnOracleDB(){
        return conexion;
    }
}
