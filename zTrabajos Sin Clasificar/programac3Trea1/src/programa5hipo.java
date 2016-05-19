
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
public class programa5hipo {
            public static void main(String[] args)
    {
        double cateto1, cateto2, hipo;
        Scanner in=new Scanner(System.in);
        System.out.printf("Insertela longitud del cateto 1: ");
        cateto1=in.nextDouble();
        System.out.printf("Inserte la longitud del cateto 2: ");
        cateto2=in.nextDouble();
        hipo=Math.sqrt(Math.pow(cateto1, 2) + Math.pow(cateto2, 2));
        hipo=Math.hypot(cateto1, cateto2);
        
        System.out.println("la hipotenusa es igual a " +hipo);
    }
}
