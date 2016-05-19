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
#define MAX 5

int f=9,c=12;
int cantlibro=-1;
int front=-1;
int rear=-1;
/*const char *titulos[]={"", "", "", "", "", "", "", "", "", 
"Vacio","Vacio" ,"Vacio","Vacio","Vacio","Salir",""};*/
struct libro
{
  int id;
  char titu[20];
  char autor[50];
  char editora[20];
  char genero[20];

};
libro Alibro[MAX];


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
        
    
     gotoxy(c,10);cprintf("Insertar");
     gotoxy(c,11);cprintf("Sacar");
     gotoxy(c,12);cprintf("Mostrar");
     gotoxy(c,13);cprintf("Salir");



  gotoxy(10,23);printf("<ESC  = salir>");
    
  
    
    
    textcolor(WHITE);
}

void insert(libro elemento)
{
  
    Alibro[cantlibro]=elemento;  
  
}




void Insertar(void)
{
  libro vlibro;
  clrpart();
  if (cantlibro==MAX-1)
  {    
    gotoxy(10,10);printf("Arreglo lleno ");    
  }
  else
  {
  gotoxy(10,9);cprintf("ID");
    Linea(13,9,15);
  gotoxy(15,9);cprintf("Titulo");
  Linea(30,9,15);
  gotoxy(31,9);cprintf("Autor");
  Linea(45,9,15);
  gotoxy(46,9);cprintf("Editora");
  Linea(60,9,15);
  gotoxy(61,9);cprintf("Genero");
  
  gotoxy(10,11);scanf("%d",&vlibro.id);
  gotoxy(15,11);scanf("%s",&vlibro.titu);
  gotoxy(31,11);scanf("%s",&vlibro.autor);
  gotoxy(46,11);scanf("%s",&vlibro.editora);
  gotoxy(61,11);scanf("%s",&vlibro.genero);
  cantlibro++;
  insert(vlibro);   
  }
  getch();
  

}



void SacarPila(void)
{
  clrpart();
  libro librovacio;
  librovacio.id=0;
  

  if (cantlibro==-1)
  {
    gotoxy(10,10);printf("Arreglo Vacio");
  }
  else
    {
      gotoxy(10,10);printf("Libro %d fue eliminado",Alibro[cantlibro].id);
      Alibro[cantlibro]=librovacio;
      cantlibro--;
    }


  getch();
}


void Mostrar(void)
{
  clrpart();

  if (cantlibro==-1)
  {
    gotoxy(10,10);printf("Arreglo Vacio");
    
  }else
  {
    gotoxy(10,9);cprintf("ID");
    Linea(13,9,20);
  gotoxy(15,9);cprintf("Titulo");
  Linea(30,9,20);
  gotoxy(31,9);cprintf("Autor");
  Linea(45,9,20);
  gotoxy(46,9);cprintf("Editora");
  Linea(60,9,20);
  gotoxy(61,9);cprintf("Genero");
  for (int i=0; i<=cantlibro; i++)
  {
    
    gotoxy(10,i+11);cprintf("%i",Alibro[i].id);
    gotoxy(15,i+11);cprintf("%s",Alibro[i].titu);
    gotoxy(31,i+11);cprintf("%s",Alibro[i].autor);
    gotoxy(46,i+11);cprintf("%s",Alibro[i].editora);
    gotoxy(61,i+11);cprintf("%s",Alibro[i].genero);
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
  
  
  do{
    t=getch();
    
    switch(t)
    {
      case 72://72
      {
        if (f>10)
          {f--;}
            else {gotoxy(c-3,f);cprintf("  ");
            f=13;} //cambiar si se agregan mas opciones
        break;
      }
      case 80://80
      {
        if (f<13)//cambiar si se agregan mas opciones
          {f++;}
            else {gotoxy(c-3,f);cprintf("  ");
            f=10;} 
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
    if ((t==13)&& (f==10))
    {
      gotoxy(10,23);cprintf("   Insertar  ");
      delay(1000);
      gotoxy(10,23);cprintf("                   ");
      Insertar();     
      titulo();
    }
    if ((t==13)&& (f==11))
    {
      gotoxy(10,23);cprintf("   Sacar   ");
      delay(1000);
      gotoxy(10,23);cprintf("                   ");
      SacarPila();
      titulo();
    }
    if ((t==13)&& (f==12))
    {
      gotoxy(10,23);cprintf("   Mostrar   ");
      delay(1000);
      gotoxy(10,23);cprintf("                   ");
      Mostrar();
      titulo();
    }
    if ((t==13)&& (f==13))
    {
      gotoxy(10,23);cprintf("   saliendo   ");
      delay(1000);
      gotoxy(10,23);cprintf("                   ");
      t=27;
      
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
    
        gotoxy(c-3,f);  cprintf("->");
        
        textcolor(WHITE);
        gotoxy(c-3,f-1);cprintf("  ");
        gotoxy(c-3,f+1);cprintf("  ");
  }while(t!=27);

}
