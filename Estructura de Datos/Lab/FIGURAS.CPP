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

const char *titulos[]={"", "", "", "", "", "", "", "", "", 
"Hexagono","Rombo" ,"Estrella","Prisma","Salir",""};

int f=9,c=12;
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

int LineaVertical(int x1, int y1, int y2)
{
  int y;
  
  for(y=y1; y<=y2; y++)
  {
    gotoxy(x1,y);
    printf("*");//printf("*%c",179);
    gotoxy(x1,y);
    printf("*");//printf("*%c",179);
    delay(1);
  }
  return 0;
}

int LineaHorizontal(int x1, int x2, int y1)
{
  int x;
  
  for(x=x1; x<=x2; x++)
  {
    gotoxy(x,y1);
    printf("*");//printf("%c",196);
    gotoxy(x,y1);
    printf("*");//printf("%c",196);
    delay(1);
  }
  return 0;
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
    gotoxy(33,5);
    cprintf("MENU DE FIGURAS");
        
    for (int i = 9; i <= 13; i++)
    {
      gotoxy(c,i);cprintf("%s",titulos[i]);
    }

  gotoxy(10,23);printf("<ESC  = salir>");
    textcolor(YELLOW);
  
    gotoxy(c,f); cprintf("%s",titulos[f]);
    
    textcolor(WHITE);
}
void Hexagono(void)
{   
  clrpart();
  int x=20,y=21,x1=61;
  LineaHorizontal(21,60,10);
  LineaHorizontal(20,60,21);
  for (int i = 1; i < 7; ++i)
  {
    gotoxy(x,10+i); printf("*");
        gotoxy(x,y); printf("*");
        gotoxy(x1,10+i); printf("*");
        gotoxy(x1,y); printf("*");
        y--;
        x--;        
        x1++;   
  }
  getch();
}

void Rombo(void)
{
  clrpart();
  int x=40,y=21,x1=40;
  for (int i = 1; i < 7; ++i)
  {
    gotoxy(x,10+i); printf("*");
        gotoxy(x,y); printf("*");
        gotoxy(x1,10+i); printf("*");
        gotoxy(x1,y); printf("*");
        y--;
        x--;        
        x1++;   
  }
  getch();
}

void Prisma(void)
{
  clrpart();
  int x=40,y=21,x1=40;
  for (int i = 1; i < 5; ++i)
  {
        gotoxy(x,14+i); printf("*");
        gotoxy(x,y); printf("*");
        gotoxy(x1,14+i); printf("*");
        gotoxy(x1,y); printf("*");
        y--;
        x--;        
        x1++;   
  }
  x=40;
  y=13;
  x1=40;
  for (int v = 1; v < 5; ++v)
  {
    gotoxy(x,6+v); printf("*");
        gotoxy(x1,6+v); printf("*");
        gotoxy(x,y); printf("*");        
        gotoxy(x1,y); printf("*");
        y--;
        x--;        
        x1++;   
  }
  LineaVertical(36,11,17);
  LineaVertical(44,11,17);//talvez uno menos en x
  getch();
}

void Estrella(void)
{
  clrpart();
  int x=40,x1=40;
  for (int i = 1; i < 5; ++i)
  {
        gotoxy(x,6+i); printf("*");
        gotoxy(x-5,11); printf("*");
        gotoxy(x1,6+i); printf("*");
        gotoxy(x1+5,11); printf("*");
        x1++;
        x--; 
  }  
  LineaHorizontal(45,50,11); 
  LineaHorizontal(30,35,11);    

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
        if (f>9)
          {f--;}
            else {gotoxy(c,f);cprintf("%s",titulos[f]);
            f=14;} //cambiar si se agregan mas opciones
        break;
      }
      case 80://80
      {
        if (f<14)//cambiar si se agregan mas opciones
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
      gotoxy(10,23);cprintf("                    ");
      Hexagono();     
      titulo();
    }
    if ((t==13)&& (f==10))
    {
      gotoxy(10,23);cprintf("   2 opcion    ");
      delay(1000);
      gotoxy(10,23);cprintf("                    ");
      Rombo();
      titulo();
    }
    if ((t==13)&& (f==11))
    {
      gotoxy(10,23);cprintf("   3 opcion   ");
      delay(1000);
      gotoxy(10,23);cprintf("                   ");
      Estrella();
      titulo();
    }
    if ((t==13)&& (f==12))
    {
      gotoxy(10,23);cprintf("   4 opcion   ");
      delay(1000);
      gotoxy(10,23);cprintf("                   ");
      Prisma();
      titulo();
    }
    if ((t==13)&& (f==13))
    {
      gotoxy(10,23);cprintf("  Saliendo...   ");
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