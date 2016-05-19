package trescifras;
/**
 *
 * @author Estela Isabel Abreu
 */
import java.util.Scanner;
public class TresCifras {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       Scanner scan = new Scanner(System.in);
        int C;
        System.out.print("Introduzca el valor: ");
        C = scan.nextInt();
        System.out.println("Primera cifra de " + C + " -> " + (C/100)); 
        System.out.println("Segunda cifra de " + C + " -> " + (C/10)%10);
        System.out.println("Tercera cifra  de " + C + " -> " + (C%10));
         
    }   
} 