#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
int main()

{
int x,y;
printf("                          Alexandro Abreu Suriel 2012-1523\n");
printf("                         Programa con Operadores Aritmeticos\n ");
printf("Inserte el primer valor: ");
scanf("%d", &x);
printf("Inserte el segundo valor: ");
scanf("%d", &y);

if (x==y) 
{
printf("                             Son iguales");
}
else
printf("                    Son diferentes y ");

if (x>y) 
{
printf("%d es mayor", x);
}
else
if (y>x)
{
printf("%d es mayor", y);
}
getch();
return 0;
}
