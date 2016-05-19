package calificaciones;
/**
 *
 * @author Estela Isabel Abreu
 */
import java.util.Scanner;
public class Calificaciones {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    int Calificaciones=1, Contador=1; //Cuatro Contadores y cuatro Acumuladores... Terminar.
    double Promedio;
    System.out.println("Registro de calificaciones");
    do{
      System.out.println("Digite la calificacion: ");
      Calificaciones = scan.nextInt();
      Contador++;
    }while(Calificaciones>0);
    Promedio = (Calificaciones/Contador);
    System.out.println("El promedio es: "+ Promedio);
    
    }
    
}
