package matriz;
/**
 *
 * @author Estela Isabel Abreu
 */
import java.util.Scanner;
public class Matriz {

    public static void main(String[] args) {
      
        int i=1;

    int[][] Matriz = new int[5][5];

    Scanner tec = new Scanner(System.in);

    System.out.println("Introduzca los 25 números.");

    for(int x=0; x<=4; x++)
    {

        for(int y=0; y<=4; y++)

        {

        System.out.println("Número "+i+": ");

       Matriz[x][y]=tec.nextInt();

        i++;

        }

    }

    System.out.println();

    for(int y=0; y<=4; y++)

    {

        for(int x=0; x<=4; x++)

        {

        System.out.print(Matriz[x][y]+"|");

        }

    System.out.println();

    }

    for(int x=0; x<=4; x++)

    {       

        for(int y=0; y<=4; y++)

        {

        System.out.print(Matriz[x][y]+"|");

        }

    System.out.println();

        }

}
    }
    