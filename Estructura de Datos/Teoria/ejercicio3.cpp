#include<stdio.h>
#include<stdlib.h>
#include<conio.h>

int numero=0;
int main()

{
	printf(" Willson Neris Acevedo Sanchez\n");
 	printf(" 2012-1993\n");
 	printf("\n");
 	printf("Introduzca un numero: ");
 	scanf("%d",&numero);
    if ( numero >= 1 && numero <= 6 )
	{
		switch(numero)
		{
		
		case 1:
			{
				printf("SEIS");
				break;
			}
		case 2:
		    {
				printf("CINCO");
				break;
			}
		case 3:	
		    {
		 		printf("CUATRO");
				break;
			}
		case 4:
		    {
				printf("TRES");
				break;
			}	
		case 5:
			{
				printf("DOS");
				break;
			}
		case 6:
		    {
				printf("UNO");
				break;
			}
		default:{}
	    }
	
		
	}
	else
	{
		printf("numero incorrecto\n");
	}
	getchar();
    return 0;

}  
