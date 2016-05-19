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
/*================Variables, Structs y Arreglos================*/
 char t1[]= "Estructura de datos", t2[]= "Segundo Parcial", t3[]= "Pedro Alberto Rosario", t4[]= "2013-0253";
 int delays = 25;
 char matr[]="        ";
 char asignatura[20];
 int lab=1;
 int topelab1=0, topelab2 = 0, topelab3 = 0;
 struct estudiante
 {
  char EMatricula[8];
  char EAsignatura[20];
  int ELab;
 };

 estudiante AEstLab1[MAX];
 estudiante AEstLab2[MAX];
 estudiante AEstLab3[MAX];
/*================Linea Vertical================*/
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
/*================Fecha================*/
 void fecha(int color)
 {
  struct date d;
  int dia,mes,agno;
  getdate(&d);
  dia=d.da_day;
  mes=d.da_mon;
  agno=d.da_year;
    gotoxy(2,5);
    textcolor(color);
  cprintf("%d/%d/%d",dia,mes,agno);
  textcolor(WHITE);
 }
/*================Cuadro================*/
 int cuadro(int x1, int x2, int y1, int y2, int ch, char color)
 {
  int x,y;
  for(x=x1; x<=x2; x++)
  {
    textcolor(color);
    gotoxy(x,y1);
    cprintf("%c",ch);
    gotoxy(x,y2);
    cprintf("%c",ch);
    delay(1);
  }
  for(y=y1; y<=y2; y++)
  {
    gotoxy(x1,y);
    cprintf("%c",ch);
    gotoxy(x2,y);
    cprintf("%c",ch);
    delay(1);
  }
  textcolor(WHITE);
  return 0;
 }
/*================Clear Part Fijo================*/
 void clrpart(void)
 {
 int x,y;    // para for de limpiar

 for (y=7; y<=20; y++) //cuanto bajara
 { for (x=1; x<=42; x++) //cuanto ira a la derecha
   {
    gotoxy(x,y);
    printf(" ");    //limpiando la parte central de pantalla
   }
  }
 }
/*================Clear Part Parametros================*/
 void clrpart2(int x1, int x2, int y1, int y2)
 {
 int x,y;
 for (y=y1; y<=y2; y++)
 { for (x=x1; x<=x2; x++)
   {
    gotoxy(x,y);
    printf(" ");
   }
  }
 }
/*================Titulos================*/
 void titulos(void)
 {
  textcolor(RED);
  gotoxy(2,21); cprintf("Barra de estado\n");
  gotoxy((80-strlen(t1))/2,2); printf("%s", t1 );//Letreros
  gotoxy((80-strlen(t2))/2,3); printf("%s", t2 );
  gotoxy((80-strlen(t3))/2,4); printf("%s", t3 );
  gotoxy((80-strlen(t4))/2,5); printf("%s", t4 );
  fecha(7);

 gotoxy(15,10);
 printf("Insertar");

 gotoxy(15,11);
 printf("Sacar");

 gotoxy(15,12);
 printf("Mostrar");

 gotoxy(15,13);
 printf("Salir");

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
/*================Animacion Sacar================*/
 void ScarEst(int lab)
 {
  int j = 0, tope = 0; //j es la variable que toma la posicion
  char matr[8];
  if (lab==1)
  {
    j=44;
    tope = topelab1;    
    strcpy(matr,AEstLab1[topelab1].EMatricula); 
  }
  if (lab==2)
  {
    j=55;
    tope = topelab2;
    strcpy(matr,AEstLab2[topelab2].EMatricula);   
  }
  if (lab==3)
  {
    j=66;
    tope = topelab3;
    strcpy(matr,AEstLab3[topelab3].EMatricula);
  }   
    for (int a = (18-tope); a > 10 ; --a) //mover arriba      19-tope
      {        
        gotoxy(j+1,a-1); printf("%s",matr);
        gotoxy(j+1,a); printf("        ");  
        delay(delays);
      } 
      for (int i = 0; i < 50; ++i) //para que cambie de color
      {
        textcolor(i);
        gotoxy(j+1,10);
        cprintf("%s", matr);
        delay(delays);
      }
      textcolor(WHITE);
      gotoxy(j+1,10); cprintf("        ");
     for (i = 9; i <= j; --j) //mover al lado
      {
       gotoxy(j,10); printf("%s  ",matr);
       delay(delays);
      }        
 }
/*================Animacion Insertar================*/
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
 		   gotoxy(i,10); printf("  %s",matr);
 		   delay(delays);
 	    }
 	    for (int a = 10; a < 19-tope; ++a) //mover abajo
 	    {
 	    	gotoxy(j+1,a-1); printf("        ");
 	    	gotoxy(j+1,a); printf("%s",matr);
 	    	delay(delays);
 	    }   
 }
/*================Insertar================*/
 void Insertar()
 {
  textcolor(WHITE);
  do
    {
      gotoxy(8,9); printf("Matricula");
      gotoxy(9,10); scanf("%s",&matr);
      if (strlen(matr) > 8)
      {
        textcolor(RED);
        gotoxy(30,22); cprintf("Matricula no valida\n");
        textcolor(CYAN);
        gotoxy(27,23); cprintf("<Press a key to continue>\n");
        getch();
        gotoxy(9,10); printf("                           "); 
        clrpart2(2,79,22,23); //se limpia el cuadrito
        textcolor(WHITE);
      }
      else
      {
        break;
      }
     } while (strlen(matr) > 8);//validacion matricula para que sea de 8 caracteres o menos
 

 gotoxy(8,11); printf("Asignatura");
 gotoxy(9,12); scanf("%s", &asignatura);

 do{
 gotoxy(8,13); printf("Laboratorio"); 
 gotoxy(9,14); scanf("%d",&lab); 
 	if (((lab ==1) && (topelab1 == MAX)) || ((lab ==2) && (topelab2 == MAX)) || ((lab ==3) && (topelab3 == MAX)))
      {   
          textcolor(RED);
          gotoxy(30,22); printf("Laboratorio %i lleno.\n",lab );
          textcolor(CYAN);
          gotoxy(27,23); cprintf("<Press a key to continue>\n");
          getch();
          gotoxy(9,14); printf("                           ");
          clrpart2(2,79,22,23); //se limpia el cuadrito
          textcolor(WHITE);

      }
      else if (lab > 3)
      {
          textcolor(RED);
          gotoxy(27,22); printf("No existe este laboratorio");
          textcolor(CYAN);
          gotoxy(27,23); cprintf("<Press a key to continue>\n");
          getch();
          gotoxy(9,14); printf("                           ");
      }
  }while( ((lab ==1) && (topelab1 == MAX)) || ((lab ==2) && (topelab2 == MAX)) || ((lab ==3) && (topelab3 == MAX)) || (lab>3) ); 
  //validacion laboratorio lleno o laboratorio mayor que 3

  if (lab==1)
 {
 	topelab1++;
 	strcpy(AEstLab1[topelab1].EMatricula,matr);
 	strcpy(AEstLab1[topelab1].EAsignatura, asignatura); 	
 	AEstLab1[topelab1].ELab = lab;
 }
 if (lab==2)
 {
 	topelab2++;
 	strcpy(AEstLab2[topelab2].EMatricula,matr);
 	strcpy(AEstLab2[topelab2].EAsignatura, asignatura); 	
 	AEstLab2[topelab2].ELab = lab;
 }
 
 if (lab==3)
 {
 	topelab3++;
 	strcpy(AEstLab3[topelab3].EMatricula,matr);
 	strcpy(AEstLab3[topelab3].EAsignatura, asignatura); 	
 	AEstLab3[topelab3].ELab = lab;
 }

 
 MoverEst(lab,matr);
 
 }
/*================Sacar================*/
 void Sacar()
 {  

 do{
 gotoxy(8,13); printf("Laboratorio"); 
 gotoxy(9,14); scanf("%d",&lab); 
  if (((lab ==1) && (topelab1 == 0)) || ((lab ==2) && (topelab2 == 0)) || ((lab ==3) && (topelab3 == 0)))
      {
          textcolor(RED);
          gotoxy(30,22); printf("Laboratorio %i vacio.\n",lab ); 
          textcolor(CYAN);
          gotoxy(27,23); cprintf("<Press a key to continue>\n");
          getch();
          gotoxy(9,14); printf("                           ");
          clrpart2(2,79,22,23); //se limpia el cuadrito
          textcolor(WHITE);          
      }
      else if (lab > 3)
      { 
          textcolor(RED);
          gotoxy(27,22); printf("No existe este laboratorio"); 
          textcolor(CYAN);
          gotoxy(27,23); cprintf("<Press a key to continue>\n");
          getch();
          gotoxy(9,14); printf("                           ");
          clrpart2(2,79,22,23); //se limpia el cuadrito
          textcolor(WHITE);      
      }
  }while( ((lab ==1) && (topelab1 == 0)) || ((lab ==2) && (topelab2 == 0)) || ((lab ==3) && (topelab3 == 0)) || (lab>3) ); 
  //validacion laboratorio lleno o laboratorio mayor que 3
  ScarEst(lab); 
  
  if (lab==1)
 {  
  strcpy(AEstLab1[topelab1].EMatricula,"        ");
  strcpy(AEstLab1[topelab1].EAsignatura, NULL);   
  AEstLab1[topelab1].ELab = 0;
  topelab1--;
 }
 if (lab==2)
 {
  
  strcpy(AEstLab2[topelab2].EMatricula,"        ");
  strcpy(AEstLab2[topelab2].EAsignatura, NULL);   
  AEstLab2[topelab2].ELab = 0;
  topelab2--;
 }
 
 if (lab==3)
 {
  
  strcpy(AEstLab3[topelab3].EMatricula,"        ");
  strcpy(AEstLab3[topelab3].EAsignatura, NULL);   
  AEstLab3[topelab3].ELab = 0;
  topelab3--;
 } 
 
 }
/*================Mostrar================*/
 void Mostrar(void)
 {
  int topemostrar = 0;
    do{
    gotoxy(11,8); printf("Laboratorio: "); 
    gotoxy(24,8); scanf("%d",&lab);
    if (((lab ==1) && (topelab1 == 0)) || ((lab ==2) && (topelab2 == 0)) || ((lab ==3) && (topelab3 == 0)))
      {
          textcolor(RED);
          gotoxy(30,22); printf("Laboratorio %i vacio.\n",lab ); 
          textcolor(CYAN);
          gotoxy(27,23); cprintf("<Press a key to continue>\n");
          getch();
          gotoxy(24,8); printf("                           ");
          clrpart2(2,79,22,23); //se limpia el cuadrito
          textcolor(WHITE);          
      }
      else if (lab > 3)
      { 
          textcolor(RED);
          gotoxy(27,22); printf("No existe este laboratorio"); 
          textcolor(CYAN);
          gotoxy(27,23); cprintf("<Press a key to continue>\n");
          getch();
          gotoxy(24,8); printf("                           ");
          clrpart2(2,79,22,23); //se limpia el cuadrito
          textcolor(WHITE);      
      }
  }while( ((lab ==1) && (topelab1 == 0)) || ((lab ==2) && (topelab2 == 0)) || ((lab ==3) && (topelab3 == 0)) || (lab>3));
  Linea(18,9,15);
  gotoxy(9,9); printf("Matricula");
  gotoxy(19,9); printf("Asignatura");
  if (lab==1)
  {
    topemostrar = topelab1;
    for (int p = 1; p <= topemostrar; ++p)
    {
    gotoxy(10,10+p); printf("%s",AEstLab1[p].EMatricula);
    gotoxy(19,10+p); printf("%s",AEstLab1[p].EAsignatura);
    } 
    Linea(18,9,15);
  }
  if (lab==2)
  {
    topemostrar = topelab2;
    for (int p = 1; p <= topemostrar; ++p)
    {
    gotoxy(10,10+p); printf("%s",AEstLab2[p].EMatricula);
    gotoxy(19,10+p); printf("%s",AEstLab2[p].EAsignatura);
    }
    Linea(18,9,15);       
  }
  if (lab==3)
  {    
    topemostrar = topelab3;
    for (int p = 1; p <= topemostrar; ++p)
    {
    gotoxy(10,10+p); printf("%s",AEstLab3[p].EMatricula);
    gotoxy(19,10+p); printf("%s",AEstLab3[p].EAsignatura);
    }
    Linea(18,9,15); 
  } 
  getch();
 }
/*================MAIN================*/
 void main() 
 {
  textcolor(WHITE);
 char colorflecha;
 clrscr();
 cuadro(1,80,1,6,176,RED);
 cuadro(1,80,21,24,178,LIGHTGRAY);
 dibujo(RED);
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
   		gotoxy(12,c1); printf("  ");
      c1=13;//cambiar al ultimo 
   	}
     
     break;
  }

  case 80: { //abajo
   if (c1<13)//modificar si se cambia Y.. Limite de abajo
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
  if ((topelab1 == MAX) && (topelab2 == MAX) && (topelab3 == MAX))
  {
    textcolor(RED);
    gotoxy(30,22); cprintf("Laboratorios llenos");
    textcolor(CYAN);
    gotoxy(27,23); cprintf("<Press a key to continue>\n");
    getch();
    clrpart2(2,79,22,23); //se limpia el cuadrito      
  }
  else
  {
   clrpart();
   Insertar();//Lee y mueve  
   clrpart();
   titulos();
  }

 }

 if ((t==13)&&(c1==11))//SACAR
 { 
  if ((topelab1 == 0) && (topelab2 == 0) && (topelab3 == 0))
  {
    textcolor(RED);
    gotoxy(30,22); cprintf("Laboratorios vacios");
    textcolor(CYAN);
    gotoxy(27,23); cprintf("<Press a key to continue>\n");
    getch();
    clrpart2(2,79,22,23); //se limpia el cuadrito      
  }
   else
   { 
   clrpart();
   Sacar();//Lee y saca  
   clrpart();
   titulos(); 
  } 
 }
  
  if ((t==13)&&(c1==12))//MOSTRAR
  {  
    if ((topelab1 == 0) && (topelab2 == 0) && (topelab3 == 0))
  {
    textcolor(RED);
    gotoxy(30,22); cprintf("Laboratorios vacios");
    textcolor(CYAN);
    gotoxy(27,23); cprintf("<Press a key to continue>\n");
    getch();
    clrpart2(2,79,22,23); //se limpia el cuadrito      
  }
   else
   { 
   clrpart();
   Mostrar();
   clrpart();
   titulos();  
  }
 }

 if ((t==13)&&(c1==13))//SALIR
 {
  t=27;
  break;
 }

 gotoxy(12,c1-1); printf("  ");
 textcolor(c1); fecha(c1);
 gotoxy(12,c1); cprintf("-> ");
 textcolor(WHITE);
 gotoxy(12,c1+1); printf("  "); 
 }while(t!=27);
 getch();

 }