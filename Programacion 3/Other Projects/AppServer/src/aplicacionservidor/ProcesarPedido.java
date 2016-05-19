/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package aplicacionservidor;

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
     public  DefaultTableModel tabla2;

    
    public ProcesarPedido(Socket socket )
    {
        cliente = socket;    
        try  
        {  
          entrada = new ObjectInputStream(socket.getInputStream()); 
          salida = new ObjectOutputStream(socket.getOutputStream());
          
          
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
             Object ob =null,ob2=null;
             ob = entrada.readObject();
             String[]arreglo=(String[])ob;
             tabla2 = Consultar(arreglo[0], arreglo[1], arreglo[2], arreglo[3]);
             ob2=(Object)tabla2;
             salida.writeObject(ob2);
         } catch (IOException ex) {
             Logger.getLogger(ProcesarPedido.class.getName()).log(Level.SEVERE, null, ex);
         } catch (ClassNotFoundException ex) {
             Logger.getLogger(ProcesarPedido.class.getName()).log(Level.SEVERE, null, ex);
         }
             
         } 
      
 
    public DefaultTableModel Consultar(String codigo,String nombre, String apellido,String Consulta) {

      DefaultTableModel tabla = new DefaultTableModel();
         ResultSetMetaData datos;
 
             SentenciaSQL sec=new SentenciaSQL();
             sec.setUsuario("willson");
             sec.setClave("123456");
             sec.setTipoDB("Oracle");
          try{
        
        /*if ("codigo".equals(Consulta)) {
            sec.setQuery("SELECT IDEMPLEADO,NOMBRE,APELLIDOS,FECNAC,SEXO,ESTADOCIVIL,STSEMP FROM nom_empleado WHERE IDEMPLEADO="+ codigo );
        } else if ("nombre".equals(Consulta)) {
          sec.setQuery("SELECT IDEMPLEADO,NOMBRE,APELLIDOS,FECNAC,SEXO,ESTADOCIVIL,STSEMP FROM nom_empleado WHERE NOMBRE LIKE '"+ nombre +"%'");

        } else if ("apellido".equals(Consulta)) {*/
            sec.setQuery("select nombre, estado, fecha_entrega from proyecto");
        // }
        
         ResultSet rset=sec.GetConsulta(); 
        datos = rset.getMetaData();

        String[] arreglo = new String[datos.getColumnCount()];
        for (int y = 0; y < datos.getColumnCount(); y++) {
            arreglo[y] = datos.getColumnLabel(y + 1);
        }
        for (int t = 0; t < datos.getColumnCount(); t++) {
            tabla.addColumn(arreglo[t]);
        }

        while (rset.next()) {
            Vector<Object> fila2 = new Vector<Object>();
            for (int h = 0; h < datos.getColumnCount(); h++) {
                fila2.add(rset.getObject(h + 1));
            }
            tabla.addRow(fila2);
        }

    } catch (SQLException r) {

        System.out.println("* No se pudo ejecutar la petición! *");
        r.printStackTrace();
        System.exit(1);

    }sec.CerrarConexion();
  
    return tabla;

}


    
}
