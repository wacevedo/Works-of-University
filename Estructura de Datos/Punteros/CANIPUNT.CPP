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


int topelab1=0;
int topelab2=0;
int topelab3=0;

struct cola
  {
    int lab;
    char matricula[10];
    char nombre[20];
    //char apellido[20];      
    char asignatura[50];

    struct cola *sig;
  } //

*CAB1=NULL,
*CAB2=NULL,
*CAB3=NULL,
*MOS=NULL,
*PRI1=NULL,
*PRI2=NULL,
*PRI3=NULL,
*AUX=NULL;


int f=9,c=12;
const char *titulos[]={"", "", "", "", "", "", "", "", "", 
"Insertar en la Cola","Extraer de la Cola" ,"Mostrar todo lo Insertado","Cantidad Insertada","Borrar Todo lo Insetado","Salir Del Programa",""};

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

void dibujo(char color)
 {
   textcolor(color);
/*for (int i = 0; i < 34; ++i)//linea horizontal
{
  gotoxy(43+i,18); cprintf("-");
}*/

   for (int i = -2; i < 5; ++i)//linea vertical
   {
     gotoxy(43,13+i); cprintf("|");
     gotoxy(54,13+i); cprintf("|");
     gotoxy(65,13+i); cprintf("|");
     gotoxy(76,13+i); cprintf("|");
   }
   gotoxy(47,8); printf("Lab1");
   gotoxy(58,8); printf("Lab2");
   gotoxy(69,8); printf("Lab3");
 }
/*================Mover Sacar================*/
void MoverEst(int lab, char matr[8])
 {
  

  int j = 0, tope = 0;
  if (lab==1)
  {
    j=44;
    tope = topelab1;
  }
  if (lab==2)
  {
    j=55;
    tope = topelab2;
  }
  if (lab==3)
  {
    j=66;
    tope = topelab3;
  }   
     for (int i = 9; i < j; ++i) //mover al lado
      {
       gotoxy(i,10); printf("  %s",matr);//cambiar por la matricula insertada del arreglo
       
       delay(50);
      }
      for (int a = 10; a < 19-tope; ++a)
      {

        gotoxy(j+1,a-1); printf("        ");
        gotoxy(j+1,a); printf("%s",matr);
        //dibujo(WHITE);
        delay(50);
      }   
 

 }
 /*================Mover Sacar================*/
void MoverEstSacar(int lab, char matr[8])
 {
  

  int j = 0, tope = 0;
  if (lab==1)
  {
    j=44;
    tope = topelab1;
    MOS=PRI1;
  }
  if (lab==2)
  {
    j=55;
    tope = topelab2;
    MOS=PRI2;
  }
  if (lab==3)
  {
    j=66;
    tope = topelab3;
    MOS=PRI3;
  }   
     
      for (int a = 18; a <= 20; ++a)
      {

        
        gotoxy(j+1,a); printf("%s",matr);
        /*if (a != 18)
        {*/
          gotoxy(j+1,a-1); printf("         ");
        //}        
      
        delay(50);
      } 
      for (int i = j; i <= 68; ++i) //mover al lado
      {
       gotoxy(i,20); printf("  %s",matr);//cambiar por la matricula insertada del arreglo
       
       delay(50);
      }
      gotoxy(68,20); printf("           "); 
      for (i = 0; i < tope; ++i)
      {
        
        gotoxy(j+1,18-i-1);printf("%s",MOS->matricula);       
         MOS=MOS->sig;        
      }
      gotoxy(j+1,18-tope);printf("         "); 
      free(MOS);
 

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
 { for (x=1; x<=40; x++) 
   {
    gotoxy(x,y);
    printf(" ");    //limpiando la parte central de pantalla
   }
  } 
}

void clrmid(void)
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
    
    int labint;
    AUX=(struct cola *)malloc(sizeof(struct cola));
    clrpart();
    gotoxy(10,9);printf("Laboratorio: ");
    scanf("%d",&labint);
    if ((labint<1)||(labint>3))
     {
       clrpart();
       gotoxy(10,10);printf("Solo hay 3 Laboratorios \n\t estan el 1, el 2 y el 3");
       listo(21);
       return;
     }
    AUX->lab=labint;
    gotoxy(10,10);printf("Matricula: ");//tuve que repetir la sentencia 2 veces porque
    gets(AUX->matricula);
    gotoxy(10,10);printf("Matricula: ");//me saltaba una de ellas
    gets(AUX->matricula);
    gotoxy(10,11);printf("Nombre: ");
    gets(AUX->nombre);    
    gotoxy(10,12);printf("Asignatura: ");
    gets(AUX->asignatura);

    //if (CAB==NULL)
              
        if ((AUX->lab==1)&&(PRI1==NULL))
        {
          PRI1=AUX;
          CAB1=AUX;
          AUX->sig=NULL;
          topelab1++;
        } 
        else if ((AUX->lab==2)&&(PRI2==NULL))
        {
          PRI2=AUX;
          CAB2=AUX;
          AUX->sig=NULL;
          topelab2++;
        }
        else if ((AUX->lab==3)&&(PRI3==NULL))
        {
          PRI3=AUX;
          CAB3=AUX;
          AUX->sig=NULL;
          topelab3++;
        } 
        else
        {
          if (AUX->lab==1)
          {
           AUX->sig=NULL;
           CAB1->sig=AUX;
           CAB1=AUX;
           topelab1++;
          } 
          if (AUX->lab==2)
          {
           AUX->sig=NULL;
           CAB2->sig=AUX;
           CAB2=AUX;
           topelab2++;
          }   
          if (AUX->lab==3)
          {
           AUX->sig=NULL;
           CAB3->sig=AUX;
           CAB3=AUX;
           topelab3++;
          }       
        } 
       MoverEst(AUX->lab,AUX->matricula);
       listo(21);
    
   }

 void descolar(void)
   {

     clrpart();
     if ((topelab1==0)&&(topelab2==0)&&(topelab3==0))
     {
      //clrpart();
      gotoxy(10,10);printf("Todos los Laboratorios \n\t estan que vacios");
      listo(21);
      return;
     }
     int labdes;
     char matdes[10];
     gotoxy(10,10);printf("De cual Laboratorios desea \n\t descolar? : ");
     scanf("%d",&labdes);

     if (labdes==1)
     {
       gotoxy(10,13);printf("El Estudiante %s \n\t fue eliminado.",PRI1->nombre);
       strcpy(matdes,PRI1->matricula);      
       PRI1=PRI1->sig;       
     }
     if (labdes==2)
     {
       gotoxy(10,13);printf("El Estudiante %s \n\t fue eliminado.",PRI2->nombre); 
       strcpy(matdes,PRI2->matricula);      
       PRI2=PRI2->sig;       
     }
     if (labdes==3)
     {
       gotoxy(10,13);printf("El Estudiante %s \n\t fue eliminado.",PRI3->nombre); 
       strcpy(matdes,PRI3->matricula);      
       PRI3=PRI3->sig;       
     }
     MoverEstSacar(labdes,matdes);
     if (labdes==1)
      topelab1--;
     if (labdes==2)
      topelab2--;
     if (labdes==3)
      topelab3--;
     listo(21);
   }
  
void mostrarcola(void)
 {

    
    clrpart();
    if ((topelab1==0)&&(topelab2==0)&&(topelab3==0))
     {      
      gotoxy(10,10);printf("Todos los Laboratorios \n\t estan que vacios");
      listo(21);
      return;
     }
     int labmos;
     gotoxy(10,10);printf("Cual Laboratorio desea \n\t Mostrar? : ");
     scanf("%d",&labmos);
     if ((labmos<1)||(labmos>3))
     {
       clrpart();
       gotoxy(10,10);printf("Solo hay 3 Laboratorios \n\t estan el 1, el 2 y el 3");
       listo(21);
       return;
     }

    if (labmos==1)
    {
      MOS=PRI1;
    }
    if (labmos==2)
    {
      MOS=PRI2;
    }
    if (labmos==3)
    {
      MOS=PRI3;
    }
    clrpart();  
    
    gotoxy(10,8);printf("     Laboratorio %d",labmos);
    gotoxy(5,9);printf("Nombre");
    Linea(15,9,20);
    gotoxy(17,9);printf("Asignatura");
    Linea(28,9,20);
    gotoxy(30,9);printf("Matricula");

    int y=10;
    while (MOS!=NULL)
       {
         gotoxy(5,y);printf("%s",MOS->nombre);
         gotoxy(17,y);printf("%s",MOS->asignatura);
         gotoxy(30,y);printf("%s",MOS->matricula);

         MOS=MOS->sig;
         y++;
       }
    free(MOS);   
    listo(21);//getch();
 }

void cantinsertada(void)
{
  //*MOS=NULL;
  int cantlab1=0,cantlab2=0,cantlab3=0,total;
  clrpart();
    if ((topelab1==0)&&(topelab2==0)&&(topelab3==0))
     {      
      gotoxy(10,10);printf("Todos los Laboratorios \n\t estan que vacios. \n\t Hay 0 Estudiante insertados.");
      listo(21);
      return;
     }
    
      MOS=PRI1; 
    while (MOS!=NULL)
       {
         MOS=MOS->sig;
         cantlab1++;
       }
       MOS=PRI2; 
    while (MOS!=NULL)
       {
         MOS=MOS->sig;
         cantlab2++;
       }
       MOS=PRI3; 
    while (MOS!=NULL)
       {
         MOS=MOS->sig;
         cantlab3++;
       }
       total=cantlab1+cantlab2+cantlab3;
    free(MOS);
    gotoxy(10,10);printf("Hay %d insertados \n\t en el Laboratorio 1.",cantlab1);
    gotoxy(10,12);printf("Hay %d insertados \n\t en el Laboratorio 2.",cantlab2);
    gotoxy(10,14);printf("Hay %d insertados \n\t en el Laboratorio 3.",cantlab3);
    gotoxy(10,16);printf("Hay %d insertados \n\t en La Cola en total.",total);
    listo(21);//getch();
}

void Borrart(void)
{
  
    clrpart();
    if ((topelab1==0)&&(topelab2==0)&&(topelab3==0))
     {      
      gotoxy(10,10);printf("Todos los Laboratorios \n\t estan que vacios");
      listo(21);
      return;
     }

    MOS=PRI1; 
    while (MOS!=NULL)
       {
         AUX=MOS;
         MOS=MOS->sig;
         free(AUX);
       }
       MOS=PRI2; 
    while (MOS!=NULL)
       {
         AUX=MOS;
         MOS=MOS->sig;
         free(AUX);
         
       }
       MOS=PRI3; 
    while (MOS!=NULL)
       {
         AUX=MOS;
         MOS=MOS->sig;
         free(AUX);         
       }
    free(PRI1);
    free(CAB1);
    free(PRI2);
    free(CAB2);
    free(PRI3);
    free(CAB3);
    free(MOS); 
    AUX=NULL;    
    MOS=NULL;
    PRI1=NULL;
    CAB1=NULL;
    PRI2=NULL;
    CAB2=NULL;
    PRI3=NULL;
    CAB3=NULL;
    topelab1=0;
    topelab2=0;
    topelab3=0;

    clrmid();
    dibujo(WHITE);
    gotoxy(10,10);printf("Todos los Elemento de \n\t la cola fueron eliminados. \n\t La Cola esta vacia."); 
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
  dibujo(WHITE);

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
      descolar();
      titulo();
    }
    if ((t==13)&& (f==11))
    {
      gotoxy(10,23);cprintf("   3 opcion   ");
      delay(1000);
      gotoxy(10,23);cprintf("                   ");
      mostrarcola();
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