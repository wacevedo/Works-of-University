#include<stdio.h>
#include<stdlib.h>
#include<conio.h>

int a=8, b=3, c=-5, d=2;
int main()

{
	clrscr();
	printf(" Willson Neris Acevedo Sanchez\n");
 	printf(" 2012-1993\n");
 	printf("\n");
 	printf(" Programa realizado con los operadores Asignacion\n");
    printf("\n");

    printf("1. 8 + %d + %d = %d\n",b,c,a+=b+c);
    printf("2. 6 - %d = %d\n",c,a-=c);
    printf("3. 11 / %d = %d\n",d,a/=d);
    printf("4. 5 modulo %d = %d\n",b,a%=b);
    printf("5. 2 * %d = %d\n",c,a*=c);
    printf("\n");

    printf(" Proceso terminado.\n");
    getchar();
    return 0;

}
