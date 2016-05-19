package hilos;

import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Estela Isabel Abreu
 */
public class Sumatoria extends Thread {
    String NombreHilo;
    private int op1, op2, resultado;
    public Sumatoria(String NombreHilo, int op1, int op2)
    {
        this.op1 = op1;
        this.op2 = op2;
        this.NombreHilo = NombreHilo;
    }
    public synchronized void Operacion()
    {
        this.resultado = op1+ op2;
    }
    public int Valor()
    {
        return this.resultado;
    }
    public void run ()
    {
        Operacion();
        try {
            Thread.sleep(30);
        } catch (InterruptedException ex) {
            Logger.getLogger(Sumatoria.class.getName()).log(Level.SEVERE, null, ex);
        }
        System.out.println(this.NombreHilo + ": Resultado es: " + Valor());
    }
}
