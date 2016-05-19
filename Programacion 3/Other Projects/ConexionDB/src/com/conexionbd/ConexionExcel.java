/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.conexionbd;

import java.io.File;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

/**
 *
 * @author reylss
 */
public class ConexionExcel {
 private String database; 
private Connection conexion;
 private Statement stmt;
    
    
public void setDBExcel(String database){this.database=database;}
public Statement  getStmt(){return this.stmt;}
public ConexionExcel() {
        try{
            
           Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
            }catch (Exception e){
                   e.printStackTrace() ;
         }
    }
     public Boolean ConectarExcelDB() throws IOException{
        try{
    String myDB = "jdbc:odbc:Driver={Microsoft Excel Driver (*.xls)};DBQ=C:\\curso_java\\Laboratorio\\Tarea2\\ConexionBD\\src\\dbExcel\\"+this.database+".xls;"
        + " ReadOnly=False;";
             this.conexion   = DriverManager.getConnection(myDB); 
             this.stmt = conexion.createStatement();
              return true;
        }catch(Exception e){
             e.printStackTrace();
                return false;
        }
    }
     public boolean getEstadoExcelDB(){
        try{
            Boolean BoEstado=conexion.isClosed();
            if(!BoEstado){
               return true;
            }else{
               return false;
            }
        }catch(Exception e){
            System.out.println("Error en excel Metodo GetEstadoDeConeccion  \n"+ e);
            return false;
        }
   }
     public void setCloseExcelDB() throws SQLException{
        conexion.close();
    }
   public Connection getConnExcelDB(){
        return conexion;
    }

   
}
