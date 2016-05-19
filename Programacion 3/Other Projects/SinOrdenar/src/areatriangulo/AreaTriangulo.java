package areatriangulo;
/**
 *
 * @author Estela Isabel Abreu
 */
import java.lang.Math;
import java.util.Scanner;
public class AreaTriangulo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    double base, altura, area;
    System.out.println("Area de un triangulo");
    System.out.print("Digite el valor de la base: ");
    base = scan.nextDouble();
    System.out.print("Digite el valor de la altura: ");
    altura = scan.nextDouble();
    area = ((base*altura)/2);
    System.out. print("El area del triangulo es: "+ Math.sqrt(area) + "m²");
    //A=Raiz((a+b+c)(-a+b+c)(a-b+c)(a+b-c)/16 Esto es cuando se conocen los tres (3) lados.
    //Formula de Heron.
    }
    
}
