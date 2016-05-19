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



char matr[]="        ";
char asignatura[20];
int labt=1;
int topelab1=0, topelab2 = 0, topelab3 = 0;
struct estudiante
 {
  char EMatricula[10];
  char EAsignatura[20];
  int ELab;
 };

 estudiante AEstLab1[MAX];
 estudiante AEstLab2[MAX];
 estudiante AEstLab3[MAX];


/*===============ANIMACION SALIDA============*/

void ansalida(int labt, char matr[10])
{
  int j = 0, tope = 0;
  if (labt==1)
  {
    j=44;
    tope = topelab1;
  }
  if (labt==2)
  {
    j=55;
    tope = topelab2;
  }
  if (labt==3)
  {
    j=66;
    tope = topelab3;
  }

  for (int a = 18-tope; a >= 8; --a) //mover abajo
      {
    gotoxy(j+1,a); printf("%s",matr);
    if(a!=18-tope)
    {
      gotoxy(j+1,a+1);printf("        ");

    }
    delay(50);
    }
    gotoxy(j+1,8);printf("        ");

}

/*================Clear Part================*/

void clrpart(void)
 {
 int x,y;    // para for de limpiar
 for (y=7; y<=21; y++)
 { for (x=1; x<=42; x++)
   {
    gotoxy(x,y);
    printf(" ");    //limpiando la parte central de pantalla
   }
  }
}

/*================DIBUJO================*/

void dibujo(char color)
{
textcolor(color);
for (int i = 0; i < 34; ++i)//linea horizontal
{
	gotoxy(43+i,18); cprintf("-");
}

for (i = 0; i < 5; ++i)//linea vertical
{
	gotoxy(43,13+i); cprintf("|");
	gotoxy(54,13+i); cprintf("|");
	gotoxy(65,13+i); cprintf("|");
	gotoxy(76,13+i); cprintf("|");
}
gotoxy(47,19); printf("Lab1");
gotoxy(58,19); printf("Lab2");
gotoxy(69,19); printf("Lab3");
}
/*================Mover================*/
void MoverEst(int labt, char matr[8])
 {
	int j = 0, tope = 0;
	if (labt==1)
	{
		j=44;
		tope = topelab1;
	}
	if (labt==2)
	{
		j=55;
		tope = topelab2;
	}
	if (labt==3)
	{
		j=66;
		tope = topelab3;
	}
	   for (int i = 9; i < j; ++i) //mover al lado
	    {
		   gotoxy(i,10); printf("  %s",matr);
		   delay(50);
	    }
	    for (int a = 10; a < 19-tope; ++a) //mover abajo
	    {
		gotoxy(j+1,a-1); printf("        ");
		gotoxy(j+1,a); printf("%s",matr);
		delay(50);
	    }
 }

/*================Insertar================*/

void Insertar()
{
  do{
 gotoxy(8,9);
 printf("Matricula");
 gotoxy(9,10); scanf("%s",&matr);

 gotoxy(8,11);
 printf("Asignatura");
 gotoxy(9,12); scanf("%s", &asignatura);

 gotoxy(8,13);
 printf("Laboratorio");
 gotoxy(9,14); scanf("%d",&labt);

 if (labt>=4);
 {
  gotoxy(8,18);/*printf("Error, Solo hay 3 Laboratorios");delay(2500)*/;clrpart();
 }
 }while((labt>3)&&(labt<1));

 if (labt==1)
 {
	topelab1++;
	strcpy(AEstLab1[topelab1].EMatricula,matr);
	strcpy(AEstLab1[topelab1].EAsignatura, asignatura);
	AEstLab1[topelab1].ELab = labt;
 }

 if (labt==2)
 {
	topelab2++;
	strcpy(AEstLab2[topelab2].EMatricula,matr);
	strcpy(AEstLab2[topelab2].EAsignatura, asignatura);
	AEstLab2[topelab2].ELab = labt;
 }

 if (labt==3)
 {
	topelab3++;
	strcpy(AEstLab3[topelab3].EMatricula,matr);
	strcpy(AEstLab3[topelab3].EAsignatura, asignatura);
	AEstLab3[topelab3].ELab = labt;
 }


 MoverEst(labt,matr);

}

/*================Titulos================*/


void titulos(void)
{

gotoxy(10,5); printf("Alexandro Abreu Suriel \n\t       2012-1523");
gotoxy(15,10); printf("Insertar");
gotoxy(15,11); printf("Sacar");
gotoxy(15,12); printf("Salir");

}


/*================SacarPila===========*/
void Sacar(void)
{
clrpart();
int fueralab=0, topes=0;
estudiante Estudv;
Estudv.ELab=0;

if((topelab1==0)&&(topelab2==0)&&(topelab3==0))
  {
    clrpart();
    gotoxy(10,10);printf("No hay datos");
  }
  else
  {
    clrpart();
    gotoxy(10,10);printf("De donde desea sacar? ");
    do
    {
      gotoxy(10,32);scanf("%d", &fueralab);
      if(fueralab==1)
      {
	      topes=topelab1;
      }
      else if (fueralab==2)
      {
	      topes=topelab2;
      }
      else if (fueralab==3)
      {
	      topes=topelab3;
      }
      else {topes==0;}

      if (topes==0)
      {
	      gotoxy(10,15);printf("Arreglo Vacio");
	      delay(1500);
	      gotoxy(10,15);printf("             ");
      }
      else
      {

	     if(fueralab==1)
	     {
        ansalida(fueralab,AEstLab1[topes].EMatricula);
	      gotoxy(7,15);printf("Eliminado %s",AEstLab1[topes].EMatricula);
       	topelab1--;
	      AEstLab1[topes]=Estudv;
      }
      if (fueralab==2)
      {
	      ansalida(fueralab,AEstLab2[topes].EMatricula);
	       gotoxy(5,15);printf("Eliminado %s", AEstLab2[topes].EMatricula);
	       topelab2--;
	       AEstLab2[topes]=Estudv;
      }
     if (fueralab==3)
      {
	      ansalida(fueralab,AEstLab3[topes].EMatricula);
       	gotoxy(5,15);printf("Eliminado %s", AEstLab3[topes].EMatricula);
	      topelab3--;
	       AEstLab3[topes]=Estudv;
       }


      break;
    }
     }while(topes==0);
    }


  getch();

}





/*================MAIN================*/
void main() {

clrscr();
dibujo(YELLOW);
titulos();
char t; int c1=10; //10 es el tope de arriba
  titulos();
  do{

  t = getch();

  switch (t){


  case 72: {//arriba
   if (c1>10) //validacion si se pasa arriba
    {
	c1--;
    }
   else
	{
		gotoxy(10,c1); printf("  ");
		gotoxy(12,c1); printf("  ");c1=12;
	}
     
     break;
  }

  case 80: { //abajo
   if (c1<12)//modificar si se cambia Y.. Limite de abajo
    {c1++;}
   else 
   	{
   		gotoxy(12,c1); printf("  "); 
   		gotoxy(10,c1); printf("  "); c1=10;
   	}
     
     break;
  }

   default: {break;}   
}

 if ((t==13)&&(c1==10))//INSERTAR
 {
  clrpart();
  Insertar();//Lee y mueve  
  clrpart();
  titulos();

 }

if ((t==13)&&(c1==11))//SACAR
 {
  clrpart();
  Sacar();
  clrpart();
  titulos();
 }

if ((t==13)&&(c1==12))//SALIR
 {
  t=27;
  break;
 }

 gotoxy(12,c1-1); printf("  ");
 gotoxy(12,c1);   printf("-> ");
 gotoxy(12,c1+1); printf("  ");
   

}while(t!=27);

getch();
}





