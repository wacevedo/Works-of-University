#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <conio.h>
#include <process.h>
#include <ctype.h>
#include <dos.h>
#include <string.h>
#include <windows.h>
#include <time.h>
#define MAX 6



int f=9,c=12,topel=0,toper=0,topee=0;
struct libro
{  
  char nombre[50];  
  char editora[50];
  char autor[50];
  
};

struct revista
{  
  char nombre[50];  
  char agno[10];
  char volumen[50];
  
};

struct ensayo
{  
  char nombre[50];
  char autor[50];  
  char agno[10]; 
};

libro alibro[MAX];
revista arevista[MAX];
ensayo aensayo[MAX];

const char usuario[]="admin";
const char contrase[]="admin";
const char *titulos[]={"", "", "", "", "", "", "", "", "", 
"Registrar los libros","Registrar la Revista" ,"Registrar ensayos","Mostrar Libro","Mostrar Revistas","Mostrar Ensayos","Salir",""};


void setcursor(bool visible, DWORD size)  
{
	HANDLE console = GetStdHandle(STD_OUTPUT_HANDLE);
	if(size == 0)
	{
		size = 20;	
	}
	CONSOLE_CURSOR_INFO lpCursor;	
	lpCursor.bVisible = visible;
	lpCursor.dwSize = size;
	SetConsoleCursorInfo(console,&lpCursor);
}

void delay(int miseg)
{  
   Sleep(miseg);
}

void gotoxy(int x,int y)
{  
      HANDLE hcon;  
      hcon = GetStdHandle(STD_OUTPUT_HANDLE);  
      COORD dwPos;  
      dwPos.X = x;  
      dwPos.Y= y;  
      SetConsoleCursorPosition(hcon,dwPos);  
 } 
 
void listo(void)
{ 
	while(!kbhit())
	{
		gotoxy(48,23);printf("Presione cualquier tecla");
		Sleep(800);
		gotoxy(48,23);printf("                        ");
		Sleep(250);
	}
	gotoxy(48,23);;printf("                         ");
	getch();
} 

void listos(int x, int y)
{ 
	while(!kbhit())
	{
		gotoxy(x,y);printf("Presione una tecla");
		Sleep(800);
		gotoxy(x,y);printf("                  ");
		Sleep(250);
	}
	gotoxy(48,23);;printf("                  ");
	getch();
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

void fecha(void)
{
   	time_t t;
	struct tm *ahora;
	time(&t);
	ahora=localtime(&t);
	gotoxy(2,4);
	printf("%i/%i/%i",  ahora->tm_mday,ahora->tm_mon +1,ahora->tm_year+1900); 
}
 
 void clrpart(void)
 {
 int x,y;    // para for de limpiar
 
 for (y=6; y<=21; y++)
 { for (x=0; x<=79; x++) 
   {
    gotoxy(x,y);
    printf(" ");    //limpiando la parte central de pantalla
   }
  } 
  gotoxy(2,23),printf("                                                     ");
}

void clrscr(void)
{
	 int x,y;    
 
 for (y=0; y<=24; y++)
 { for (x=0; x<=79; x++) 
   {
    gotoxy(x,y);
    printf(" ");    //limpiando la pantalla completa
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

void login(void)
{
	cuadro(20,60,8,20,178);
	cuadrito(35,58,9,11);
	cuadrito(35,58,12,14);
	gotoxy(22,10);printf("Usuario:");
	gotoxy(22,13);printf("Contrase%ca:",164);
	char us[50];
	char ps[50];
	int intentos=3;
	
	
	
	while(intentos>0)
	{
		
		gotoxy(36,10);scanf("%s",&us);
		gotoxy(36,13);scanf("%s",&ps);
		if((strcmp(usuario,us)==0)&&(strcmp(contrase,ps)==0))
		{
			gotoxy(25,18);printf("        Bienvenido  %c     ",1);
			listos(31,23);
			break;
		}
		else
		{
			intentos--;
			gotoxy(25,16);printf("     Le quenda %d intentos",intentos);			
			delay(2000); 
			gotoxy(25,16);printf("                           ");
			gotoxy(36,10);printf("               ");
		    gotoxy(36,13);printf("               ");
		}
				
		
	}
	if(intentos==0)
	{
		clrscr();
		int col=1;
		system ("COLOR 4F");
		cuadro(20,60,11,15,178);
	    
		for(;;)
		{		
		  gotoxy(25,13);printf("Error de usuario / contrase%ca",164 );
		  delay(800);
	      gotoxy(25,13);printf("                              ");
	      delay(250);
	      if(col==1)
	       {
	         system ("COLOR CF");
		     col=0;	
	       }
	      else
	       {
	    	 system ("COLOR 4F");
		     col=1;	    	
	       }
		
		}
	}
	
}

void present(void)
{
	clrscr();
	system ("COLOR 3F");
	cuadro(20,54,6,22,178);
	gotoxy(22,8);printf(" Willson Neris Acevedo Sanchez");
	gotoxy(22,10);printf("          2012-1993");
	gotoxy(22,12);printf("      Estructura de datos");
	gotoxy(22,14);printf("   Programa para Biblioteca");
	gotoxy(22,16);printf("  Prof. Diego Orlando Matias");
	gotoxy(22,18);printf("       UCATECI, La Vega");
	gotoxy(22,20);printf("   15/07/2014  -  07/08/2014 ");
	listos(28,24);
	
}

void titulo(void)
{
	clrpart();
	fecha();
	cuadrito(0,78,6,21);
	gotoxy(31,1);
	printf("ESTRUCTURA DE DATOS");
	gotoxy(48,23);
	//printf("Willson Neris Acevedo Sanchez");
	gotoxy(68,4);
    printf("2012-1993");
    gotoxy(38,4);
    printf("MENU");
        
    for (int i = 9; i <= 15; i++)
    {
    	gotoxy(c,i);printf("%s",titulos[i]);
    }
    
	gotoxy(4,23);printf("<ESC  = salir>  <Cursores para moverse>");

    gotoxy(c,f);  printf("-> %s",titulos[f]);    
    
}
void registrarlibro(void)
{
	
	gotoxy(30,4);
    printf("  Registrar Libros  ");
    
	clrpart();
	if (topel<MAX)
	{
	 while(topel<MAX)		
	  {
	  clrpart();
	  libro vlibro;
	 
	  gotoxy(13,9);printf("Nombre:");	
      gotoxy(13,10);scanf("%s",&vlibro.nombre);
      gotoxy(13,11);printf("Editora:");
      gotoxy(13,12);scanf("%s",&vlibro.editora);
      gotoxy(13,13);printf("Autor:");
      gotoxy(13,14);scanf("%s",&vlibro.autor);
      
      alibro[topel]=vlibro;
      topel++;
      }
    }
    else
     {
      gotoxy(13,9);printf("Arreglo de libros lleno");
      
	  listo();	
     }  
    gotoxy(30,4);
    printf("        MENU          ");
	
}
void registrarrevista(void)
{
	gotoxy(30,4);
    printf(" Registrar Revista ");
	clrpart();
	if (toper<MAX)
	{
	while(toper<MAX)		
	 {
	 clrpart();	
	 revista vrevista;
	
	 gotoxy(13,9);printf("Nombre:");	
     gotoxy(13,10);scanf("%s",&vrevista.nombre);
     gotoxy(13,11);printf("A%co:",164);
     gotoxy(13,12);scanf("%s",&vrevista.agno);
     gotoxy(13,13);printf("Volumen:");
     gotoxy(13,14);scanf("%s",&vrevista.volumen);
     
     arevista[toper]=vrevista;
     toper++;
     }
    }
    else
     {
      gotoxy(13,9);printf("Arreglo de Revistas lleno");
      listo();	
     }  
    gotoxy(30,4);
    printf("        MENU          ");
	
}
void registrarensayo(void)
{
	gotoxy(30,4);
    printf("  Registrar Ensayo  ");
	clrpart();
	if (topee<MAX)
	{
	while(topee<MAX)		
	 {
	 clrpart();	
	 ensayo vensayo;
	
	 gotoxy(13,9);printf("Nombre:");	
     gotoxy(13,10);scanf("%s",&vensayo.nombre);
     gotoxy(13,11);printf("A%co:",164);
     gotoxy(13,12);scanf("%s",&vensayo.agno);
     gotoxy(13,13);printf("Autor:");
     gotoxy(13,14);scanf("%s",&vensayo.autor);
     
     aensayo[topee]=vensayo;
     topee++;
     }
    }
    else
     {
      gotoxy(13,9);printf("Arreglo de Revistas lleno");
      listo();	
     }  
    gotoxy(30,4);
    printf("        MENU          ");
	
}

void mostrarlibro(void)
{
	gotoxy(30,4);
    printf("  Mostrando Libros  ");
	clrpart();
	if (topel-1>=0)
	{	
	 gotoxy(10,9);
	 printf("Nombre      Autor         Editora");
	 Linea(19,9,19);
	 Linea(31,9,19);	 	
	 
     
     for(int x=0; x<=topel; ++x)
     {
     
      gotoxy(10,11+x);printf("%s",alibro[x].nombre);
      gotoxy(20,11+x);printf("%s",alibro[x].autor);
      gotoxy(33,11+x);printf("%s",alibro[x].editora);
     
     }
     listo();
    }
    else
     {
      gotoxy(13,9);printf("Arreglo de Libros Vacio");
      listo();	
     }  
   gotoxy(30,4);
    printf("        MENU          "); 
	
}

void mostrarrevista(void)
{
	gotoxy(30,4);
    printf("  Mostrando Revistas  ");
	clrpart();
	if (toper-1>=0)
	{	
	 gotoxy(10,9);
	 printf("Nombre      A%co         Volumen",164);
	 Linea(19,9,19);
	 Linea(31,9,19);	 	
	 
     
     for(int x=0; x<=toper; ++x)
     {
     
      gotoxy(10,11+x);printf("%s",arevista[x].nombre);
      gotoxy(20,11+x);printf("%s",arevista[x].agno);
      gotoxy(33,11+x);printf("%s",arevista[x].volumen);
     
     }
     listo();
    }
    else
     {
      gotoxy(13,9);printf("Arreglo de Revistas Vacio");
      listo();	
     } 
    gotoxy(30,4);
    printf("        MENU          ");
	
}

void mostrarensayo(void)
{
	gotoxy(30,4);
    printf("  Mostrando Ensayos  ");
	clrpart();
	if (topee-1>=0)
	{	
	 gotoxy(10,9);
	 printf("Nombre      A%co         Autor",164);
	 Linea(19,9,19);
	 Linea(31,9,19);	 	
	 
     
     for(int x=0; x<=topee; ++x)
     {
     
      gotoxy(10,11+x);printf("%s",aensayo[x].nombre);
      gotoxy(20,11+x);printf("%s",aensayo[x].agno);
      gotoxy(33,11+x);printf("%s",aensayo[x].autor);
     
     }
     listo();
    }
    else
     {
      gotoxy(13,9);printf("Arreglo de Ensayos Vacio");
      listo();	
     } 
    gotoxy(30,4);
    printf("        MENU          ");
	
}

int main()
{   
	//textcolor(3);
	//textbackground(red);
	system ("COLOR 1F");//3F
	setcursor(1,100);
	login();
	setcursor(1,20);
	present();	
	clrscr();
	system ("COLOR 1F");
	char t;
	cuadro(0,78,0,5,177);
	cuadro(0,78,22,24,178);

	titulo();
	
	
	do{
		t=getch();
		
		switch(t)
		{
			case 72://72
			{
				if (f>9)
					{f--;}
					  else {gotoxy(c,f);printf("%s   ",titulos[f]);
					  f=15;} //cambiar si se agregan mas opciones
				break;
			}
			case 80://80
			{
				if (f<15)//cambiar si se agregan mas opciones
					{f++;}
					  else {gotoxy(c,f);printf("%s   ",titulos[f]);
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
			clrpart();
			gotoxy(10,23);printf("   1 opcion   ");
			delay(1000);
			gotoxy(10,23);printf("                   ");
			system ("COLOR 5F");
			registrarlibro();
			system ("COLOR 1F");			
			titulo();
		}
		if ((t==13)&& (f==10))
		{
			clrpart();
			gotoxy(10,23);printf("   2 opcion   ");
			delay(1000);			
			gotoxy(10,23);printf("                   ");
			system ("COLOR 2F");
			registrarrevista();
			system ("COLOR 1F");
			titulo();
		}
		if ((t==13)&& (f==11))
		{
			clrpart();
			gotoxy(10,23);printf("   3 opcion   ");
			delay(1000);
			gotoxy(10,23);printf("                   ");
			system ("COLOR 6F");
			registrarensayo();
			system ("COLOR 1F");
			titulo();
		}
		if ((t==13)&& (f==12))
		{
			clrpart();
			gotoxy(10,23);printf("   4 opcion   ");
			delay(1000);
			gotoxy(10,23);printf("                   ");
			system ("COLOR 5F");
			mostrarlibro();
			system ("COLOR 1F");
			titulo();
		}
		if ((t==13)&& (f==13))
		{
			clrpart();
			gotoxy(10,23);printf("  5 opcion   ");
			delay(1000);
			gotoxy(10,23);printf("                   ");
			system ("COLOR 2F");
			mostrarrevista();
			system ("COLOR 1F");
			titulo();
		}
		if ((t==13)&& (f==14))
		{
			clrpart();
			gotoxy(10,23);printf("  6 opcion   ");
			delay(1000);
			gotoxy(10,23);printf("                   ");
			system ("COLOR 6F");
			mostrarensayo();
			system ("COLOR 1F");
			titulo();
		}
		if ((t==13)&& (f==15))
		{
			clrpart();
			gotoxy(10,23);printf("   Saliendo...  ");
			delay(1000);
			gotoxy(10,23);printf("                   ");
			t=27;
		}			
				
        gotoxy(c,f);  printf("-> %s",titulos[f]);
                       
        gotoxy(c,f-1);printf("%s   ",titulos[f-1]);
        gotoxy(c,f+1);printf("%s   ",titulos[f+1]);
	}while(t!=27);
return 0;
}
