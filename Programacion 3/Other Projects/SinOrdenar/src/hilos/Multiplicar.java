package hilos;
/**
 *
 * @author Estela Isabel Abreu
 */
public class Multiplicar extends Thread {
    private int resultado, op1;
    private String NombreHilo;
    
    public Multiplicar (String NombreHilo, int op1)
    {
        this.op1 = op1;
        this.NombreHilo = NombreHilo;
    }
    public void Operacion()
    {
        synchronized(getClass())
        {
           System.out.println("Tabla del" + this.NombreHilo);
            for (int x=0; x<=10; x++)
            {
                this.resultado = x*this.op1;
                System.out.println(x + "*" + this.op1 + "=" + resultado);
                getClass().notifyAll();
                try{
                    getClass().wait();
                }
                catch (java.lang.InterruptedException ex){
                }
                getClass().notifyAll();
                
            }
        }
    }      
    public void run() 
    {
        Operacion();
    }
    public static void main (String [] args)
    {
        Thread hilo1 = new Multiplicar("\n Tabla del " + 5,5);
        Thread hilo2 = new Multiplicar("\n Tabla del " + 4,4);
        Thread hilo3 = new Multiplicar("\n Tabla del " + 3,3);
        hilo1.start();
        hilo2.start();
        hilo3.start();
    }
}
