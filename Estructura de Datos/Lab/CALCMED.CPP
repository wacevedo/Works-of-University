#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <conio.h>
#include <process.h>
#include <ctype.h>
#include <dos.h>
#include <string.h>

int f=9,c=7;



int cuadro(int x1, int x2, int y1, int y2)
{
	int x,y;
	for(x=x1; x<=x2; x++)
	{
		gotoxy(x,y1);
		printf("%c",177);
		gotoxy(x,y2);
		printf("%c",177);
		delay(1);
	}
	for(y=y1; y<=y2; y++)
	{
		gotoxy(x1,y);
		printf("%c",177);
		gotoxy(x2,y);
		printf("%c",177);
		delay(1);
	}
	return 0;
}


 
 void clrpart(void)
 {
 int x,y;    // para for de limpiar

 for (y=7; y<=21; y++)
 { for (x=1; x<=80; x++) 
   {
    gotoxy(x,y);
    printf(" ");    //limpiando la parte central de pantalla
   }
  } 
}

void titulo(void)
{
	clrpart();        

	gotoxy(10,9); cprintf("  Indice de Masa corporal");
	gotoxy(10,10);cprintf("  Calculo de Osmolaridad");
	gotoxy(10,11);cprintf("  Presion arterial media");
	gotoxy(10,12);cprintf("  Fecha Probable de parto");
	gotoxy(10,13);cprintf("  Sangrado de los huesos");
	gotoxy(10,14);cprintf("  Formula de parkland para quemaduras");
	gotoxy(10,15);cprintf("  Salir");


	gotoxy(10,23);printf("   estado: ");
    textcolor(YELLOW);
	gotoxy(c,f-1);cprintf("   ");
    gotoxy(c,f);  cprintf("->");
    gotoxy(c,f+1);cprintf("   ");
    textcolor(WHITE);
}

void indmasacorpotal(void)
 { 
 	float masa,estatura,imc;
 	clrpart();

 	
 	    gotoxy(10,8);
 		printf("Del panciente inserte los siguientes datos");
 		gotoxy(10,9);
 		printf("Introduzca la masa(Kg): ");
 		scanf("%f",&masa);
 		gotoxy(10,10);
 		printf("Introduzca la estatura(m): ");
 		scanf("%f",&estatura);

 		imc=masa/(estatura*estatura);
 		gotoxy(10,11);
 		printf("El indice de masa corporal es: %2.2f",imc);
 		gotoxy(10,12);
 		printf("Clasificacion de la OMS del estado nutricional de acuerdo con el IMC:");
 		gotoxy(10,13);
 		if (imc<18.50)
 		 	{ printf("Bajo peso: ");
 		      if (imc<16.00)
 		      {
 		      	printf("Delgadez severa");
 		      }
 		      if ((imc<=16.00)&&(imc>=16.99))
 		      {
 		      	printf("Delgadez moderada");
 		      }
 		      if ((imc<=17.00)&&(imc>=18.49))
 		      {
 		      	printf("Delgadez leve");
 		      }
 		 		
 		 	} 
 		if ((imc>=18.50)&&(imc<=24.99))
 		 	{
 		 		printf("Normal");
 		 	}
 		if ((imc>=25.00)&&(imc<=29.99))
 		    {
 		    	printf("Sobrepeso: preobeso");
 		    }
 		if (imc>=30.00)
 		    {printf("Obesidad: ");
 		     if ((imc>=30.00)&&(imc<=34.99))
 		     {
 		     	printf("Obesidad leve");
 		     }
 		     if ((imc>=35.00)&&(imc<=39.99))
 		     {
 		     	printf("Obesidad media");
 		     }
 		     if (imc>=40)
 		     {
 		     	printf("Obesidad morbida");
 		     }

 		    } 
        getch();
 }
 void osmolaridad(void)
 {
 	float osm,na,k,gluc,urea;
 	clrpart();
 	gotoxy(10,8);
 	printf("Del panciente inserte los siguientes datos");
 	gotoxy(10,9);
 	printf("Sodio: ");scanf("%f",&na);

 	gotoxy(10,9);printf("           ");

 	gotoxy(10,9);
 	printf("Potasio: ");scanf("%f",&k);

 	gotoxy(10,9);printf("           ");

 	gotoxy(10,9);
 	printf("Glucemia: ");scanf("%f",&gluc);

 	gotoxy(10,9);printf("           ");

 	gotoxy(10,9);
 	printf("Urea: ");scanf("%f",&urea);
 	osm=(na+k)*2+gluc/18+urea/6;
 	gotoxy(10,10);
 	printf("La osmolaridad es: %2.1f mosm/l",osm);
 	getch();
 }

 void presionmedio(void)
 {
 	int  PAM,diast,sist;
 	clrpart();
 	gotoxy(10,8);
 	printf("Del panciente inserte los siguientes datos");
 	gotoxy(10,9);
 	printf("Sistolica: ");scanf("%d",&sist); 	
 	gotoxy(10,10);
 	printf("Diastolica: ");scanf("%d",&diast);
 	PAM=((2 * diast)+sist) / 3;
 	gotoxy(10,11);
 	printf("La presion arterial media es: %d",PAM);
 	getch();
 }

 void sangradofrac(void)
 {
 	int p1=0,p2=0;
 	int hueso;
    clrpart();
    gotoxy(10,16);  printf("1-Costillas");
    gotoxy(10,17);  printf("2-Clavicula");
    gotoxy(10,18);  printf("3-Perone");
    gotoxy(10,19);  printf("4-Humero");
    gotoxy(55,16);  printf("5-Tibia");
    gotoxy(55,17);  printf("6-Femur");
    gotoxy(55,18);  printf("7-Pelvis");
    gotoxy(55,19);  printf("8-Cadera");
    gotoxy(58,3); printf("<0=salir>       ");
 	do{
 	 gotoxy(10,8);
 	 printf("Del panciente inserte el numero de hueso afectado: ");
 	 scanf("%d",&hueso);
 	 if (hueso==0)
 	 {
 	 	break;
 	 }
 	 if (hueso==1)
 	 {
 	 	p1+=125; p2+=150;
 	 }
 	 if (hueso==2)
 	 {
 	 	p1+=200; p2+=250;
 	 }
 	 if (hueso==3)
 	 {
 	 	p1+=250; p2+=500;
 	 }
 	 if (hueso==4)
 	 {
 	 	p1+=500; p2+=700;
 	 }
 	 if (hueso==5)
 	 {
 	 	p1+=750; p2+=1500;
 	 }
 	 if (hueso==6)
 	 {
 	 	p1+=1500; p2+=2000;
 	 }
 	 if ((hueso==7) || (hueso==8))
 	 {
 	 	p1+=2500; p2+=3000;
 	 }

 	 gotoxy(10,10);printf("Estimado de sangrado: %d - %d ml",p1,p2);

 	}while(hueso!=0);
 }

 void fechaprobabledeparto(void)
 {
     float FPPa,FPPm=0,FPPd,mes;
     
     clrpart();
 	 gotoxy(10,8);
 	 printf("Del panciente inserte los siguientes datos <Enter> para /");
 	 gotoxy(10,9);FPPm=0;
 	 printf("Hace cuanto tiempo fue La fecha ultima de menstruacion: ");
 	 scanf("%f",&FPPd); gotoxy(68,9);printf("/");scanf("%f",&mes);gotoxy(71,9);printf("/");scanf("%f",&FPPa);
 	 FPPa+=1; 	 
 	 FPPd+=7;
 	 if (FPPd>=32)
 	 {
 	 	FPPm+=1;
 	 	FPPd-=31;
 	 }
 	 if (mes<=3)
 	 {
 	 	FPPm+=12+mes-3;
 	 	FPPa-=1;
 	 } else if(mes>=4) {FPPm=mes-3;}
 	 gotoxy(10,11);
 	 printf("Fecha probable de parto: %4.0f / %4.0f / %4.0f",FPPd,FPPm,FPPa);
 	 getch();
 }

 void parkland(void)
 {
 	float masa,porc=0.0,park;
 	int numarea;
 	 clrpart();
 	 gotoxy(10,16);  printf("1-Cabeza");
     gotoxy(10,17);  printf("2-Tronco");
     gotoxy(10,18);  printf("3-Brazo");
     gotoxy(10,19);  printf("4-Genitales");
     gotoxy(10,20);  printf("5-pierna");
 	 gotoxy(10,8);
 	 printf("Del panciente inserte los siguientes datos");
 	 gotoxy(10,9);
 	 printf("masa(Kg):");
 	 scanf("%f",&masa);
 	 gotoxy(10,10);
 	 printf("Numero de area afectada: ");
 	 scanf("%d",&numarea);
 	 if (numarea==1)
 	 {
 	 	porc=0.09;
 	 }
 	 if (numarea==2)
 	 {
 	 	porc=0.18;
 	 }
 	 if (numarea==3)
 	 {
 	 	porc=0.09;
 	 }
 	 if (numarea==4)
 	 {
 	 	porc=0.01;
 	 }
 	 if (numarea==5)
 	 {
 	 	porc=0.18;
 	 }
 	 park=(4.0*masa)*porc;
 	 gotoxy(10,12);
 	 printf("Fluido requerido en las primeras 24 horas: %4.2f mL",park);
 	 getch();
 	 
     


 }


void main()
{
	textcolor(WHITE);
	textbackground(BLUE);
	char t;
	clrscr();
	cuadro(1,80,1,6);cuadro(1,80,22,24);
	gotoxy(48,23);
	cprintf("Willson Neris Acevedo Sanchez");
	gotoxy(8,3);
    cprintf(" 2012-1993");
    gotoxy(58,3);cprintf("<ESC  = salir>");
    gotoxy(38,5);
    cprintf("MENU");
    gotoxy(32,2);
    cprintf("Calculos Medicos");
	titulo();
	
	
	do{
		t=getch();
		
		switch(t)
		{
			case 72://72
			{
				if (f>9)
					{f--;}
					  else {gotoxy(c,f);printf("   ");
					  f=15;} //cambiar si se agregan mas opciones
				break;
			}
			case 80://80
			{
				if (f<15)//cambiar si se agregan mas opciones
					{f++;}
					  else {gotoxy(c,f);printf("   ");
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
			gotoxy(21,23);cprintf(" 1 opcion ");
			delay(1000);
			gotoxy(21,23);cprintf("                   ");
			indmasacorpotal();			
			titulo();
		}
		if ((t==13)&& (f==10))
		{
			gotoxy(21,23);cprintf(" 2 opcion ");
			delay(1000);
			gotoxy(21,23);cprintf("                   ");
			osmolaridad();
			titulo();
		}
		if ((t==13)&& (f==11))
		{
			gotoxy(21,23);cprintf(" 3 opcion ");
			delay(1000);
			gotoxy(21,23);cprintf("                   ");
			presionmedio();
			titulo();
		}
		if ((t==13)&& (f==12))
		{
			gotoxy(21,23);cprintf(" 4 opcion ");
			delay(1000);
			gotoxy(21,23);cprintf("                   ");
			fechaprobabledeparto();
			titulo();
		}
		if ((t==13)&& (f==13))
		{
			gotoxy(21,23);cprintf(" 5 opcion ");
			delay(1000);
			gotoxy(21,23);cprintf("                   ");
			sangradofrac();
			titulo();
		}	
		if ((t==13)&& (f==14))
		{
			gotoxy(21,23);cprintf(" 6 opcion ");
			delay(1000);
			gotoxy(21,23);cprintf("                   ");
			parkland();
			titulo();
		}	
		if ((t==13)&& (f==15))
		{
			gotoxy(21,23);cprintf(" saliendo...");
			delay(1000);
			gotoxy(21,23);cprintf("                   ");
			t=27;
		}
		textcolor(YELLOW);
		gotoxy(c,f-1);cprintf("   ");
        gotoxy(c,f);  cprintf("->",16);
        gotoxy(c,f+1);cprintf("   ");
        textcolor(WHITE);
	}while(t!=27);

}

