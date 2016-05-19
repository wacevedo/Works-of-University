/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package aplicacionservidor;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

/**
 *
 * @author reylss
 */
public class servidor{
private String codigo =null;
    private String nombre =null;
    private String apellido =null;
    private String consulta =null;
    
    static ServerSocket servidor;
    static final int puerto = 5000; 

     public static void main(String[] args) throws IOException {
  
          try  
        {  
           servidor = new ServerSocket(puerto);
               do  
        {  
            try {
                System.out.println("esperando petición");
                Socket cliente = servidor.accept();
                System.out.println("\n NUEVA PETICION \n");
                ProcesarPedido servicio = new ProcesarPedido(cliente); 
                servicio.start();
            } catch (IOException ex) {
                Logger.getLogger(FServidor.class.getName()).log(Level.SEVERE, null, ex);
            }
        }while (true); 
                
        }  
        catch (IOException ioEx)  
        {  
           JOptionPane.showMessageDialog(null, ioEx.toString(), "ERROR",JOptionPane.ERROR_MESSAGE);  
           System.exit(1);  
        }     
                
           
    }
 
    
    
}
