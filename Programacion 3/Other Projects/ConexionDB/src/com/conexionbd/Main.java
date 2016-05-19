/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.conexionbd;

/**
 *
 * @author reylss
 */
public class Main {
  public static void main(String[] args){
  SentenciaSQL sec=new SentenciaSQL();
   boolean ok;
   sec.setDB("xe");
   sec.setPuerto("1521");
   sec.setUsuario("willson");
   sec.setClave("123456");
   sec.setTipoDB("Oracle");
   sec.setQuery("update nom_secuencia set idsecuencia=idsecuencia+1 where tabla='EMPLEADO'");
   sec.EjecutarQuery();
   sec.CerrarConexion(); 
 
//      SentenciaSQL sec=new SentenciaSQL();
//  boolean ok;
//   sec.setDB("dbExcel");
//   sec.setTipoDB("Excel");
//   sec.setQuery("update [nom_secuencia$] set idsecuencia=idsecuencia+1 where tabla='EMPLEADO'");
//   ok= sec.EjecutarQuery();
//   sec.CerrarConexion();
   /*
   sec.setDB("NOMINA");
   sec.setPuerto("3306");
   sec.setUsuario("root");
   sec.setClave("1234");
   sec.setTipoDB("Mysql");
   sec.setQuery("update nom_secuencia set idsecuencia=idsecuencia+1 where tabla='EMPLEADO'");
   sec.EjecutarQuery();
   sec.CerrarConexion(); */
   } 
    
}
