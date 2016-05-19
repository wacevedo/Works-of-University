package incrementodecremento;
/**
 *
 * @author Estela Isabel Abreu
 */
import java.util.Scanner;
public class IncrementoDecremento {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner scan = new Scanner (System.in);
        int C;
        System.out.println("Introduzca el valor: ");
        C = scan.nextInt();
        C+=77;
        System.out.println("El valor introducido + 77 = " + C);
        C-=3;
        System.out.println("El valor introducido - 3 = " + C);
        C*=2;
        System.out.println("El valor introducido * 2 = " + C);
    }
}