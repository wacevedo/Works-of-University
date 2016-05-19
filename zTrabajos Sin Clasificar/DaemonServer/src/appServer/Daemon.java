package appServer;

import java.text.ParseException;
import java.util.Date;

import javax.swing.table.DefaultTableModel;

public class Daemon extends Thread {
    
	Object ob =null;
	public  DefaultTableModel tabla;
	int index;
	int seconds;
	boolean tablalista=false;
	public Daemon(int seconds) {
		// TODO Auto-generated constructor stub
		this.setDaemon(true);
	}
	
	public Daemon(String index,String fecha) throws ParseException {
		ManejadorFecha mf = new ManejadorFecha();
		Date fechaInicial = mf.getFechaYHoraActual();
    	Date fechaFinal = mf.ConvertToDate7(fecha);
    	this.seconds = mf.diferenciasDeFechaASeg(fechaInicial, fechaFinal);
		this.index = Integer.parseInt(index);
		 System.out.println("Daemon: Fecha lista!!");
		//this.setDaemon(true);
		//this.run();
	}
	
	
	public void run() {
		//Aqui se pone lo que se quiere que haga el hilo.
		TimerDeamon td = new TimerDeamon(seconds, index);
		do{ 
		if(td.timerend==true){
		System.out.println("Acabo el tiempo: timer enviando resultados");
		tablalista=true;
		ob=td.ob;
		String a = ob.toString();
		System.out.println(a);
		break;
		   }
		  }while(true);
		}
	
	public static void main (String args[]) {
		try {
			Daemon uno = new Daemon("0","December 7, 2014, 5, 36, PM");
		} catch (ParseException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		}

}
