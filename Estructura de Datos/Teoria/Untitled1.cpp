#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main()
{

char u[50];
char c[50];
int i=3;
 do {
 
printf("inserte el usuario: ");
scanf("%s", &u);
printf("inserte el contrasena: ");
scanf("%s", &c);

if ((u=="admin") && (c=="1234"))
{
printf("Seccion Iniciada correctamente\n");
}
else
{
	printf("Datos incorrectos\n");
	i--;
	printf("Le quedan %d intentos\n\n", i);
}

if (i==0)
{
printf("No le quedan intentos, vuelva manana");
}

}while(i!=0);


getchar();
return 0;
}
