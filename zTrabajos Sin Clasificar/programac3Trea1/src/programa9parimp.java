
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
import java.util.*;
public class programa9parimp {
         public static void main(String[] args)
    {
        double numero;
        Scanner in=new Scanner(System.in);
        System.out.printf("Inserte numero entero: ");
        numero=in.nextDouble();
        
        if (numero % 2 == 0)
        {
            System.out.println("El número es par.");
        }
        if (numero % 2 == 1)
        {
            System.out.println("El número es impar.");
        }
    }
}
