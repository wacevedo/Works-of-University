#include<stdio.h>
#include<stdlib.h>
#include<conio.h>

int a=8, b=3, c=-5, R;

int main()

{
	clrscr();
	printf(" Willson Neris Acevedo Sanchez\n");
 	printf(" 2012-1993\n");
 	printf("\n");
 	printf(" Programa realizado con los operadores Aritmeticos\n");
    printf("\n");

    printf("1. a + b + c = %d\n",R=a+b+c);
    printf("2. 2 * b + 3 * (a - c) = %d\n",R=2*b+3*(a-c));
    printf("3. a / b = %d\n",R=a/b);
    printf("4. a modulo b = %d\n",R=a%b);
    printf("5. a / c = %d\n",R=a/c);
    printf("6. a modulo c = %d\n",R=a%c);
    printf("7. a * b / c = %d\n",R=a*b/c);
    printf("8. a * (b / c) = %d\n",R=a*(b/c));
    printf("9. (a * c) m%cdulo b = %d\n",R=(a * c)%b);
    printf("10. a * (c m%cdulo b) = %d\n",162,R=a*(c%b));
    printf("\n");

    printf(" Proceso terminado.\n");
    getchar();
    return 0;

} 
