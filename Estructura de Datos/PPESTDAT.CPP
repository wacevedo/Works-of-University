#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <conio.h>
#include <process.h>
#include <ctype.h>
#include <dos.h>
#include <string.h>
#include <iostream.h>


void main()
{
	long valor=1,divd=1;
//do{
	clrscr();
      printf("Digite el valor monetario: ");
      scanf("%ld",&valor);      

      if (valor>=2000)
      {
      	divd=valor/2000;
      	printf("%ld billetes de 2000\n",divd);
      	valor=valor%2000;
      }	
      
      if (valor>=1000)
      {
      	divd=valor/1000;
      	printf("%ld billetes de 1000\n",divd);
      	valor=valor%1000;
      }

      if (valor>=500)
      {
      	divd=valor/500;
      	printf("%ld billetes de 500\n",divd);
      	valor=valor%500;
      }

      if (valor>=200)
      {
      	divd=valor/200;
      	printf("%ld billetes de 200\n",divd);
      	valor=valor%200;
      }

      if (valor>=100)
      {
      	divd=valor/100;
      	printf("%ld billetes de 100\n",divd);
      	valor=valor%100;
      }

      if (valor>=50)
      {
      	divd=valor/50;
      	printf("%ld billetes de 50\n",divd);
      	valor=valor%50;
      }

      if (valor>=25)
      {
      	divd=valor/25;
      	printf("%ld monedas de 25\n",divd);
      	valor=valor%25;
      }

      if (valor>=20)
      {
      	divd=valor/20;
      	printf("%ld billetes de 20\n",divd);
      	valor=valor%20;
      }

      if (valor>=10)
      {
      	divd=valor/10;
      	printf("%ld monedas de 10\n",divd);
      	valor=valor%10;
      }

      if (valor>=5)
      {
      	divd=valor/5;
      	printf("%ld moneda de 5\n",divd);
      	valor=valor%5;

      }

      if (valor>=1)
      {
      	divd=valor/1;
      	printf("%ld moneda de 1\n",divd);
      	valor=valor%1;
      }
      getch();


    
	//}while(deseo!=0);
	
}
