
#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <conio.h>

void main()
{
  int x=0, sum=0, num, mayor=0,menor=0,y=6;
  float prom;
  clrscr();
  printf(" Willson Neris Acevedo Sanchez\n");
  printf(" 2012-1993                                             <0=sacar promedio>\n");
  printf("\n");
  printf(" Programa busca promedio, numero mayor, numero menor y cantidad de numero\n");
  printf("\n");

  do {
  	  gotoxy(30,y);
      printf("ingresar un numero: "); scanf("%d",&num);
      if ((mayor==0)&&(menor==0))
      {
      	mayor=num;
      	menor=num;
      }

      if(num==0){break;}

      if (num>=mayor)
      {
 	    mayor=num;
      }

      if (num<=menor)
      {
 	    menor=num;
      }
      y++;
      x++;
      sum+=num;
     }while(num!=0);

   prom=sum/x;
   printf("\n");
   printf("----------------------------------------\n");
   printf("\n");
   printf("El promedio de los numeros es: %4.1f\n",prom);
   printf("El numero mayor es: %d\n",mayor);
   printf("El numero menor es: %d\n",menor);
   printf("La cantidad de valores es: %d\n",x);
   printf("La sumatoria de estos numeros: %d\n",sum);
   getch();

}

