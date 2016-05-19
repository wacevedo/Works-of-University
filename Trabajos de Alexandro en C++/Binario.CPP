#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#define MAX 5
int main ()

{
	int s, x, f1, f2, bin[15];
	clrscr();
	printf("Inserte el valor a convertir: ");
	scanf("%d", &x);
	s=x;

	for (f1 = 0; f1 <= 14; ++f1)
	{
		bin[f1]=x%2;
		x=x/2;
	}
	
	printf("%d en binario es  ",s);
	for (f2 = 14; f2 >= 0 ; --f2)
	{ 
     printf("%d",bin[f2]);
	}
getch();
return 0;
}