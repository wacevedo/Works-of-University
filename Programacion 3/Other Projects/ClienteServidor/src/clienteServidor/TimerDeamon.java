package clienteServidor;

import java.util.*;
import java.awt.Toolkit;


public class TimerDeamon {

 
	Toolkit toolkit;

	  Timer timer;

	  public TimerDeamon(int seconds) { //habra que convertir la fecha a segundos, y poner el parametro de lo que se quiere
	    toolkit = Toolkit.getDefaultToolkit();
	    timer = new Timer();
	    timer.schedule(new RemindTask(), seconds * 1000);
	  }

	  class RemindTask extends TimerTask {
	    public void run() {
	    	
	    	//
	    	// aqui se debe poner la instanciacion de la clase que crea el pdf 
	    	//
	    	
	      System.out.println("Acabo el tiempo");
	      
	      
	      toolkit.beep();
	      //timer.cancel(); //no es necesacio cancelarlo porque mas abajo ya se sale con el exit de este hilo
	      System.exit(0); //esto detiene el hilo para que no consuma mas procesador
	    }
	  }

	  public static void main(String args[]) {
	    
	    new TimerDeamon(5);
	    System.out.println("Se fijo el tiempo");
	  }
	
}
