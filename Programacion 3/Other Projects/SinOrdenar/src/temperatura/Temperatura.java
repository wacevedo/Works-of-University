package temperatura;
/**
 *
 * @author Estela Isabel Abreu
 */
import java.util.Scanner;
public class Temperatura {
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    float gradosCent, gradosFahr;
    System.out.println("Convertidor de temperatura");
    System.out.print("Introduzca los grados en centigrados: ");
    gradosCent = scan.nextFloat();
    gradosFahr = 32 + (9 * gradosCent / 5);
    System.out.println(gradosCent + "°C equivale a " + gradosFahr+ "°F");
    }
    
}
