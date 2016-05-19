package matrizyvectores;


public class Main {

	public static void main(String[] args) {
		
		int[][] mat1 = {
				{2,4,4},
				{6,6,9},
				{8,10,12}
				};
		int[][] mat2 = {
				{3,7,8},
				{9,6,1},
				{13,14,11}				
				};
		
		Matriz m = new Matriz();
		m.imprimirMatriz(mat1);
		System.out.println();
		m.imprimirMatriz(mat2);
		System.out.println();
		m.imprimirMatriz(m.multiplicarMatrices(mat1, mat2));
		System.out.println();
		m.imprimirMatriz(m.voltearMatriz(mat1));
		
		
		
		
		
		
		
		

	}

}
