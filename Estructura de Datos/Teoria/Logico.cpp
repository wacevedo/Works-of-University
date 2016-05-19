#include<stdio.h>
#include<stdlib.h>
#include<conio.h>

int x=1, y=2, z=3;

int main()

{
	clrscr();
	printf(" Willson Neris Acevedo S%cnchez\n",160);
 	printf(" 2012-1993\n");
 	printf(" \n");
 	printf(" Programa realizado con los operadores l%cgicos\n",162);
    printf(" \n");
    
    ///---primera exprecion
    
    printf("x es igual z, O, x es igual a y?  ");
    if((x==z) || (x==y))
    {
    	printf("cierto\n");
    }
    else {
    	printf("falso\n");
    }
    
    ///---segunda exprecion 
    printf("x es diferente z, Y, x es diferente a y?  ");
    
    if ((x!=z)&&(x!=y))
    {
    	printf("cierto\n");
    }
	else {
    	printf("falso\n");
    }
    printf("\n");

    printf(" Proceso terminado.\n");    
    getch();
    return 0;
}
