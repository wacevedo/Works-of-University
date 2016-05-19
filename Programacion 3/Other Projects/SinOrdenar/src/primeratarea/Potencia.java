package primeratarea;
/**
 *
 * @author Estela Isabel Abreu
 */
public class Potencia {
    public int elevar  (int base, int exp) {
    int resultado=base;
    for (int x=1; x<=exp-1; x++)
    {
        resultado=resultado*base;
    }
    return resultado;
    }
    
}
