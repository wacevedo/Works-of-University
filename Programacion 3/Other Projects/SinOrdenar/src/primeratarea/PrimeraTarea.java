package primeratarea;
/**
 *
 * @author Estela Isabel Abreu
 */
public class PrimeraTarea {

    public static void main(String[] args) {
        // Operadores
        int num1=10, num2=5;
        char op='/';
        Operadores ope = new Operadores();
        System.out.println(ope.operador(num1, op, num2));
        
        
        //Potencia
        Potencia po = new Potencia();
        System.out.println(po.elevar (5,3));
        
        
        //Pares e impares
        ParEImpar pei= new ParEImpar();
       
        System.out.println(pei.par(10,5));
        System.out.println(pei.impar(10,5));
    }
    
}
