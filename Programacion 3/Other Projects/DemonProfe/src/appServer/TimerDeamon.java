package appServer;

import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.text.ParseException;
import java.util.*;
import java.awt.Toolkit;

import javax.swing.table.DefaultTableModel;

import com.conexionbd.SentenciaSQL;


public class TimerDeamon extends Thread {

	Object ob =null;
	Toolkit toolkit;
	int index;
	  Timer timer;
     boolean timerend=false;
 
 
    
     public DefaultTableModel aTimerDeamon(String fecha,String index) throws ParseException {
    	 DefaultTableModel tabla = null;
        ManejadorFecha mf = new ManejadorFecha();
		Date fechaInicial = mf.getFechaYHoraActual();
 	    Date fechaFinal = mf.ConvertToDate7(fecha);
 	    int seconds = mf.diferenciasDeFechaASeg(fechaInicial, fechaFinal);
		this.index = Integer.parseInt(index);
		toolkit = Toolkit.getDefaultToolkit();
	    timer = new Timer();
	    timer.schedule(new RemindTask(), seconds * 1000);
		
	    //do{ 
			//if(this.timerend==true){
			//System.out.println("Acabo el tiempo: timer enviando resultados");
			//tablalista=true;
			//ob=td.ob;
			tabla = select();
			
			//break;
			//   }
			 // }while(true);
	    
	    return tabla;
     }
     
	  /*public TimerDeamon(int seconds,int index) { //habra que convertir la fecha a segundos, y poner el parametro de lo que se quiere
		this.index = index;
		toolkit = Toolkit.getDefaultToolkit();
	    timer = new Timer();
	    timer.schedule(new RemindTask(), seconds * 1000);
	    //System.out.println("Acabo el tiempo");
	  }*/

	  class RemindTask extends TimerTask {
	    public void run() {
	    	
	    	//
	    	// 
	    	//
	    	
	    	switch (index) {
			case 0:{
				
				ob = (Object)select();
				String a = ob.toString();
				System.out.println(a);
				System.out.println("?");
				System.out.println("timer: el objeto ta!");
				break;}

			default:{
				break;
				}
			}
	      System.out.println("Acabo el tiempo: timer enviando resultados");
	      timerend=true;
	      
	      toolkit.beep();
	      //timer.cancel(); //no es necesacio cancelarlo porque mas abajo ya se sale con el exit de este hilo
	      System.exit(0); //esto detiene el hilo para que no consuma mas procesador
	    }
	  }

	  public static void main(String args[]) throws ParseException {
	    
		  TimerDeamon t =new TimerDeamon();
	   t.aTimerDeamon("december 9, 2014, 7, 12, pm", "1");
	    System.out.println("Se fijo el tiempo de la solicitud");
	  }
	  
	  public DefaultTableModel select() {

	      DefaultTableModel tabla = new DefaultTableModel();
	         ResultSetMetaData datos;
	 
	             SentenciaSQL sec=new SentenciaSQL();
	             sec.setUsuario("willson");
	             sec.setClave("123456");
	             sec.setTipoDB("Oracle");
	             
	          try{
	        
	        
	            sec.setQuery("select nombre, estado, fecha_entrega from proyecto");
	        
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
	        	//System.out.println(rset.getString("nombre"));
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
	    //System.out.println(tabla.getColumnName(1));
	   // System.out.println(tabla.getColumnName(2));
	    return tabla;

	}
}
