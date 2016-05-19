#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <string.h>

const char *unidads[]={"vacio", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve"};
const char *decena[]={"vacio", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa"};
const char *diezvar[]={"vacio", "once", "doce", "trece", "catorce", "quince"};
const char *centenas[]={"vacio", "ciento", "dociento", "treciento", "cuatrociento", "quiniento", "seisciento", "seteciento", "ochociento", "noveciento"};
const char *milesima[]={"vacio", "mil", "vacio", "vacio", "vacio", "vacio", "vacio", "vacio", "vacio", "vacio"};

void unidadesl(unsigned long a)
{
	//int unidad, decima, centena;
	unsigned unidad=a%10;
	unsigned decima=(a/10)%10;
	unsigned centena=(a/100)%100;
	if (centena!=0)
	{
		/*if (centenas[centena]=="vacio")
		{
			printf("%scientos",unidads[centena] );
		}
		else*/ if ((centena!=1)||(unidad!=0)||(decima!=0))
		{
			printf("%s",centenas[centena]);
		}
		else
		{
			printf("cien");
		}
	}
	if ((unidad!=0)||(decima!=0))
	{
		if (centena!=0)
		{
			printf(" ");
		}
		if (decima==0)
		{
			printf("%s",unidads[unidad] );
		}
		else if (unidad==0)
		{
			printf("%s",decena[decima] );
		}
		else if ((decima==1)&&(unidad>=1)&&(unidad<=5))
		{
			printf("%s",diezvar[unidad] );
		}
		else if (decima==1)
		{
			printf(" dieci%s",unidads[unidad] );
		}
		else if (decima==2)
		{
			printf(" veinti%s",unidads[unidad] );
		}
		else
		{
			printf("%s y %s",decena[decima],unidads[unidad] );
		}
	}
}

void millaresl(unsigned long b)
{
	//long unidades,miles;

	unsigned long unidades=b%1000;
	unsigned long miles=(b/1000)%1000;

	if (miles>1)
	{
		unidadesl(miles);
	}
	if (miles!=0)
	{
		printf(" mil");
	}
	if ((unidades!=0)&&(miles!=0))
	{
		printf(" ");		
	}
	unidadesl(unidades);
}

void millonl (unsigned long c)
{
	//long unidades2, millares;
	unsigned long unidades2=c%1000000;
	unsigned long millares=(c/1000000)%1000000;
	if (millares>1)
	{
		millaresl(millares);
		printf(" millones");
	}
	else if (millares!=0)
	{
		printf("un millon");
	}
	if ((unidades2!=0)&&(millares!=0))
	{
	    printf(" ");
	}
	millaresl(unidades2);
}

void main()
{
	long cantidad;
	do{
	clrscr();
	printf("Digite su cantidad: ");
	scanf("%ld",&cantidad);
	printf("\n");
	if (cantidad<0)
	{
		printf("menos");
		cantidad=-cantidad;
	}
	if (cantidad==0)
	{
		printf("cero");
	}
	else
	{
		millonl(cantidad);
	}
    printf("%ld\n",cantidad );
	getch();
	}while(cantidad!=0);	
}