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
public class ConexionMysql {
private String database;    
private String usuario;
private String clave;
private String    puerto;
private Connection conexion;
private String ip;
private Statement stmt;
    
    
public void setDBMysql(String database){this.database=database;}
public void setUsuarioMysql(String usuario){this.usuario=usuario;}
public void setClaveMysql(String clave){this.clave=clave;}
public void setPuertoMysql(String puerto){this.puerto=puerto;}
public void setIpOracle(String ip){this.ip=ip;}
public Statement  getStmt(){return this.stmt;}

public ConexionMysql() {
        try{
            Class.forName("com.mysql.jdbc.Driver");
           }catch (Exception e){
                   e.printStackTrace() ;
         }
    }
     public Boolean ConectarMysqlDB() throws IOException{
        try{jdbc:mysql: 
             conexion= DriverManager.getConnection("jdbc:mysql://127.0.0.1:"  + this.puerto + "/" + this.database ,this.usuario,this.clave);
             this.stmt = conexion.createStatement(ResultSet.TYPE_SCROLL_SENSITIVE, ResultSet.CONCUR_UPDATABLE);//declaración
             return true;
        }catch(Exception e){
             e.printStackTrace();
            return false;
        }
    }
     public boolean getEstadoMysqlDB(){
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
     public void setCloseMysqlDB() throws SQLException{
          conexion.close();
   
    }
   public Connection getConnMysqlDB(){
        return conexion;
    }
}
