
package primeratarea;
/**
 *
 * @author Estela Isabel Abreu
 */
public class Operadores {
    public int operador (int num1, char op, int num2)
    {
        switch (op)
        {
        case '+':
            return num1+num2;
        case '-':
            return num1-num2;
        case '*':
            return num1*num2;
        case '/':
            return num1/num2;
        case '%':
            return num1%num2;
        default:
            return 0;
        }
    }
    
}

