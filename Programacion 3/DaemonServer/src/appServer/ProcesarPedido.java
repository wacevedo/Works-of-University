/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package appServer;

import com.conexionbd.SentenciaSQL;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.Socket;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.ParseException;
import java.util.Vector;
import java.util.logging.Level;
import java.util.logging.Logger;

import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author reylss
 */
public class ProcesarPedido extends Thread {
      
     private final Socket cliente;  
     private ObjectInputStream entrada;  
     private ObjectOutputStream salida; 
     public  DefaultTableModel tabla2 = null;

    public DefaultTableModel getTabla (){
    	
    	return tabla2;
    }
     
    public ProcesarPedido(Socket socket)
    {
        cliente = socket;    
        try  
        {  
          entrada = new ObjectInputStream(socket.getInputStream()); 
          salida = new ObjectOutputStream(socket.getOutputStream());
          //System.out.println("Procesando pedido");
         // run();
          
        } 
         catch(IOException ioEx) 
         {
            JOptionPane.showMessageDialog(null, ioEx, "ERROR",JOptionPane.ERROR_MESSAGE);
         }
    }
    
    @Override
    public void run()
    {    
         try {
        	 javax.swing.JTable JTCliente = new javax.swing.JTable();
        	 String mensaje;
             Object ob =null,ob2=null;
             ob = entrada.readObject();
             String[]arreglo=(String[])ob;
             System.out.println(arreglo[0]+" "+arreglo[1]);
             TimerDeamon  td = new TimerDeamon(); 
             //Daemon d = new Daemon(arreglo[0], arreglo[1]);
             //do{ 
             //if(d.tablalista==true){
             tabla2 = td.aTimerDeamon(arreglo[1], arreglo[0]);
             //System.out.println("Procesando: el objeto ta!");
             //ob2=(Object)tabla2;
             /*if(tabla2!= null){
            	 mensaje="Tabla llena";
             ob2=(Object)mensaje;
             }else{
            	 mensaje="Tabla vacia";
            	 ob2=(Object)mensaje;
             }*/////////////////////////////
             
             
             
             
             ob2=(Object)tabla2;
             
             salida.writeObject(ob2);
             
             
             
             ///////////////////////////
                                  
            // break;
            // }  		   
  		 // }while(true);
             
            // String a = ob2.toString();
			 //System.out.println(a);
             
         } catch (IOException ex) {
             Logger.getLogger(ProcesarPedido.class.getName()).log(Level.SEVERE, null, ex);
         } catch (ClassNotFoundException ex) {
             Logger.getLogger(ProcesarPedido.class.getName()).log(Level.SEVERE, null, ex);
         } catch (ParseException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
             
         } 
      
    public static void main(String args[]) {
    	 
    }
 
    


    
}
