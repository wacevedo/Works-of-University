package primeratarea;

/**
 *
 * @author Estela Isabel Abreu
 */
public class ParEImpar {
    public String par(int num1, int num2){
    String npares = new String();
    
    if (num1<num2)
    {
    for (int x=num1; x<=num2; x++)
        
    {
        if (x%2==0)
        {
           npares+=x+",";
        }
    }
    
    }
    
    else
    {
        for (int x=num1; x>=num2; x++)
        
    {
        if (x%2==0)
        {
           npares+=x+",";
        }
    }
    }
    return npares;
    }
    
    public String impar(int num1, int num2){
    String nimpares = new String();
    
    if (num1<num2)
    {
    for (int x=num1; x<=num2; x++)
        
    {
        if (x%2!=0)
        {
           nimpares+=x+",";
        }
    }
    }
    else
    {
        for (int x=num1; x<=num2; x++)
        
    {
        if (x%2!=0)
        {
           nimpares+=x+",";
        }
    }
    }
        return nimpares;
    
    }
    
}
