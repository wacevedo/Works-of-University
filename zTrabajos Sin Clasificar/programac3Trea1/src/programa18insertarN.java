
import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author AlexWork
 */
public class programa18insertarN {
        public static void main(String[] args)
    {
        double N;
        Scanner in=new Scanner(System.in);
        System.out.printf("Inserte el valor para N: ");
        N=in.nextDouble();
        N=N+77;
        N=N-3;
        N=N*2;
              
        System.out.println("El valor de N es:  " +N);
        
    }
}
