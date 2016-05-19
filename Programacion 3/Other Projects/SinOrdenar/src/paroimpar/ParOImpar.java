package paroimpar;
/**
 *
 * @author Estela Isabel Abreu
 */
import java.util.Scanner;
public class ParOImpar {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    int Numero;
    System.out.println("Par o impar");
    System.out.print("Introduzca un numero entero: ");
    Numero = scan.nextInt(); 
    if(Numero%2==0)
    System.out.println("El numero es par.");    
    else
     System.out.println("El numero es impar.");  
    }
    
}
