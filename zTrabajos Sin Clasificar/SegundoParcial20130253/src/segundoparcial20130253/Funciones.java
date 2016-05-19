/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package segundoparcial20130253;



/**
 *
 * @author Entrenamiento
 */
public class Funciones {
    
   
    
    public double resultado;
    
    public double Suma(double Numero1, double Numero2){
        this.resultado = 0;
        this.resultado = Numero1 + Numero2;    
        return resultado;
}
    
    public double Resta(double Numero1, double Numero2){
        this.resultado = 0;
        this.resultado = Numero1 - Numero2;    
        return resultado;
}
    public double Mult(double Numero1, double Numero2){
        this.resultado = 0;
        this.resultado = Numero1 * Numero2;    
        return resultado;
}
    public double Div(double Numero1, double Numero2){
        this.resultado = 0;
        this.resultado = Numero1 / Numero2;    
        return resultado;
}
    
    public double Root(double Numero1){
        this.resultado = 0;
        this.resultado = Math.sqrt(Numero1);    
        return resultado;
}
    public double Porc(double Numero1, double Numero2){
        this.resultado = 0;
        this.resultado = Numero1 * (Numero2/100);    
        return resultado;
}
    public double Igual(double Numero1, char op, double Numero2){
        switch(op){
            case '+': 
        this.resultado = Suma(Numero1, Numero2);
        break;
        
            case '-':
        this.resultado = Resta(Numero1, Numero2);
        break;
        
            case '*':
        this.resultado = Mult(Numero1, Numero2);
        break;
            
            case '/':
        this.resultado = Div(Numero1, Numero2);
        break;
        
            case 'R':
        this.resultado = Root(Numero1);
        break;
        
            case '%':
        this.resultado = Porc(Numero1, Numero2);
        break; 
        }
        return resultado;
    }
}
