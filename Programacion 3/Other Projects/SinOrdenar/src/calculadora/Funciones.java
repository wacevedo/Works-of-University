package calculadora;
/**
 *
 * @author Estela Isabel Abreu
 */
import java.lang.Math;
public class Funciones{
    private double op1, op2, result;
    private char op;
    

    public double Funciones(double op1, double op2, char op) 
    {
            switch(op)
            {
                case '+':
                {
                  result =op1 + op2;
                  break;
                }
                case '-':
                {
                    result = op1 - op2;
                  break;
                }
                case '*':
                {
                    result = op1 * op2;
                  break;
                }
                case '/':
                {
                    result = op1 / op2;
                  break;
                }
                case '%':
                {
                    result = op1* (op2/100);
                  break;
                }
                case '√':
                {
                    result = java.lang.Math.sqrt(op1);
                  break;
                }
                default:
                    break;
            }
            return result;
    }
    
           
    }

