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
public class programa3 {
    public static void main(String[] args)
    {
        int nota;
        Scanner not=new Scanner(System.in);
        System.out.println("Inserte la nota del estudiante: ");
        nota=not.nextInt();
        if ((nota>=90) && (nota<=100));
        {
                System.out.println("Exelente!");
        }
        if ((nota>=80) && (nota<=89));
                System.out.println("Bueno!");    
        if ((nota>=70) && (nota<=79));
                System.out.println("Regular!"); 
        if ((nota>=0) && (nota<=69));
                System.out.println("Vallase!");         
        
    }
    
}
