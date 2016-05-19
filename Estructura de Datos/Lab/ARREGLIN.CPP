#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <conio.h>
#include <process.h>
#include <ctype.h>
#include <dos.h>
#include <string.h>
#include <iostream.h>
#include <time.h>

int f=9,c=12;
const char *titulos[]={"", "", "", "", "", "", "", "", "", 
"LLenar Arreglos de Numeros Enteros","Mostrar Arreglos de Numeros Enteros" ,"Salir","","","",""};
int ArregloA[5];
int ArregloB[5];

 int Linea(int x1, int y1, int y2)
{
	int y;
	
	for(y=y1; y<=y2; y++)
	{
		gotoxy(x1,y);
		printf("%c",186);
		gotoxy(x1,y);
		printf("%c",186);
		delay(1);
	}
	return 0;
}

void fecha(void)
{
	struct date d;
	int dia,mes,agno;
	getdate(&d);
	dia=d.da_day;
	mes=d.da_mon;
	agno=d.da_year;
    gotoxy(2,5);
	printf("%d/%d/%d",dia,mes,agno);
}
 
 void clrpart(void)
 {
 int x,y;    // para for de limpiar
 fecha();
 for (y=7; y<=21; y++)
 { for (x=1; x<=80; x++) 
   {
    gotoxy(x,y);
    printf(" ");    //limpiando la parte central de pantalla
   }
  } 
}

int cuadro(int x1, int x2, int y1, int y2, int ch)
{
	int x,y;
	for(x=x1; x<=x2; x++)
	{
		gotoxy(x,y1);
		printf("%c",ch);
		gotoxy(x,y2);
		printf("%c",ch);
		delay(1);
	}
	for(y=y1; y<=y2; y++)
	{
		gotoxy(x1,y);
		printf("%c",ch);
		gotoxy(x2,y);
		printf("%c",ch);
		delay(1);
	}
	return 0;
}

int cuadrito(int x1, int x2, int y1, int y2)
{
	int x,y;

	
	for(x=x1; x<=x2; x++)
	{
		gotoxy(x,y1);
		printf("%c",196);
		gotoxy(x,y2);
		printf("%c",196);
		delay(1);
	}
	for(y=y1; y<=y2; y++)
	{
		gotoxy(x1,y);
		printf("%c",179);
		gotoxy(x2,y);
		printf("%c",179);
		delay(1);
	}

	gotoxy(x2,y1);printf("%c",191);
	gotoxy(x1,y2);printf("%c",192);
	gotoxy(x2,y2);printf("%c",217);
	gotoxy(x1,y1);printf("%c",218);



	return 0;
}

void LLenarArreglo(void)
{
	clrpart();
	for (int i = 0; i <= 5; ++i)
	{
		gotoxy(10,10);printf("Arreglo A Numero %d:",i);
		scanf("%d",&ArregloA[i]);
		gotoxy(27,10);printf("         ");
	}
	for (int p = 0; p <= 5; ++p)
	{
		gotoxy(10,10);printf("Arreglo B Numero %d:",p);
		scanf("%d",&ArregloB[p]);
		gotoxy(27,10);printf("         ");
	}
	gotoxy(10,15); printf("Listo!");
	getch();
	
}

void MostrarArreglos(void)
{
	clrpart();
	int y=10,r=0,j=2;
	gotoxy(7,8); printf("Arreglo A");
	gotoxy(j+17,8); printf("Arreglo B");
	gotoxy(j+27,8); printf("Suma");
	gotoxy(j+32,8); printf("Resta");
	gotoxy(j+39,8); printf("Mult");
	gotoxy(j+44,8); printf("Division");
	for (int i = 0; i <= 5; ++i)
	{
		gotoxy(10,y);printf(" %d",ArregloA[i]);
		gotoxy(j+19,y);printf(" %d",ArregloB[i]);
		gotoxy(j+28,y);printf(" %d", r=ArregloA[i]+ArregloB[i]);
		gotoxy(j+33,y);printf(" %d", r=ArregloA[i]-ArregloB[i]);
		gotoxy(j+40,y);printf(" %d", r=ArregloA[i]*ArregloB[i]);
		gotoxy(j+45,y);printf(" %d", r=ArregloA[i]/ArregloB[i]);

		y++;
	}
	getch();

}


void titulo(void)
{
	clrpart();
	cuadrito(1,80,7,21);
	gotoxy(31,2);
	printf("ESTRUCTURA DE DATOS");
	gotoxy(48,23);
	cprintf("Willson Neris Acevedo Sanchez");
	gotoxy(70,5);
    cprintf("2012-1993");
    gotoxy(38,5);
    cprintf("MENU");
        
    for (int i = 9; i <= 11; i++)
    {
    	gotoxy(c,i);cprintf("%s",titulos[i]);
    }
	


	gotoxy(10,23);printf("<ESC  = salir>");
    textcolor(YELLOW);
	
    gotoxy(c,f); cprintf("%s",titulos[f]);
    
    textcolor(WHITE);
}

void main()
{   
	textcolor(WHITE);
	textbackground(BLUE);
	clrscr();
	char t;
	cuadro(1,80,1,6,177);
	cuadro(1,80,22,24,178);

	titulo();
	
	
	do{
		t=getch();
		
		switch(t)
		{
			case 72://72
			{
				if (f>9)
					{f--;}
					  else {gotoxy(c,f);cprintf("%s",titulos[f]);
					  f=11;} //cambiar si se agregan mas opciones
				break;
			}
			case 80://80
			{
				if (f<11)//cambiar si se agregan mas opciones
					{f++;}
					  else {gotoxy(c,f);cprintf("%s",titulos[f]);
					  f=9;} 
				break;
			}
			default:
			{
				/*gotoxy(21,14);printf(" Comando invalido");
			    delay(1000);
			    gotoxy(21,14);printf("                   ");*/
				break;
			}
		}
		if ((t==13)&& (f==9))
		{
			gotoxy(10,23);cprintf("   1 opcion   ");
			delay(1000);
			gotoxy(10,23);cprintf("                   ");
			LLenarArreglo();			
			titulo();
		}
		if ((t==13)&& (f==10))
		{
			gotoxy(10,23);cprintf("   2 opcion   ");
			delay(1000);
			gotoxy(10,23);cprintf("                   ");
			MostrarArreglos();
			titulo();
		}
		if ((t==13)&& (f==15))
		{
			gotoxy(10,23);cprintf("   3 opcion   ");
			delay(1000);
			gotoxy(10,23);cprintf("                   ");
			
			titulo();
		}
		if ((t==13)&& (f==12))
		{
			gotoxy(10,23);cprintf("   4 opcion   ");
			delay(1000);
			gotoxy(10,23);cprintf("                   ");
			
			titulo();
		}
		if ((t==13)&& (f==13))
		{
			gotoxy(10,23);cprintf("  5 opcion   ");
			delay(1000);
			gotoxy(10,23);cprintf("                   ");
			
			titulo();
		}
		if ((t==13)&& (f==11))
		{
			gotoxy(10,23);cprintf("   saliendo...  ");
			delay(1000);
			gotoxy(10,23);cprintf("                   ");
			t=27;
		}
		textcolor(YELLOW);
		
        gotoxy(c,f);  cprintf("%s",titulos[f]);
        
        textcolor(WHITE);
        gotoxy(c,f-1);cprintf("%s",titulos[f-1]);
        gotoxy(c,f+1);cprintf("%s",titulos[f+1]);
	}while(t!=27);

}