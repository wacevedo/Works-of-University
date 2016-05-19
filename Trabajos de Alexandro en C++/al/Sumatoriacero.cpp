#include <stdlib.h>
#include <stdio.h>
#include <conio.h>

int main() 
{
	int x,a=0;
	int suma=0;
	printf("  Digite valores para saber su sumatoria. Cuando halla terminado pulse 0.\n");
	do {
		scanf("%d", &x);
		if (x==0) {break;}
		a=a+1;
		suma+=x;
		
	} while (x!=0);
	
	printf("Se insertaron %d valores, y la sumatoria es igual a %d.", a,suma);
	getch();	
	return 0;
}
