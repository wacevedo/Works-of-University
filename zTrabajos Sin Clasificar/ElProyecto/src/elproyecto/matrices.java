package elproyecto;

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

public class matrices {
    
    public void matriz5x5()
    {
        int[][] matrizX = new int[5][5];
        Scanner in= new Scanner(System.in);
        
        for (int x=0; x<5; x++)
        for (int y=0; y<5; y++)
            matrizX[x][y]=in.nextInt();
        
        for (int x=0; x<5; x++)
        {
        for (int y=0; y<5; y++)
        {
        System.out.print(matrizX[x][y]);
        }
        System.out.println();
        }
        
        for (int x=0; x<5; x++)
        {
        for (int y=0; y<5; y++)
        {
        System.out.print(matrizX[y][x]);
        }
        System.out.println();
        }
    }
    
    
    
}
