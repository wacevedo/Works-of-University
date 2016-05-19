#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>

int main()

{
	int x, y, almx, almy, MCM;

	printf("Inserte el primer valor (Mayor de 0): ");
	scanf("%d", &x);
  	printf("Inserte el Segundo valor (Mayor de 0): ");
    scanf("%d", &y); 
    almx=x;
    almy=y;

    do {
    	if (x>y)
    	{
    		x-=y;
    		y=y;
    	}
    	if (x<y)
    	{
    		x=x+y;
    		y=x-y;
    		x=x-y;
    	}

    } while (x!=y);
    printf("El MCD es %d\n", x);
    MCM=almx*almy/x;
    printf("El MCM es igual a %d", MCM);

getch();
return 0;
}