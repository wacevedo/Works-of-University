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
#define MAX 6

int f=9,c=12;

int topelab1=0;
int topelab2=0;
int topelab3=0;



struct Estudiante
{
  int lab;
  char matricula[10];
  char asignatura[50];
  
};
Estudiante AEstudiantelab1[MAX];
Estudiante AEstudiantelab2[MAX];
Estudiante AEstudiantelab3[MAX];


/*================DIBUJO================*/
void dibujo(char color)
{
textcolor(color);
/*for (int i = 0; i < 34; ++i)//linea horizontal
{
  gotoxy(43+i,18); cprintf("-");
}*/

for (int i = 0; i < 5; ++i)//linea vertical
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
/*================Mover================*/
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
        if (lab==1)
        {
          gotoxy(j+1,18-i);printf("%s",AEstudiantelab1[i].matricula);
        }
        if (lab==2)
        {
          gotoxy(j+1,18-i);printf("%s",AEstudiantelab2[i].matricula);
        }
        if (lab==3)
        {
          gotoxy(j+1,18-i);printf("%s",AEstudiantelab3[i].matricula); 
        }   
        
      }
      gotoxy(j+1,18-tope);printf("         "); 
 

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
    gotoxy((80-strlen("MENU ANIMADO COLA"))/2,4);
    //gotoxy(38,5);
    cprintf(" MENU ANIMADO COLA");
        
    
     gotoxy(c,10);cprintf("Insertar");
     gotoxy(c,11);cprintf("Sacar");
     gotoxy(c,12);cprintf("Mostrar");
     gotoxy(c,13);cprintf("Salir");
     dibujo(WHITE);



  gotoxy(10,23);printf("<ESC  = salir>");
    
  
    
    
    textcolor(WHITE);
}

void insert(Estudiante elemento)
{
  if (elemento.lab==1)
  {
    topelab1++;
    AEstudiantelab1[topelab1]=elemento;
  }
  if (elemento.lab==2)
  {
    topelab2++;
    AEstudiantelab2[topelab2]=elemento;
  }
  if (elemento.lab==3)
  {
    topelab3++;
    AEstudiantelab3[topelab3]=elemento;
  }

      
  
}




void Insertar(void)
{
  Estudiante vEstudiante;
  char error[8];
  char matri[8];
  clrpart();
  //cuadrito(1,80,7,21);
    if ((topelab1==MAX-1)&&(topelab2==MAX-1)&&(topelab3==MAX-1))
  {    
    gotoxy(10,10);printf("Arreglo lleno ");    
  }
  else
  {
    do{
  gotoxy(9,9);cprintf("Matricula:");
    
  gotoxy(9,11);cprintf("Asignatura:");
  
  gotoxy(9,13);cprintf("Laboratorio:");
    
  
  gotoxy(9,10);scanf("%s",&matri);
  strcpy(vEstudiante.matricula,matri);

  gotoxy(9,12);scanf("%s",&vEstudiante.asignatura);
  gotoxy(9,14);scanf("%d",&vEstudiante.lab);
  if ((topelab1==MAX-1)&&(vEstudiante.lab==1))
  {    
    gotoxy(10,15);printf("Arreglo lleno ");  
    delay(2500);
    clrpart();       
  }
  if ((topelab2==MAX-1)&&(vEstudiante.lab==2))
  {    
    gotoxy(10,15);printf("Arreglo lleno ");  
    delay(2500);
    clrpart();       
  }
  if ((topelab3==MAX-1)&&(vEstudiante.lab==3))
  {    
    gotoxy(10,15);printf("Arreglo lleno ");  
    delay(2500);
    clrpart();   
  }
  if ((vEstudiante.lab!=3)&&(vEstudiante.lab!=2)&&(vEstudiante.lab!=1))
  {
    gotoxy(10,15); printf("Error de Laboratorio");
    delay(2500);
    clrpart();
  }
  }while((vEstudiante.lab!=3)&&(vEstudiante.lab!=2)&&(vEstudiante.lab!=1)||(topelab3==MAX-1)&&(vEstudiante.lab==3)||(topelab2==MAX-1)&&(vEstudiante.lab==2)||(topelab1==MAX-1)&&(vEstudiante.lab==1));
  
  
  insert(vEstudiante);
  MoverEst(vEstudiante.lab,matri);   
  }
  getch();
  

}



void SacarCola(void)
{
  clrpart();
  int labsacar=0,topesacar=0;;
  /*Estudiante Estudiantevacio;
  Estudiantevacio.lab=0;*/
  if ((topelab1==0)&&(topelab2==0)&&(topelab3==0))
  {
    clrpart();
    gotoxy(10,10);printf("Todos los Laboratorios \n\t estan que vacios");
  }
  else
  {
    clrpart();
    gotoxy(10,10);printf("Elija el Laboratorio \n\t del que quiere sacar");
    do{
        gotoxy(10,12);scanf("%d",&labsacar);
        if (labsacar==1)
        {
          topesacar=topelab1;
        }
        else if (labsacar==2)
        {
          topesacar=topelab2;
        }
        else  if (labsacar==3)
        {
          topesacar=topelab3;
        }
        else
        {topesacar=0;}

  if (topesacar==0)
  {
    gotoxy(10,15);printf("Arreglo Vacio");
    delay(1500);
    gotoxy(10,15);printf("             ");
  }
  else
    {
      
      
      
      
      if (labsacar==1)
  {
    
    gotoxy(7,15);printf("Estudiante %s fue eliminado",AEstudiantelab1[1].matricula);
    
    char matric[10];
    strcpy(matric,AEstudiantelab1[1].matricula);
    //AEstudiantelab1[1]=Estudiantevacio;
    for (int i = 1; i < topelab1; ++i)
    {
      AEstudiantelab1[i]=AEstudiantelab1[i+1];
    }
    MoverEstSacar(labsacar,matric);
    topelab1--;
  }
  if (labsacar==2)
  {
    
    gotoxy(5,15);printf("Estudiante %s fue eliminado",AEstudiantelab2[1].matricula);
    char matric[10];
    strcpy(matric,AEstudiantelab2[1].matricula);
    //AEstudiantelab2[1]=Estudiantevacio;
    for (int i = 1; i < topelab2; ++i)
    {
      AEstudiantelab2[i]=AEstudiantelab2[i+1];
    }
    MoverEstSacar(labsacar,matric);
    topelab2--;
  }
  if (labsacar==3)
  {
    gotoxy(5,15);printf("Estudiante %s fue eliminado",AEstudiantelab3[1].matricula);
    char matric[10];
    strcpy(matric,AEstudiantelab3[1].matricula);
    for (int i = 1; i < topelab3; ++i)
    {
      AEstudiantelab3[i]=AEstudiantelab3[i+1];
    }
    MoverEstSacar(labsacar,matric);
    topelab3--;
    //AEstudiantelab3[1]=Estudiantevacio;
    
  }
  
      
      break;
    }
  }while(topesacar==0);
    }


  getch();
}


void Mostrar(void)
{
  clrpart();
  int labmost=0;
  int topemost=0;

  if (((topelab1==0)&&(topelab2==0)&&(topelab3==0)))
  {
    gotoxy(10,15);printf("Arreglos Vacio");
    delay(1500);    
    
  }else
  {
    
    do{
        gotoxy(10,10);printf("Elija el Laboratorio \n\t que quiere Mostrar");
        gotoxy(10,12);scanf("%d",&labmost);
        if ((labmost!=3)&&(labmost!=2)&&(labmost!=1))
        {
          gotoxy(10,15); printf("Error de Laboratorio");
          delay(2500);
          clrpart();
        }
      }while((labmost!=3)&&(labmost!=2)&&(labmost!=1));

    if (labmost==1)
    {
      topemost=topelab1;
    }
    else if (labmost==2)
    {
      topemost=topelab2;
    }
      else  if (labmost==3)
    {
      topemost=topelab3;
    }
    clrpart();
    gotoxy(5,9);printf("Matricula");
    Linea(15,9,17);
    gotoxy(17,9);printf("Asignatura");
    for (int i=1; i<=topemost; i++)
    {
      if (labmost==1)
      {
        gotoxy(5,i+10);printf("%s",AEstudiantelab1[i].matricula);
        gotoxy(17,i+10);printf("%s",AEstudiantelab1[i].asignatura);    
      }
      if (labmost==2)
      {
        gotoxy(5,i+10);printf("%s",AEstudiantelab2[i].matricula);
        gotoxy(17,i+10);printf("%s",AEstudiantelab2[i].asignatura);    
      }
      if (labmost==3)
      {
        gotoxy(5,i+10);printf("%s",AEstudiantelab3[i].matricula);
        gotoxy(17,i+10);printf("%s",AEstudiantelab3[i].asignatura);    
      }
    
      
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
      SacarCola();
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
    
    textcolor(YELLOW);
    
        gotoxy(c-3,f);  cprintf("->");
        
        textcolor(WHITE);
        gotoxy(c-3,f-1);cprintf("  ");
        gotoxy(c-3,f+1);cprintf("  ");
  }while(t!=27);

}
