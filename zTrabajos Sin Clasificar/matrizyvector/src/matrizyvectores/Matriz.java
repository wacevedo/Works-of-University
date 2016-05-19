package matrizyvectores;



public class Matriz {

	/**
	 * para que funcione la multiplicion la matrizA tiene que ser mayor
	 * o de igual dimecion que la matrizB
	 * @param matriz
	 * 
	 */
    public void imprimirMatriz(int[][] matriz){
		
    	for(int x=0; x<matriz.length; x++)
		{ 
			for(int y=0; y<matriz[0].length; y++)
			{
				System.out.print(matriz[x][y]+",");
			}
			System.out.println();	
		}
	}
	
    public int[][] voltearMatriz(int[][] matriz)
	{
    	int[][] mat = new int[matriz.length][matriz[0].length];
    	
    	for(int x=0; x<matriz.length; x++)
		{ 
			for(int y=0; y<matriz[0].length; y++)
			{
				mat[y][x]=matriz[x][y];
			}
			
		}
    	
    	return mat;
	}
    
    public int[][] multiplicarMatrices(int[][] matrizA, int[][] matrizB){
		int suma=0;
		int[][] result = new int[matrizA.length][matrizB.length];
		
		for(int i = 0; i < matrizA.length; i++){
            for(int j = 0; j < matrizB.length; j++){
                suma = 0;
                for(int k = 0; k < matrizB.length; k++){
                    suma += matrizA[i][k] * matrizB[k][j];
                }
                result[i][j] = suma;
            }
        }
		
		return result;
	}
    
	public void matriz5x5voltear(int[][] matriz)
	{
		//int[][] mat = new int[5][5];
		
		for(int x=0; x<=4; x++)
		{ 
			for(int y=0; y<=4; y++)
			{
				if((x!=0)&&(y!=0))
			    matriz[y][x]=matriz[x][y];
			}
				
		}
		
		System.out.println();
		
		for(int x=0; x<=4; x++)
		{ 
			for(int y=0; y<=4; y++)
			{
				System.out.print(matriz[x][y]+",");
			}
			System.out.println();	
		}
		
	}
	
	
	
	

}
