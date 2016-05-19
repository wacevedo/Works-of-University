package volumenesfera;
/**
 *
 * @author Estela Isabel Abreu
 */
import java.util.Scanner;
import java.lang.Math;
public class VolumenEsfera {
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
     double radio, volumen;
     System.out.println("Calcular el volumen de una esfera.");
     System.out.print("Digite el radio de la esfera en metros: ");
     radio = scan.nextFloat();
     volumen = (4/3 * Math.PI * Math.pow(radio,3));
     System.out.println("El volumen de la esfera es: " + volumen + " m³");
     }
}
