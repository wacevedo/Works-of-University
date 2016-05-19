/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package aplicacioncliente;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.PrintWriter;
import java.net.InetAddress;
import java.net.Socket;
import java.net.UnknownHostException;
import java.sql.ResultSet;
import java.util.Scanner;
import java.util.Vector;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author David Rasheeld
 */
public class EnviaPedido {
    
    private static InetAddress cIp;  
    private static final int puerto = 5000;      
    private String codigo;
    private String nombre;
    private String apellido;
    private String consulta;
    public String[]arrDatos = new String[4];
    
    
    public void setCodigo(String codigo)
    {
        this.codigo = codigo;
        }
    
    public void setNombre(String nombre)
    {
        this.nombre = nombre;
        }
    
    public void setApellido(String apellido)
    {
        this.apellido = apellido;
        
    }
    
    public void setConsulta(String consulta)
    {
        this.consulta = consulta;
    }
    
    public DefaultTableModel iniciar() 
    {
        DefaultTableModel tabla4;
          try  
          {  
              cIp = InetAddress.getLocalHost();  
          }  
          catch(UnknownHostException uhEx)  
          {  
              System.out.println("\nLa Pc no Funciona\n");  
              System.exit(1);   
          }  
           arrDatos[0]= this.codigo;
           arrDatos[1]=this.nombre;
           arrDatos[2]=this.apellido;
           
           arrDatos[3]=this.consulta;

          tabla4 = llamarServidor(arrDatos);  
          return tabla4;
    }
    
    
    public DefaultTableModel llamarServidor(String[] arreglo2)  
      {  
          DefaultTableModel tabla3=null;
          Socket socket = null;    
          try  
          {  
              
              socket = new Socket(cIp,puerto);     
              ObjectOutputStream salida = new ObjectOutputStream(socket.getOutputStream()); 
              ObjectInputStream entrada = new ObjectInputStream(socket.getInputStream());
              Object objeto_salida=(Object)arreglo2;
              salida.writeObject(objeto_salida);
              
              Object objeto_entrada =null;
       
              try 
              {
                  objeto_entrada = entrada.readObject();
              } 
              catch (ClassNotFoundException ex) 
              {
                   Logger.getLogger(EnviaPedido.class.getName()).log(Level.SEVERE, null, ex);
              }
              
              tabla3 = (DefaultTableModel)objeto_entrada;
              
          }  
          catch(IOException ioEx)  
          {  
              ioEx.printStackTrace();  
          }  
          finally  
          {  
              try  
              {  
                  System.out.println("\nCerrando conexion");  
                  socket.close();  
              }  
              catch(IOException ioEx)  
              {  
                   System.out.println("NO SE PUEDE DESCONECTAR!");  
                  System.exit(1);   
              }  
          }
          
          return tabla3;
      }
    
    
    
    
}
