package tablademultiplicar;
/**
 *
 * @author Estela Isabel Abreu
 */
import java.util.Scanner;
public class TablaDeMultiplicar {
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
     Scanner scan = new Scanner(System.in);
        int C, R;
        System.out.print("Introduce un número entero: ");
        C = scan.nextInt();
        System.out.println("Tabla del " + C);
        for(int I = C; I<=C+5; I++){
             for (int G=1; G<=10; G++){
               R= I*G;
               System.out.println(I+" * "+G+" = "+R);
             
             }
        }
    }
}