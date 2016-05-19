package teclado;
/**
 *
 * @author Estela Isabel Abreu
 */
import java.util.Scanner;
public class Teclado {

    public static void main(String[] args) {
        // TODO code application logic here
        Scanner tec = new Scanner(System.in); //Diciendole al Metodo Contructor que me lea por el teclado.
        /**int entero =0;
        System.out.println("Digitar un entero");
        entero = tec.nextInt();
        System.out.println("Digito el #:" + entero);**/
        
        String palabra = new String();
        System.out.print("Digite la palabra: ");
        palabra = tec.nextLine();
        //System.out.println("Digite la palabra: " + palabra);
        for (int x=1; x<=palabra.length(); x++)
        {
           System.out.println(palabra.substring(x-1, x)); 
        }
        
        
    }
    
}
