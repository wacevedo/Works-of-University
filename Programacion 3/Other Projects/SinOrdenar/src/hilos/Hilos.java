package hilos;

/**
 *
 * @author Estela Isabel Abreu
 */
public class Hilos extends Thread {

    private String Mensaje;
    public Hilos(String Mensaje)
    {
      this.Mensaje = Mensaje; 
    }
 public void run ()
 {
 System.out.println(Mensaje);
 }
 

    public static void main(String[] args)
    {
     Thread msj0 = new Hilos("Hola");
     Thread msj1 = new Hilos("Estela Isabel Abreu");
     Thread msj2 = new Hilos("Programacion III");
     Thread msj3 = new Hilos ("ISC");
     Thread msj4 = new Hilos ("Adios");
     msj0.start();
     msj1.start();
     msj2.start();
     msj3.start();
     msj4.start();
   
     }
 }