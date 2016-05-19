#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#define MAX 5
int main ()

{
	int prec=0, totalp, cant, canti[MAX],i, preci[MAX], arti[MAX];
	char art[25];
	
	for (i=0;i<MAX;++i)
	{
	
		printf ("Inserte el nombre del articulo <escriba salir cuando termine>: ");
		scanf("%s", &art);
		arti[i]=art;
		if (art=="salir") 
		  {break;}
		printf("Precio del articulo: ");
		scanf("%d", &prec);
		preci[i]=prec;
		printf("Cantidad: ");
		scanf("%d", &cant);
		canti[i]+=cant;
		
	}
	totalp=preci[i]*canti[i];
	printf("Cantidad de articulos= %d", canti[i]);
	

	
	getch();
	return 0;
	
	
	
}
