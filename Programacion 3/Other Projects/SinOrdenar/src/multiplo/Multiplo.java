package multiplo;
/**
 *
 * @author Estela Isabel Abreu
 */
import java.util.Scanner;
public class Multiplo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    int Numero;
    System.out.println("Multiplo de Diez");
    System.out.print("Introduzca un numero entero: ");
    Numero = scan.nextInt(); 
    if(Numero%10==0)
    System.out.println("El numero es multiplo de 10.");    
    else
     System.out.println("El numero NO es multiplo de 10.");  
    }
    
}
