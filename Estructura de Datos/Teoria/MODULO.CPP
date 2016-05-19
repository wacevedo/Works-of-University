#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>

int a=50,b=4,c;
int x=21,y=5 ,result=0, modulo;

int  main()
{
	clrscr();
	
 	printf(" Willson Neris Acevedo S%cnchez\n",160);
 	printf(" 2012-1993\n");
 	printf("\n");
 	printf(" Ejemplo de hacer m%cdulo sin % \n",162);
 	printf("\n");

//---Forma mandada por el profesor Diego---
	 printf("-Forma mandada por el profesor Diego-\n");
	 printf("\n");
	 
	 result=x/y;
	 modulo= x-(result * y); 
	 printf("El Resto de la divisi%cn es %i\n",162, modulo);
	 printf("\n");
	 printf("------------------------------------\n"); 
	 printf("\n");
	 
//---Como sacar modulo a variable float---
printf("-Como sacar modulo a variable float- \n");
printf("\n");
float v1=20.5,v2=4,modulofloat;
printf("El modulo es: %2.1f\n",modulofloat=fmod(v1,v2));

	 printf("\n");
	 printf("------------------------------------\n"); 
	 printf("\n");
	 
	 
	  
 	
//--- otra forma---
 	printf("-Otra forma-...");
 	printf("\n");
	
	c=a-b;
	
	do 
	    {	
	    	if (c<b)
	    	{
	    		break;
	    	}
		
			c=c-b;
			printf(".");
		}while(c>=b);

	printf("\n");	
	printf("%d m%cdulo de %d = %d\n",a,162,b,c);
	getch();
	return 2;	
	
}
