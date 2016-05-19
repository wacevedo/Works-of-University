package Demon;

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



public class Cliente {
	private static InetAddress cIp;  
    private static final int puerto = 5000;
    private String fechaHora;
    private String index;
    private String[]arrDatos = new String[2];
        
    private void GetIndex(int index){    	
    	this.index = String.valueOf(index);
    }
    
	private void GetFechaHora(String minutos, String hora, String dia, String mes, String anio, String ampm)
	{
		String fechaHora;
		fechaHora = mes +" "+ dia + ", " + anio + ", " + hora+ ", "+ minutos + ", " + ampm;	
		this.fechaHora = fechaHora;
	}
	
    public Cliente(String minutos, String hora, String dia, String mes, String anio, String ampm, int index){
    	GetFechaHora(minutos, hora, dia, mes, anio, ampm);
    	GetIndex(index);
    	//metodo constructor que llena la clase desde que se instancia en el form con los parametros
    }
    
	
	public DefaultTableModel iniciar() //cambiar DefaultTableModel por lo que se necesite para ejecutar el PDF
    {
        DefaultTableModel tabla4; //porque tabla 4?
          try  
          {  
              cIp = InetAddress.getLocalHost();  
          }  
          catch(UnknownHostException uhEx)  
          {  
              System.out.println("\nLa Pc no Funciona\n");  
              System.exit(1);   
          }  
           arrDatos[0]=this.index;
           arrDatos[1]= this.fechaHora;
           
           /*arrDatos[2]=this.apellido;
           arrDatos[3]=this.consulta;*/

          tabla4 = llamarServidor(arrDatos);  
          return tabla4; //deberia retornar algo para usar en el PDF
    }
    
    
    private DefaultTableModel llamarServidor(String[] arreglo2)  //cambiar DefaultTableModel por lo que se necesite para ejecutar el PDF
      {  
          DefaultTableModel tabla3=null; //porque tabla3?
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
                   Logger.getLogger(Cliente.class.getName()).log(Level.SEVERE, null, ex);
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
          
          return tabla3; //deberia retornar algo para usar en el PDF
      }
    
}
