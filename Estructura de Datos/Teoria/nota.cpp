#include <stdlib.h>
#include <stdio.h>
#include <conio.h>

int main()
{
	int nota;
	printf(" Willson Neris Acevedo Sanchez\n");
 	printf(" 2012-1993\n");
 	printf("\n"); 	
    printf("\n");
	printf("Inserte su nota: ");
	scanf("%d",&nota);
	if (nota>89)
	{
		printf("Aprob%c en A",162);
	}
	if ((nota<89)&&(nota>=80))
	{
		printf("Aprob%c en B",162);
	}
	if ((nota<79)&&(nota>=70))
	{
		printf("Aprob%c en C",162);
	}
	if (nota<70)
	{
		printf("Reprob%c la asignatura",162);
	}
	getch();
	return 0;
}
