package saludopersonalizado;
/**
 *
 * @author Estela Isabel Abreu
 */
import java.util.Scanner;
public class SaludoPersonalizado {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
     Scanner scan = new Scanner(System.in);
     String Nombre;
     System.out.println("Saludo Personalizado");
     System.out.print("Inserte el nombre de la persona a saludar: ");
     Nombre = scan.nextLine();
     System.out.println("Buenas noches, " + Nombre + "!!!");
    }
    
}
