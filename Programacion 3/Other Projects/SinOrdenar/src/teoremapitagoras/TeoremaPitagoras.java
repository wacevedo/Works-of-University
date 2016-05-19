package teoremapitagoras;
/**
 *
 * @author Estela Isabel Abreu
 */
import java.util.Scanner;
import java.lang.Math;
public class TeoremaPitagoras {
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    double CatetoA, CatetoB, Hipotenusa;
    System.out.println("Teoremas de Pitagoras.");
    System.out.print("Valor del cateto A: ");
    CatetoA = scan.nextDouble();
    System.out.print("Valor del cateto B: ");
    CatetoB = scan.nextDouble();
    Hipotenusa = (Math.sqrt(Math.pow(CatetoA,2)+ (Math.pow(CatetoB,2) ) ) );
    System.out.print("El valor de la hipotenusa del triangulo con estos catetos es: " + Hipotenusa);
    }
    
}
