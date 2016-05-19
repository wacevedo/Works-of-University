#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <conio.h>
#include <process.h>
#include <ctype.h>
#include <dos.h>

int f=9,c=7;

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
 
 void clrpart(void){

 int x,y;    // para for de limpiar

 for (y=7; y<=21; y++)
 { for (x=1; x<=80; x++) 
   {
    gotoxy(x,y);
    printf(" ");    //limpiando la parte central de pantalla
   }
  } 
}

void binario(void)
{
	int num,alm,j,i,bin[15]; 
	clrpart();
	gotoxy(10,9);
    printf("Digite el numeto que quiere convertir a binario: ");
    scanf("%d",&num); 
	alm=num;
    for(i=0;i<=14;i++) 
    { 
     bin[i]=num%2; 
     num=num/2; 
    } 
    gotoxy(10,11);
    printf("%d en binario es: ",alm);
    for(j=14;j>=0;j--) 
    { 
     printf("%d",bin[j]); 
    } 
    getch();
}

void mcmmcd(void)
{
	float num1,num2,a,b,MCM;
	clrpart();
	do{
		gotoxy(10,9);
		printf("Digite un numero: "); scanf("%f",&num1);
		gotoxy(10,10);
		printf("Digite el otro numero: ");scanf("%f",&num2);
		if ((num1>0) && (num2>0)) {break;}
		gotoxy(10,9);
		printf("                     "); 
		gotoxy(10,10);
		printf("                         ");
		gotoxy(10,9);
		printf("ERROR FATAL! los numero no pueden ser igual o menor que 0");
		delay(1500);
		gotoxy(10,9);
		printf("                                                          ");

	}while((num1<=0) && (num2<=0));

	a=num1;//almacena las variables
	b=num2;

	do{
		if (a>b)
		{
			a-=b;
			b=b;
		}
		if (a<b)
		{
			a=a+b;
			b=a-b;
			a=a-b;
		}

	}while(a!=b);

	gotoxy(10,11);
	printf("El MCD entre %4.1f y %4.1f es : %4.1f",num1,num2,a);
	MCM=num1*num2/a;
	gotoxy(10,12);
	printf("El MCM entre %4.1f y %4.1f es : %4.1f",num1,num2,MCM);
	getch();
}

void ascii(void)
{
 
 int codigo=1, y=1,x=1;
 clrscr();
 
  do
   {
       
      gotoxy(x,y);
   	  printf("%d= %c\n",codigo,codigo);
      codigo++;
      y++;
      if (y>=25)
      	{y=1; x+=7;}
   }
  while(codigo<=255);
  getch();
}

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


void titulo(void)
{
	clrscr();
	cuadro(1,80,1,6);cuadro(1,80,22,24);
	gotoxy(31,2);
	printf("ESTRUCTURA DE DATOS");
	gotoxy(48,23);
	cprintf("Willson Neris Acevedo Sanchez\n");
	gotoxy(8,3);
    cprintf(" 2012-1993                                        <ESC  = salir>\n");
    gotoxy(38,5);
    cprintf("MENU");
        

	gotoxy(10,9); cprintf("  Tabla del Codigo ascii");
	gotoxy(10,10);cprintf("  Maximo comun divisor y minimo comun multiplo");
	gotoxy(10,11);cprintf("  Conversor de decimal a binario");
	gotoxy(10,12);cprintf("  Tipo de Triangulo");
	gotoxy(10,13);cprintf("  Calculador de unidades, decenas, centena y millares");
	gotoxy(10,14);cprintf("  Salir");


	gotoxy(10,23);printf("   estado: ");
    textcolor(YELLOW);
	gotoxy(c,f-1);cprintf("   ");
    gotoxy(c,f);  cprintf("->");
    gotoxy(c,f+1);cprintf("   ");
    textcolor(WHITE);
}

void triangulo(void)
{
	int a=0,b=0,c=0;

	clrpart();
    gotoxy(10,9);
	printf("Lado A: ");
    scanf("%d", &a); 
    gotoxy(10,10);
    printf("Lado B: ");
    scanf("%d", &b);
    gotoxy(10,11);
    printf("Lado C: ");
    scanf("%d", &c);
    gotoxy(10,13);
	if ((a==b) && (b==c) && (c==a))
    {
      printf("El triangulo es: Equilatero");
    }
    if ((a==b && c!=a) || (a==c && b!=c) || (a!=b && b==c))
  //if ((a==b && b==a && c!=a) || (a==c && b!=c && c==a) || (a!=b && b==c && c==b))
    {
      printf("El traingulo es: Escaleno");
    }
     if ((a!=b && b!=c && c!=a))
    {
	  printf("El triangulo es: Is%csceles", 162);
    }
    getch();
}

void udcm(void)

{
	
	int valor, uni=0, dec=0, cent=0, mill=0;
	clrpart();
	do{
	gotoxy(10,9);	
	printf("Calculador de unidades, decenas, centena y millares ");
	gotoxy(10,10);
	printf("Digite el valor que desee: ");
	scanf("%d", &valor);
	if (valor>9999) 
	 {
	  gotoxy(10,10);
	  printf("ERROR intente de nuevo con valores inferiores a 999,999");
      delay(2500);
      gotoxy(10,10);
	  printf("                                                       ");
     }
    
	} while (valor>9999);
	
	if (valor>1000)	
	{
	  uni=valor;
	  dec=valor/10;
	  cent=valor/100;
	  mill=valor/1000;
	}
	if ((valor<1000)&& (valor>100))
	{
	  uni=valor;
	  dec=valor/10;
	  cent=valor/100;
	}
	
	if (valor<100)
	{
	  uni=valor;
	  dec=valor/10;
	}
	if (valor<10)	
	{
	  uni=valor;
	}
	gotoxy(10,13);
	printf("Hay: %d unidades, %d decenas, %d centenas, %d millares.", uni, dec, cent, mill);

	getch();
	
}

void main()
{
	textcolor(WHITE);
	textbackground(BLUE);
	char t;
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
					  f=14;} //cambiar si se agregan mas opciones
				break;
			}
			case 80://80
			{
				if (f<14)//cambiar si se agregan mas opciones
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
			gotoxy(21,23);cprintf(" 1 opcion ascii");
			delay(1000);
			gotoxy(21,23);cprintf("                   ");
			ascii();			
			titulo();
		}
		if ((t==13)&& (f==10))
		{
			gotoxy(21,23);cprintf(" 2 opcion mcmmcd");
			delay(1000);
			gotoxy(21,23);cprintf("                   ");
			mcmmcd();
			titulo();
		}
		if ((t==13)&& (f==11))
		{
			gotoxy(21,23);cprintf(" 3 opcion binario");
			delay(1000);
			gotoxy(21,23);cprintf("                   ");
			binario();
			titulo();
		}
		if ((t==13)&& (f==12))
		{
			gotoxy(21,23);cprintf(" 4 opcion triangulo");
			delay(1000);
			gotoxy(21,23);cprintf("                   ");
			triangulo();
			titulo();
		}
		if ((t==13)&& (f==13))
		{
			gotoxy(21,23);cprintf(" 5 opcion udcm");
			delay(1000);
			gotoxy(21,23);cprintf("                   ");
			udcm();
			titulo();
		}
		if ((t==13)&& (f==14))
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