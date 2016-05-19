package formula;
/**
 *
 * @author Estela Isabel Abreu
 */
import java.util.Scanner;
import java.lang.Math;
public class Formula {

    /**
     * @param args the command line arguments
     */
     
    public static void main(String[] args) {
        // TODO code application logic here
        
        Scanner form = new Scanner(System.in);
        System.out.println("Z = 2x + 3xy + y^2");
        System.out.print("Digite valor de X: ");
        int x;
        x = form.nextInt();
        
        System.out.print("Digite valor de Y: ");
        int y;
        y = form.nextInt();       
        
        System.out.println( 2*x + 3*x*y + y*y);
        
        /*^ FORMULA ^*/
        /*v VEHICULO v*/
        
        Scanner scan = new Scanner(System.in);
        int monto, tasa;
        System.out.print("Digite el valor del vehiculo <RD$>: ");
        monto = scan.nextInt();
        
        System.out.print("Digite la tasa de interes <%>: ");
        tasa = scan.nextInt();
        
        System.out.println("La prima es: RD$ " + (monto * tasa/100));
        System.out.println("El monto total es: RD$ " + (monto + (monto * tasa / 100)));
        
    }
    
}
