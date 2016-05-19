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


int f=9,c=12,L=3;
   int op=0;
   int fondo=0;
   int tope=4;

   struct libro
{
	int id,AN;
	char titu[20],autor[50],editora[20],genero[20];

};
libro Alibro[3]; 
const char *titulos[]={"", "", "", "", "", "", "", "", "", 
"Ingresar","Sacar" ,"Mostrar","Salir","","",""};
 //limite es L cambiar con la L 



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


void titulo(void)
{

	clrpart();
	
	//cuadrito(1,80,7,21);
	gotoxy(31,2);
	printf(" ESTRUCTURA DE DATOS");
	gotoxy(48,23);
	cprintf("Willson Neris Acevedo Sanchez");
	gotoxy(70,5);
    cprintf("2012-1993");
    gotoxy(38,5);
    cprintf("MENU");
        
    /*for (int ias = 9; ias <= 12; ias++)
    {*/ 
    	gotoxy(c,9);cprintf("%s",titulos[9]);
    	gotoxy(c,10);cprintf("%s",titulos[10]);
    	gotoxy(c,11);cprintf("Mostrar");
    	gotoxy(c,12);cprintf("%s",titulos[12]);
    //}
	


	gotoxy(10,23);printf("<ESC  = salir>");
    textcolor(YELLOW);
	
    gotoxy(c,f); cprintf("%s",titulos[f]);
    
    textcolor(WHITE);
    gotoxy(31,2);
	printf(" ESTRUCTURA DE DATOS");
}

void Ingresardatos(void)
{
	clrpart();
	gotoxy(10,9);cprintf("ID");
    Linea(13,9,20);
	gotoxy(15,9);cprintf("Titulo");
	Linea(30,9,20);
	gotoxy(31,9);cprintf("Autor");
	Linea(45,9,20);
	gotoxy(46,9);cprintf("Editora");
	Linea(60,9,20);
	gotoxy(61,9);cprintf("Genero");
	for (int iu = 1; iu <= 3; ++iu)
	{   //Alibro[i].AN=i;
		gotoxy(10,iu+9);scanf("%d",&Alibro[iu].id);
		gotoxy(15,iu+9);scanf("%s",&Alibro[iu].titu);
		gotoxy(31,iu+9);scanf("%s",&Alibro[iu].autor);
		gotoxy(46,iu+9);scanf("%s",&Alibro[iu].editora);
		gotoxy(61,iu+9);scanf("%s",&Alibro[iu].genero);
		
	}
	getch();
}

void Mostrardatos(void)
{
	
	clrpart();
	gotoxy(10,9);cprintf("ID");
    Linea(13,9,20);
	gotoxy(15,9);cprintf("Titulo");
	Linea(30,9,20);
	gotoxy(31,9);cprintf("Autor");
	Linea(45,9,20);
	gotoxy(46,9);cprintf("Editora");
	Linea(60,9,20);
	gotoxy(61,9);cprintf("Genero");
	//Linea(78,9,20);
	//gotoxy(79,9); printf("Posicion");
	for (int ic = 1; ic <= 3; ++ic)
	{   
		gotoxy(10,ic+9);cprintf("%i",Alibro[ic].id);
		gotoxy(15,ic+9);cprintf("%s",Alibro[ic].titu);
		gotoxy(31,ic+9);cprintf("%s",Alibro[ic].autor);
		gotoxy(46,ic+9);cprintf("%s",Alibro[ic].editora);
		gotoxy(61,ic+9);cprintf("%s",Alibro[ic].genero);
		//gotoxy(79,i+9);printf("%d",&Alibro[i].AN);
	}
	getch();
}

void sacarpila(void)
{
	gotoxy(2,2);printf("%d",tope);
	int reset=0;
	clrpart();
	getch();
	tope--;
	gotoxy(2,2);printf("%d",tope);
	getch();
	if (tope>0)
	{
	gotoxy(10,9);printf("ID");
    Linea(13,9,20);
	gotoxy(15,9);printf("Titulo");
	Linea(30,9,20);
	gotoxy(31,9);printf("Autor");
	Linea(45,9,20);
	gotoxy(46,9);printf("Editora");
	Linea(60,9,20);
	gotoxy(61,9);printf("Genero");
	//Linea(78,9,20);
	//gotoxy(79,9); printf("Posicion");
	
		gotoxy(10,12);printf("%i",Alibro[tope].id);
		gotoxy(15,12);printf("%s",Alibro[tope].titu);
		gotoxy(31,12);printf("%s",Alibro[tope].autor);
		gotoxy(46,12);printf("%s",Alibro[tope].editora);
		gotoxy(61,12);printf("%s",Alibro[tope].genero);
		//gotoxy(79,12);printf("%d",&Alibro[tope].AN);
	}
	else
	{
		gotoxy(10,10);printf("Ha llegado al fondo de la Pila, Desea reiniciar la sacadera? <0=No> <1=si> ");
		gotoxy(10,11);scanf("%d",&reset);
		if (reset==1)
		{
			tope=L+1;
		}

	}	
	getch();
}


void sacarcola(void)
{
	int reset=0;
	clrpart();
	fondo++;
	if (fondo<=3)
	{
	gotoxy(10,9);printf("ID");
    Linea(13,9,20);
	gotoxy(15,9);printf("Titulo");
	Linea(30,9,20);
	gotoxy(31,9);printf("Autor");
	Linea(45,9,20);
	gotoxy(46,9);printf("Editora");
	Linea(60,9,20);
	gotoxy(61,9);printf("Genero");
	//Linea(78,9,20);
	//gotoxy(79,9); printf("Posicion");
	
		gotoxy(10,12);printf("%d",Alibro[fondo].id);
		gotoxy(15,12);printf("%s",Alibro[fondo].titu);
		gotoxy(31,12);printf("%s",Alibro[fondo].autor);
		gotoxy(46,12);printf("%s",Alibro[fondo].editora);
		gotoxy(61,12);printf("%s",Alibro[fondo].genero);
		//gotoxy(79,12);printf("%d",&Alibro[tope].AN);
	}
	else
	{
		gotoxy(10,10);printf("Ha llegado al fondo de la Pila, Desea reiniciar la sacadera? <0=No> <1=si> ");
		gotoxy(10,11);scanf("%d",&reset);
		if (reset==1)
		{
			fondo=0;
		}

	}	
	getch();

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
	clrpart();

	gotoxy(10,10);printf("1-Pila");
	gotoxy(10,11); printf("2-Cola");
	gotoxy(10,13);printf("opcion: ");
	gotoxy(18,13);scanf("%d",&op);
	clrpart();


	




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
					  f=12;} //cambiar si se agregan mas opciones
				break;
			}
			case 80://80
			{
				if (f<12)//cambiar si se agregan mas opciones
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
			gotoxy(10,23);cprintf(" Ingresando datos  ");
			delay(1000);
			gotoxy(10,23);cprintf("                   ");
			Ingresardatos();			
			titulo();
		}
		if ((t==13)&& (f==10))
		{
			gotoxy(10,23);cprintf("   Sacar datos   ");
			delay(1000);
			gotoxy(10,23);cprintf("                   ");
			if (op==1)
			{
				sacarpila();
			}
			if (op==2)
			{
				sacarcola();
			}
	
			titulo();
		}
		if ((t==13)&& (f==11))
		{
			gotoxy(10,23);cprintf("  Mostrando datos  ");
			delay(1000);
			gotoxy(10,23);cprintf("                   ");
			Mostrardatos();
			titulo();
		}
		if ((t==13)&& (f==12))
		{
			gotoxy(10,23);cprintf("   saliendo...   ");
			delay(1000);
			gotoxy(10,23);cprintf("                   ");
			t=27;
			//titulo();
		}
		/*if ((t==13)&& (f==13))
		{
			gotoxy(10,23);cprintf("  5 opcion   ");
			delay(1000);
			gotoxy(10,23);cprintf("                   ");
			
			titulo();
		}
		if ((t==13)&& (f==14))
		{
			gotoxy(10,23);cprintf("   saliendo...  ");
			delay(1000);
			gotoxy(10,23);cprintf("                   ");
			
		}*/
		textcolor(YELLOW);
		
        gotoxy(c,f);  cprintf("%s",titulos[f]);
        
        textcolor(WHITE);
        gotoxy(c,f-1);cprintf("%s",titulos[f-1]);
        gotoxy(c,f+1);cprintf("%s",titulos[f+1]);
	}while(t!=27);

}