/* Ejemplo de una cola. */
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <alloc.h>

void insertar(void);
void extraer(void);
void visualizar(void);
struct cola
{
char nombre[20];
struct cola *sig;
}
*CAB=NULL,*AUX=NULL,*FIN=NULL;
main() /* Rellenar, extraer y visualizar */
{
char opc;
do
{
clrscr();
gotoxy(30,8); printf("1.- Insertar");
gotoxy(30,10);printf("2.- Extraer");
gotoxy(30,12);printf("3.- Visualizar la cola");
gotoxy(30,14);printf("4.- Salir");
opc=getch( );
switch(opc)
  {
    case '1': insertar(); break;
    case '2': extraer(); break;
    case '3': visualizar( );
  }
}while (opc!='4');
return 0;
}

void insertar(void)
{
AUX=(struct cola *)malloc(sizeof(struct cola));
clrscr();
printf("Nombre: ");gets(AUX->nombre);
AUX->sig=NULL;
if (FIN==NULL)
   FIN=CAB=AUX;
else
  {
    FIN->sig=AUX;
    FIN=AUX;
  }
}

void extraer(void)
{
 if (CAB==NULL)
     return;
  AUX=CAB;
  CAB=CAB->sig;
  free(AUX);
}

 void visualizar(void)
{
if (CAB==NULL)
    return;
clrscr();
AUX=CAB;
while (AUX!=NULL)
{
printf("Nombre: %s\n",AUX->nombre);
AUX=AUX->sig;
}
getch();
}
