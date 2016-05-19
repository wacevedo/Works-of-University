#include <windows.h>
#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
int a=0,b=0,c=0;
int main()

{
do {
printf("                     Programa para saber el tipo de triangulo\n");
printf("                         Digite el tama%co de los lados\n", 164);
printf("Lado A: ");
scanf("%d", &a);
printf("Lado B: ");
scanf("%d", &b);
printf("Lado C: ");
scanf("%d", &c);
if ((a==b) && (b==c) && (c==a))
{
printf("                           El triangulo es Equilatero!");
}
if ((a==b && c!=a) || (a==c && b!=c) || (a!=b && b==c))
//if ((a==b && b==a && c!=a) || (a==c && b!=c && c==a) || (a!=b && b==c && c==b))
{
printf("                          El traingulo es Escaleno!");
}
if ((a!=b && b!=c && c!=a))
{
	printf("                      El triangulo es Is%csceles!", 162);
}

Sleep (2000); system("cls");
} while (a!=0);
getch();
return 0;
}
