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
#include <alloc.h>

struct pila
  {
    char nombre[20];
    char apellido[20];
    char matricula[10];

    struct pila *ant;
  } //

*CAB=NULL,
*AUX=NULL;


int f=9,c=12;
const char *titulos[]={"", "", "", "", "", "", "", "", "", 
"Insertar en la Pila","Extraer de la Pila" ,"Mostrar todo lo Insertado","Cantidad Insertada","Borrar Todo lo Insetado","Salir",""};

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

void listo(int y)
{ 
  while(!kbhit())
  {
    gotoxy(28,y);printf("Presione cualquier tecla");
    delay(800);
    gotoxy(28,y);printf("                        ");
    delay(250);
  }
  gotoxy(28,y);;printf("                         ");
  getch();
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
  {  for (x=1; x<=80; x++) 
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
        
    for (int i = 9; i <= 14; i++)
    {
      gotoxy(c,i);cprintf("%s",titulos[i]);
    }
  


    gotoxy(10,23);printf("<ESC  = salir>");
    textcolor(YELLOW);
  
    gotoxy(c,f); cprintf("%s",titulos[f]);
    
    textcolor(WHITE);
}

void insertar(void)
  {
    if ((CAB!=NULL)&&(AUX!=NULL))
    {
      CAB=AUX;
    }
    /*struct Pila *nuevo;

    nuevo = (struct Pila *) malloc(sizeof(struct Pila));
    AUX=*nuevo;*/
    AUX=(struct pila *)malloc(sizeof(struct pila));
    clrpart();
    gotoxy(10,10);printf("Nombre: ");
    gets(AUX->nombre);
    gotoxy(10,11);printf("Apellido: ");
    gets(AUX->apellido);
    gotoxy(10,12);printf("Matricula: ");
    gets(AUX->matricula);

    if (CAB==NULL)
       {
	 CAB=AUX;
	 AUX->ant=NULL;
       }
    else
       {
	 AUX->ant=CAB;
	 CAB=AUX;
       }
   }

 void despilar(void)
   {
     clrpart();
     if (CAB==NULL)
     {
      gotoxy(10,10);printf("La Pila esta vacia.");
      listo(21);
      return;
     }         
   
     AUX=CAB;
     CAB=CAB->ant;
     gotoxy(10,10);printf("El Estudiante %s fue eliminado.",AUX->nombre);
     free(AUX);
     listo(21);

   }
  
void mostrarpila(void)
 {

    
    clrpart();
    if (CAB==NULL)
    {
      gotoxy(10,10);printf("La Pila esta vacia.");
      listo(21);
      return;
    }

    AUX=CAB;

    gotoxy(5,9);printf("Nombre");
    Linea(15,9,20);
    gotoxy(17,9);printf("Apellido");
    Linea(28,9,20);
    gotoxy(30,9);printf("Matricula");

    int y=10;
    while (AUX!=NULL)
       {
         gotoxy(5,y);printf("%s",AUX->nombre);
         gotoxy(17,y);printf("%s",AUX->apellido);
         gotoxy(30,y);printf("%s",AUX->matricula);

         AUX=AUX->ant;
         y++;
       }
      
    listo(21);//getch();
 }

void cantinsertada(void)
{
  
    int cant=0;
    clrpart();
    if (CAB==NULL)
    {
      gotoxy(10,10);printf("La Pila esta vacia.");
      listo(21);
      return;
    }
   
    AUX=CAB;
    while (AUX!=NULL)
       {
         AUX=AUX->ant;
         cant++;
       }
    
    gotoxy(10,10);printf("Hay %d insertados en La Pila.",cant);
    listo(20);//getch();
}

void Borrart(void)
{
  clrpart();
    if (CAB==NULL)
    {
      gotoxy(10,10);printf("La Pila esta vacia.");
      listo(21);
      return;
    }    

    
    while (CAB!=NULL)
       {
         AUX=CAB;
         CAB=CAB->ant;
         free(AUX);         
       }
    
    free(CAB);
    
    AUX=NULL;
    CAB=NULL;    
    
    gotoxy(10,10);printf("Todos los Elemento de la Pila fueron eliminados. \n\t La Pila esta vacia."); 
    listo(21);//getch();
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
      gotoxy(10,23);cprintf("                   ");
      insertar();     
      titulo();
    }
    if ((t==13)&& (f==10))
    {
      gotoxy(10,23);cprintf("   2 opcion   ");
      delay(1000);
      gotoxy(10,23);cprintf("                   ");
      despilar();
      titulo();
    }
    if ((t==13)&& (f==11))
    {
      gotoxy(10,23);cprintf("   3 opcion   ");
      delay(1000);
      gotoxy(10,23);cprintf("                   ");
      mostrarpila();
      titulo();
    }
    if ((t==13)&& (f==12))
    {
      gotoxy(10,23);cprintf("   4 opcion   ");
      delay(1000);
      gotoxy(10,23);cprintf("                   ");
      cantinsertada();
      titulo();
    }
    if ((t==13)&& (f==13))
    {
      gotoxy(10,23);cprintf("  5 opcion   ");
      delay(1000);
      gotoxy(10,23);cprintf("                   ");
      Borrart();
      titulo();
    }
    if ((t==13)&& (f==14))
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