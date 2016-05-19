package proyeccioncapital;
/**
 *
 * @author Estela Isabel Abreu
 */
import java.util.Scanner;
import java.lang.Math;
public class ProyeccionCapital {
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    String Nombre;
    double Monto, Tasa, Capital;
    float Tiempo;
    int Codigo;
    System.out.println("Proyeccion de Capital");
    System.out.print("Digite el nombre del cliente: ");
    Nombre = scan.nextLine();
    System.out.print("Digite el codigo: ");
    Codigo = scan.nextInt();
    System.out.print("Digite el Capital: ");
    Capital = scan.nextDouble();
    System.out.print("Digite la tasa: ");
    Tasa = scan.nextDouble();
    System.out.print("Digite el periodo de tiempo: ");
    Tiempo = scan.nextFloat();
    Monto = (Capital * Math.pow(1+(Tasa/100),Tiempo));
    System.out.println("La proyeccion de "+ Nombre + " es: RD$" + Monto);
    }
    
}
