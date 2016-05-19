package hilos;
/**
 *
 * @author Estela Isabel Abreu
 */
public class InvocarSumatoria {
    public static void main (String[] args)
    {
        Thread Hil0 = new Sumatoria("Hilo 0", 1,25);
        Thread Hil1 = new Sumatoria("Hilo 1", 10,24);
        Thread Hil2 = new Sumatoria("Hilo 2", 20,25);
        Thread Hil3 = new Sumatoria("Hilo 3", 30,25);
        Thread Hil4 = new Sumatoria("Hilo 4", 40,25);
        
        Hil0.start();
        Hil1.start();
        Hil2.start();
        Hil3.start();
        Hil4.start();
        
        
    }
    
}
