/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package primeraclase;

/**
 *
 * @author Willson Acevedo
 */
public class Primeraclase {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int num1=2, num2=5;
        char ope='-';       
        
        operador op= new operador();     
        
        System.out.println(op.operador(num1, ope, num2));
    }
    
}
