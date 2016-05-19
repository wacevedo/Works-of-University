#include <iostream>
#include <stdio.h>
#include <stdlib.h>
int main()

{
        printf(" Willson Neris Acevedo Sanchez\n");
 	printf(" 2012-1993\n");
 	printf("\n\n"); 
	int a=0, b=0, r=0;
	int hasta=0;
	printf("Inserte el numero de tabla: ");
	scanf("%d", &a);
	printf("Inserte hasta donde: ");
	scanf("%d", &hasta);
	 for (b=0;b<=hasta;b++)
	{
		r=a*b;
		printf("%d * %d = %d\n", a,b,r);
	}

return 0;
}
