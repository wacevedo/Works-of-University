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

/**
 *
 * @author reylss
 */
public interface InterfazDB {
   static final String OraclDB      = "Oracle";
   static final String OraclIP      = "127.0.0.1";
   static final String OraclPuerto  = "1521"; 
   static final String OracleNomDB  = "xe";
   
   static final String MySqlDB      = "Mysql";
   static final String MySqlPuerto  = "3306";
   static final String MySqlIP      = "127.0.0.1";
   static final String MySqlNomDB   = "NOMINA";
   
   static final String ExcelDB       = "Excel";
   static final String ExcelNomDB    = "dbExcel";
     

    /**
     *conexion base de datos de oracle
     */
    ConexionOracle oracleDB =new ConexionOracle();
    ConexionMysql  mysqlDB =new ConexionMysql();
    ConexionExcel  excelDB  =new ConexionExcel();
    
  
}
