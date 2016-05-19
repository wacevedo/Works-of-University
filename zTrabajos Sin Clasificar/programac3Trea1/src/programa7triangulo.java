
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
public class programa7triangulo {
         public static void main(String[] args)
    {
        double lado1, lado2, lado3, per;
        Scanner in=new Scanner(System.in);
        System.out.printf("Inserte tamano de lado 1: ");
        lado1=in.nextDouble();
        System.out.printf("Inserte tamano de lado 2: ");
        lado2=in.nextDouble();
        System.out.printf("Inserte tamano de lado 3: ");
        lado3=in.nextDouble();
        per=(lado1+lado2+lado3)/2;
        
        System.out.println("El Area es igual a " +  Math.sqrt(per*(per-lado1)*(per-lado2)*(per-lado3)));
        
    }
}
