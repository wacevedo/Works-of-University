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
public class programa4grados {
        public static void main(String[] args)
    {
        float grado, convert;
        Scanner in=new Scanner(System.in);
        System.out.printf("Inserte la Tempreratura en Celsius: ");
        grado=in.nextInt();
        convert=32+(9*grado/5);
        
        System.out.println("Convertido a Farenheit es igual a " +convert);
    }
}
