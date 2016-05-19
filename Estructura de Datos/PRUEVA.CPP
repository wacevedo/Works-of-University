#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <dos.h>


void listo(int y)
{char x=27;
	 clrscr();
 for (;;) //infinito
 { back:
	 gotoxy(20,y);
     printf("Preciona cualquier tecla para continuar");
     delay(500);
     gotoxy(20,y);
     printf("                                        ");
     delay(250);

	 while (getch()) {break;}
	 //else {break;}
	//if (x!=27) {break;}

 } 
}

void main()
{
	listo(12);
}