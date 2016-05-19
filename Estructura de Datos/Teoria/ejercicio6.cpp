#include<stdio.h>
#include<stdlib.h>
#include<conio.h>

int num5=0,num4=0,num3=0,suma=0;
int main()

{
	printf(" Willson Neris Acevedo Sanchez\n");
 	printf(" 2012-1993\n");
 	printf("\n");
 	for (int i=25; i<=100; i++)
 	{
 		printf("5*%d=%d\n",i,num5=5*i);
 		printf("4*%d=%d\n",i,num4=4*i);
 		printf("3*%d=%d\n",i,num3=3*i);
 		suma=suma+num5+num4+num3;
 	}
 	printf("La sumatoria es: %d",suma);
 	getchar();
    return 0;

}
