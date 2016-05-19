#include <windows.h>
#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
int v=3,a=0,x=0,y=0,z=0;
int main()

{
printf("Escriba dos numeros del 1 al 10 y obtendra un mensaje si acierta\n");
do {
printf("Inserta el primer numero: ");
scanf("%d", &x);
printf("Inserta el segundo valor: ");
scanf("%d", &y);
a=a+1;
if ((x==5) && (y==8))
{
printf("                                   Acertaste!");
a=3;
}
else 
{
printf("                                   fallaste!\n");
v=v-1;
printf("                             LE QUEDAN %d Intentos\n", v);
}

Sleep(2500);system("cls");
} while (a!=3);
if (a=3)
{

printf("Dificil? Intenta adivinando un solo digito\n");
printf(" \n");
printf("Escribe un numero del 1 al 2: ");
scanf("%d", &z);
if (z==2) 
{printf(" \n");
printf ("                               Ahora si ganaste!");
} 
if (z==1)
{
printf("Fallaste :-(, los  numeros eran 5 & 8, y 2.. ");
}
}


getch();
return 0;
}
