
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
public class programa6volumen {
         public static void main(String[] args)
    {
        double radio, volumen;
        Scanner in=new Scanner(System.in);
        System.out.printf("Inserte El radio de la esfera: ");
        radio=in.nextFloat();
        volumen=(4/3)*Math.PI*radio;
        
        System.out.println("El volumen es igual:" +volumen);
    }
}
