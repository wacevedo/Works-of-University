#include<stdio.h>
#include<stdlib.h>
#include<conio.h>

char dato;
int main()

{
	//clrscr();
	printf(" Willson Neris Acevedo Sanchez\n");
 	printf(" 2012-1993\n");
 	printf("\n");
 	printf("Introduzca una letra: ");
 	scanf("%c",&dato);
 	if((dato=='D')||(dato=='M'))
 	{
 		printf("Es correcto\n");
 	}
 	else
 	{
 		printf("Es incorrecto\n");
 	}
 	
	getchar();
    return 0;

} 	
