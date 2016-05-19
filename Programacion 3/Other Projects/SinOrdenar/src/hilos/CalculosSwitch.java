package hilos;

import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Estela Isabel Abreu
 */
public class CalculosSwitch extends Thread{
    private int op1, op2, result;
    private String op;
    
public CalculosSwitch(int op1, int op2, String op, String suma)
{
    this.op1 = op1;
    this.op2 = op2;
    this.op = op;
}

    private CalculosSwitch(String string, int i) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
public void Operation() throws InterruptedException
    {
        synchronized(getClass())
        {
            switch(op)
            {
                case "+":
                {
                  result = this.op1 + this.op2;
                  System.out.println("La suma de: " + this.op1 + "+" + this.op2 + " es: " + this.result);
                  break;
                }
                case "-":
                {
                    result = this.op1 - this.op2;
                  System.out.println("La resta de: " + this.op1 + "+" + this.op2 + " es: " + this.result);
                  break;
                }
                case "*":
                {
                    getClass().wait();
                    result = this.op1 * this.op2;
                  System.out.println("La multiplicacion de: " + this.op1 + "+" + this.op2 + " es: " + this.result);
                  break;
                }
            }
               
            getClass().notifyAll();
        }
           
    }      
     public void run() 
    {
        try {
            Operation();
        } catch (InterruptedException ex) {
            Logger.getLogger(CalculosSwitch.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
     public static void main (String [] args)
    {
        Thread hilo1 = new CalculosSwitch(28,94, "+", "Suma");
        Thread hilo2 = new CalculosSwitch(59,36, "-", "Resta");
        Thread hilo3 = new CalculosSwitch(7,4, "*", "Multiplicacion");
        hilo1.start();
        hilo2.start();
        hilo3.start();
    }
}