#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
/*#include <iostream>*/

/*using namespace std;*/


struct estudiante
{
  int  matricula;
  char nombre[20];
  int  calif;
};

estudiante aestudiante[3];
int s;

/* declaracion de las funciones (prototipo) */
void registrar(estudiante []);
void mostrar(estudiante []);

int main()
{
  clrscr();
  registrar(aestudiante);
  getch();
  mostrar(aestudiante);
  getch();
  return 0;
}

void registrar(estudiante aest[])
{
  int x;
  for (x=0; x<=3; x++)
    {
       clrscr();
       printf("Matricula...: "); scanf("%d",&aest[x].matricula);
       printf("Nombre......: "); scanf("%s",&aest[x].nombre);
       printf("Calificacion: "); scanf("%d",&aest[x].calif);

    }
}

void mostrar(estudiante aest[])
{
  int x;
  clrscr();
  printf("## Matric. Nombre           Calificacion \n");
  for (x=3;x>=0;x--)
    {
     printf(" %i  %i  %s           %i \n",x, aest[x].matricula, aest[x].nombre, aest[x].calif);

    }
    getch();
}