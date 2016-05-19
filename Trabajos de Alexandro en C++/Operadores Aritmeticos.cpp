#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
int main()


{
int x,y,z,s,m,d,r;

    printf("                          Alexandro Abreu Suriel 2012-1523\n");
    printf("                         Programa con Operadores Aritmeticos\n ");
    printf("Inserte el primer valor: ");
    scanf("%d", &x);
    printf("Inserte el segundo valor: ");
    scanf("%d", &y);
    s=x+y;
    r=x-y;
    m=x*y;
    d=x/y;
    printf("La suma es igual a: %d\n", s);
    printf("La resta es igual a: %d\n", r);
    printf("La multiplicacion es igual a: %d\n", m);
    printf("La division es igual a: %d\n", d);    
    getch();
    return 0;
}
