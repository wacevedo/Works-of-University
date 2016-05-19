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
public class operador
{
    public int operador(int num1, char op, int num2)
    {
        switch(op)
        {
            case '+':
                return num1+num2;
            case'-':  
                return num1-num2;
            case'/':  
                return num1/num2;
            case'*':  
                return num1*num2;
            default:
                return 0;
        }
    }
    
}
