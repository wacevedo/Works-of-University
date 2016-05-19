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
public class programa1tabla {
    public static void main(String[] args)
    {
        int numero, r, a=1;
        Scanner in=new Scanner(System.in);
        System.out.println("Inserte el numero: ");
        numero=in.nextInt();
        
        for (int x=1;x<=12;x++)
        {
            r=numero*x;
            System.out.println(+numero+"*"+x+"="+r);
        }
        while (a!=5){
            a=a+1;
            numero=numero-1;
            for (int y=1;y<=12;y++)
            {
            r=numero*y;
            System.out.println(+numero+"*"+y+"="+r);
            }}
    }
}
