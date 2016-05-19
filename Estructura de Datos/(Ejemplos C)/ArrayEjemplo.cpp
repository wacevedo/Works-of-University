 /*PROGRAMA EJEMPLO PARA TRABAJAR CON ARREGLOS*/

#include <stdio.h>
#include <conio.h>

void main()
{
  int n;
  int arreglo[20];
  clrscr();
  printf(" LLENAR EL ARREGLO CON NUMEROS\n");
  for(n=1;n<=20;n++)
     {
       printf("Valor %d =",n); scanf("%d",&arreglo[n]);
     }
  getch();  
  printf("\n");
  printf(" MOSTRAR LOS DATOS GUARDADOS EN EL ARREGLO\n");
  for(n=1;n<=20;n++)
    {
      printf("\n%i",arreglo[n]);
    }
  getch();

 return 0;
}