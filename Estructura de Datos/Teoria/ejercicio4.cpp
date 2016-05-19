#include<stdio.h>
#include<stdlib.h>
#include<conio.h>

char letra;
int main()

{
	printf(" Willson Neris Acevedo Sanchez\n");
 	printf(" 2012-1993\n");
 	printf("\n");
 	printf("Introduzca una letra: <en bloq mayus porfavor>\n");
 	scanf("%c",&letra);
 	switch(letra)
		{
		
		case 'N':
			{
				printf("Negro");
				break;
			}
		case 'B':
		    {
				printf("Blanco");
				break;
			}
		case 'V':	
		    {
		 		printf("Verde");
				break;
			}
		case 'R':
		    {
				printf("Rojo");
				break;
			}	
		case 'M':
			{
				printf("Marron");
				break;
			}
		case 'G':
		    {
				printf("Gris");
				break;
			}
		default:
		    {
		    	printf("No tenemos ese color\n");
				break;
			}
	    }
 	
 	
    getchar();
    return 0;

}
