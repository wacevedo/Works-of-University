#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <dos.h>

int cuadro(int x1, int x2, int y1, int y2)
{
	int x,y;
	for(x=x1; x<=x2; x++)
	{
		gotoxy(x,y1);
		printf("%c",177);
		gotoxy(x,y2);
		printf("%c",177);
		delay(1);
	}
	for(y=y1; y<=y2; y++)
	{
		gotoxy(x1,y);
		printf("%c",177);
		gotoxy(x2,y);
		printf("%c",177);
		delay(1);
	}
	return 0;
}

 void clrpart(void){

 int x,y;    // para for de limpiar

 for (y=7; y<=21; y++)
 { for (x=1; x<=80; x++) 
   {
    gotoxy(x,y);
    printf(" ");    //limpiando la parte central de pantalla
   }
  } 
}


void main()
{
	long valor=1,divd=1;
	int y=10,deseo=1;

	textcolor(WHITE);
	textbackground(BLUE);
	clrscr();
	cuadro(1,80,1,6);cuadro(1,80,22,24);
	gotoxy(31,2);
	printf("ESTRUCTURA DE DATOS");
	gotoxy(48,23);
	cprintf("Willson Neris Acevedo Sanchez");
	gotoxy(36,3);
    cprintf("2012-1993\n");
    gotoxy(20,4);
    printf("Billetes equivalentes al valor monetario");
    gotoxy(35,5);
    cprintf("Programa #2");
    gotoxy(8,23);printf("<0  = salir> <1 = continuar> ");
do{
	  clrpart();
	  gotoxy(10,8);
      cprintf("Digite el valor monetario: ");
      scanf("%ld",&valor);      

      if (valor>=2000)
      {
      	divd=valor/2000;
      	gotoxy(10,y);
      	cprintf("%ld billetes de 2000\n",divd);
      	valor=valor%2000;
      	delay(10);
      	y++;
      }	
      
      if (valor>=1000)
      {
      	divd=valor/1000;
      	gotoxy(10,y); y++;
      	cprintf("%ld billetes de 1000\n",divd);
      	valor=valor%1000;
      	delay(10);
      }

      if (valor>=500)
      {
      	divd=valor/500;
      	gotoxy(10,y); y++;
      	printf("%ld billetes de 500\n",divd);
      	valor=valor%500;
      	delay(10);
      }

      if (valor>=200)
      {
      	divd=valor/200;
      	gotoxy(10,y); y++;
      	printf("%ld billetes de 200\n",divd);
      	valor=valor%200;
      	delay(10);
      }

      if (valor>=100)
      {
      	divd=valor/100;
      	gotoxy(10,y); y++;
      	printf("%ld billetes de 100\n",divd);
      	valor=valor%100;
      	delay(10);
      }

      if (valor>=50)
      {
      	divd=valor/50;
      	gotoxy(10,y); y++;
      	cprintf("%ld billetes de 50\n",divd);
      	valor=valor%50;
      	delay(10);
      }

      if (valor>=25)
      {
      	divd=valor/25;
      	gotoxy(10,y); y++;
      	cprintf("%ld monedas de 25\n",divd);
      	valor=valor%25;
      	delay(10);
      }

      if (valor>=20)
      {
      	divd=valor/20;
      	gotoxy(10,y); y++;
      	cprintf("%ld billetes de 20\n",divd);
      	valor=valor%20;
      	delay(10);
      }

      if (valor>=10)
      {
      	divd=valor/10;
      	gotoxy(10,y); y++;
      	cprintf("%ld monedas de 10\n",divd);
      	valor=valor%10;
      	delay(10);
      }

      if (valor>=5)
      {
      	divd=valor/5;
      	gotoxy(10,y); y++;
      	cprintf("%ld moneda de 5\n",divd);
      	valor=valor%5;
      	delay(10);

      }

      if (valor>=1)
      {
      	divd=valor/1;
      	gotoxy(10,y); y++;
      	cprintf("%ld moneda de 1\n",divd);
      	valor=valor%1;
      	delay(10);
      }
      getch();
     y++;
     gotoxy(10,y); 
     cprintf("Desea insetar otro valor? ");
     scanf("%d",&deseo);
    
	}while(deseo!=0);
	
}