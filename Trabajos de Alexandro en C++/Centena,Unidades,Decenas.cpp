#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <windows.h>
int main()

{
	
	int x, uni=0, dec=0, cent=0, mill=0;
	do
	{
	printf("determinar cuantas centena, decenas, unidades y millares tiene un valor\n");
	printf("Por Favor, Inserte el valor que desee: ");
	scanf("%d", &x);
	if (x>999999) 
	{printf("ERROR intente de nuevo con valores inferiores a 999,999\n");Sleep(2500);system("cls");}
    
	} while (x>999999);
	
	if (x>1000)	
	{
	uni=x;
	dec=x/10;
	cent=x/100;
	mill=x/1000;
	}
	if ((x<1000)	&& (x>100))
	{
	uni=x;
	dec=x/10;
	cent=x/100;
	}
	
	if (x<100)
	{
	uni=x;
	dec=x/10;
	}
	if (x<10)	
	{
	uni=x;
	}
	
	printf("Hay:\n %d unidad(es).\n %d decena(s).\n %d centena(s).\n %d millar(es).\n", uni, dec, cent, mill);

	getch();
	return 0;
}
